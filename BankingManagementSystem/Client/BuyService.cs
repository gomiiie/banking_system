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
    public partial class BuyService : Form
    {
        private string compAccNo;
        private float price;
        private Account currAcc;
        private int serviceID = -1;
        public BuyService(Account a1)
        {
            InitializeComponent();
            this.currAcc = a1;
            clientSideBar1.CurrAcc = a1;
            lblCurrBal.Text = "$" + currAcc.Balance.ToString();
            lblTotal.Text = "$0.00";
            lblNewBal.Text = "$" + currAcc.Balance.ToString();

            show();
        }

        private void defaultPrice()
        {
            lblCurrBal.Text = "$" + currAcc.Balance.ToString();
            lblTotal.Text = "$0.00";
            lblNewBal.Text = "$" + currAcc.Balance.ToString();
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT S_ID, S_NAME, S_PRICE, S_DESCRIPTION, S_STATUS, AC_NO, Name FROM CompanyServices";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void clientSideBar1_Load(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if(serviceID == -1)
            {
                MessageBox.Show("Please select a service to purchase.", "No Service Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currAcc.Balance < price)
            {
                MessageBox.Show("Insufficient Balance!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currAcc.Balance -= price;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string updateQuery = $"UPDATE AccountTable SET BALANCE = {currAcc.Balance} WHERE AC_NO = {currAcc.AccountNumber}";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.ExecuteNonQuery();
            string insertQuery = $"INSERT into Transactions(txn_from,txn_to,txn_date,txn_amt,txn_type, l_id) " +
                $"values('{currAcc.AccountNumber}',{compAccNo},'{DateTime.Now}',{price},'Service Purchase', {serviceID});";
            updateCmd = new SqlCommand(insertQuery, conn);
            updateCmd.ExecuteNonQuery();
            MessageBox.Show($"You have successfully purchased the service for ${price.ToString()}.", "Transaction Successful");
            defaultPrice();
            conn.Close();
            serviceID = -1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serviceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            lblCurrBal.Text = "$  " + currAcc.Balance.ToString();
            price = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            lblTotal.Text = "$ " + price.ToString();
            lblNewBal.Text = "$  " + (currAcc.Balance - price).ToString();
            compAccNo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
