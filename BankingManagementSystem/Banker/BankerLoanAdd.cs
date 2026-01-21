using BankingManagementSystem.Banker;
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
    public partial class BankerLoanAdd : Form
    {
        private string AC_NO;
        private BankerLoans l1;
        public BankerLoanAdd(string AC_NO, BankerLoans l1)
        {
            InitializeComponent();
            this.AC_NO = AC_NO;
            this.l1 = l1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (tboxName.Text.Length > 50 || tboxName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name within 50 characters.");
                flag = false;
            }
            if (!decimal.TryParse(tboxIR.Text, out decimal ir) || ir < 0 || ir > 100)
            {
                MessageBox.Show("Please enter a valid interest rate (0-100).");
                flag = false;
            }
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                flag = false;
            }
            if (!int.TryParse(tboxDur.Text, out int dur) || dur <= 0 || dur >50)
            {
                MessageBox.Show("Please enter a valid duration in integer years (0-50)");
                flag = false;
            }
            if (tboxDescription.Text.Length < 0 || tboxDescription.Text.Length > 100)
            {
                MessageBox.Show("Please enter a description within 100 characters.");
                flag = false;
            }
            if (flag)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
                conn.Open();
                string query = $"INSERT INTO LoanTypes (LT_NAME, LT_INTEREST, LT_STATUS, LT_DATE_ADDED, LASTEDIT_BY, LT_DURATION, LT_DESCRIPTION) " +
                               $"VALUES ('{tboxName.Text}', {tboxIR.Text}, '{cbStatus.Text}', '{DateTime.Now}', '{AC_NO}', '{tboxDur.Text}', '{tboxDescription.Text}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A new loan type has been added.");
                query = "SELECT lt_id, lt_name, lt_interest, lt_status, lt_date_added, lastedit_by, lt_duration FROM LoanTypes;";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                l1.dataGridView1.DataSource = dt;
                l1.dataGridView1.AutoGenerateColumns = true;
                conn.Close();
            }
        }
    }
}
