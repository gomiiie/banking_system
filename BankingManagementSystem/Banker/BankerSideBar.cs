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


        public BankerSideBar()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTxn_Click(object sender, EventArgs e)
        {
            BankerClients bc = new BankerClients();
            bc.Show();
            this.FindForm().Hide();
        }
    }
}
