using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem.Company
{
    public partial class CompanyProfile : Form
    {
        public CompanyProfile()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyEditProfile c1 = new CompanyEditProfile();
            c1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyHome c1 = new CompanyHome();
            c1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();

        }
    }
}
