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
    public partial class CompanySales : Form
    {
        public CompanySales()
        {
            InitializeComponent();
        }

        private void backk1_Click(object sender, EventArgs e)
        {
            CompanyHome c1 = new CompanyHome();
            c1.Show();
            this.Hide();
        }
    }
}
