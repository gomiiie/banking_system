namespace BankingManagementSystem
{
    partial class ClientTransactions
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSClientTransactions = new BankingManagementSystem.ABMSClientTransactions();
            this.transactionsTableAdapter = new BankingManagementSystem.ABMSClientTransactionsTableAdapters.TransactionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1026, 756);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.aBMSClientTransactions;
            // 
            // aBMSClientTransactions
            // 
            this.aBMSClientTransactions.DataSetName = "ABMSClientTransactions";
            this.aBMSClientTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "All Transactions History";
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
            this.txnidDataGridViewTextBoxColumn,
            this.txnfromDataGridViewTextBoxColumn,
            this.txntoDataGridViewTextBoxColumn,
            this.txndateDataGridViewTextBoxColumn,
            this.txnamtDataGridViewTextBoxColumn,
            this.txntypeDataGridViewTextBoxColumn,
            this.lidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(53, 137);
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
            this.dataGridView1.Size = new System.Drawing.Size(910, 527);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(53, 717);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "© 2026, Group 8, C# (X), AIUB, Dhaka, Bangladesh";
            // 
            // clientSideBar1
            // 
            this.clientSideBar1.CurrAcc = null;
            this.clientSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientSideBar1.Location = new System.Drawing.Point(0, 0);
            this.clientSideBar1.Name = "clientSideBar1";
            this.clientSideBar1.Size = new System.Drawing.Size(177, 756);
            this.clientSideBar1.TabIndex = 8;
            // 
            // ClientTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "ClientTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientTransactions";
            this.Load += new System.EventHandler(this.ClientTransactions_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ClientSideBar clientSideBar1;
        private ABMSClientTransactions aBMSClientTransactions;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private ABMSClientTransactionsTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}