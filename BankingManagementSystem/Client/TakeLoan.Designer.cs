namespace BankingManagementSystem
{
    partial class TakeLoan
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
            this.clientSideBar1 = new BankingManagementSystem.ClientSideBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBMSLoanTypes = new BankingManagementSystem.ABMSLoanTypes();
            this.loanTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTypesTableAdapter = new BankingManagementSystem.ABMSLoanTypesTableAdapters.LoanTypesTableAdapter();
            this.ltidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltinterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasteditbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSLoanTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientSideBar1
            // 
            this.clientSideBar1.CurrAcc = null;
            this.clientSideBar1.Location = new System.Drawing.Point(0, 0);
            this.clientSideBar1.Name = "clientSideBar1";
            this.clientSideBar1.Size = new System.Drawing.Size(177, 756);
            this.clientSideBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 756);
            this.panel1.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(462, 600);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 75);
            this.button11.TabIndex = 4;
            this.button11.Text = "APPLY FOR LOAN";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(56, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 487);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ltidDataGridViewTextBoxColumn,
            this.ltnameDataGridViewTextBoxColumn,
            this.ltinterestDataGridViewTextBoxColumn,
            this.ltstatusDataGridViewTextBoxColumn,
            this.ltdateaddedDataGridViewTextBoxColumn,
            this.ltdescriptionDataGridViewTextBoxColumn,
            this.lasteditbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(640, 372);
            this.dataGridView1.TabIndex = 5;
            // 
            // aBMSLoanTypes
            // 
            this.aBMSLoanTypes.DataSetName = "ABMSLoanTypes";
            this.aBMSLoanTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTypesBindingSource
            // 
            this.loanTypesBindingSource.DataMember = "LoanTypes";
            this.loanTypesBindingSource.DataSource = this.aBMSLoanTypes;
            // 
            // loanTypesTableAdapter
            // 
            this.loanTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ltidDataGridViewTextBoxColumn
            // 
            this.ltidDataGridViewTextBoxColumn.DataPropertyName = "lt_id";
            this.ltidDataGridViewTextBoxColumn.Frozen = true;
            this.ltidDataGridViewTextBoxColumn.HeaderText = "lt_id";
            this.ltidDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.ltidDataGridViewTextBoxColumn.Name = "ltidDataGridViewTextBoxColumn";
            this.ltidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ltidDataGridViewTextBoxColumn.Width = 50;
            // 
            // ltnameDataGridViewTextBoxColumn
            // 
            this.ltnameDataGridViewTextBoxColumn.DataPropertyName = "lt_name";
            this.ltnameDataGridViewTextBoxColumn.HeaderText = "lt_name";
            this.ltnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltnameDataGridViewTextBoxColumn.Name = "ltnameDataGridViewTextBoxColumn";
            this.ltnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ltinterestDataGridViewTextBoxColumn
            // 
            this.ltinterestDataGridViewTextBoxColumn.DataPropertyName = "lt_interest";
            this.ltinterestDataGridViewTextBoxColumn.HeaderText = "lt_interest";
            this.ltinterestDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltinterestDataGridViewTextBoxColumn.Name = "ltinterestDataGridViewTextBoxColumn";
            this.ltinterestDataGridViewTextBoxColumn.Width = 150;
            // 
            // ltstatusDataGridViewTextBoxColumn
            // 
            this.ltstatusDataGridViewTextBoxColumn.DataPropertyName = "lt_status";
            this.ltstatusDataGridViewTextBoxColumn.HeaderText = "lt_status";
            this.ltstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltstatusDataGridViewTextBoxColumn.Name = "ltstatusDataGridViewTextBoxColumn";
            this.ltstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // ltdateaddedDataGridViewTextBoxColumn
            // 
            this.ltdateaddedDataGridViewTextBoxColumn.DataPropertyName = "lt_date_added";
            this.ltdateaddedDataGridViewTextBoxColumn.HeaderText = "lt_date_added";
            this.ltdateaddedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltdateaddedDataGridViewTextBoxColumn.Name = "ltdateaddedDataGridViewTextBoxColumn";
            this.ltdateaddedDataGridViewTextBoxColumn.Width = 150;
            // 
            // ltdescriptionDataGridViewTextBoxColumn
            // 
            this.ltdescriptionDataGridViewTextBoxColumn.DataPropertyName = "lt_description";
            this.ltdescriptionDataGridViewTextBoxColumn.HeaderText = "lt_description";
            this.ltdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ltdescriptionDataGridViewTextBoxColumn.Name = "ltdescriptionDataGridViewTextBoxColumn";
            this.ltdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // lasteditbyDataGridViewTextBoxColumn
            // 
            this.lasteditbyDataGridViewTextBoxColumn.DataPropertyName = "lastedit_by";
            this.lasteditbyDataGridViewTextBoxColumn.HeaderText = "lastedit_by";
            this.lasteditbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lasteditbyDataGridViewTextBoxColumn.Name = "lasteditbyDataGridViewTextBoxColumn";
            this.lasteditbyDataGridViewTextBoxColumn.Width = 150;
            // 
            // TakeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientSideBar1);
            this.Name = "TakeLoan";
            this.Text = "TakeLoan";
            this.Load += new System.EventHandler(this.TakeLoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSLoanTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClientSideBar clientSideBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABMSLoanTypes aBMSLoanTypes;
        private System.Windows.Forms.BindingSource loanTypesBindingSource;
        private ABMSLoanTypesTableAdapters.LoanTypesTableAdapter loanTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltinterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasteditbyDataGridViewTextBoxColumn;
    }
}