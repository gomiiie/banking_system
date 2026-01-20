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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sls = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.Button();
            this.trns1 = new System.Windows.Forms.Button();
            this.lgout = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sls
            // 
            this.sls.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sls.Location = new System.Drawing.Point(59, 57);
            this.sls.Name = "sls";
            this.sls.Size = new System.Drawing.Size(110, 50);
            this.sls.TabIndex = 1;
            this.sls.Text = "sales";
            this.sls.UseVisualStyleBackColor = true;
            this.sls.Click += new System.EventHandler(this.sls_Click);
            // 
            // service
            // 
            this.service.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(59, 126);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(110, 52);
            this.service.TabIndex = 2;
            this.service.Text = "service ";
            this.service.UseVisualStyleBackColor = true;
            this.service.Click += new System.EventHandler(this.button2_Click);
            // 
            // trns1
            // 
            this.trns1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trns1.Location = new System.Drawing.Point(59, 198);
            this.trns1.Name = "trns1";
            this.trns1.Size = new System.Drawing.Size(110, 52);
            this.trns1.TabIndex = 3;
            this.trns1.Text = "transaction";
            this.trns1.UseVisualStyleBackColor = true;
            this.trns1.Click += new System.EventHandler(this.trns1_Click);
            // 
            // lgout
            // 
            this.lgout.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgout.Location = new System.Drawing.Point(59, 351);
            this.lgout.Name = "lgout";
            this.lgout.Size = new System.Drawing.Size(110, 53);
            this.lgout.TabIndex = 4;
            this.lgout.Text = "Logout";
            this.lgout.UseVisualStyleBackColor = true;
            this.lgout.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(217, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // CompanyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lgout);
            this.Controls.Add(this.trns1);
            this.Controls.Add(this.service);
            this.Controls.Add(this.sls);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompanyHome";
            this.Text = "CompanyTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sls;
        private System.Windows.Forms.Button service;
        private System.Windows.Forms.Button trns1;
        private System.Windows.Forms.Button lgout;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}