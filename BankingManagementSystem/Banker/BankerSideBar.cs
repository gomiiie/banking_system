using BankingManagementSystem.Banker;
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

    public partial class BankerSideBar : UserControl
    {

        private string aC_NO;
        private Form f1;
        public string AC_NO
        {
            get; set;
        }

        public BankerSideBar()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(f1 is BankerCompany)
            {
                return;
            }
            BankerCompany bc = new BankerCompany(AC_NO);
            bc.Show();
            f1.Hide();
        }

        private void btnTxn_Click(object sender, EventArgs e)
        {
            if(f1 is BankerClients)
            {
                return;
            }
            BankerClients bc = new BankerClients(AC_NO);
            bc.Show();
            f1.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            f1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(f1 is BankerLoans)
            {
                return;
            }
            BankerLoans b1 = new BankerLoans(AC_NO);
            b1.Show();
            f1.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (f1 is BankerDashboard)
            {
                return;
            }
            BankerDashboard b1 = new BankerDashboard(AC_NO);
            b1.Show();
            f1.Hide();
        }

        private void BankerSideBar_Load(object sender, EventArgs e)
        {
            f1 = this.FindForm();
            if (f1 is BankerDashboard)
            {
                btnHome.BackColor = Color.FromArgb(26, 174, 248);
            }
            else if (f1 is BankerClients)
            {
                btnTxn.BackColor = Color.FromArgb(26, 174, 248);
            }
            else if (f1 is BankerLoans)
            {
                button1.BackColor = Color.FromArgb(26, 174, 248);
            }
            else if (f1 is BankerCompany)
            {
                button2.BackColor = Color.FromArgb(26, 174, 248);
            }
        }
    }
}
