namespace SupportTicket.DTOs
{
    public class AddCommentDto
    {
        public string Comment { get; set; }
        public bool IsInternal { get; set; }
        public int UserId { get; set; }
    }
}
