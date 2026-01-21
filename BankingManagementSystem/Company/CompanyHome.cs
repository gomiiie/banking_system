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
    public partial class CompanyHome : Form
    {
        private string AC_NO = 3001.ToString();
        public CompanyHome()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();

            DateTime now = DateTime.Now;
            DateTime thisMonth = new DateTime(now.Year, now.Month, 1);
            DateTime nextMonth = thisMonth.AddMonths(1);

            string query = $"SELECT SUM(TXN_AMT) FROM Transactions WHERE TXN_TO = {AC_NO} AND TXN_DATE BETWEEN '{thisMonth}' AND '{nextMonth}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            float result = Convert.ToSingle(cmd.ExecuteScalar());
            lblMonthlyRevenue.Text = $"${result.ToString()}";

            query = $"SELECT COUNT(*) FROM Transactions WHERE TXN_TO = {AC_NO} AND TXN_DATE BETWEEN '{ thisMonth}' AND '{nextMonth}'";
            cmd = new SqlCommand(query, conn);
            result = Convert.ToSingle(cmd.ExecuteScalar());
            lblNoOfSales.Text = result.ToString();
            //
            query = $"SELECT TOP 5 txn_from, SUM(txn_amt) as Total, COUNT(*) as Times from Transactions WHERE txn_to = {AC_NO} " +
                $"GROUP BY txn_from " +
                $"ORDER BY Total DESC;";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            query = $"SELECT TOP 5 l_id, COUNT(l_id) as Total, sum(txn_amt) AS Revenue FROM TopCustomers  WHERE txn_to = {AC_NO} AND L_ID IS NOT NULL GROUP BY l_id ORDER BY Total DESC;";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            DataTable dt2 = ds2.Tables[0];
            dataGridView2.DataSource = dt2;
            dataGridView2.AutoGenerateColumns = true;
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyServces c1 = new CompanyServces();
            c1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login c1 = new Login();
            c1.Show();
            this.Hide();
        }

        private void trns1_Click(object sender, EventArgs e)
        {
            CompanyTransactions c1 = new CompanyTransactions();
            c1.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompanyHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet6.TopCustomers' table. You can move, or remove it, as needed.
            //this.topCustomersTableAdapter.Fill(this.aBMSDataSet6.TopCustomers);

        }
    }
}
