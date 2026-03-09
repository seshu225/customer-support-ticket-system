using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportTicket.Data;
using SupportTicket.DTOs;
using SupportTicket.Models;

namespace SupportTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TicketController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ CREATE TICKET
        [HttpPost]
        public async Task<IActionResult> CreateTicket(CreateTicketDto dto)
        {
            if (string.IsNullOrEmpty(dto.Subject) ||
                string.IsNullOrEmpty(dto.Description))
                return BadRequest("All fields are required.");

            var count = await _context.Tickets.CountAsync();
            var ticketNumber = $"TKT-{(count + 1).ToString("D5")}";

            var ticket = new Ticket
            {
                TicketNumber = ticketNumber,
                Subject = dto.Subject,
                Description = dto.Description,
                Priority = dto.Priority,
                Status = "Open",
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.UtcNow
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return Ok(ticket);
        }

        // ✅ GET TICKETS (Role Based)
        [HttpGet]
        public async Task<IActionResult> GetTickets(int userId, string role)
        {
            var query = _context.Tickets.AsQueryable();

            if (role != "Admin")    
            {
                query = query.Where(t => t.CreatedBy == userId);
            }

            var tickets = await (
                from t in query
                join u in _context.Users
                    on t.AssignedTo equals u.Id into assignedUsers
                from u in assignedUsers.DefaultIfEmpty()
                select new
                {
                    t.Id,
                    t.TicketNumber,
                    t.Subject,
                    t.Priority,
                    t.Status,
                    t.CreatedAt,
                    AssignedTo = u != null ? u.Username : "Not Assigned"
                }
            ).ToListAsync();

            return Ok(tickets);
        }

        // ✅ GET TICKET DETAILS
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicketDetails(int id)
        {
            var ticket = await _context.Tickets
                .Where(a => a.Id == id)
                .Select(a => new
                {
                    a.Id,
                    a.TicketNumber,
                    a.Subject,
                    a.Description,
                    a.Priority,
                    a.Status,
                    a.CreatedAt,

                    AssignedTo = _context.Users
                        .Where(u => u.Id == a.AssignedTo)
                        .Select(u => u.Username)
                        .FirstOrDefault(),

                    Comments = _context.TicketComments
                        .Where(c => c.TicketId == a.Id)
                        .Select(c => new
                        {
                            c.Comment,
                            c.CreatedAt,
                            c.IsInternal
                        })
                        .ToList(),

                    History = _context.TicketStatusHistory
                        .Where(h => h.TicketId == a.Id)
                        .Select(h => new
                        {
                            h.OldStatus,
                            h.NewStatus,
                            h.UpdatedAt
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (ticket == null)
                return NotFound("Ticket not found");

            return Ok(ticket);
        }


        // ✅ ASSIGN TICKET (Admin Only)
        [HttpPut("{id}/assign")]
        public async Task<IActionResult> AssignTicket(int id, AssignTicketDto dto)
        {
            var admin = await _context.Users.FindAsync(dto.AdminId);

            if (admin == null || admin.Role != "Admin")
                return Unauthorized("Only Admin can assign tickets.");

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
                return NotFound("Ticket not found");

            if (ticket.Status == "Closed")
                return BadRequest("Closed ticket cannot be modified.");

            ticket.AssignedTo = dto.AdminId;
            await _context.SaveChangesAsync();

            return Ok("Assigned successfully");
        }

        // ✅ UPDATE STATUS (With Business Rules)
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, UpdateStatusDto dto)
        {
            var user = await _context.Users.FindAsync(dto.UpdatedBy);

            if (user == null || user.Role != "Admin")
                return Unauthorized("Only Admin can update status.");

            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
                return NotFound("Ticket not found");

            if (ticket.Status == "Closed")
                return BadRequest("Closed ticket cannot be modified.");

            if (ticket.Status == "Open" && dto.NewStatus != "In Progress")
                return BadRequest("Invalid status flow.");

            if (ticket.Status == "In Progress" && dto.NewStatus != "Closed")
                return BadRequest("Invalid status flow.");

            var history = new TicketStatusHistory
            {
                TicketId = id,
                OldStatus = ticket.Status,
                NewStatus = dto.NewStatus,
                UpdatedBy = dto.UpdatedBy,
                UpdatedAt = DateTime.UtcNow
            };

            ticket.Status = dto.NewStatus;

            _context.TicketStatusHistory.Add(history);
            await _context.SaveChangesAsync();

            return Ok("Status updated");
        }

        // ✅ ADD COMMENT
        [HttpPost("{id}/comment")]
        public async Task<IActionResult> AddComment(int id, AddCommentDto dto)
        {

            var ticket = await _context.Tickets.FindAsync(id);

            var user = await _context.Users.FindAsync(dto.UserId);

            if (user.Role == "User" && dto.IsInternal)
                return Unauthorized("User cannot add internal comments.");

            if (user.Role == "User" && ticket.CreatedBy != dto.UserId)
                return Unauthorized("You can comment only your own ticket.");
            if (ticket == null)
                return NotFound("Ticket not found");

            if (ticket.Status == "Closed")
                return BadRequest("Cannot comment on closed ticket.");

            var comment = new TicketComment
            {
                TicketId = id,
                Comment = dto.Comment,
                IsInternal = dto.IsInternal,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.UtcNow
            };
            
            _context.TicketComments.Add(comment);
            await _context.SaveChangesAsync();

            return Ok("Comment added");
        }

        
    }
}
