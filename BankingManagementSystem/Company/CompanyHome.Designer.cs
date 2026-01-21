namespace BankingManagementSystem
{
    partial class CompanyHome
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
            this.service = new System.Windows.Forms.Button();
            this.trns1 = new System.Windows.Forms.Button();
            this.lgout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNoOfSales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aBMSDataSet6 = new BankingManagementSystem.ABMSDataSet6();
            this.topCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topCustomersTableAdapter = new BankingManagementSystem.ABMSDataSet6TableAdapters.TopCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(47, 374);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(31, 121);
            this.service.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(138, 54);
            this.service.TabIndex = 2;
            this.service.Text = "service ";
            this.service.UseVisualStyleBackColor = true;
            this.service.Click += new System.EventHandler(this.button2_Click);
            // 
            // trns1
            // 
            this.trns1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trns1.Location = new System.Drawing.Point(31, 42);
            this.trns1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trns1.Name = "trns1";
            this.trns1.Size = new System.Drawing.Size(138, 65);
            this.trns1.TabIndex = 3;
            this.trns1.Text = "sales";
            this.trns1.UseVisualStyleBackColor = true;
            this.trns1.Click += new System.EventHandler(this.trns1_Click);
            // 
            // lgout
            // 
            this.lgout.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgout.Location = new System.Drawing.Point(31, 525);
            this.lgout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lgout.Name = "lgout";
            this.lgout.Size = new System.Drawing.Size(138, 66);
            this.lgout.TabIndex = 4;
            this.lgout.Text = "Logout";
            this.lgout.UseVisualStyleBackColor = true;
            this.lgout.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lgout);
            this.panel1.Controls.Add(this.service);
            this.panel1.Controls.Add(this.trns1);
            this.panel1.Location = new System.Drawing.Point(42, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 637);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "profile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(278, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 637);
            this.panel4.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(457, 374);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 228);
            this.dataGridView2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Top Services";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Top Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Summary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.lblMonthlyRevenue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(47, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 214);
            this.panel2.TabIndex = 11;
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.AutoSize = true;
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyRevenue.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(19, 53);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(267, 58);
            this.lblMonthlyRevenue.TabIndex = 13;
            this.lblMonthlyRevenue.Text = "$8,000,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monthly Revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.panel3.Controls.Add(this.lblNoOfSales);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(457, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 214);
            this.panel3.TabIndex = 9;
            // 
            // lblNoOfSales
            // 
            this.lblNoOfSales.AutoSize = true;
            this.lblNoOfSales.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSales.ForeColor = System.Drawing.Color.White;
            this.lblNoOfSales.Location = new System.Drawing.Point(12, 54);
            this.lblNoOfSales.Name = "lblNoOfSales";
            this.lblNoOfSales.Size = new System.Drawing.Size(133, 58);
            this.lblNoOfSales.TabIndex = 14;
            this.lblNoOfSales.Text = "3000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "No. of Monthly Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(406, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Company Home Dashboard";
            // 
            // aBMSDataSet6
            // 
            this.aBMSDataSet6.DataSetName = "ABMSDataSet6";
            this.aBMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topCustomersBindingSource
            // 
            this.topCustomersBindingSource.DataMember = "TopCustomers";
            this.topCustomersBindingSource.DataSource = this.aBMSDataSet6;
            // 
            // topCustomersTableAdapter
            // 
            this.topCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 794);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Home";
            this.Load += new System.EventHandler(this.CompanyHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button service;
        private System.Windows.Forms.Button trns1;
        private System.Windows.Forms.Button lgout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.Label lblNoOfSales;
        private System.Windows.Forms.Label label8;
        private ABMSDataSet6 aBMSDataSet6;
        private System.Windows.Forms.BindingSource topCustomersBindingSource;
        private ABMSDataSet6TableAdapters.TopCustomersTableAdapter topCustomersTableAdapter;
    }
}