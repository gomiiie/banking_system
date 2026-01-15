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
    public partial class SendMoney : Form
    {
        public SendMoney()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int accountNumber = int.Parse(tboxAC.Text);
            float transferAmt = float.Parse(tboxAmt.Text);
            MessageBox.Show("You have successfully transferred $" + transferAmt.ToString("F2") + " to account number " + accountNumber + ".", "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
