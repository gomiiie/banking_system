namespace BankingManagementSystem.Banker
{
    partial class BankerLoans
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
            this.allAccountDetailsTableAdapter = new BankingManagementSystem.ABMSDataSet2TableAdapters.AllAccountDetailsTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.RichTextBox();
            this.tboxDescription = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ltidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltinterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasteditbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet1 = new BankingManagementSystem.ABMSDataSet1();
            this.allAccountDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet2 = new BankingManagementSystem.ABMSDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tboxDur = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxIR = new System.Windows.Forms.RichTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblACNO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.loanTypesTableAdapter = new BankingManagementSystem.ABMSDataSet1TableAdapters.LoanTypesTableAdapter();
            this.bankerSideBar1 = new BankingManagementSystem.BankerSideBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAccountDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allAccountDetailsTableAdapter
            // 
            this.allAccountDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(63, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 29);
            this.label13.TabIndex = 41;
            this.label13.Text = "Loan Types";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(58, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(297, 44);
            this.label15.TabIndex = 40;
            this.label15.Text = "Loan Management";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(769, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Loan ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.button2.Location = new System.Drawing.Point(306, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 51);
            this.button2.TabIndex = 34;
            this.button2.Text = "View Pending Loans";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(770, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 29);
            this.label14.TabIndex = 42;
            this.label14.Text = "Loan Details";
            // 
            // tboxName
            // 
            this.tboxName.BackColor = System.Drawing.Color.White;
            this.tboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(866, 221);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(140, 33);
            this.tboxName.TabIndex = 31;
            this.tboxName.Text = "";
            // 
            // tboxDescription
            // 
            this.tboxDescription.BackColor = System.Drawing.Color.White;
            this.tboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescription.Location = new System.Drawing.Point(773, 591);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(227, 70);
            this.tboxDescription.TabIndex = 30;
            this.tboxDescription.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(773, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(773, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(770, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Interest Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(862, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ltidDataGridViewTextBoxColumn,
            this.ltnameDataGridViewTextBoxColumn,
            this.ltinterestDataGridViewTextBoxColumn,
            this.ltstatusDataGridViewTextBoxColumn,
            this.ltdateaddedDataGridViewTextBoxColumn,
            this.lasteditbyDataGridViewTextBoxColumn,
            this.ltdurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanTypesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(66, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(641, 484);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ltidDataGridViewTextBoxColumn
            // 
            this.ltidDataGridViewTextBoxColumn.DataPropertyName = "lt_id";
            this.ltidDataGridViewTextBoxColumn.HeaderText = "LT ID";
            this.ltidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltidDataGridViewTextBoxColumn.Name = "ltidDataGridViewTextBoxColumn";
            this.ltidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ltnameDataGridViewTextBoxColumn
            // 
            this.ltnameDataGridViewTextBoxColumn.DataPropertyName = "lt_name";
            this.ltnameDataGridViewTextBoxColumn.HeaderText = "Name";
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
            // ltstatusDataGridViewTextBoxColumn
            // 
            this.ltstatusDataGridViewTextBoxColumn.DataPropertyName = "lt_status";
            this.ltstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.ltstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltstatusDataGridViewTextBoxColumn.Name = "ltstatusDataGridViewTextBoxColumn";
            // 
            // ltdateaddedDataGridViewTextBoxColumn
            // 
            this.ltdateaddedDataGridViewTextBoxColumn.DataPropertyName = "lt_date_added";
            this.ltdateaddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.ltdateaddedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltdateaddedDataGridViewTextBoxColumn.Name = "ltdateaddedDataGridViewTextBoxColumn";
            // 
            // lasteditbyDataGridViewTextBoxColumn
            // 
            this.lasteditbyDataGridViewTextBoxColumn.DataPropertyName = "lastedit_by";
            this.lasteditbyDataGridViewTextBoxColumn.HeaderText = "Edit By";
            this.lasteditbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lasteditbyDataGridViewTextBoxColumn.Name = "lasteditbyDataGridViewTextBoxColumn";
            // 
            // ltdurationDataGridViewTextBoxColumn
            // 
            this.ltdurationDataGridViewTextBoxColumn.DataPropertyName = "lt_duration";
            this.ltdurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.ltdurationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltdurationDataGridViewTextBoxColumn.Name = "ltdurationDataGridViewTextBoxColumn";
            // 
            // loanTypesBindingSource
            // 
            this.loanTypesBindingSource.DataMember = "LoanTypes";
            this.loanTypesBindingSource.DataSource = this.aBMSDataSet1;
            // 
            // aBMSDataSet1
            // 
            this.aBMSDataSet1.DataSetName = "ABMSDataSet1";
            this.aBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allAccountDetailsBindingSource
            // 
            this.allAccountDetailsBindingSource.DataMember = "AllAccountDetails";
            this.allAccountDetailsBindingSource.DataSource = this.aBMSDataSet2;
            // 
            // aBMSDataSet2
            // 
            this.aBMSDataSet2.DataSetName = "ABMSDataSet2";
            this.aBMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(777, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update Loan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.Controls.Add(this.tboxName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tboxDur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxIR);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblACNO);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tboxDescription);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 839);
            this.panel1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(66, 692);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 51);
            this.button3.TabIndex = 47;
            this.button3.Text = "Add New Loan";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tboxDur
            // 
            this.tboxDur.BackColor = System.Drawing.Color.White;
            this.tboxDur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDur.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDur.Location = new System.Drawing.Point(774, 413);
            this.tboxDur.Name = "tboxDur";
            this.tboxDur.Size = new System.Drawing.Size(227, 33);
            this.tboxDur.TabIndex = 46;
            this.tboxDur.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Duration";
            // 
            // tboxIR
            // 
            this.tboxIR.BackColor = System.Drawing.Color.White;
            this.tboxIR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxIR.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxIR.Location = new System.Drawing.Point(774, 323);
            this.tboxIR.Name = "tboxIR";
            this.tboxIR.Size = new System.Drawing.Size(227, 33);
            this.tboxIR.TabIndex = 44;
            this.tboxIR.Text = "";
            this.tboxIR.TextChanged += new System.EventHandler(this.tboxIR_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Archived"});
            this.cbStatus.Location = new System.Drawing.Point(775, 501);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(141, 30);
            this.cbStatus.TabIndex = 43;
            // 
            // lblACNO
            // 
            this.lblACNO.AutoSize = true;
            this.lblACNO.Location = new System.Drawing.Point(769, 230);
            this.lblACNO.Name = "lblACNO";
            this.lblACNO.Size = new System.Drawing.Size(19, 22);
            this.lblACNO.TabIndex = 36;
            this.lblACNO.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(863, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "_______________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(771, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "_________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(773, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 22);
            this.label8.TabIndex = 67;
            this.label8.Text = "_________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(772, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 22);
            this.label12.TabIndex = 68;
            this.label12.Text = "______________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label16.Location = new System.Drawing.Point(772, 650);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(235, 22);
            this.label16.TabIndex = 69;
            this.label16.Text = "_________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(769, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 64;
            this.label11.Text = "______";
            // 
            // loanTypesTableAdapter
            // 
            this.loanTypesTableAdapter.ClearBeforeFill = true;
            // 
            // bankerSideBar1
            // 
            this.bankerSideBar1.AC_NO = null;
            this.bankerSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bankerSideBar1.Location = new System.Drawing.Point(0, 0);
            this.bankerSideBar1.Name = "bankerSideBar1";
            this.bankerSideBar1.Size = new System.Drawing.Size(173, 839);
            this.bankerSideBar1.TabIndex = 21;
            // 
            // BankerLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 839);
            this.Controls.Add(this.bankerSideBar1);
            this.Controls.Add(this.panel1);
            this.Name = "BankerLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankerLoans";
            this.Load += new System.EventHandler(this.BankerLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAccountDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ABMSDataSet2TableAdapters.AllAccountDetailsTableAdapter allAccountDetailsTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox tboxName;
        private System.Windows.Forms.RichTextBox tboxDescription;
        private BankerSideBar bankerSideBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource allAccountDetailsBindingSource;
        private ABMSDataSet2 aBMSDataSet2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblACNO;
        private System.Windows.Forms.RichTextBox tboxIR;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RichTextBox tboxDur;
        private System.Windows.Forms.Label label1;
        private ABMSDataSet1 aBMSDataSet1;
        private System.Windows.Forms.BindingSource loanTypesBindingSource;
        private ABMSDataSet1TableAdapters.LoanTypesTableAdapter loanTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltinterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasteditbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
    }
}