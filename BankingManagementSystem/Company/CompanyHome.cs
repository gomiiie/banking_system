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
        private string AC_NO;
        public CompanyHome()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            DateTime now = DateTime.Now;
            DateTime thisMonth = new DateTime(now.Year, now.Month, 1);
            DateTime nextMonth = thisMonth.AddMonths(1);
            string query = $"SELECT SUM(TXN_AMT) FROM Transactions WHERE TXN_TO = {AC_NO} AND TXN_DATE BETWEEN '{thisMonth}' AND '{nextMonth}";
            SqlCommand cmd = new SqlCommand(query, conn);
            object result = cmd.ExecuteScalar();

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

        private void sls_Click(object sender, EventArgs e)
        {
            CompanySales c1 = new CompanySales();
            c1.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
