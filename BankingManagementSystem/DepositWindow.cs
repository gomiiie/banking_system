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
    public partial class DepositWindow : Form
    {

        private float depositAmt;
        public DepositWindow()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            depositAmt = float.Parse(tboxDepostAmt.Text);
            MessageBox.Show("You have successfully deposited $" + depositAmt.ToString("F2") + " into your account.", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
