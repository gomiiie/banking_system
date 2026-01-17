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
    public partial class TakeLoan : Form
    {

        private Account currAcc;
        public TakeLoan(Account a1)
        {
            InitializeComponent();
            show();
            this.currAcc = a1;
            clientSideBar1.CurrAcc = a1;
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM LoanTypes";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void TakeLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSLoanTypes.LoanTypes' table. You can move, or remove it, as needed.
           // this.loanTypesTableAdapter.Fill(this.aBMSLoanTypes.LoanTypes);

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
