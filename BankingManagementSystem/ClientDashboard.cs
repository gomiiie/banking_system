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
        public ClientDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WithdrawWindow w1 = new WithdrawWindow();
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
            DepositWindow dw1 = new DepositWindow();
            dw1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            SendMoney s1 = new SendMoney();
            s1.Show();
        }
    }
}
