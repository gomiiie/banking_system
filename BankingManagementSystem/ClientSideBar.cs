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
    public partial class ClientSideBar : UserControl
    {


        private Form a;

        public ClientSideBar()
        {
            InitializeComponent();
            a = this.FindForm();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Form a = this.FindForm();
            if(a is ClientDashboard) { return; }
            else
            {
                ClientDashboard c1 = new ClientDashboard();
                c1.Show();
                a.Close();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(a is ClientSettings) { return; }
            else
            {
                ClientSettings cs1 = new ClientSettings();
                cs1.Show();
                a.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.FindForm().Close();
        }

        private void btnTxn_Click(object sender, EventArgs e)
        {
            //Form a = this.FindForm();
            if(a is ClientTransactions) { return; }
            else
            {
                ClientTransactions ct1 = new ClientTransactions();
                ct1.Show();
                a.Close();
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            //Form a = this.FindForm();
            if (a is ClientLoans) { return; }
            else
            {
                ClientLoans cl1 = new ClientLoans();
                cl1.Show();
                a.Close();
            }
        }
    }
}
