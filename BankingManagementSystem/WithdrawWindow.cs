using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public WithdrawWindow()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            depositAmt = float.Parse(tboxWithdrawAmt.Text);
            MessageBox.Show("You have successfully withdrawn $" + depositAmt.ToString("F2") + " from your account.", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
