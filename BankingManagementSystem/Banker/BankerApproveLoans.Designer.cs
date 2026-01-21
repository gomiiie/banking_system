namespace BankingManagementSystem.Banker
{
    partial class BankerApproveLoans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltinterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldatetakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet4 = new BankingManagementSystem.ABMSDataSet4();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet3 = new BankingManagementSystem.ABMSDataSet3();
            this.aBMSClientTransactions = new BankingManagementSystem.ABMSClientTransactions();
            this.aBMSClientTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new BankingManagementSystem.ABMSDataSet3TableAdapters.TransactionsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pendingLoansTableAdapter = new BankingManagementSystem.ABMSDataSet4TableAdapters.PendingLoansTableAdapter();
            this.l_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt_interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_bal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_date_taken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactionsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lidDataGridViewTextBoxColumn,
            this.ltnameDataGridViewTextBoxColumn,
            this.ltinterestDataGridViewTextBoxColumn,
            this.ltdurationDataGridViewTextBoxColumn,
            this.totalbalDataGridViewTextBoxColumn,
            this.lstatusDataGridViewTextBoxColumn,
            this.ldatetakenDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendingLoansBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(991, 602);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "LID";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            // 
            // ltnameDataGridViewTextBoxColumn
            // 
            this.ltnameDataGridViewTextBoxColumn.DataPropertyName = "lt_name";
            this.ltnameDataGridViewTextBoxColumn.HeaderText = "Loan Type";
            this.ltnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltnameDataGridViewTextBoxColumn.Name = "ltnameDataGridViewTextBoxColumn";
            // 
            // ltinterestDataGridViewTextBoxColumn
            // 
            this.ltinterestDataGridViewTextBoxColumn.DataPropertyName = "lt_interest";
            this.ltinterestDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.ltinterestDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltinterestDataGridViewTextBoxColumn.Name = "ltinterestDataGridViewTextBoxColumn";
            // 
            // ltdurationDataGridViewTextBoxColumn
            // 
            this.ltdurationDataGridViewTextBoxColumn.DataPropertyName = "lt_duration";
            this.ltdurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.ltdurationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltdurationDataGridViewTextBoxColumn.Name = "ltdurationDataGridViewTextBoxColumn";
            // 
            // totalbalDataGridViewTextBoxColumn
            // 
            this.totalbalDataGridViewTextBoxColumn.DataPropertyName = "total_bal";
            this.totalbalDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.totalbalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalbalDataGridViewTextBoxColumn.Name = "totalbalDataGridViewTextBoxColumn";
            // 
            // lstatusDataGridViewTextBoxColumn
            // 
            this.lstatusDataGridViewTextBoxColumn.DataPropertyName = "l_status";
            this.lstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.lstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lstatusDataGridViewTextBoxColumn.Name = "lstatusDataGridViewTextBoxColumn";
            // 
            // ldatetakenDataGridViewTextBoxColumn
            // 
            this.ldatetakenDataGridViewTextBoxColumn.DataPropertyName = "l_date_taken";
            this.ldatetakenDataGridViewTextBoxColumn.HeaderText = "Date Applied";
            this.ldatetakenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ldatetakenDataGridViewTextBoxColumn.Name = "ldatetakenDataGridViewTextBoxColumn";
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "By";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            // 
            // pendingLoansBindingSource
            // 
            this.pendingLoansBindingSource.DataMember = "PendingLoans";
            this.pendingLoansBindingSource.DataSource = this.aBMSDataSet4;
            // 
            // aBMSDataSet4
            // 
            this.aBMSDataSet4.DataSetName = "ABMSDataSet4";
            this.aBMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.aBMSDataSet3;
            // 
            // aBMSDataSet3
            // 
            this.aBMSDataSet3.DataSetName = "ABMSDataSet3";
            this.aBMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBMSClientTransactions
            // 
            this.aBMSClientTransactions.DataSetName = "ABMSClientTransactions";
            this.aBMSClientTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBMSClientTransactionsBindingSource
            // 
            this.aBMSClientTransactionsBindingSource.DataSource = this.aBMSClientTransactions;
            this.aBMSClientTransactionsBindingSource.Position = 0;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 66);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(991, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "APPROVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pendingLoansTableAdapter
            // 
            this.pendingLoansTableAdapter.ClearBeforeFill = true;
            // 
            // l_id
            // 
            this.l_id.DataPropertyName = "l_id";
            this.l_id.HeaderText = "L ID";
            this.l_id.MinimumWidth = 8;
            this.l_id.Name = "l_id";
            this.l_id.Width = 150;
            // 
            // lt_name
            // 
            this.lt_name.DataPropertyName = "lt_name";
            this.lt_name.HeaderText = "lt_name";
            this.lt_name.MinimumWidth = 8;
            this.lt_name.Name = "lt_name";
            this.lt_name.Width = 150;
            // 
            // lt_interest
            // 
            this.lt_interest.DataPropertyName = "lt_interest";
            this.lt_interest.HeaderText = "lt_interest";
            this.lt_interest.MinimumWidth = 8;
            this.lt_interest.Name = "lt_interest";
            this.lt_interest.Width = 150;
            // 
            // lt_status
            // 
            this.lt_status.DataPropertyName = "lt_status";
            this.lt_status.HeaderText = "lt_status";
            this.lt_status.MinimumWidth = 8;
            this.lt_status.Name = "lt_status";
            this.lt_status.Width = 150;
            // 
            // lt_duration
            // 
            this.lt_duration.DataPropertyName = "lt_duration";
            this.lt_duration.HeaderText = "lt_duration";
            this.lt_duration.MinimumWidth = 8;
            this.lt_duration.Name = "lt_duration";
            this.lt_duration.Width = 150;
            // 
            // total_bal
            // 
            this.total_bal.DataPropertyName = "total_bal";
            this.total_bal.HeaderText = "total_bal";
            this.total_bal.MinimumWidth = 8;
            this.total_bal.Name = "total_bal";
            this.total_bal.Width = 150;
            // 
            // l_date_taken
            // 
            this.l_date_taken.DataPropertyName = "l_date_taken";
            this.l_date_taken.HeaderText = "l_date_taken";
            this.l_date_taken.MinimumWidth = 8;
            this.l_date_taken.Name = "l_date_taken";
            this.l_date_taken.Width = 150;
            // 
            // LID
            // 
            this.LID.DataPropertyName = "l_id";
            this.LID.HeaderText = "l_id";
            this.LID.MinimumWidth = 8;
            this.LID.Name = "LID";
            this.LID.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lt_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "lt_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lt_interest";
            this.dataGridViewTextBoxColumn2.HeaderText = "lt_interest";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lt_status";
            this.dataGridViewTextBoxColumn3.HeaderText = "lt_status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lt_duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "lt_duration";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total_bal";
            this.dataGridViewTextBoxColumn5.HeaderText = "total_bal";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // l_status
            // 
            this.l_status.DataPropertyName = "l_status";
            this.l_status.HeaderText = "l_status";
            this.l_status.MinimumWidth = 8;
            this.l_status.Name = "l_status";
            this.l_status.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "l_date_taken";
            this.dataGridViewTextBoxColumn6.HeaderText = "l_date_taken";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // BankerApproveLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BankerApproveLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankerApproveLoans";
            this.Load += new System.EventHandler(this.BankerApproveLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactionsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private ABMSDataSet3 aBMSDataSet3;
        private ABMSClientTransactions aBMSClientTransactions;
        private System.Windows.Forms.BindingSource aBMSClientTransactionsBindingSource;
        private ABMSDataSet3TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private ABMSDataSet4 aBMSDataSet4;
        private System.Windows.Forms.BindingSource pendingLoansBindingSource;
        private ABMSDataSet4TableAdapters.PendingLoansTableAdapter pendingLoansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt_interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_bal;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_date_taken;
        private System.Windows.Forms.DataGridViewTextBoxColumn LID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltinterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldatetakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
    }
}