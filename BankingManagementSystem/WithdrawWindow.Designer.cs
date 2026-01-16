namespace BankingManagementSystem
{
    partial class WithdrawWindow
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
            this.button11 = new System.Windows.Forms.Button();
            this.tboxWithdrawAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxAgentNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(211, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 45);
            this.button11.TabIndex = 7;
            this.button11.Text = "WITHDRAW";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tboxWithdrawAmt
            // 
            this.tboxWithdrawAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxWithdrawAmt.Location = new System.Drawing.Point(297, 101);
            this.tboxWithdrawAmt.Name = "tboxWithdrawAmt";
            this.tboxWithdrawAmt.Size = new System.Drawing.Size(167, 19);
            this.tboxWithdrawAmt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(295, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "__________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Agent Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Withdraw Amount";
            // 
            // tboxAgentNum
            // 
            this.tboxAgentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAgentNum.Location = new System.Drawing.Point(299, 46);
            this.tboxAgentNum.Name = "tboxAgentNum";
            this.tboxAgentNum.Size = new System.Drawing.Size(167, 19);
            this.tboxAgentNum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(297, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "__________________";
            // 
            // WithdrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(520, 233);
            this.ControlBox = false;
            this.Controls.Add(this.tboxAgentNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.tboxWithdrawAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WithdrawWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawWindow";
            this.Load += new System.EventHandler(this.WithdrawWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox tboxWithdrawAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxAgentNum;
        private System.Windows.Forms.Label label4;
    }
}