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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.lblRemDue = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblCurrBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxAmt = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldatetakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet = new BankingManagementSystem.ABMSDataSet();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.loansTableAdapter = new BankingManagementSystem.ABMSDataSetTableAdapters.LoansTableAdapter();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).BeginInit();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblNewBal);
            this.panel3.Controls.Add(this.lblRemDue);
            this.panel3.Controls.Add(this.lblPayment);
            this.panel3.Controls.Add(this.lblCurrBal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxAmt);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(75, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(25, 15, 25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 623);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "_____________________";
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Location = new System.Drawing.Point(793, 353);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(51, 20);
            this.lblNewBal.TabIndex = 24;
            this.lblNewBal.Text = "label9";
            // 
            // lblRemDue
            // 
            this.lblRemDue.AutoSize = true;
            this.lblRemDue.Location = new System.Drawing.Point(793, 294);
            this.lblRemDue.Name = "lblRemDue";
            this.lblRemDue.Size = new System.Drawing.Size(51, 20);
            this.lblRemDue.TabIndex = 23;
            this.lblRemDue.Text = "label8";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(793, 244);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(51, 20);
            this.lblPayment.TabIndex = 22;
            this.lblPayment.Text = "label7";
            // 
            // lblCurrBal
            // 
            this.lblCurrBal.AutoSize = true;
            this.lblCurrBal.Location = new System.Drawing.Point(793, 204);
            this.lblCurrBal.Name = "lblCurrBal";
            this.lblCurrBal.Size = new System.Drawing.Size(51, 20);
            this.lblCurrBal.TabIndex = 21;
            this.lblCurrBal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Current \r\nBalance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "Remaining \r\nDue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "New \r\nBalance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount";
            // 
            // tboxAmt
            // 
            this.tboxAmt.Location = new System.Drawing.Point(753, 84);
            this.tboxAmt.Name = "tboxAmt";
            this.tboxAmt.Size = new System.Drawing.Size(100, 26);
            this.tboxAmt.TabIndex = 15;
            this.tboxAmt.Text = "0.00";
            this.tboxAmt.TextChanged += new System.EventHandler(this.tboxAmt_TextChanged);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(726, 452);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 62);
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
            // loansBindingSource
            // 
            this.loansBindingSource.DataMember = "Loans";
            this.loansBindingSource.DataSource = this.aBMSDataSet;
            // 
            // aBMSDataSet
            // 
            this.aBMSDataSet.DataSetName = "ABMSDataSet";
            this.aBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
            // 
            // ClientLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "ClientLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientLoans";
            this.Load += new System.EventHandler(this.ClientLoans_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).EndInit();
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
        private System.Windows.Forms.Label lblNewBal;
        private System.Windows.Forms.Label lblRemDue;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblCurrBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxAmt;
        private System.Windows.Forms.Label label8;
    }
}