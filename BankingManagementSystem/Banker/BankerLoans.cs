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
    public partial class BankerLoans : Form
    {
        private string AC_NO;
        public BankerLoans(string AC_NO)
        {
            InitializeComponent();
            this.AC_NO = AC_NO; 
            tableShow();
        }

        private void tableShow()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT lt_id, lt_name, lt_interest, lt_status, lt_date_added, lastedit_by, lt_duration FROM LoanTypes;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void BankerLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet1.LoanTypes' table. You can move, or remove it, as needed.
            //this.loanTypesTableAdapter.Fill(this.aBMSDataSet1.LoanTypes);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string LT_ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string query = $"SELECT * FROM LoanTypes WHERE LT_ID = {LT_ID};";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tboxName.Text = $"{reader["LT_NAME"]}";
                lblACNO.Text = $"{reader["LT_ID"]}";
                tboxIR.Text = $"{reader["LT_INTEREST"]}";
                tboxDur.Text = $"{reader["LT_DURATION"]}";
                cbStatus.Text = $"{reader["LT_STATUS"]}";
                tboxDescription.Text = $"{reader["LT_DESCRIPTION"]}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (tboxName.Text.Length == 0 || tboxName.Text.Length > 50)
            {
                MessageBox.Show("Please enter a name within 50 characters.");
                flag = false;
            }
            if (!decimal.TryParse(tboxIR.Text, out decimal ir) || ir < 0 || ir > 100)
            {
                MessageBox.Show("Please enter a valid interest rate (0-100).");
                flag = false;
            }
            if (!int.TryParse(tboxDur.Text, out int dur) || dur <= 0 || dur > 50)
            {
                MessageBox.Show("Please enter a valid duration in integer years (0-50)");
                flag = false;
            }
            if (tboxDescription.Text.Length < 0 || tboxDescription.Text.Length > 100)
            {
                MessageBox.Show("Please enter a description within 100 characters.");
                flag = false;
            }
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                flag = false;
            }
            if (flag)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string query = $"UPDATE LoanTypes SET LT_NAME = '{tboxName.Text}', LT_INTEREST = '{tboxIR.Text}', LT_STATUS = '{cbStatus.Text}', LT_DURATION = '{tboxDur.Text}', LT_DESCRIPTION = '{tboxDescription.Text}', LASTEDIT_BY = '{AC_NO}' WHERE LT_ID = {lblACNO.Text};";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Loan Type updated successfully.");
                conn.Close();
                tableShow();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BankerLoanAdd bla = new BankerLoanAdd(AC_NO, this);
            bla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankerApproveLoans bal = new BankerApproveLoans(AC_NO);
            bal.Show();
        }

        private void tboxIR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
