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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBMSClientTransactions = new BankingManagementSystem.ABMSClientTransactions();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new BankingManagementSystem.ABMSClientTransactionsTableAdapters.TransactionsTableAdapter();
            this.txnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
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
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(75, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(25, 20, 25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 621);
            this.panel3.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(871, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aBMSClientTransactions
            // 
            this.aBMSClientTransactions.DataSetName = "ABMSClientTransactions";
            this.aBMSClientTransactions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.aBMSClientTransactions;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // txnidDataGridViewTextBoxColumn
            // 
            this.txnidDataGridViewTextBoxColumn.DataPropertyName = "txn_id";
            this.txnidDataGridViewTextBoxColumn.HeaderText = "txn_id";
            this.txnidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnidDataGridViewTextBoxColumn.Name = "txnidDataGridViewTextBoxColumn";
            this.txnidDataGridViewTextBoxColumn.ReadOnly = true;
            this.txnidDataGridViewTextBoxColumn.Width = 150;
            // 
            // txnfromDataGridViewTextBoxColumn
            // 
            this.txnfromDataGridViewTextBoxColumn.DataPropertyName = "txn_from";
            this.txnfromDataGridViewTextBoxColumn.HeaderText = "txn_from";
            this.txnfromDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnfromDataGridViewTextBoxColumn.Name = "txnfromDataGridViewTextBoxColumn";
            this.txnfromDataGridViewTextBoxColumn.Width = 150;
            // 
            // txntoDataGridViewTextBoxColumn
            // 
            this.txntoDataGridViewTextBoxColumn.DataPropertyName = "txn_to";
            this.txntoDataGridViewTextBoxColumn.HeaderText = "txn_to";
            this.txntoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txntoDataGridViewTextBoxColumn.Name = "txntoDataGridViewTextBoxColumn";
            this.txntoDataGridViewTextBoxColumn.Width = 150;
            // 
            // txndateDataGridViewTextBoxColumn
            // 
            this.txndateDataGridViewTextBoxColumn.DataPropertyName = "txn_date";
            this.txndateDataGridViewTextBoxColumn.HeaderText = "txn_date";
            this.txndateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txndateDataGridViewTextBoxColumn.Name = "txndateDataGridViewTextBoxColumn";
            this.txndateDataGridViewTextBoxColumn.Width = 150;
            // 
            // txnamtDataGridViewTextBoxColumn
            // 
            this.txnamtDataGridViewTextBoxColumn.DataPropertyName = "txn_amt";
            this.txnamtDataGridViewTextBoxColumn.HeaderText = "txn_amt";
            this.txnamtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnamtDataGridViewTextBoxColumn.Name = "txnamtDataGridViewTextBoxColumn";
            this.txnamtDataGridViewTextBoxColumn.Width = 150;
            // 
            // txntypeDataGridViewTextBoxColumn
            // 
            this.txntypeDataGridViewTextBoxColumn.DataPropertyName = "txn_type";
            this.txntypeDataGridViewTextBoxColumn.HeaderText = "txn_type";
            this.txntypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txntypeDataGridViewTextBoxColumn.Name = "txntypeDataGridViewTextBoxColumn";
            this.txntypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "l_id";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            this.lidDataGridViewTextBoxColumn.Width = 150;
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSClientTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABMSClientTransactions aBMSClientTransactions;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private ABMSClientTransactionsTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
    }
}