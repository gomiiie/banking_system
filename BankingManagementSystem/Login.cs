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

namespace BankingManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private int LogUserIn()
        {
            return 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To reset your password, please contact our head office at Kuratoli, Dhaka.");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblEmptyPass.Text = lblEmptyAC.Text = "";
            if (tboxAC.Text == "")
            {
                lblEmptyAC.Text = "Account Number is empty";
            }
            if (tboxPass.Text == "")
            {
                lblEmptyPass.Text = "Password is empty";
            }
            if (tboxAC.Text != "" && tboxPass.Text != "")
            {

                SqlConnection conn = Connect();
                string query = $"SELECT AC_NO, password FROM AccountTable WHERE AC_NO = {tboxAC.Text} AND password = '{tboxPass.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successful Login!");
                    ClientDashboard c1 = new ClientDashboard();
                    c1.Show();
                    this.Hide();  
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
                /*if (tboxAC.Text == "nsm" && tboxPass.Text == "nsm")
                {
                    // Open admin dashboard
                    //AdminDashboard adminDashboard = new AdminDashboard();
                    //adminDashboard.Show();
                    //MessageBox.Show("Successful Login!");
                    ClientDashboard c1 = new ClientDashboard();
                    c1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Account Number or Password.");
                }*/
            }
        }

        private void lblEmptyAC_Click(object sender, EventArgs e)
        {

        }

        private void lblEmptyPass_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegChoose r1 = new RegChoose();
            r1.Show();
            this.Close();
        }
    }
}
