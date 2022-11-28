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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brian Huynh\Documents\inventoryDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM TCustomer", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(),dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void customerButton1_Click(object sender, EventArgs e)
        {
            CustomerModuleForm customerModule = new CustomerModuleForm();
            customerModule.button1.Enabled = true;
            customerModule.button2.Enabled = false;
            customerModule.ShowDialog();
            LoadUser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm customerModule = new CustomerModuleForm();
                customerModule.txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.txtCPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                customerModule.button1.Enabled = false;
                customerModule.button2.Enabled = true;
                customerModule.ShowDialog();
            }
            else if (colName == "Remove")
            {
                if (MessageBox.Show("Are you sure you want to remove this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM TCustomer WHERE name LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted");
                }
            }
            LoadUser();
        }
    }
}
