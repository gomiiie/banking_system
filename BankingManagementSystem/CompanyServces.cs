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
    public partial class CompanyServces : Form
    {
        public CompanyServces()
        {
            InitializeComponent();
        }

        private void addserv_Click(object sender, EventArgs e)
        {
            CompanyHome c1 = new CompanyHome();
            c1.Show();
            this.Hide();
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SUMAIYA\SQLEXPRESS;Initial Catalog=ABMS;Integrated Security=True;");
            conn.Open();
            string query = "Select * from services";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void CompanyServces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBMSDataSet1.Services' table. You can move, or remove it, as needed.
            //this.servicesTableAdapter.Fill(this.aBMSDataSet1.Services);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
