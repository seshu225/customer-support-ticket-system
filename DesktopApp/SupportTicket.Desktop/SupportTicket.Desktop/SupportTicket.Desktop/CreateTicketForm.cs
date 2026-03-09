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
    public partial class CreateTicketForm : Form
    {
        private int _userId;

        public CreateTicketForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTicketForm_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("High");

            cmbPriority.SelectedIndex = 0;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            ApiService api = new ApiService();

            var ticket = new
            {
                Subject = txtSubject.Text,
                Description = txtDescription.Text,
                Priority = cmbPriority.Text,
                UserId = _userId
            };

            var result = await api.CreateTicket(ticket);

            if (result)
            {
                MessageBox.Show("Ticket Created Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create ticket");
            }
        }
    }

}
