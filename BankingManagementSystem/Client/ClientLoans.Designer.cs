namespace BankingManagementSystem
{
    partial class ClientLoans
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBMSDataSet = new BankingManagementSystem.ABMSDataSet();
            this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansTableAdapter = new BankingManagementSystem.ABMSDataSetTableAdapters.LoansTableAdapter();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldatetakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1026, 756);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // clientSideBar1
            // 
            this.clientSideBar1.CurrAcc = null;
            this.clientSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientSideBar1.Location = new System.Drawing.Point(0, 0);
            this.clientSideBar1.Name = "clientSideBar1";
            this.clientSideBar1.Size = new System.Drawing.Size(177, 756);
            this.clientSideBar1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(75, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(25, 15, 25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 623);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lidDataGridViewTextBoxColumn,
            this.currbalDataGridViewTextBoxColumn,
            this.totalbalDataGridViewTextBoxColumn,
            this.lstatusDataGridViewTextBoxColumn,
            this.ldatetakenDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn,
            this.approvedbyDataGridViewTextBoxColumn,
            this.ltidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(613, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // aBMSDataSet
            // 
            this.aBMSDataSet.DataSetName = "ABMSDataSet";
            this.aBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loansBindingSource
            // 
            this.loansBindingSource.DataMember = "Loans";
            this.loansBindingSource.DataSource = this.aBMSDataSet;
            // 
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "l_id";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            this.lidDataGridViewTextBoxColumn.ReadOnly = true;
            this.lidDataGridViewTextBoxColumn.Width = 150;
            // 
            // currbalDataGridViewTextBoxColumn
            // 
            this.currbalDataGridViewTextBoxColumn.DataPropertyName = "curr_bal";
            this.currbalDataGridViewTextBoxColumn.HeaderText = "curr_bal";
            this.currbalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currbalDataGridViewTextBoxColumn.Name = "currbalDataGridViewTextBoxColumn";
            this.currbalDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalbalDataGridViewTextBoxColumn
            // 
            this.totalbalDataGridViewTextBoxColumn.DataPropertyName = "total_bal";
            this.totalbalDataGridViewTextBoxColumn.HeaderText = "total_bal";
            this.totalbalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalbalDataGridViewTextBoxColumn.Name = "totalbalDataGridViewTextBoxColumn";
            this.totalbalDataGridViewTextBoxColumn.Width = 150;
            // 
            // lstatusDataGridViewTextBoxColumn
            // 
            this.lstatusDataGridViewTextBoxColumn.DataPropertyName = "l_status";
            this.lstatusDataGridViewTextBoxColumn.HeaderText = "l_status";
            this.lstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lstatusDataGridViewTextBoxColumn.Name = "lstatusDataGridViewTextBoxColumn";
            this.lstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // ldatetakenDataGridViewTextBoxColumn
            // 
            this.ldatetakenDataGridViewTextBoxColumn.DataPropertyName = "l_date_taken";
            this.ldatetakenDataGridViewTextBoxColumn.HeaderText = "l_date_taken";
            this.ldatetakenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ldatetakenDataGridViewTextBoxColumn.Name = "ldatetakenDataGridViewTextBoxColumn";
            this.ldatetakenDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            this.aCNODataGridViewTextBoxColumn.Width = 150;
            // 
            // approvedbyDataGridViewTextBoxColumn
            // 
            this.approvedbyDataGridViewTextBoxColumn.DataPropertyName = "approved_by";
            this.approvedbyDataGridViewTextBoxColumn.HeaderText = "approved_by";
            this.approvedbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.approvedbyDataGridViewTextBoxColumn.Name = "approvedbyDataGridViewTextBoxColumn";
            this.approvedbyDataGridViewTextBoxColumn.Width = 150;
            // 
            // ltidDataGridViewTextBoxColumn
            // 
            this.ltidDataGridViewTextBoxColumn.DataPropertyName = "lt_id";
            this.ltidDataGridViewTextBoxColumn.HeaderText = "lt_id";
            this.ltidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltidDataGridViewTextBoxColumn.Name = "ltidDataGridViewTextBoxColumn";
            this.ltidDataGridViewTextBoxColumn.Width = 150;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(720, 510);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 62);
            this.button11.TabIndex = 3;
            this.button11.Text = "MAKE PAYMENT";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ClientLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "ClientLoans";
            this.Text = "ClientLoans";
            this.Load += new System.EventHandler(this.ClientLoans_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABMSDataSet aBMSDataSet;
        private System.Windows.Forms.BindingSource loansBindingSource;
        private ABMSDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currbalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldatetakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button11;
    }
}