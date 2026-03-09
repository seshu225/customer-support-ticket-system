namespace SupportTicket.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string Subject { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AssignedTo { get; set; }
    }
}
