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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Customers c = new Customers();
                dgvCustomers.DataSource = c.ListCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string email = textBox2.Text;
                string password = textBox3.Text;
                string customerId = textBox4.Text;
                string address = textBox5.Text;
                string customerDetails = textBox6.Text;


                Customers c = new Customers();
                c.Name = name;
                c.Email = email;
                c.Password = password;
                c.CustomerId = customerId;
                c.Address = address;
                c.CustomerDetails = customerDetails;


                int result = c.AddCustomers(c);

                if(result>0)
                    MessageBox.Show("Customer Added");
                else
                {
                    MessageBox.Show("NOT Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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


                int result = c.AddCustomers(c);

                if (result > 0)
                    MessageBox.Show("Customer Added");
                else
                {
                    MessageBox.Show("NOT Added");
                }
                dgvCustomers.DataSource = c.ListCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
            this.Hide();
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

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BakımAsaması bakımAsaması = new BakımAsaması();
            bakımAsaması.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addAccessoriesToolStripMenuItem_Click(object sender, EventArgs e)
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
