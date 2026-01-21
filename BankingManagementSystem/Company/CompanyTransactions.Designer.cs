namespace BankingManagementSystem
{
    partial class CompanyTransactions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lgout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sls = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.Button();
            this.trns1 = new System.Windows.Forms.Button();
            //this.aBMSDataSet6 = new BankingManagementSystem.ABMSDataSet6();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.transactionsTableAdapter = new BankingManagementSystem.ABMSDataSet6TableAdapters.TransactionsTableAdapter();
            this.txnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txntypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet6)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(259, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // allct
            // 
            this.allct.AutoSize = true;
            this.allct.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allct.ForeColor = System.Drawing.Color.White;
            this.allct.Location = new System.Drawing.Point(476, 31);
            this.allct.Name = "allct";
            this.allct.Size = new System.Drawing.Size(494, 47);
            this.allct.TabIndex = 1;
            this.allct.Text = "All Company Transactions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lgout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sls);
            this.panel1.Controls.Add(this.service);
            this.panel1.Controls.Add(this.trns1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 642);
            this.panel1.TabIndex = 8;
            // 
            // lgout
            // 
            this.lgout.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgout.Location = new System.Drawing.Point(31, 524);
            this.lgout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lgout.Name = "lgout";
            this.lgout.Size = new System.Drawing.Size(124, 66);
            this.lgout.TabIndex = 4;
            this.lgout.Text = "Logout";
            this.lgout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.button1.Location = new System.Drawing.Point(31, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sls
            // 
            this.sls.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sls.Location = new System.Drawing.Point(31, 123);
            this.sls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sls.Name = "sls";
            this.sls.Size = new System.Drawing.Size(138, 59);
            this.sls.TabIndex = 1;
            this.sls.Text = "sales";
            this.sls.UseVisualStyleBackColor = true;
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(31, 202);
            this.service.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(138, 54);
            this.service.TabIndex = 2;
            this.service.Text = "service ";
            this.service.UseVisualStyleBackColor = true;
            // 
            // trns1
            // 
            this.trns1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trns1.Location = new System.Drawing.Point(31, 273);
            this.trns1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trns1.Name = "trns1";
            this.trns1.Size = new System.Drawing.Size(138, 65);
            this.trns1.TabIndex = 3;
            this.trns1.Text = "transaction";
            this.trns1.UseVisualStyleBackColor = true;
            // 
            // aBMSDataSet6
            // 
            //this.aBMSDataSet6.DataSetName = "ABMSDataSet6";
            //this.aBMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            //this.transactionsBindingSource.DataSource = this.aBMSDataSet6;
            // 
            // transactionsTableAdapter
            // 
            //this.transactionsTableAdapter.ClearBeforeFill = true;
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
            this.txnfromDataGridViewTextBoxColumn.HeaderText = "From";
            this.txnfromDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txnfromDataGridViewTextBoxColumn.Name = "txnfromDataGridViewTextBoxColumn";
            // 
            // txntoDataGridViewTextBoxColumn
            // 
            this.txntoDataGridViewTextBoxColumn.DataPropertyName = "txn_to";
            this.txntoDataGridViewTextBoxColumn.HeaderText = "To";
            this.txntoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.txntoDataGridViewTextBoxColumn.Name = "txntoDataGridViewTextBoxColumn";
            // 
            // txndateDataGridViewTextBoxColumn
            // 
            this.txndateDataGridViewTextBoxColumn.DataPropertyName = "txn_date";
            this.txndateDataGridViewTextBoxColumn.HeaderText = "Date";
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
            // CompanyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1175, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allct);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CompanyTransactions";
            this.Text = "CompanyTransactions1";
            this.Load += new System.EventHandler(this.CompanyTransactions1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label allct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lgout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sls;
        private System.Windows.Forms.Button service;
        private System.Windows.Forms.Button trns1;
        //private ABMSDataSet6 aBMSDataSet6;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        //private ABMSDataSet6TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txnamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txntypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
    }
}