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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ApiService api = new ApiService();

            var result = await api.Login(txtUsername.Text, txtPassword.Text);

            if (result == null)
            {
                MessageBox.Show("Invalid Login");
                return;
            }

            MessageBox.Show("Login Success");

            // Next Step → TicketListForm open 
            TicketListForm form = new TicketListForm(result.Id, result.Role);
            form.Show();
            this.Hide();
        }
    }
}
