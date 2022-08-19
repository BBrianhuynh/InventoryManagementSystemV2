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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brian Huynh\Documents\inventoryDataBase.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM TUser", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtFullname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.button1.Enabled = false;
                userModule.button2.Enabled = true;
                userModule.ShowDialog();
            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this year?","Delete Record",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM TUser WHERE phone LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted");
                }
            }
        }
    }
}
