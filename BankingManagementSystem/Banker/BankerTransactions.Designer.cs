namespace BankingManagementSystem.Banker
{
    partial class BankerTransactions
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
            this.aBMSClientTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSClientTransactions = new BankingManagementSystem.ABMSClientTransactions();
            this.label1 = new System.Windows.Forms.Label();
            //this.aBMSDataSet1 = new BankingManagementSystem.ABMSDataSet1();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.transactionsTableAdapter = new BankingManagementSystem.ABMSDataSet1TableAdapters.TransactionsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter1 = new BankingManagementSystem.ABMSClientTransactionsTableAdapters.TransactionsTableAdapter();
            this.txnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bankerSideBar1 = new BankingManagementSystem.BankerSideBar();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aBMSClientTransactionsBindingSource
            // 
            this.aBMSClientTransactionsBindingSource.DataSource = this.aBMSClientTransactions;
            this.aBMSClientTransactionsBindingSource.Position = 0;
            // 
            // aBMSClientTransactions
            // 
            this.aBMSClientTransactions.DataSetName = "ABMSClientTransactions";
            this.aBMSClientTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Transactions History";
            // 
            // aBMSDataSet1
            // 
            //this.aBMSDataSet1.DataSetName = "ABMSDataSet1";
            //this.aBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            //this.transactionsBindingSource.DataSource = this.aBMSDataSet1;
            // 
            // transactionsTableAdapter
            // 
            //this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(52, 816);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "© 2026, Group 8, C# (X), AIUB, Dhaka, Bangladesh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 839);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txnidDataGridViewTextBoxColumn,
            this.txnfromDataGridViewTextBoxColumn,
            this.txntoDataGridViewTextBoxColumn,
            this.txndateDataGridViewTextBoxColumn,
            this.txnamtDataGridViewTextBoxColumn,
            this.txn_type,
            this.l_id});
            this.dataGridView1.DataSource = this.transactionsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(55, 283);
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
            this.dataGridView1.Size = new System.Drawing.Size(917, 484);
            this.dataGridView1.TabIndex = 8;
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "Transactions";
            this.transactionsBindingSource1.DataSource = this.aBMSClientTransactions;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // txnidDataGridViewTextBoxColumn
            // 
            this.txnidDataGridViewTextBoxColumn.DataPropertyName = "txn_id";
            this.txnidDataGridViewTextBoxColumn.HeaderText = "TID";
            this.txnidDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.txnidDataGridViewTextBoxColumn.Name = "txnidDataGridViewTextBoxColumn";
            this.txnidDataGridViewTextBoxColumn.ReadOnly = true;
            this.txnidDataGridViewTextBoxColumn.Width = 70;
            // 
            // txnfromDataGridViewTextBoxColumn
            // 
            this.txnfromDataGridViewTextBoxColumn.DataPropertyName = "txn_from";
            this.txnfromDataGridViewTextBoxColumn.HeaderText = "From";
            this.txnfromDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.txnfromDataGridViewTextBoxColumn.Name = "txnfromDataGridViewTextBoxColumn";
            this.txnfromDataGridViewTextBoxColumn.Width = 80;
            // 
            // txntoDataGridViewTextBoxColumn
            // 
            this.txntoDataGridViewTextBoxColumn.DataPropertyName = "txn_to";
            this.txntoDataGridViewTextBoxColumn.FillWeight = 10F;
            this.txntoDataGridViewTextBoxColumn.HeaderText = "To";
            this.txntoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.txntoDataGridViewTextBoxColumn.Name = "txntoDataGridViewTextBoxColumn";
            this.txntoDataGridViewTextBoxColumn.Width = 150;
            // 
            // txndateDataGridViewTextBoxColumn
            // 
            this.txndateDataGridViewTextBoxColumn.DataPropertyName = "txn_date";
            this.txndateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.txndateDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.txndateDataGridViewTextBoxColumn.Name = "txndateDataGridViewTextBoxColumn";
            this.txndateDataGridViewTextBoxColumn.Width = 180;
            // 
            // txnamtDataGridViewTextBoxColumn
            // 
            this.txnamtDataGridViewTextBoxColumn.DataPropertyName = "txn_amt";
            this.txnamtDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.txnamtDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.txnamtDataGridViewTextBoxColumn.Name = "txnamtDataGridViewTextBoxColumn";
            this.txnamtDataGridViewTextBoxColumn.Width = 130;
            // 
            // txn_type
            // 
            this.txn_type.DataPropertyName = "txn_type";
            this.txn_type.HeaderText = "Type";
            this.txn_type.MinimumWidth = 8;
            this.txn_type.Name = "txn_type";
            this.txn_type.Width = 150;
            // 
            // l_id
            // 
            this.l_id.DataPropertyName = "l_id";
            this.l_id.HeaderText = "SLID";
            this.l_id.MinimumWidth = 8;
            this.l_id.Name = "l_id";
            this.l_id.Width = 90;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(115, 207);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(314, 37);
            this.searchBox.TabIndex = 15;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bankerSideBar1
            // 
            this.bankerSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bankerSideBar1.Location = new System.Drawing.Point(0, 0);
            this.bankerSideBar1.Name = "bankerSideBar1";
            this.bankerSideBar1.Size = new System.Drawing.Size(173, 839);
            this.bankerSideBar1.TabIndex = 17;
            // 
            // BankerTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 839);
            this.Controls.Add(this.bankerSideBar1);
            this.Controls.Add(this.panel1);
            this.Name = "BankerTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankerTransactions";
            this.Load += new System.EventHandler(this.BankerTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankerSideBar bankerSideBar1;
        private System.Windows.Forms.BindingSource aBMSClientTransactionsBindingSource;
        private ABMSClientTransactions aBMSClientTransactions;
        private System.Windows.Forms.Label label1;
        //private ABMSDataSet1 aBMSDataSet1;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        //private ABMSDataSet1TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private ABMSClientTransactionsTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}