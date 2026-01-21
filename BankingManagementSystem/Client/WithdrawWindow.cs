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
    public partial class WithdrawWindow : Form
    {

        private float depositAmt;
        private Account a1;
        private ClientDashboard c1;

        public WithdrawWindow(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            this.a1 = a1;
            this.c1 = c1;
            label6.Text = a1.AccountNumber;
            lblAmt.Text = lblAgent.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(tboxWithdrawAmt.Text == "")
            {
                lblAmt.Text = "Please enter an amount to withdraw.";
                flag = false;
            }
            if(tboxAgentNum.Text == "")
            {
                lblAgent.Text = "Please enter your agent number.";
                flag = false;
            }
            if (flag)
            {
                depositAmt = Convert.ToSingle(tboxWithdrawAmt.Text);
                if(depositAmt <= 0)
                {
                    lblAmt.Text = "Please enter a valid amount to withdraw.";
                    return;
                }
                if(depositAmt > a1.Balance)
                {
                    lblAmt.Text = "Insufficient balance for this withdrawal.";
                    return;
                }
                if(depositAmt > 1000)
                {
                    lblAmt.Text = "Withdrawal amount exceeds the maximum limit of $1000.";
                    return;
                }
                if(!Decimal.TryParse(tboxAgentNum.Text, out decimal n))
                {
                    lblAgent.Text = "Please enter a valid agent number.";
                    return;
                }
                int agentNum = Convert.ToInt32(tboxAgentNum.Text);
                if (agentNum <= 0)
                {
                    lblAgent.Text = "Please enter a valid agent number.";
                    return;
                }

                a1.Balance -= depositAmt;
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string updateQuery = $"UPDATE AccountTable SET BALANCE = {a1.Balance} WHERE AC_NO = {a1.AccountNumber}";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.ExecuteNonQuery();

                string insertQuery = "INSERT INTO Transactions (TXN_FROM, TXN_TO, TXN_DATE, TXN_AMT, TXN_TYPE)" +
                                     $"VALUES ({a1.AccountNumber}, {agentNum}, '{DateTime.Now}', {depositAmt}, Withdrawal)";
                c1.lblBalance.Text = "$" + a1.Balance.ToString();
                MessageBox.Show("You have successfully withdrawn $" + depositAmt.ToString("F2") + " from your account.", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
