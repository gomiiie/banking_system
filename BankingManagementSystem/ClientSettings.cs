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
    public partial class ClientSettings : Form
    {

        private RichTextBox[] richTextBoxes;
        private string[] profile;

        public ClientSettings()
        {
            InitializeComponent();
            richTextBoxes = new RichTextBox[] { richTextBox1, richTextBox2, richTextBox3, richTextBox4 };
            profile = new string[] { "John Doe", "nyeowneko@gmail.com", "27/02/2003", "01517262882" };
            for (int i = 0; i < profile.Length; i++)
            {
                richTextBoxes[i].Text = profile[i];
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "EDIT") 
            { 
                btnEditUpdate.Text = "UPDATE"; 
                foreach (var rtb in richTextBoxes)
                {
                    rtb.ReadOnly = false;
                }
            }
            else if (btnEditUpdate.Text == "UPDATE") 
            {
                for (int i = 0; i < profile.Length; i++)
                {
                    richTextBoxes[i].ReadOnly = true;
                    profile[i] = richTextBoxes[i].Text;
                }
                btnEditUpdate.Text = "EDIT";
            }
        }
    }
}
