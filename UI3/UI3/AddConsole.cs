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
    public partial class AddConsole : Form
    {
        public AddConsole()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer home = new AddCustomer();
            home.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
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
            AddGame addGame = new AddGame();
            addGame.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Consoles c = new Consoles();
                dgvConsole.DataSource = c.ListConsoles();
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
                string id = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string price = textBox3.Text.Trim();
                string details = textBox4.Text.Trim();
                string driveT = textBox5.Text.Trim();



                Consoles c = new Consoles();
                c.ProductId1 = id;
                c.ProductName1 = name;
                c.Price1 = price;
                c.Details1 = details;
                c.DriveType = driveT;



                int result = c.AddConsoles(c);

                if (result > 0)
                    MessageBox.Show("Console Added");
                else
                {
                    MessageBox.Show("NOT Added");
                }
                dgvConsole.DataSource = c.ListConsoles();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
