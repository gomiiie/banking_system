namespace BankingManagementSystem
{
    partial class MobileRecharge
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tboxNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOperator = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransfer.Location = new System.Drawing.Point(164, 220);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(118, 45);
            this.btnTransfer.TabIndex = 25;
            this.btnTransfer.Text = "RECHARGE";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tboxNum
            // 
            this.tboxNum.BackColor = System.Drawing.Color.LightCyan;
            this.tboxNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNum.Location = new System.Drawing.Point(204, 45);
            this.tboxNum.Name = "tboxNum";
            this.tboxNum.Size = new System.Drawing.Size(167, 19);
            this.tboxNum.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(202, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter Amount";
            // 
            // tboxAmt
            // 
            this.tboxAmt.BackColor = System.Drawing.Color.LightCyan;
            this.tboxAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAmt.Location = new System.Drawing.Point(202, 98);
            this.tboxAmt.Name = "tboxAmt";
            this.tboxAmt.Size = new System.Drawing.Size(167, 19);
            this.tboxAmt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(203, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "__________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Number";
            // 
            // listOperator
            // 
            this.listOperator.BackColor = System.Drawing.Color.LightCyan;
            this.listOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOperator.FormattingEnabled = true;
            this.listOperator.ItemHeight = 20;
            this.listOperator.Items.AddRange(new object[] {
            "TeleTalk",
            "Grameenphone",
            "Banglalink",
            "Airtel"});
            this.listOperator.Location = new System.Drawing.Point(211, 161);
            this.listOperator.Name = "listOperator";
            this.listOperator.Size = new System.Drawing.Size(183, 20);
            this.listOperator.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(201, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "__________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Enter Operator";
            // 
            // MobileRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listOperator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.tboxNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MobileRecharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobileRecharge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox tboxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}