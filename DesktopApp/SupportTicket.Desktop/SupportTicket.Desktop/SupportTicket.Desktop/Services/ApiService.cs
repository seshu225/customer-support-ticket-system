using Auth0.ManagementApi.Models;
using SupportTicket.Desktop.LoginResponse_Model_Create;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("https://localhost:7122/");
    }

    // LOGIN API
    public async Task<LoginResponse> Login(string username, string password)
    {
        try
        {
            var response = await _client.PostAsJsonAsync("api/Auth/login",
                new { Username = username, Password = password });

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }
        catch
        {
            return null;
        }
    }

    // GET ALL TICKETS
    public async Task<List<Ticket>> GetTickets(int userId, string role)
    {
        var response = await _client.GetAsync($"api/Ticket?userId={userId}&role={role}");

        if (!response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<List<Ticket>>();
    }

    // CREATE TICKET
    public async Task<bool> CreateTicket(object ticket)
    {
        var response = await _client.PostAsJsonAsync("api/Ticket", ticket);

        return response.IsSuccessStatusCode;
    }

    // GET SINGLE TICKET DETAILS
    public async Task<TicketDetails> GetTicketById(int id)
    {
        var response = await _client.GetAsync($"api/Ticket/{id}");

        if (!response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<TicketDetails>();
    }
    public async Task<bool> AssignTicket(int ticketId, int adminId)
    {
        var response = await _client.PutAsJsonAsync(
            $"api/Ticket/{ticketId}/assign",
            new { AdminId = adminId });

        return response.IsSuccessStatusCode;
    }
    public async Task<bool> UpdateStatus(int ticketId, string status, int userId)
    {
        var response = await _client.PutAsJsonAsync(
            $"api/Ticket/{ticketId}/status",
            new
            {
                NewStatus = status,
                UpdatedBy = userId
            });

        return response.IsSuccessStatusCode;
    }
    public async Task<bool> AddComment(int ticketId, string comment, int userId)
    {
        var response = await _client.PostAsJsonAsync(
            $"api/Ticket/{ticketId}/comment",
            new
            {
                Comment = comment,
                UserId = userId,
                IsInternal = true
            });

        return response.IsSuccessStatusCode;
    }
    public async Task<List<User>> GetAdmins()
    {
        var response = await _client.GetAsync("api/Auth/admins");

        if (!response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<List<User>>();
    }
}