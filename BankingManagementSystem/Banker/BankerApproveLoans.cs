using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingManagementSystem.Banker
{
    public partial class BankerApproveLoans : Form
    {
        private string AC_NO;
        private string L_ID;
        private string status;
        public BankerApproveLoans(string AC_NO)
        {
            InitializeComponent();
            this.AC_NO = AC_NO;
            show();
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Loans;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            L_ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            status = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void BankerApproveLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet4.PendingLoans' table. You can move, or remove it, as needed.
            //this.pendingLoansTableAdapter.Fill(this.aBMSDataSet4.PendingLoans);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (status == "APPROVED")
            {
                MessageBox.Show("Loan is already approved.");
                return;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"UPDATE Loans SET LOAN_STATUS = 'APPROVED', APPROVED_BY = '{AC_NO}' WHERE LOAN_ID = {L_ID};";
        }
    }
}
