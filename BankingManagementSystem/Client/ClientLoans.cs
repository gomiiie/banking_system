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
using System.Xml.Linq;

namespace BankingManagementSystem
{
    public partial class ClientLoans : Form
    {

        private Account currAcc;
        private float remDue;
        private float totalPaid;
        private float amt;
        private int loanId;
        public ClientLoans()
        {
            InitializeComponent();
        }

        public ClientLoans(Account a1)
        {
            InitializeComponent();
            clientSideBar1.CurrAcc = a1;
            this.currAcc = a1;
            lblCurrBal.Text = "$" + currAcc.Balance.ToString();
            lblNewBal.Text = "$" + currAcc.Balance.ToString();
            lblPayment.Text = "$0.00";
            lblRemDue.Text = "$0.00";
            show();
        }

        private void ClientLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet.Loans' table. You can move, or remove it, as needed.
            //this.loansTableAdapter.Fill(this.aBMSDataSet.Loans);

        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Loans";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tboxAmt.Text == "")
            {
                MessageBox.Show("Please enter a payment amount.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amt > remDue)
            {
                MessageBox.Show("Payment amount exceeds remaining due.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amt > currAcc.Balance)
            {
                MessageBox.Show("Insufficient balance.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amt <= 0)
            {
                MessageBox.Show("Payment amount must be greater than zero.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (totalPaid == -1)
            {
                MessageBox.Show("Please select a loan to make payment.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"UPDATE Loans SET CURR_BAL = {totalPaid + amt} WHERE AC_NO = {currAcc.AccountNumber}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            query = $"UPDATE AccountTable SET BALANCE = {currAcc.Balance - amt} WHERE AC_NO = {currAcc.AccountNumber}";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            query = $"INSERT into Transactions(txn_from, txn_to, txn_date ,txn_amt ,txn_type ,l_id) " +
                    $"VALUES({currAcc.AccountNumber}, '{1999}', '{DateTime.Now}', {amt}, 'Loan Payment', {loanId})";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            currAcc.Balance -= amt;
            conn.Close();
            show();
            MessageBox.Show("Payment Successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            amt = 0;
            lblPayment.Text = "$0.00";
            lblRemDue.Text = "$0.00";
            totalPaid = -1;
        }

        private void tboxAmt_TextChanged(object sender, EventArgs e)
        {
            if (tboxAmt.Text == "") return;
            amt = Convert.ToSingle(tboxAmt.Text);
            lblCurrBal.Text = "$" + currAcc.Balance.ToString();
            lblNewBal.Text = "$" + (currAcc.Balance - amt).ToString();
            lblPayment.Text = "$" + amt.ToString();
            lblRemDue.Text = "$" + (remDue - amt).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalPaid = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            remDue = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[2].Value) - totalPaid;
            loanId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            lblCurrBal.Text = "$" + currAcc.Balance.ToString();
            lblNewBal.Text = "$" + currAcc.Balance.ToString();
            lblPayment.Text = "$0.00";
            lblRemDue.Text = remDue.ToString();

        }
    }
}
