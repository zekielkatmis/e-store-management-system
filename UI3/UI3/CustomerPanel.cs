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
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Accessories a = new Accessories();
                Consoles co = new Consoles();
                Games g = new Games();
                Cart c = new Cart();
                c.Name = textBox3.Text.Trim();
                c.Price = double.Parse(textBox4.Text.Trim());
                c.Detail = textBox5.Text.Trim();

                int result = c.AddtoCart(c);

                if (result > 0)
                    MessageBox.Show("Product Added");
                else
                {
                    MessageBox.Show("NOT Added");
                }
                dgvAccessories.DataSource = a.ListAccessories();
                dgvConsoles.DataSource = co.ListConsoles();
                dgvGames.DataSource = g.ListGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccessories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAccessories.Rows[e.RowIndex];
                textBox3.Text = row.Cells["name"].Value.ToString();
                textBox4.Text = row.Cells["price"].Value.ToString();
                textBox5.Text = row.Cells["detail"].Value.ToString();
            }
        }

        private void dgvConsoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvConsoles.Rows[e.RowIndex];
                textBox3.Text = row.Cells["name"].Value.ToString();
                textBox4.Text = row.Cells["price"].Value.ToString();
                textBox5.Text = row.Cells["detail"].Value.ToString();
            }
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGames.Rows[e.RowIndex];
                textBox3.Text = row.Cells["name"].Value.ToString();
                textBox4.Text = row.Cells["price"].Value.ToString();
                textBox5.Text = row.Cells["detail"].Value.ToString();
            }
        }

        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartPanel cart = new CartPanel();
            cart.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
