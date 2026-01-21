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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.companyServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSCompanyServices = new BankingManagementSystem.ABMSCompanyServices();
            this.companyServicesTableAdapter = new BankingManagementSystem.ABMSCompanyServicesTableAdapters.CompanyServicesTableAdapter();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCurrBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNewBal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblCurrBal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(173, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 756);
            this.panel1.TabIndex = 1;
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
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBal.Location = new System.Drawing.Point(1026, 344);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(67, 27);
            this.lblNewBal.TabIndex = 33;
            this.lblNewBal.Text = "label9";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1029, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 22);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "label8";
            // 
            // lblCurrBal
            // 
            this.lblCurrBal.AutoSize = true;
            this.lblCurrBal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrBal.Location = new System.Drawing.Point(1030, 247);
            this.lblCurrBal.Name = "lblCurrBal";
            this.lblCurrBal.Size = new System.Drawing.Size(55, 22);
            this.lblCurrBal.TabIndex = 30;
            this.lblCurrBal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(913, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "Current \r\nBalance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 8F);
            this.label7.Location = new System.Drawing.Point(913, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Net Total\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "New Balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(914, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 51);
            this.button1.TabIndex = 36;
            this.button1.Text = "MAKE PAYMENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(906, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "_____________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 44);
            this.label15.TabIndex = 46;
            this.label15.Text = "Bill Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(67, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "Service Catalogue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(909, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Payment Details";
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
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.spriceDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyServicesBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(72, 220);
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
            this.dataGridView1.Size = new System.Drawing.Size(772, 453);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Service";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // spriceDataGridViewTextBoxColumn
            // 
            this.spriceDataGridViewTextBoxColumn.DataPropertyName = "s_price";
            this.spriceDataGridViewTextBoxColumn.HeaderText = "Monthly Bill";
            this.spriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spriceDataGridViewTextBoxColumn.Name = "spriceDataGridViewTextBoxColumn";
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // BuyService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "BuyService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyService";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.Panel panel1;
        private ABMSCompanyServices aBMSCompanyServices;
        private System.Windows.Forms.BindingSource companyServicesBindingSource;
        private ABMSCompanyServicesTableAdapters.CompanyServicesTableAdapter companyServicesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewBal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurrBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}