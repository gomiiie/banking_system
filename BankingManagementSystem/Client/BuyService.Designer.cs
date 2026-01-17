namespace BankingManagementSystem
{
    partial class BuyService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSCompanyServices = new BankingManagementSystem.ABMSCompanyServices();
            this.companyServicesTableAdapter = new BankingManagementSystem.ABMSCompanyServicesTableAdapters.CompanyServicesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrB = new System.Windows.Forms.Label();
            this.lblCurrBal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).BeginInit();
            this.SuspendLayout();
            // 
            // clientSideBar1
            // 
            this.clientSideBar1.CurrAcc = null;
            this.clientSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientSideBar1.Location = new System.Drawing.Point(0, 0);
            this.clientSideBar1.Name = "clientSideBar1";
            this.clientSideBar1.Size = new System.Drawing.Size(177, 756);
            this.clientSideBar1.TabIndex = 0;
            this.clientSideBar1.Load += new System.EventHandler(this.clientSideBar1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblNewBal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCurrBal);
            this.panel1.Controls.Add(this.lblCurrB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 756);
            this.panel1.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(776, 559);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 75);
            this.button11.TabIndex = 3;
            this.button11.Text = "MAKE PAYMENT";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.spriceDataGridViewTextBoxColumn,
            this.sdescriptionDataGridViewTextBoxColumn,
            this.sstatusDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyServicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(638, 432);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "s_id";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.Width = 150;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "s_name";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 150;
            // 
            // spriceDataGridViewTextBoxColumn
            // 
            this.spriceDataGridViewTextBoxColumn.DataPropertyName = "s_price";
            this.spriceDataGridViewTextBoxColumn.HeaderText = "s_price";
            this.spriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spriceDataGridViewTextBoxColumn.Name = "spriceDataGridViewTextBoxColumn";
            this.spriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // sdescriptionDataGridViewTextBoxColumn
            // 
            this.sdescriptionDataGridViewTextBoxColumn.DataPropertyName = "s_description";
            this.sdescriptionDataGridViewTextBoxColumn.HeaderText = "s_description";
            this.sdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sdescriptionDataGridViewTextBoxColumn.Name = "sdescriptionDataGridViewTextBoxColumn";
            this.sdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // sstatusDataGridViewTextBoxColumn
            // 
            this.sstatusDataGridViewTextBoxColumn.DataPropertyName = "s_status";
            this.sstatusDataGridViewTextBoxColumn.HeaderText = "s_status";
            this.sstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sstatusDataGridViewTextBoxColumn.Name = "sstatusDataGridViewTextBoxColumn";
            this.sstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            this.aCNODataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyServicesBindingSource
            // 
            this.companyServicesBindingSource.DataMember = "CompanyServices";
            this.companyServicesBindingSource.DataSource = this.aBMSCompanyServices;
            // 
            // aBMSCompanyServices
            // 
            this.aBMSCompanyServices.DataSetName = "ABMSCompanyServices";
            this.aBMSCompanyServices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyServicesTableAdapter
            // 
            this.companyServicesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblCurrB
            // 
            this.lblCurrB.AutoSize = true;
            this.lblCurrB.Location = new System.Drawing.Point(721, 408);
            this.lblCurrB.Name = "lblCurrB";
            this.lblCurrB.Size = new System.Drawing.Size(124, 20);
            this.lblCurrB.TabIndex = 5;
            this.lblCurrB.Text = "Current Balance";
            // 
            // lblCurrBal
            // 
            this.lblCurrBal.AutoSize = true;
            this.lblCurrBal.Location = new System.Drawing.Point(860, 408);
            this.lblCurrBal.Name = "lblCurrBal";
            this.lblCurrBal.Size = new System.Drawing.Size(0, 20);
            this.lblCurrBal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Net Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(860, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "New Balance";
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Location = new System.Drawing.Point(860, 481);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(0, 20);
            this.lblNewBal.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "_____________________";
            // 
            // BuyService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "BuyService";
            this.Text = "BuyService";
            this.Load += new System.EventHandler(this.BuyService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABMSCompanyServices aBMSCompanyServices;
        private System.Windows.Forms.BindingSource companyServicesBindingSource;
        private ABMSCompanyServicesTableAdapters.CompanyServicesTableAdapter companyServicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrBal;
        private System.Windows.Forms.Label lblCurrB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNewBal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
    }
}