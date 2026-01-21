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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loansTableAdapter = new BankingManagementSystem.ABMSDataSetTableAdapters.LoansTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dataGridView1);
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
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(61, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(25, 15, 25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 636);
            this.panel3.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, -9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(297, 44);
            this.label15.TabIndex = 45;
            this.label15.Text = "Loan Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Loan Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(807, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 29);
            this.label14.TabIndex = 43;
            this.label14.Text = "Payment Details";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            this.currbalDataGridViewTextBoxColumn,
            this.totalbalDataGridViewTextBoxColumn,
            this.lstatusDataGridViewTextBoxColumn,
            this.ldatetakenDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn,
            this.approvedbyDataGridViewTextBoxColumn,
            this.ltidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loansBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
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
            this.dataGridView1.Size = new System.Drawing.Size(772, 524);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "L ID";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            this.lidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currbalDataGridViewTextBoxColumn
            // 
            this.currbalDataGridViewTextBoxColumn.DataPropertyName = "curr_bal";
            this.currbalDataGridViewTextBoxColumn.HeaderText = "Amount Paid";
            this.currbalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currbalDataGridViewTextBoxColumn.Name = "currbalDataGridViewTextBoxColumn";
            // 
            // totalbalDataGridViewTextBoxColumn
            // 
            this.totalbalDataGridViewTextBoxColumn.DataPropertyName = "total_bal";
            this.totalbalDataGridViewTextBoxColumn.HeaderText = "Total Taken";
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
            this.ldatetakenDataGridViewTextBoxColumn.HeaderText = "Date Taken";
            this.ldatetakenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ldatetakenDataGridViewTextBoxColumn.Name = "ldatetakenDataGridViewTextBoxColumn";
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "Taken By";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            // 
            // approvedbyDataGridViewTextBoxColumn
            // 
            this.approvedbyDataGridViewTextBoxColumn.DataPropertyName = "approved_by";
            this.approvedbyDataGridViewTextBoxColumn.HeaderText = "Approved By";
            this.approvedbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.approvedbyDataGridViewTextBoxColumn.Name = "approvedbyDataGridViewTextBoxColumn";
            // 
            // ltidDataGridViewTextBoxColumn
            // 
            this.ltidDataGridViewTextBoxColumn.DataPropertyName = "lt_id";
            this.ltidDataGridViewTextBoxColumn.HeaderText = "LT ID";
            this.ltidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltidDataGridViewTextBoxColumn.Name = "ltidDataGridViewTextBoxColumn";
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
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBal.Location = new System.Drawing.Point(913, 413);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(67, 27);
            this.lblNewBal.TabIndex = 24;
            this.lblNewBal.Text = "label9";
            // 
            // lblRemDue
            // 
            this.lblRemDue.AutoSize = true;
            this.lblRemDue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemDue.Location = new System.Drawing.Point(914, 353);
            this.lblRemDue.Name = "lblRemDue";
            this.lblRemDue.Size = new System.Drawing.Size(55, 22);
            this.lblRemDue.TabIndex = 23;
            this.lblRemDue.Text = "label8";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblPayment.Location = new System.Drawing.Point(914, 314);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(55, 22);
            this.lblPayment.TabIndex = 22;
            this.lblPayment.Text = "label7";
            // 
            // lblCurrBal
            // 
            this.lblCurrBal.AutoSize = true;
            this.lblCurrBal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrBal.Location = new System.Drawing.Point(914, 263);
            this.lblCurrBal.Name = "lblCurrBal";
            this.lblCurrBal.Size = new System.Drawing.Size(55, 22);
            this.lblCurrBal.TabIndex = 21;
            this.lblCurrBal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(808, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 38);
            this.label5.TabIndex = 20;
            this.label5.Text = "Current \r\nBalance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 8F);
            this.label4.Location = new System.Drawing.Point(808, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 8F);
            this.label3.Location = new System.Drawing.Point(808, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Remaining \r\nDue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(808, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "New \r\nBalance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(809, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount to Pay";
            // 
            // tboxAmt
            // 
            this.tboxAmt.BackColor = System.Drawing.Color.Azure;
            this.tboxAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAmt.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAmt.Location = new System.Drawing.Point(812, 167);
            this.tboxAmt.Name = "tboxAmt";
            this.tboxAmt.Size = new System.Drawing.Size(164, 25);
            this.tboxAmt.TabIndex = 15;
            this.tboxAmt.Text = "0.00";
            this.tboxAmt.TextChanged += new System.EventHandler(this.tboxAmt_TextChanged);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(812, 582);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(194, 51);
            this.button11.TabIndex = 3;
            this.button11.Text = "MAKE PAYMENT";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(797, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "_____________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(808, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "__________________";
            // 
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 756);
            this.panel1.TabIndex = 27;
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
            // ClientLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "ClientLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientLoans";
            this.Load += new System.EventHandler(this.ClientLoans_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.Panel panel3;
        private ABMSDataSet aBMSDataSet;
        private System.Windows.Forms.BindingSource loansBindingSource;
        private ABMSDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currbalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldatetakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
    }
}