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
    public partial class RegChoose : Form
    {
        public RegChoose()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            Registration1 reg1Form = new Registration1();
            reg1Form.Show();
            this.Hide();
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            Registration1 reg2Form = new Registration1();
            reg2Form.Show();
            this.Hide();
        }

        private void btnChoose3_Click(object sender, EventArgs e)
        {
            Registration1 reg3Form = new Registration1();
            reg3Form.Show();
            this.Hide();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();
        }
    }
}
