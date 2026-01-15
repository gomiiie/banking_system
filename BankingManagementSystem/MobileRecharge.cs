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
    public partial class MobileRecharge : Form
    {
        public MobileRecharge()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            float rechargeAmt = float.Parse(tboxAmt.Text);
            int mobileNumber = int.Parse(tboxNum.Text);
            string mobOp = listOperator.Text;
            MessageBox.Show("You have successfully recharged $" + rechargeAmt.ToString("F2") + " to mobile number " + mobileNumber + " (" + mobOp + ").", "Recharge Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
