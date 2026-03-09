using Auth0.ManagementApi.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SupportTicket.Desktop
{
    public partial class TicketDetailsForm : Form
    {
        private int _ticketId;
        private int _userId;
        private string _role;

        public TicketDetailsForm(int ticketId, int userId, string role)
        {
            InitializeComponent();
            _ticketId = ticketId;
            _userId = userId;
            _role = role;
        }

        private async void TicketDetailsForm_Load(object sender, EventArgs e)
        {
            
            await LoadTicketDetails();
            await LoadAdmins();
            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Closed");
            if (_role != "Admin")
            {

                adAssignTo.Visible = false;
                adstatus.Visible = false;
                adcomment.Visible = false;
                cmbAssignAdmin.Visible = false;
                cmbStatus.Visible = false;
                txtComment.Visible = false;
                btnSave.Visible = false;
            }
        }
        private async Task LoadAdmins()
        {
            ApiService api = new ApiService();

            var admins = await api.GetAdmins();

            cmbAssignAdmin.DataSource = admins;
            cmbAssignAdmin.DisplayMember = "Username";
            cmbAssignAdmin.ValueMember = "Id";
        }
        private async Task LoadTicketDetails()
        {
            ApiService api = new ApiService();

            var ticket = await api.GetTicketById(_ticketId);

            if (ticket != null)
            {
                lblTicketNumber.Text = ticket.TicketNumber;
                lblSubject.Text = ticket.Subject;
                txtDescription.Text = ticket.Description;
                lblPriority.Text = ticket.Priority;
                lblCreatedDate.Text = ticket.CreatedAt.ToString();
                lblAssignedAdmin.Text = ticket.AssignedTo;
                lblStatus.Text = ticket.Status;

                LoadHistory(ticket);
            }
        }
        private void LoadHistory(TicketDetails ticket)
        {
            var list = new List<object>();

            if (ticket.History != null)
            {
                foreach (var h in ticket.History)
                {
                    list.Add(new
                    {
                        StatusChanges = h.OldStatus + " → " + h.NewStatus,
                        Comments = "",
                        UpdatedBy = "Admin",
                        DateTime = h.UpdatedAt
                    });
                }
            }

            if (ticket.Comments != null)
            {
                foreach (var c in ticket.Comments)
                {
                    list.Add(new
                    {
                        StatusChanges = "",
                        Comments = c.CommentText,
                        UpdatedBy = "User",
                        DateTime = c.CreatedAt
                    });
                }
            }

            dgvHistory.DataSource = list;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            ApiService api = new ApiService();

            int adminId = (int)cmbAssignAdmin.SelectedValue;
            string status = cmbStatus.Text;
            string comment = txtComment.Text;

            await api.AssignTicket(_ticketId, adminId);

            await api.UpdateStatus(_ticketId, status, _userId);

            await api.AddComment(_ticketId, comment, _userId);

            MessageBox.Show("Ticket Updated");
        }
    }
}
