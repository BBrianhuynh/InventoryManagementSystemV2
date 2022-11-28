using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemV2
{
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brian Huynh\Documents\inventoryDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO TCustomer(name,phone)VALUES(@name,@phone)", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtCPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been sucessfully created");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Update TCustomer SET name=@name, phone=@phone WHERE name LIKE '" + txtName.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtCPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        public void clear()
        {
            txtName.Clear();
            txtCPhone.Clear();
        }
    }
}
