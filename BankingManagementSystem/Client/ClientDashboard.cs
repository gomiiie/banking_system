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
    public partial class ClientDashboard : Form
    {

        private Account currAccount;
        public ClientDashboard()
        {
            InitializeComponent();
        }

        public ClientDashboard(Account a1)
        {
            InitializeComponent();
            currAccount = a1;
            label3.Text += currAccount.Name;
            lblBalance.Text = "$" + currAccount.Balance.ToString();
            clientSideBar1.CurrAcc = a1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeLoan_Click(object sender, EventArgs e)
        {
            TakeLoan l1 = new TakeLoan(currAccount);
            l1.Show();
            this.Close();
        }

        private void clientSideBar1_Load(object sender, EventArgs e)
        {

        }

        private void btnTakeLoan_Click_1(object sender, EventArgs e)
        {
            TakeLoan l1 = new TakeLoan(currAccount);
            l1.Show();
            this.Close();
        }

        private void btnSendMoney_Click_1(object sender, EventArgs e)
        {
            SendMoney s1 = new SendMoney(currAccount, this);
            s1.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DepositWindow s1 = new DepositWindow(currAccount, this);
            s1.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            WithdrawWindow w1 = new WithdrawWindow(currAccount, this);
            w1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMobileRecharge_Click_1(object sender, EventArgs e)
        {
            MobileRecharge m1 = new MobileRecharge(currAccount, this);
            m1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyServ_Click_1(object sender, EventArgs e)
        {
            BuyService b1 = new BuyService(currAccount);
            b1.Show();
            this.Close();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {

        }
    }
}
