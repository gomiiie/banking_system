using BankingManagementSystem.Banker;
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
    public partial class BankerDashboard : Form
    {
        private string AC_NO;
        public BankerDashboard()
        {
            InitializeComponent();
        }


        public BankerDashboard(string AC_NO)
        {
            InitializeComponent();
            this.AC_NO = AC_NO;
            bankerSideBar1.AC_NO = AC_NO;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();

            string query = "SELECT COUNT(*) FROM AccountTable WHERE AC_NO LIKE '1%';";
            SqlCommand cmd = new SqlCommand(query, conn);
            lblClients.Text = cmd.ExecuteScalar().ToString();

            query = "SELECT COUNT(*) FROM AccountTable WHERE AC_NO LIKE '3%';";
            cmd = new SqlCommand(query, conn);
            lblCompanies.Text = cmd.ExecuteScalar().ToString();

            query = $"SELECT COUNT(*) FROM Transactions WHERE txn_date = '{DateTime.Today.Date}';";
            cmd = new SqlCommand(query, conn);
            lblTXNToday.Text = cmd.ExecuteScalar().ToString();

            query = "SELECT COUNT(*) FROM Loans WHERE l_status <> 'Closed';";
            cmd = new SqlCommand(query, conn);
            lblActiveLoans.Text = cmd.ExecuteScalar().ToString();

            //query = "SELECT txn_id AS TID, txn_from AS [FROM], txn_to AS [TO], txn_date AS [DATE], txn_amt AS AMT FROM Transactions ORDER BY txn_date DESC;";
            query = "SELECT TOP 5 txn_id, txn_from, txn_to, txn_date, txn_amt from Transactions ORDER BY txn_date DESC;";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
            dataGridView1.AutoResizeColumns();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BankerDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet1.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.aBMSDataSet1.Transactions);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankerTransactions bt = new BankerTransactions(AC_NO);
            bt.Show();
            this.Hide();
        }
    }
}
