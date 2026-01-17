namespace BankingManagementSystem
{
    partial class DepositWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDepostAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much would you like to deposit?";
            // 
            // tboxDepostAmt
            // 
            this.tboxDepostAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDepostAmt.Location = new System.Drawing.Point(145, 119);
            this.tboxDepostAmt.Name = "tboxDepostAmt";
            this.tboxDepostAmt.Size = new System.Drawing.Size(167, 19);
            this.tboxDepostAmt.TabIndex = 1;
            this.tboxDepostAmt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(143, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "__________________";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(165, 179);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 45);
            this.button11.TabIndex = 3;
            this.button11.Text = "DEPOSIT";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // DepositWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(449, 275);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.tboxDepostAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepositWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDepostAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
    }
}