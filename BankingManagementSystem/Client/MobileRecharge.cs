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
    public partial class MobileRecharge : Form
    {

        private Account currAccount;
        private ClientDashboard c1;
        public MobileRecharge()
        {
            InitializeComponent();
        }

        public MobileRecharge(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            currAccount = a1;
            this.c1 = c1;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            float rechargeAmt = Convert.ToSingle(tboxAmt.Text);
            string mobileNumber = (tboxNum.Text);
            string mobOp = listOperator.Text;

            currAccount.Balance -= rechargeAmt;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();

            string updateQuery = $"UPDATE AccountTable SET BALANCE = {currAccount.Balance} WHERE AC_NO = {currAccount.AccountNumber}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();

            string insertQuery = $"INSERT into Transactions(txn_from,txn_to,txn_date,txn_amt,txn_type) " +
                $"values('{currAccount.AccountNumber}','{mobileNumber}','{DateTime.Now}',{rechargeAmt},'Mobile Recharge');";
            updateCmd = new SqlCommand(insertQuery, conn);
            updateCmd.ExecuteNonQuery();

            c1.lblBalance.Text = "$" + currAccount.Balance.ToString();
            MessageBox.Show($"You have successfully recharged ${rechargeAmt.ToString()} to {mobileNumber}.", "Recharge Successful");
            this.Close();
        }
    }
}
