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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Accessories a = new Accessories();
                Consoles c = new Consoles();
                Games g = new Games();

                dgvAccessories.DataSource = a.ListAccessories();
                dgvConsoles.DataSource = c.ListConsoles();
                dgvGames.DataSource = g.ListGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            this.Hide();
        }

        private void addAccessoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccessory addAccessory = new AddAccessory();
            addAccessory.Show();
            this.Hide();
        }

        private void addConsolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConsole addConsole = new AddConsole();
            addConsole.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string type = comboBox1.Text.Trim();
            string id = textBox2.Text.Trim();
            string name = textBox3.Text.Trim();
            string price = textBox4.Text.Trim();
            string detail = textBox5.Text.Trim();
            if (type == "consoles" || type == "accessories" || type == "games")
            {
                try
                {
                    Accessories a = new Accessories();
                    Consoles c = new Consoles();
                    Games g = new Games();

                    int result = g.UpdateProduct(type, name, price, detail, id);//this is in the Games class because i cannot solve this problem when deleteproduct in the product class.

                    if (result > 0)
                        MessageBox.Show("Product Updated");
                    else
                    {
                        MessageBox.Show("NOT Updated");
                    }
                    dgvAccessories.DataSource = a.ListAccessories();
                    dgvConsoles.DataSource = c.ListConsoles();
                    dgvGames.DataSource = g.ListGames();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Product type has to be; accessories, consoles, games");
            }
        }
    }
}
