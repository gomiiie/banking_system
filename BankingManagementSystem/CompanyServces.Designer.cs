namespace BankingManagementSystem
{
    partial class CompanyServces
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
            this.comser1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBMSCompanyServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSCompanyServices = new BankingManagementSystem.ABMSCompanyServices();
            this.back1 = new System.Windows.Forms.Button();
            //this.aBMSDataSet1 = new BankingManagementSystem.ABMSDataSet1();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.servicesTableAdapter = new BankingManagementSystem.ABMSDataSet1TableAdapters.ServicesTableAdapter();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.dspton = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.stts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comser1
            // 
            this.comser1.AutoSize = true;
            this.comser1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comser1.Location = new System.Drawing.Point(256, 40);
            this.comser1.Name = "comser1";
            this.comser1.Size = new System.Drawing.Size(272, 37);
            this.comser1.TabIndex = 0;
            this.comser1.Text = "Company Services";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.spriceDataGridViewTextBoxColumn,
            this.sdescriptionDataGridViewTextBoxColumn,
            this.sstatusDataGridViewTextBoxColumn,
            this.aCNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(147, 121);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // aBMSCompanyServicesBindingSource
            // 
            this.aBMSCompanyServicesBindingSource.DataSource = this.aBMSCompanyServices;
            this.aBMSCompanyServicesBindingSource.Position = 0;
            // 
            // aBMSCompanyServices
            // 
            this.aBMSCompanyServices.DataSetName = "ABMSCompanyServices";
            this.aBMSCompanyServices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back1
            // 
            this.back1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back1.Location = new System.Drawing.Point(376, 442);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(75, 23);
            this.back1.TabIndex = 2;
            this.back1.Text = "back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.addserv_Click);
            // 
            // aBMSDataSet1
            // 
            //this.aBMSDataSet1.DataSetName = "ABMSDataSet1";
            //this.aBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            //this.servicesBindingSource.DataSource = this.aBMSDataSet1;
            // 
            // servicesTableAdapter
            // 
            //this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "s_id";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Width = 61;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "s_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "s_name";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 84;
            // 
            // spriceDataGridViewTextBoxColumn
            // 
            this.spriceDataGridViewTextBoxColumn.DataPropertyName = "s_price";
            this.spriceDataGridViewTextBoxColumn.HeaderText = "s_price";
            this.spriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spriceDataGridViewTextBoxColumn.Name = "spriceDataGridViewTextBoxColumn";
            this.spriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // sdescriptionDataGridViewTextBoxColumn
            // 
            this.sdescriptionDataGridViewTextBoxColumn.DataPropertyName = "s_description";
            this.sdescriptionDataGridViewTextBoxColumn.HeaderText = "s_description";
            this.sdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdescriptionDataGridViewTextBoxColumn.Name = "sdescriptionDataGridViewTextBoxColumn";
            this.sdescriptionDataGridViewTextBoxColumn.Width = 116;
            // 
            // sstatusDataGridViewTextBoxColumn
            // 
            this.sstatusDataGridViewTextBoxColumn.DataPropertyName = "s_status";
            this.sstatusDataGridViewTextBoxColumn.HeaderText = "s_status";
            this.sstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sstatusDataGridViewTextBoxColumn.Name = "sstatusDataGridViewTextBoxColumn";
            this.sstatusDataGridViewTextBoxColumn.Width = 85;
            // 
            // aCNODataGridViewTextBoxColumn
            // 
            this.aCNODataGridViewTextBoxColumn.DataPropertyName = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.HeaderText = "AC_NO";
            this.aCNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCNODataGridViewTextBoxColumn.Name = "aCNODataGridViewTextBoxColumn";
            this.aCNODataGridViewTextBoxColumn.Width = 81;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(808, 217);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(88, 22);
            this.tboxName.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(808, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(731, 280);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(38, 16);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Price";
            // 
            // dspton
            // 
            this.dspton.AutoSize = true;
            this.dspton.Location = new System.Drawing.Point(725, 338);
            this.dspton.Name = "dspton";
            this.dspton.Size = new System.Drawing.Size(75, 16);
            this.dspton.TabIndex = 9;
            this.dspton.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(808, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(808, 396);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            // 
            // stts
            // 
            this.stts.AutoSize = true;
            this.stts.Location = new System.Drawing.Point(743, 399);
            this.stts.Name = "stts";
            this.stts.Size = new System.Drawing.Size(44, 16);
            this.stts.TabIndex = 12;
            this.stts.Text = "Status";
            // 
            // CompanyServces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 521);
            this.Controls.Add(this.stts);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dspton);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comser1);
            this.Name = "CompanyServces";
            this.Text = "CompanyServces";
            this.Load += new System.EventHandler(this.CompanyServces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSCompanyServices)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comser1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.BindingSource aBMSCompanyServicesBindingSource;
        private ABMSCompanyServices aBMSCompanyServices;
        //private ABMSDataSet1 aBMSDataSet1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        //private ABMSDataSet1TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label dspton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label stts;
    }
}