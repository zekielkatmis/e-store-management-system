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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string price = textBox3.Text.Trim();
                string details = textBox4.Text.Trim();
                string memoryr = textBox5.Text.Trim();
              


                Games g = new Games();
                g.ProductId1 = id;
                g.ProductName1 = name;
                g.Price1 = price;
                g.Details1 = details;
                g.MemoryRequired = memoryr;



                int result = g.AddGames(g);

                if (result > 0)
                    MessageBox.Show("Game Added");
                else
                {
                    MessageBox.Show("NOT Added");
                }
                dgvGame.DataSource = g.ListGames();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Games g = new Games();
                dgvGame.DataSource = g.ListGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer home = new AddCustomer();
            home.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addAccessoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccessory addAccessories = new AddAccessory();
            addAccessories.Show();
            this.Hide();
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addConsolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConsole addConsole = new AddConsole();
            addConsole.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
            this.Hide();
        }
    }
}
