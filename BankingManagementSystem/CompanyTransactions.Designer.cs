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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allct = new System.Windows.Forms.Label();
            this.bck1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // allct
            // 
            this.allct.AutoSize = true;
            this.allct.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allct.Location = new System.Drawing.Point(240, 52);
            this.allct.Name = "allct";
            this.allct.Size = new System.Drawing.Size(388, 39);
            this.allct.TabIndex = 1;
            this.allct.Text = "All Company Transactions";
            // 
            // bck1
            // 
            this.bck1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck1.Location = new System.Drawing.Point(373, 457);
            this.bck1.Name = "bck1";
            this.bck1.Size = new System.Drawing.Size(134, 31);
            this.bck1.TabIndex = 2;
            this.bck1.Text = "Back";
            this.bck1.UseVisualStyleBackColor = true;
            this.bck1.Click += new System.EventHandler(this.bck1_Click);
            // 
            // CompanyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.bck1);
            this.Controls.Add(this.allct);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CompanyTransactions";
            this.Text = "CompanyTransactions1";
            this.Load += new System.EventHandler(this.CompanyTransactions1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label allct;
        private System.Windows.Forms.Button bck1;
    }
}