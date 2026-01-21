using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private Account currAccount;
        public ClientSettings(Account a1)
        {
            InitializeComponent();
            this.currAccount = a1;
            clientSideBar1.CurrAcc = a1;
            tboxAC.Text = currAccount.AccountNumber;
            tboxDOB.Value = currAccount.Dob;
            tboxNumber.Text = currAccount.Number;
            tboxName.Text = currAccount.Name;
            tboxNominee.Text = currAccount.Nominee;
            tboxNID.Text = currAccount.Nid;
            tboxTIN.Text = currAccount.Tin;
            tboxAddress.Text = currAccount.Address;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "Edit Profile") 
            { 
                btnEditUpdate.Text = "Save Changes";
                tboxDOB.Enabled = true;
                tboxName.ReadOnly = false;
                tboxNominee.ReadOnly = false;
                tboxNID.ReadOnly = false;
                tboxTIN.ReadOnly = false;
                tboxAddress.ReadOnly = false;
                MessageBox.Show("You can now edit your profile. Click 'Save Changes' when you are done.");
            }
            else if (btnEditUpdate.Text == "Save Changes") 
            {
                if(tboxName.Text == "" || tboxNominee.Text == "" || tboxNID.Text == "" || tboxTIN.Text == "" || tboxAddress.Text == "")
                {
                    MessageBox.Show("Please do not leave any field empty!");
                    return;
                }
                else if (tboxName.Text.Length > 150)
                {
                    MessageBox.Show("Name cannot be more than 150 characters");
                    return;
                }
                else if (tboxNominee.Text.Length > 150)
                {
                    MessageBox.Show("Nominee cannot be more than 100 characters");
                    return;
                }
                else if (TimeSpan.Compare(DateTime.Now.Subtract(tboxDOB.Value), new TimeSpan(6570, 0, 0, 0)) < 0)
                {
                    MessageBox.Show("You must be over 18 ");
                    return;
                }
                else if (tboxTIN.Text.Length != 12)
                {
                    MessageBox.Show("TIN must be exactly 12 in length");
                    return;
                }
                else if (tboxNID.Text.Length > 17)
                {
                    MessageBox.Show("NID cannot be more than 17 in length");
                    return;
                }
                else if (tboxAddress.Text.Length > 500)
                {
                    MessageBox.Show("Address cannot be more than 500 characters");
                    return;
                }
                else if(tboxNumber.Text.Length != 11)
                {
                    MessageBox.Show("Phone number must be exactly 11 digits");
                    return;
                }

                tboxDOB.Enabled = false;
                tboxName.ReadOnly = true;
                tboxNominee.ReadOnly = true;
                tboxNID.ReadOnly = true;
                tboxTIN.ReadOnly = true;
                tboxAddress.ReadOnly = true;

                currAccount.Dob = tboxDOB.Value;
                currAccount.Number= tboxNumber.Text;
                currAccount.Name = tboxName.Text;
                currAccount.Nominee = tboxNominee.Text;
                currAccount.Nid = tboxNID.Text;
                currAccount.Tin = tboxTIN.Text;
                currAccount.Address = tboxAddress.Text;

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string updateQuery = $"UPDATE AccountTable SET DOB = '{currAccount.Dob}', NAME = '{currAccount.Name}', NOMINEE = '{currAccount.Nominee}', NID = '{currAccount.Nid}', TIN = '{currAccount.Tin}', ADDRESS = '{currAccount.Address}' WHERE AC_NO = {currAccount.AccountNumber}";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Profile has been updated!");
                conn.Close();
                btnEditUpdate.Text = "Edit Profile";
            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
