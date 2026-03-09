using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class TicketDetails
{
    [JsonPropertyName("ticketNumber")]
    public string TicketNumber { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("priority")]
    public string Priority { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("assignedTo")]
    public string AssignedTo { get; set; }
    [JsonPropertyName("Status")]
    public string Status { get; set; }


    public List<History> History { get; set; }

    public List<Comment> Comments { get; set; }
}

public class User
{
    public int Id { get; set; }

    public string Username { get; set; }
}