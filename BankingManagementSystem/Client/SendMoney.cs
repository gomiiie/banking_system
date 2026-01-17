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
    public partial class SendMoney : Form
    {

        private Account currAccount;
        private ClientDashboard c1;
        public SendMoney()
        {
            InitializeComponent();
        }
        public SendMoney(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            currAccount = a1;
            this.c1 = c1;
        }

        private void button11_Click(object sender, EventArgs e)
        {


        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string accountNumber = tboxAC.Text;
            float transferAmt = Convert.ToSingle(tboxAmt.Text);
            float Balance;

            currAccount.Balance -= transferAmt;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"SELECT BALANCE FROM AccountTable WHERE AC_NO = {accountNumber}";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Balance = Convert.ToSingle(reader[0]);
            }
            else
            {
                MessageBox.Show("Account number not found.", "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }
            reader.Close();
            string updateQuery = $"UPDATE AccountTable SET BALANCE = {currAccount.Balance} WHERE AC_NO = {currAccount.AccountNumber}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();

            updateQuery = $"UPDATE AccountTable SET BALANCE = {Balance+transferAmt} WHERE AC_NO = {accountNumber}";
            updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();

            string insertQuery = $"INSERT into Transactions(txn_from,txn_to,txn_date,txn_amt,txn_type) " +
                $"values('{currAccount.AccountNumber}','{accountNumber}','{DateTime.Now}',{transferAmt},'Send Money');";
            updateCmd = new SqlCommand(insertQuery, conn);
            updateCmd.ExecuteNonQuery();

            c1.lblBalance.Text = "$" + currAccount.Balance.ToString();
            MessageBox.Show("You have successfully transferred $" + transferAmt.ToString() + " to account number " + accountNumber + ".", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tboxAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tboxAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
