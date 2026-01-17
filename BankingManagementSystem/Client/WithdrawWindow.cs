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
        public WithdrawWindow()
        {
            InitializeComponent();
        }

        public WithdrawWindow(Account a1, ClientDashboard c1)
        {
            InitializeComponent();
            this.a1 = a1;
            this.c1 = c1;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            depositAmt = Convert.ToSingle(tboxWithdrawAmt.Text);
            a1.Balance -= depositAmt;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string updateQuery = $"UPDATE AccountTable SET BALANCE = {a1.Balance} WHERE AC_NO = {a1.AccountNumber}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();
            c1.lblBalance.Text = "$" + a1.Balance.ToString();
            MessageBox.Show("You have successfully withdrawn $" + depositAmt.ToString("F2") + " from your account.", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            this.Close();
        }

        private void WithdrawWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
