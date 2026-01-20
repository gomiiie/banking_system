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
    public partial class CompanyHome : Form
    {
        public CompanyHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyServces c1 = new CompanyServces();
            c1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login c1 = new Login();
            c1.Show();
            this.Hide();
        }

        private void trns1_Click(object sender, EventArgs e)
        {
            CompanyTransactions c1 = new CompanyTransactions();
            c1.Show();
            this.Hide();
        }

        private void sls_Click(object sender, EventArgs e)
        {
            CompanySales c1 = new CompanySales();
            c1.Show();
            this.Hide();
        }
    }
}
