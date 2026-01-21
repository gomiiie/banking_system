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

namespace BankingManagementSystem.LoginRegister
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tboxAC.Text == "" || tboxSQ.Text == "" || tboxPass.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            string connectionString = @"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = $"SELECT * FROM AccountTable WHERE AC_NO = {tboxAC.Text} AND SQ = '{tboxSQ.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) { }
            else
            {
                MessageBox.Show("Wrong Answer");
            }
            reader.Close();
            query = $"UPDATE AccountTable SET password = '{tboxPass.Text}' WHERE AC_NO = {tboxAC.Text}";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password Changed Successfully");
            conn.Close();
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }
    }
}
