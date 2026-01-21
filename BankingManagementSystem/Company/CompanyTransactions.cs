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
    public partial class CompanyTransactions : Form
    {
        private string AC_NO;
        public CompanyTransactions()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"SELECT txn_id, txn_from, txn_to, txn_date, txn_amt, txn_type, txn_l_id FROM Transactions WHERE txn_from = {AC_NO} OR txn_to = {AC_NO};";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void CompanyTransactions1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet6.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.aBMSDataSet6.Transactions);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bck1_Click(object sender, EventArgs e)
        {
            CompanyHome c1 = new CompanyHome();
            c1.Show();
            this.Hide();
        }
    }
}
