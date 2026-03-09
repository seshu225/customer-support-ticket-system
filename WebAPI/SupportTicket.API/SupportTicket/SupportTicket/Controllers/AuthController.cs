using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportTicket.Data;
using SupportTicket.DTOs;

namespace SupportTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
       
            private readonly AppDbContext _context;

            public AuthController(AppDbContext context)
            {
                _context = context;
            }

            [HttpPost("login")]
            public async Task<IActionResult> Login(LoginRequestDto request)
            {
                if (string.IsNullOrEmpty(request.Username) ||
                    string.IsNullOrEmpty(request.Password))
                    return BadRequest("Username and Password required");

                var user = await _context.Users
                    .FirstOrDefaultAsync(u =>
                        u.Username == request.Username &&
                        u.PasswordHash == request.Password);

                if (user == null)
                    return Unauthorized("Invalid credentials");

                return Ok(new
                {
                    user.Id,
                    user.Username,
                    user.Role
                });
            }

        [HttpGet("admins")]
        public async Task<IActionResult> GetAdmins()
        {
            var admins = await _context.Users
                .Where(x => x.Role == "Admin")
                .Select(x => new
                {
                    x.Id,
                    x.Username
                })
                .ToListAsync();

            return Ok(admins);
        }
    }
}
