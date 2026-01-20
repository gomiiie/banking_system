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
    public partial class RegistrationBanker : Form
    {
        public RegistrationBanker()
        {
            InitializeComponent();
            //lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";
            lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";
            if (TimeSpan.Compare(DateTime.Now.Subtract(dateTimePicker1.Value), new TimeSpan(6570, 0, 0, 0)) < 0)
            {
                MessageBox.Show("You must be over 18 to register");
            }
            if (tboxName.Text == "")
            {
                lblEmptyName.Text = "Name field cannot be empty";
                flag = false;
            }
            if (tboxPassword.Text == "")
            {
                lblEmptyPass.Text = "Password field cannot be empty";
                flag = false;
            }
            if (tboxNID.Text == "")
            {
                lblEmptyNID.Text = "NID field cannot be empty";
                flag = false;

            }
            if (tboxTIN.Text.Length != 12)
            {
                lblEmptyTIN.Text = "Must be exactly 12 in length";
                flag = false;
            }
            if (tboxTIN.Text == "")
            {
                lblEmptyTIN.Text = "TIN field cannot be empty";
                flag = false;
            }
            if (tboxNominee.Text == "")
            {
                lblEmptyNominee.Text = "Nominee field cannot be empty";
                flag = false;
            }
            if (tboxNumber.Text == "")
            {
                lblEmptyNum.Text = "Number field cannot be empty";
                flag = false;
            }
            if (tboxAddress.Text == "")
            {
                lblEmptyAddr.Text = "Address field cannot be empty";
                flag = false;
            }
            //if (tboxName.Text != "" && lblAddress.Text != "" && lblNumber.Text != "" && tboxTIN.Text != "" && lblNID.Text != "" && dateTimePicker1.Text != "" && tboxPassword.Text != "")
            if (flag)
            {
                int AC_NO;
                //lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string query = "SELECT AC_NO FROM AccountTable WHERE AC_NO > 2000 AND AC_NO < 3000 ORDER BY AC_NO DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AC_NO = Convert.ToInt32(reader[0]);
                }
                else
                {
                    AC_NO = 2001;
                }
                reader.Close();
                query = "INSERT INTO AccountTable (AC_NO, password, name, DOB, TIN, NID, address, nominee, balance, AC_status, AC_type) " +
                               $"VALUES ( {AC_NO + 1}, '{tboxPassword.Text}', '{tboxName.Text}', '{dateTimePicker1.Value}', '{tboxTIN.Text}', '{tboxNID.Text}', '{tboxAddress.Text}', '{tboxNominee.Text}', 0, 'Normal', 2)";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"A new acounnt has been created. Your A/C NO is: {AC_NO + 1}");
                conn.Close();
            }
        }

        private void RegistrationBanker_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack1_Click_1(object sender, EventArgs e)
        {
            RegChoose r1 = new RegChoose();
            r1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";
            if (TimeSpan.Compare(DateTime.Now.Subtract(dateTimePicker1.Value), new TimeSpan(6570, 0, 0, 0)) < 0)
            {
                MessageBox.Show("You must be over 18 to register");
            }
            if (tboxName.Text == "")
            {
                lblEmptyName.Text = "Name field cannot be empty";
                flag = false;
            }
            if (tboxPassword.Text == "")
            {
                lblEmptyPass.Text = "Password field cannot be empty";
                flag = false;
            }
            if (tboxNID.Text == "")
            {
                lblEmptyNID.Text = "NID field cannot be empty";
                flag = false;

            }
            if (tboxTIN.Text.Length != 12)
            {
                lblEmptyTIN.Text = "Must be exactly 12 in length";
                flag = false;
            }
            if (tboxTIN.Text == "")
            {
                lblEmptyTIN.Text = "TIN field cannot be empty";
                flag = false;
            }
            if (tboxNominee.Text == "")
            {
                lblEmptyNominee.Text = "Nominee field cannot be empty";
                flag = false;
            }
            if (tboxNumber.Text == "")
            {
                lblEmptyNum.Text = "Number field cannot be empty";
                flag = false;
            }
            if (tboxAddress.Text == "")
            {
                lblEmptyAddr.Text = "Address field cannot be empty";
                flag = false;
            }
            //if (tboxName.Text != "" && lblAddress.Text != "" && lblNumber.Text != "" && tboxTIN.Text != "" && lblNID.Text != "" && dateTimePicker1.Text != "" && tboxPassword.Text != "")
            if (flag)
            {
                int AC_NO;
                //lblEmptyName.Text = lblEmptyPass.Text = lblEmptyNID.Text = lblEmptyTIN.Text = lblEmptyNominee.Text = lblEmptyNum.Text = lblEmptyAddr.Text = "";
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string query = "SELECT AC_NO FROM AccountTable WHERE AC_NO > 2000 AND AC_NO < 3000 ORDER BY AC_NO DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AC_NO = Convert.ToInt32(reader[0]);
                }
                else
                {
                    AC_NO = 2001;
                }
                reader.Close();
                query = "INSERT INTO AccountTable (AC_NO, password, name, DOB, TIN, NID, address, nominee, balance, AC_status, AC_type) " +
                               $"VALUES ( {AC_NO + 1}, '{tboxPassword.Text}', '{tboxName.Text}', '{dateTimePicker1.Value}', '{tboxTIN.Text}', '{tboxNID.Text}', '{tboxAddress.Text}', '{tboxNominee.Text}', 0, 'Normal', 2)";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"A new acounnt has been created. Your A/C NO is: {AC_NO + 1}");
                conn.Close();
            }
        }
    }
}
