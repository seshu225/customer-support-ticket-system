namespace SupportTicket.Models
{
    public class TicketStatusHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
