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
    public partial class TakeLoan : Form
    {

        private int LID = -1;
        private float interestRate;
        private float duration;
        private float TA;
        private float TI;
        private float TR;

        private Account currAcc;
        public TakeLoan(Account a1)
        {
            InitializeComponent();
            show();
            this.currAcc = a1;
            clientSideBar1.CurrAcc = a1;
            tboxAmt.Text = "0.00";
            lblTAmt.Text = "$0.00";
            lblTI.Text = "$0.00";
            lblTR.Text = "$0.00";

        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM LoanTypes WHERE LT_STATUS = 'AVAILABLE'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void TakeLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSLoanTypessss.LoanTypes' table. You can move, or remove it, as needed.
            this.loanTypesTableAdapter1.Fill(this.aBMSLoanTypessss.LoanTypes);
            // TODO: This line of code loads data into the 'aBMSLoanTypes.LoanTypes' table. You can move, or remove it, as needed.
            // this.loanTypesTableAdapter.Fill(this.aBMSLoanTypes.LoanTypes);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(LID == -1)
            {
                MessageBox.Show("Please select a loan type first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tboxAmt.Text == "")
            {
                MessageBox.Show("Please enter a loan amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(TA <= 0)
            {
                MessageBox.Show("Loan amount must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(TA >= 1000000000000)
            {
                MessageBox.Show("Loan amount is too large.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CQ6UGDS\SQLEXPRESS01;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = $"INSERT INTO Loans (AC_NO, curr_bal, total_bal, l_date_taken, l_status, lt_id) " +
                           $"VALUES ({currAcc.AccountNumber}, 0, {TR}, '{DateTime.Now}', 'PENDING', {LID})";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Loan application submitted successfully!", "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            LID = -1;
            tboxAmt.Text = "0.00";
            TI = TR = TA = 0;
            lblTI.Text = lblTR.Text = lblTAmt.Text = "$0.00";
            tboxName.Text = "";
            tboxIR.Text = "";
            tboxDur.Text = "";
        }

        private void lblNewBal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            interestRate = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            
            tboxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            duration = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            lblTAmt.Text = "$" + tboxAmt.Text;
            float totalInterest = (Convert.ToSingle(tboxAmt.Text) * interestRate * duration) / 100;
            lblTI.Text = "$" + totalInterest.ToString();
            lblTR.Text = "$" + (Convert.ToSingle(tboxAmt.Text) + totalInterest).ToString();
            tboxDur.Text = duration.ToString();
            tboxIR.Text = interestRate.ToString() + "% p.a.";
        }

        private void tboxAmt_TextChanged(object sender, EventArgs e)
        {
            if(tboxAmt.Text == "") return;
            if(!Single.TryParse(tboxAmt.Text, out float result))
            {
                MessageBox.Show("Please enter a numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tboxAmt.Text = "0.00";
                return;
            }
            TA = Convert.ToSingle(tboxAmt.Text);
            TI = (TA * interestRate * duration) / 100;
            TR = TA + TI;
            lblTAmt.Text = "$" + tboxAmt.Text;
            lblTI.Text = "$" + TI.ToString();
            lblTR.Text = "$" + TR.ToString();
        }
    }
}
