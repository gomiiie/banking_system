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

        public ClientSettings()
        {
            InitializeComponent();
            
        }

        public ClientSettings(Account a1)
        {
            InitializeComponent();
            this.currAccount = a1;
            clientSideBar1.CurrAcc = a1;
            tboxAC.Text = currAccount.AccountNumber;
            tboxDOB.Value = currAccount.Dob;
            //tboxNumber.Text = currAccount.PhoneNumber;
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
            if (btnEditUpdate.Text == "EDIT") 
            { 
                btnEditUpdate.Text = "UPDATE";
                //tboxDOB.ReadOnly = false;
                tboxName.ReadOnly = false;
                tboxNominee.ReadOnly = false;
                tboxNID.ReadOnly = false;
                tboxTIN.ReadOnly = false;
                tboxAddress.ReadOnly = false;
            }
            else if (btnEditUpdate.Text == "UPDATE") 
            {
                //tboxDOB.ReadOnly = true;
                tboxName.ReadOnly = true;
                tboxNominee.ReadOnly = true;
                tboxNID.ReadOnly = true;
                tboxTIN.ReadOnly = true;
                tboxAddress.ReadOnly = true;

                currAccount.Dob = tboxDOB.Value;
                //currAccount.PhoneNumber = tboxNumber.Text;
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
                btnEditUpdate.Text = "EDIT";
            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
