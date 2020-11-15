using Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class login : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        DBConectionManager db;
        SqlDataAdapter da;
        EmployeeList empList;
        public login()
        {
            InitializeComponent();
            db = new DBConectionManager();
            empList = new EmployeeList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please enter the complete information of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conn = db.GetConnection();
                conn.Open();
                string sql = "select * from Account where username='" + txtUsername.Text + "' and password='" + empList.MD5Hash(txtPass.Text) + "' and role = 1";
                da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Product pro = new Product();
                    pro.ShowDialog();
                }
                else
                {
                    
                    MessageBox.Show("Username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
