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

namespace BankingManagementSystem
{
    public partial class DepositWindow : Form
    {

        private float depositAmt;
        private Account currAccount;
        private ClientDashboard c1;

        public DepositWindow(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            currAccount = a1;
            this.c1 = c1;
            label6.Text = currAccount.AccountNumber;
            lblAmt.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(tboxDepostAmt.Text,out decimal r))
            {
                lblAmt.Text = "Please enter a numeric amount.";
                return;
            }
            if (comboBox1.Text == "")
            {
                lblAmt.Text = "Please select a deposit method.";
                return;
            }
            depositAmt = Convert.ToSingle(tboxDepostAmt.Text);
            if (depositAmt <= 0)
            {
                lblAmt.Text = "Please enter a positive amount.";
                return;
            }
            if (depositAmt > 10000)
            {
                lblAmt.Text = "Deposit limit is $10,000.";
                return;
            }
            currAccount.Balance += depositAmt;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string updateQuery = $"UPDATE AccountTable SET BALANCE = {currAccount.Balance} WHERE AC_NO = {currAccount.AccountNumber}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();
            c1.lblBalance.Text = "$" + currAccount.Balance.ToString();
            MessageBox.Show("You have successfully deposited $" + depositAmt.ToString() + " into your account.", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
