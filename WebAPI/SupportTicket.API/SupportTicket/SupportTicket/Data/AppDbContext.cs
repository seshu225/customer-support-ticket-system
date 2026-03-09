using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using SupportTicket.Models;

namespace SupportTicket.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketStatusHistory> TicketStatusHistory { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
    }
}

