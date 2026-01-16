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

        private void LogUserIn(string AC, string Password)
        {
            SqlConnection conn = Connect();
            string query = $"SELECT * FROM AccountTable WHERE AC_NO = {AC} AND password = '{Password}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Account a1 = new Account(
                    acNo: reader[0].ToString(), 
                    name: reader[2].ToString(),
                    dob: (DateTime)reader[3],
                    tin: reader[4].ToString(),
                    nid: reader[5].ToString(),
                    address: reader[6].ToString(),
                    nominee: reader[7].ToString(),
                    balance: Convert.ToSingle(reader[8]),
                    accountStatus: reader[9].ToString(),
                    accountType: Convert.ToByte(reader[10])
                    );
                MessageBox.Show("Successful Login!");
                if (a1.AccountType == 1)
                {
                    ClientDashboard c1 = new ClientDashboard(a1);
                    c1.Show();
                    this.Hide();
                }
                else if (a1.AccountType == 2)
                {
                    /*ClientDashboard c1 = new ClientDashboard();
                    c1.Show();
                    this.Hide();
                    return;*/
                }
                else if (a1.AccountType == 3)
                {
                    /*
                    ClientDashboard c1 = new ClientDashboard();
                    c1.Show();
                    this.Hide();
                    return;
                    */
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            reader.Close();
            conn.Close();
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
                LogUserIn(tboxAC.Text, tboxPass.Text);
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
