namespace BankingManagementSystem
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxAC = new System.Windows.Forms.TextBox();
            this.pnlBlueBG = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblMessageLogIn = new System.Windows.Forms.Label();
            this.btnForget = new System.Windows.Forms.Button();
            this.lblEmptyAC = new System.Windows.Forms.Label();
            this.lblEmptyPass = new System.Windows.Forms.Label();
            this.lblACNO = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlBlueBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(196, 657);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 55);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxAC
            // 
            this.tboxAC.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAC.Location = new System.Drawing.Point(86, 420);
            this.tboxAC.Name = "tboxAC";
            this.tboxAC.Size = new System.Drawing.Size(357, 23);
            this.tboxAC.TabIndex = 1;
            this.tboxAC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlBlueBG
            // 
            this.pnlBlueBG.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBlueBG.Controls.Add(this.lblTitle);
            this.pnlBlueBG.Controls.Add(this.pnlLogo);
            this.pnlBlueBG.Location = new System.Drawing.Point(0, -1);
            this.pnlBlueBG.Name = "pnlBlueBG";
            this.pnlBlueBG.Size = new System.Drawing.Size(519, 212);
            this.pnlBlueBG.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(226, 136);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ABMS";
            this.lblTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::BankingManagementSystem.Properties.Resources.attachment_97757090__1__removebg_preview;
            this.pnlLogo.Location = new System.Drawing.Point(217, 40);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(100, 100);
            this.pnlLogo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(83, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "_______________________________________";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tboxPass
            // 
            this.tboxPass.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPass.Location = new System.Drawing.Point(90, 527);
            this.tboxPass.Name = "tboxPass";
            this.tboxPass.PasswordChar = '*';
            this.tboxPass.Size = new System.Drawing.Size(353, 23);
            this.tboxPass.TabIndex = 9;
            this.tboxPass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(86, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "_______________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Don\'t have an account? ";
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(317, 714);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(66, 27);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblMessageLogIn
            // 
            this.lblMessageLogIn.AutoSize = true;
            this.lblMessageLogIn.BackColor = System.Drawing.Color.AliceBlue;
            this.lblMessageLogIn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblMessageLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessageLogIn.Location = new System.Drawing.Point(83, 268);
            this.lblMessageLogIn.Name = "lblMessageLogIn";
            this.lblMessageLogIn.Size = new System.Drawing.Size(353, 38);
            this.lblMessageLogIn.TabIndex = 13;
            this.lblMessageLogIn.Text = "Login to your account";
            // 
            // btnForget
            // 
            this.btnForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForget.FlatAppearance.BorderSize = 0;
            this.btnForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForget.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnForget.Location = new System.Drawing.Point(304, 559);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(139, 27);
            this.btnForget.TabIndex = 14;
            this.btnForget.Text = "Forgot password?";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEmptyAC
            // 
            this.lblEmptyAC.AutoSize = true;
            this.lblEmptyAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyAC.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyAC.Location = new System.Drawing.Point(86, 447);
            this.lblEmptyAC.Name = "lblEmptyAC";
            this.lblEmptyAC.Size = new System.Drawing.Size(0, 17);
            this.lblEmptyAC.TabIndex = 16;
            this.lblEmptyAC.Click += new System.EventHandler(this.lblEmptyAC_Click);
            // 
            // lblEmptyPass
            // 
            this.lblEmptyPass.AutoSize = true;
            this.lblEmptyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyPass.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyPass.Location = new System.Drawing.Point(89, 559);
            this.lblEmptyPass.Name = "lblEmptyPass";
            this.lblEmptyPass.Size = new System.Drawing.Size(0, 17);
            this.lblEmptyPass.TabIndex = 17;
            this.lblEmptyPass.Click += new System.EventHandler(this.lblEmptyPass_Click);
            // 
            // lblACNO
            // 
            this.lblACNO.AutoSize = true;
            this.lblACNO.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACNO.Location = new System.Drawing.Point(81, 379);
            this.lblACNO.Name = "lblACNO";
            this.lblACNO.Size = new System.Drawing.Size(98, 25);
            this.lblACNO.TabIndex = 3;
            this.lblACNO.Text = "A/C NO";
            this.lblACNO.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(83, 489);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(114, 25);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(514, 808);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblACNO);
            this.Controls.Add(this.lblEmptyPass);
            this.Controls.Add(this.lblEmptyAC);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.lblMessageLogIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlBlueBG);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlBlueBG.ResumeLayout(false);
            this.pnlBlueBG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tboxAC;
        private System.Windows.Forms.Panel pnlBlueBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tboxPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblMessageLogIn;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblEmptyAC;
        private System.Windows.Forms.Label lblEmptyPass;
        private System.Windows.Forms.Label lblACNO;
        private System.Windows.Forms.Label lblPass;
    }
}