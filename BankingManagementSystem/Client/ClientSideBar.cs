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


        private Form currForm;
        private Account currAcc;

        public Account CurrAcc { get; set; }

        public ClientSideBar()
        {
            InitializeComponent();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currForm is ClientDashboard) { return; }
            ClientDashboard c1 = new ClientDashboard(CurrAcc);
            c1.Show();
            currForm.Close();
        }
        private void btnTxn_Click(object sender, EventArgs e)
        {

            if (currForm is ClientTransactions) { return; }
            ClientTransactions ct1 = new ClientTransactions(CurrAcc);
            ct1.Show();
            currForm.Close();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (currForm is ClientLoans) { return; }
            ClientLoans cl1 = new ClientLoans(CurrAcc);
            cl1.Show();
            currForm.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (currForm is ClientSettings) { return; }
            ClientSettings cs1 = new ClientSettings(CurrAcc);
            cs1.Show();
            currForm.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            currForm.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientSideBar_Load(object sender, EventArgs e)
        {
            currForm = this.FindForm();
            if(currForm is ClientDashboard)
            {
                btnHome.BackColor = Color.FromArgb(53, 134, 249);
            }
            else if(currForm is ClientTransactions)
            {
                btnTxn.BackColor = Color.FromArgb(53, 134, 249);
            }
            else if(currForm is ClientLoans)
            {
                btnLoan.BackColor = Color.FromArgb(53, 134, 249);
            }
            else if(currForm is ClientSettings)
            {
                btnSettings.BackColor = Color.FromArgb(53, 134, 249);
            }
        }
    }
}
