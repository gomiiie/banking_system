namespace BankingManagementSystem
{
    partial class BankerLoanAdd
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
            this.tboxDur = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxIR = new System.Windows.Forms.RichTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tboxName = new System.Windows.Forms.RichTextBox();
            this.tboxDescription = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxDur
            // 
            this.tboxDur.BackColor = System.Drawing.Color.White;
            this.tboxDur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDur.Location = new System.Drawing.Point(210, 178);
            this.tboxDur.Name = "tboxDur";
            this.tboxDur.Size = new System.Drawing.Size(227, 33);
            this.tboxDur.TabIndex = 56;
            this.tboxDur.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Duration";
            // 
            // tboxIR
            // 
            this.tboxIR.BackColor = System.Drawing.Color.White;
            this.tboxIR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxIR.Location = new System.Drawing.Point(219, 119);
            this.tboxIR.Name = "tboxIR";
            this.tboxIR.Size = new System.Drawing.Size(227, 33);
            this.tboxIR.TabIndex = 54;
            this.tboxIR.Text = "";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Archived"});
            this.cbStatus.Location = new System.Drawing.Point(214, 233);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(227, 28);
            this.cbStatus.TabIndex = 53;
            // 
            // tboxName
            // 
            this.tboxName.BackColor = System.Drawing.Color.White;
            this.tboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxName.Location = new System.Drawing.Point(219, 61);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(227, 33);
            this.tboxName.TabIndex = 52;
            this.tboxName.Text = "";
            // 
            // tboxDescription
            // 
            this.tboxDescription.BackColor = System.Drawing.Color.White;
            this.tboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxDescription.Location = new System.Drawing.Point(214, 297);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(227, 96);
            this.tboxDescription.TabIndex = 51;
            this.tboxDescription.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Interest Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(207)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(214, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 55);
            this.button3.TabIndex = 57;
            this.button3.Text = "Add New Loan";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(215, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "_________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(215, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "_________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(215, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "_________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(216, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "_________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(214, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "_________________________";
            // 
            // BankerLoanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 534);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxIR);
            this.Controls.Add(this.tboxDur);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "BankerLoanAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankerLoanAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tboxDur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tboxIR;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RichTextBox tboxName;
        private System.Windows.Forms.RichTextBox tboxDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}