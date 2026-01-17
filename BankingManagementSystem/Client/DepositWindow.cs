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
        public DepositWindow()
        {
            InitializeComponent();
        }


        public DepositWindow(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            currAccount = a1;
            this.c1 = c1;
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            depositAmt = Convert.ToSingle(tboxDepostAmt.Text);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
