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
    public partial class ClientTransactions : Form
    {
        public ClientTransactions()
        {
            InitializeComponent();
        }

        public ClientTransactions(Account a1)
        {
            InitializeComponent();
            clientSideBar1.CurrAcc = a1;
            show();
        }

        private void show()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Transactions ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void ClientTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSClientTransactions.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.aBMSClientTransactions.Transactions);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
