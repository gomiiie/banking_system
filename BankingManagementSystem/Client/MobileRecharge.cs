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
            label8.Text = currAccount.AccountNumber;
            lblAmt.Text = label11.Text = label12.Text = "";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(!Decimal.TryParse(tboxAmt.Text,out decimal r))
            {
                lblAmt.Text = "Please enter a numeric amount.";
                flag = false;
            }
            if (listOperator.Text == "")
            {
                label11.Text = "Please select a mobile operator.";
                flag = false;
            }
            if (tboxNum.Text.Length != 11 || tboxNum.Text == "" || !Decimal.TryParse(tboxNum.Text, out decimal a) || Convert.ToInt32(tboxNum.Text) < 0)
            {
                label12.Text = "Please enter a valid 11-digit mobile number.";
                flag = false;
            }
            if (flag)
            {
                float rechargeAmt = Convert.ToSingle(tboxAmt.Text);
                if(rechargeAmt <= 0)
                {
                    lblAmt.Text = "Please enter a positive amount.";
                    return;
                }
                if(rechargeAmt > currAccount.Balance)
                {
                    lblAmt.Text = "Insufficient balance for this recharge.";
                    return;
                }
                if(rechargeAmt > 500)
                {
                    lblAmt.Text = "Recharge limit is $500.";
                    return;
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
