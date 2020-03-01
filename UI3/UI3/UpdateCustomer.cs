using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI3
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
            this.Hide();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer home = new AddCustomer();
            home.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Customers c = new Customers();
                dgvUpdate.DataSource = c.ListCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                string email = textBox2.Text.Trim();
                string password = textBox3.Text.Trim();
                string customerId = textBox4.Text.Trim();
                string address = textBox5.Text.Trim();
                string customerDetails = textBox6.Text.Trim();


                Customers c = new Customers();
                c.Name = name;
                c.Email = email;
                c.Password = password;
                c.CustomerId = customerId;
                c.Address = address;
                c.CustomerDetails = customerDetails;


                int result = c.UpdateCustomers(c);

                if (result > 0)
                    MessageBox.Show("Customer Updated");
                else
                {
                    MessageBox.Show("NOT Updated");
                }
                dgvUpdate.DataSource = c.ListCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.Show();
            this.Hide();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddAccessory addAccessories = new AddAccessory();
            addAccessories.Show();
            this.Hide();
        }

        private void addConsolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConsole addConsole = new AddConsole();
            addConsole.Show();
            this.Hide();
        }
    }
}
