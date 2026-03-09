using System;
using System.Collections.Generic;

public class Ticket
{
    public int Id { get; set; }
    public string TicketNumber { get; set; }
    public string Subject { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public string AssignedTo { get; set; }
    public string Description { get; internal set; }

   
}
public class History
{
    public string OldStatus { get; set; }

    public string NewStatus { get; set; }

    public DateTime UpdatedAt { get; set; }
}

public class Comment
{
    public string CommentText { get; set; }

    public DateTime CreatedAt { get; set; }
}