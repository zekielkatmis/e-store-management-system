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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Customers c = new Customers();
                dgvDelete.DataSource = c.ListCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox4.Text.Trim();
                Customers c = new Customers();
                c.CustomerId = id;

                int result = c.DeleteCustomers(id);

                if (result > 0)
                    MessageBox.Show("Customer Deleted");
                else
                {
                    MessageBox.Show("NOT Deleted");
                }
                dgvDelete.DataSource = c.ListCustomers();

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer home = new AddCustomer();
            home.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.Show();
            this.Hide();
        }

        private void addAccessoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccessory addAccessories = new AddAccessory();
            addAccessories.Show();
            this.Hide();
        }

        private void addConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConsole addConsole = new AddConsole();
            addConsole.Show();
            this.Hide();
        }
    }
}
