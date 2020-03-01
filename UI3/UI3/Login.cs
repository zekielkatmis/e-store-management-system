using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (email=="admin" && password=="123")
            {
                AddCustomer home = new AddCustomer();
                home.Show();
                this.Hide();
            }

            if(email=="")
            {
                lblMessage.Text = "Please enter email.";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();
                return;
            }

            if(password==string.Empty)
            {
                lblMessage.Text = "Please enter password";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();
                return;
            }

            lblMessage.Text = "";

            Customers c = new Customers();
            int result =  c.Login(email, password); 

            if(result==1)
            {
                CustomerPanel customerPanel = new CustomerPanel();
                customerPanel.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Invalid email or password";
                lblMessage.ForeColor = Color.Red;
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
