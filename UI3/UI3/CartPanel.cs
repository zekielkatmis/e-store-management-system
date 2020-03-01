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
    public partial class CartPanel : Form
    {
        public CartPanel()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Cart c = new Cart();
                dgvCart.DataSource = c.ListCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCart.CurrentCell.RowIndex;
            dgvCart.Rows.RemoveAt(rowIndex);

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCart.Rows[e.RowIndex];
                textBox3.Text = row.Cells["name"].Value.ToString();
                textBox4.Text = row.Cells["price"].Value.ToString();
                textBox5.Text = row.Cells["detail"].Value.ToString();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            customerPanel.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cart c = new Cart();
                dataGridView1.DataSource = c.sum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void dgvCart_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //   
        //}

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cart c = new Cart();
                c.cleanTable();
                MessageBox.Show("Your cart is confirmed. Have a nice day!");
                CustomerPanel customerPanel = new CustomerPanel();
                customerPanel.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
