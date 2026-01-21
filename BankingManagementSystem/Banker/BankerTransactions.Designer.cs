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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aBMSClientTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSClientTransactions = new BankingManagementSystem.ABMSClientTransactions();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter1 = new BankingManagementSystem.ABMSClientTransactionsTableAdapters.TransactionsTableAdapter();
            this.aBMSTransactions = new BankingManagementSystem.ABMSTransactions();
            this.transactionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBMSDataSet5 = new BankingManagementSystem.ABMSDataSet5();
            this.transactionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new BankingManagementSystem.ABMSDataSet5TableAdapters.TransactionsTableAdapter();
            this.txnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankerSideBar1 = new BankingManagementSystem.BankerSideBar();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(58, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Transactions History";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 839);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(115, 174);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(314, 37);
            this.searchBox.TabIndex = 15;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
            // aBMSTransactions
            // 
            this.aBMSTransactions.DataSetName = "ABMSTransactions";
            this.aBMSTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource2
            // 
            this.transactionsBindingSource2.DataMember = "Transactions";
            this.transactionsBindingSource2.DataSource = this.aBMSClientTransactionsBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txnidDataGridViewTextBoxColumn,
            this.txnfromDataGridViewTextBoxColumn,
            this.txntoDataGridViewTextBoxColumn,
            this.txndateDataGridViewTextBoxColumn,
            this.txnamtDataGridViewTextBoxColumn,
            this.txntypeDataGridViewTextBoxColumn,
            this.lidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource3;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(66, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 500);
            this.dataGridView1.TabIndex = 20;
            // 
            // aBMSDataSet5
            // 
            this.aBMSDataSet5.DataSetName = "ABMSDataSet5";
            this.aBMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource3
            // 
            this.transactionsBindingSource3.DataMember = "Transactions";
            this.transactionsBindingSource3.DataSource = this.aBMSDataSet5;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // txnidDataGridViewTextBoxColumn
            // 
            this.txnidDataGridViewTextBoxColumn.DataPropertyName = "txn_id";
            this.txnidDataGridViewTextBoxColumn.HeaderText = "TXN ID";
            this.txnidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnidDataGridViewTextBoxColumn.Name = "txnidDataGridViewTextBoxColumn";
            this.txnidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txnfromDataGridViewTextBoxColumn
            // 
            this.txnfromDataGridViewTextBoxColumn.DataPropertyName = "txn_from";
            this.txnfromDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.txnfromDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnfromDataGridViewTextBoxColumn.Name = "txnfromDataGridViewTextBoxColumn";
            // 
            // txntoDataGridViewTextBoxColumn
            // 
            this.txntoDataGridViewTextBoxColumn.DataPropertyName = "txn_to";
            this.txntoDataGridViewTextBoxColumn.HeaderText = "Receiver";
            this.txntoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txntoDataGridViewTextBoxColumn.Name = "txntoDataGridViewTextBoxColumn";
            // 
            // txndateDataGridViewTextBoxColumn
            // 
            this.txndateDataGridViewTextBoxColumn.DataPropertyName = "txn_date";
            this.txndateDataGridViewTextBoxColumn.HeaderText = "Date of Transaction";
            this.txndateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txndateDataGridViewTextBoxColumn.Name = "txndateDataGridViewTextBoxColumn";
            // 
            // txnamtDataGridViewTextBoxColumn
            // 
            this.txnamtDataGridViewTextBoxColumn.DataPropertyName = "txn_amt";
            this.txnamtDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.txnamtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnamtDataGridViewTextBoxColumn.Name = "txnamtDataGridViewTextBoxColumn";
            // 
            // txntypeDataGridViewTextBoxColumn
            // 
            this.txntypeDataGridViewTextBoxColumn.DataPropertyName = "txn_type";
            this.txntypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.txntypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txntypeDataGridViewTextBoxColumn.Name = "txntypeDataGridViewTextBoxColumn";
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "SLID";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            // 
            // bankerSideBar1
            // 
            this.bankerSideBar1.AC_NO = null;
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
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).EndInit();
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
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private ABMSClientTransactionsTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ABMSTransactions aBMSTransactions;
        private System.Windows.Forms.BindingSource transactionsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABMSDataSet5 aBMSDataSet5;
        private System.Windows.Forms.BindingSource transactionsBindingSource3;
        private ABMSDataSet5TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
    }
}