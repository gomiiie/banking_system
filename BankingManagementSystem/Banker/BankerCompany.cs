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

namespace BankingManagementSystem.Banker
{
    public partial class BankerCompany : Form
    {
        private string status;
        public BankerCompany(string AC_NO)
        {
            InitializeComponent();
            tboxName.Text = lblACNO.Text = lblBalance.Text = lblNum.Text = lblNID.Text
                = lblTIN.Text = lblDOB.Text = tboxNominee.Text = tboxAddress.Text = "";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT AC_NO, NAME, BALANCE, NUMBER FROM AllAccountDetails WHERE AC_NO LIKE '3%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
            bankerSideBar1.AC_NO = AC_NO;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string ac_no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query = $"SELECT * FROM AllAccountDetails WHERE AC_NO = '{ac_no}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tboxName.Text = $"{reader["NAME"]}";
                lblACNO.Text = $"{reader["AC_NO"]}";
                lblBalance.Text = $"${reader["BALANCE"]}";
                lblNum.Text = $"{reader["NUMBER"]}";
                lblNID.Text = $"{reader["NID"]}";
                lblTIN.Text = $"{reader["TIN"]}";
                DateTime dob = Convert.ToDateTime(reader["DOB"]);
                lblDOB.Text = dob.ToShortDateString();
                tboxNominee.Text = $"{reader["NOMINEE"]}";
                tboxAddress.Text = $"{reader["ADDRESS"]}";
                status = $"{reader["AC_STATUS"]}";

            }
        }

        private void buttonStuff()
        {
            if (lblACNO.Text == "")
            {
                MessageBox.Show("Please select a client first.");
                return;
            }
            BankerCTXN ctxnForm = new BankerCTXN(lblACNO.Text);
            ctxnForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void markBtnStuff()
        {
            if (lblACNO.Text == "")
            {
                MessageBox.Show("Please select a company first.");
                return;
            }
            if (status == "Marked")
            {
                MessageBox.Show("This account is already marked for review.");
                return;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"UPDATE AccountTable SET AC_STATUS = 'Marked' WHERE AC_NO = {lblACNO.Text};";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("Account marked for review.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonStuff();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            markBtnStuff();
        }
    }
}
