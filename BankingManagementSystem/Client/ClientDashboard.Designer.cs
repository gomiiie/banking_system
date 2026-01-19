namespace BankingManagementSystem
{
    partial class ClientDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.btnBuyServ = new System.Windows.Forms.Button();
            this.btnTakeLoan = new System.Windows.Forms.Button();
            this.btnMobileRecharge = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.btnSendMoney);
            this.flowLayoutPanel2.Controls.Add(this.btnBuyServ);
            this.flowLayoutPanel2.Controls.Add(this.btnTakeLoan);
            this.flowLayoutPanel2.Controls.Add(this.btnMobileRecharge);
            this.flowLayoutPanel2.Controls.Add(this.btnNotifications);
            this.flowLayoutPanel2.Controls.Add(this.btnReview);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(178, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1026, 764);
            this.flowLayoutPanel2.TabIndex = 8;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.lblBalance);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(75, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 239);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(223, 148);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(126, 62);
            this.button12.TabIndex = 3;
            this.button12.Text = "WITHDRAW";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(53, 148);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 62);
            this.button11.TabIndex = 2;
            this.button11.Text = "DEPOSIT";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(152, 92);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(31, 33);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Balance";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Location = new System.Drawing.Point(545, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(40, 25, 25, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 239);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Azure;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Azure;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Azure;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 233);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // btnSendMoney
            // 
            this.btnSendMoney.FlatAppearance.BorderSize = 0;
            this.btnSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMoney.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMoney.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendMoney.Location = new System.Drawing.Point(175, 399);
            this.btnSendMoney.Margin = new System.Windows.Forms.Padding(125, 60, 60, 60);
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(144, 96);
            this.btnSendMoney.TabIndex = 4;
            this.btnSendMoney.Text = "\r\n\r\n\r\nSend Money";
            this.btnSendMoney.UseVisualStyleBackColor = true;
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);
            // 
            // btnBuyServ
            // 
            this.btnBuyServ.FlatAppearance.BorderSize = 0;
            this.btnBuyServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyServ.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyServ.Location = new System.Drawing.Point(439, 399);
            this.btnBuyServ.Margin = new System.Windows.Forms.Padding(60);
            this.btnBuyServ.Name = "btnBuyServ";
            this.btnBuyServ.Size = new System.Drawing.Size(144, 96);
            this.btnBuyServ.TabIndex = 3;
            this.btnBuyServ.Text = "\r\n\r\n\r\nBuy Service\r\n";
            this.btnBuyServ.UseVisualStyleBackColor = true;
            this.btnBuyServ.Click += new System.EventHandler(this.btnBuyServ_Click);
            // 
            // btnTakeLoan
            // 
            this.btnTakeLoan.FlatAppearance.BorderSize = 0;
            this.btnTakeLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeLoan.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeLoan.Location = new System.Drawing.Point(703, 399);
            this.btnTakeLoan.Margin = new System.Windows.Forms.Padding(60);
            this.btnTakeLoan.Name = "btnTakeLoan";
            this.btnTakeLoan.Size = new System.Drawing.Size(144, 96);
            this.btnTakeLoan.TabIndex = 4;
            this.btnTakeLoan.Text = "\r\n\r\n\r\nTake Loan";
            this.btnTakeLoan.UseVisualStyleBackColor = true;
            this.btnTakeLoan.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnMobileRecharge
            // 
            this.btnMobileRecharge.FlatAppearance.BorderSize = 0;
            this.btnMobileRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobileRecharge.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobileRecharge.Location = new System.Drawing.Point(175, 565);
            this.btnMobileRecharge.Margin = new System.Windows.Forms.Padding(125, 10, 60, 60);
            this.btnMobileRecharge.Name = "btnMobileRecharge";
            this.btnMobileRecharge.Size = new System.Drawing.Size(144, 96);
            this.btnMobileRecharge.TabIndex = 5;
            this.btnMobileRecharge.Text = "\r\n\r\n\r\nMobile Recharge";
            this.btnMobileRecharge.UseVisualStyleBackColor = true;
            this.btnMobileRecharge.Click += new System.EventHandler(this.btnMobileRecharge_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Location = new System.Drawing.Point(439, 565);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(60, 10, 60, 60);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(144, 96);
            this.btnNotifications.TabIndex = 6;
            this.btnNotifications.Text = "\r\n\r\n\r\nNotifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // btnReview
            // 
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.Location = new System.Drawing.Point(703, 565);
            this.btnReview.Margin = new System.Windows.Forms.Padding(60, 10, 60, 60);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(144, 96);
            this.btnReview.TabIndex = 7;
            this.btnReview.Text = "\r\n\r\n\r\nLeave Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(175, 781);
            this.button1.Margin = new System.Windows.Forms.Padding(125, 60, 60, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 96);
            this.button1.TabIndex = 8;
            this.button1.Text = "\r\n\r\n\r\nSend Money";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clientSideBar1
            // 
            this.clientSideBar1.CurrAcc = null;
            this.clientSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientSideBar1.Location = new System.Drawing.Point(0, 0);
            this.clientSideBar1.Name = "clientSideBar1";
            this.clientSideBar1.Size = new System.Drawing.Size(177, 756);
            this.clientSideBar1.TabIndex = 9;
            this.clientSideBar1.Load += new System.EventHandler(this.clientSideBar1_Load);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDashboard";
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyServ;
        private System.Windows.Forms.Button btnTakeLoan;
        private System.Windows.Forms.Button btnMobileRecharge;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSendMoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private ClientSideBar clientSideBar1;
    }
}