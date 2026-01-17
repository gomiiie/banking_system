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
            label3.Text = "Welcome, " + currAccount.Name;
            lblBalance.Text = "$" + currAccount.Balance.ToString();
            clientSideBar1.CurrAcc = a1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WithdrawWindow w1 = new WithdrawWindow(currAccount, this);
            w1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientSettings cs1 = new ClientSettings();
            cs1.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DepositWindow dw1 = new DepositWindow(currAccount, this);
            dw1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            SendMoney s1 = new SendMoney(currAccount, this);
            s1.Show();
        }

        private void btnTakeLoan_Click(object sender, EventArgs e)
        {
            TakeLoan l1 = new TakeLoan(currAccount);
            l1.Show();
            this.Close();
        }

        private void btnBuyServ_Click(object sender, EventArgs e)
        {
            BuyService b1 = new BuyService(currAccount);
            b1.Show();
            this.Close();
        }

        private void btnMobileRecharge_Click(object sender, EventArgs e)
        {
            MobileRecharge m1 = new MobileRecharge(currAccount, this);
            m1.Show();
        }
    }
}
