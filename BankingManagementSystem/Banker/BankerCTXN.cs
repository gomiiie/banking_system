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
    public partial class BankerCTXN : Form
    {
        public BankerCTXN()
        {
            InitializeComponent();
        }

        public BankerCTXN(string ac_no)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"SELECT * from Transactions WHERE txn_from = '{ac_no}' OR txn_to = '{ac_no}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void BankerCTXN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet3.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.aBMSDataSet3.Transactions);

        }
    }
}
