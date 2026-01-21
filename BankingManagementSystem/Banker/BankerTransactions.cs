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

namespace BankingManagementSystem.Banker
{
    public partial class BankerTransactions : Form
    {
        public BankerTransactions()
        {
            InitializeComponent();
        }

        private void BankerTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSClientTransactions.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter1.Fill(this.aBMSClientTransactions.Transactions);

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
    
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query;
            if (searchBox.Text == "")
            {
                query = "SELECT * from Transactions;";

            }
            else
            {
                query = $"SELECT * from Transactions WHERE txn_from LIKE '{searchBox.Text}%';";
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }
    }
}
