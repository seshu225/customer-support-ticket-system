using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportTicket.Desktop
{
    public partial class TicketListForm : Form
    {
        private int _userId;
        private string _role;

        public TicketListForm(int userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            _role = role;
        }

        private async void TicketListForm_Load(object sender, EventArgs e)
        {
            await LoadTickets();
        }

        private async Task LoadTickets()
        {
            ApiService api = new ApiService();

            var tickets = await api.GetTickets(_userId, _role);

            if (tickets != null)
            {
                dgvTickets.DataSource = tickets;
            }
            else
            {
                MessageBox.Show("Failed to load tickets");
            }
        }
           
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm form = new CreateTicketForm(_userId);
            form.ShowDialog();

            // ticket create  list refresh
            _ = LoadTickets();
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadTickets();
        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {
            //int ticketId = Convert.ToInt32(dgvTickets.CurrentRow.Cells["Id"].Value);

            //TicketDetailsForm form = new TicketDetailsForm(ticketId);
            //form.ShowDialog();
            int ticketId = Convert.ToInt32(dgvTickets.CurrentRow.Cells["Id"].Value);

            TicketDetailsForm form = new TicketDetailsForm(ticketId, _userId, _role);
            form.Show();
        }
        
    }
}
