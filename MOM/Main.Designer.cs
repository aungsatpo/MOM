namespace MOM
{
    partial class Main
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
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnSearchLoan = new System.Windows.Forms.Button();
            this.btnUncollected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(26, 27);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(124, 78);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(201, 27);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(124, 78);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit / Delete Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(26, 27);
            this.btnAddLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(124, 78);
            this.btnAddLoan.TabIndex = 2;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(26, 27);
            this.btnRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(124, 78);
            this.btnRate.TabIndex = 3;
            this.btnRate.Text = "Adjust Interest Rate";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnSearchLoan
            // 
            this.btnSearchLoan.Location = new System.Drawing.Point(377, 27);
            this.btnSearchLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchLoan.Name = "btnSearchLoan";
            this.btnSearchLoan.Size = new System.Drawing.Size(124, 78);
            this.btnSearchLoan.TabIndex = 4;
            this.btnSearchLoan.Text = "Search Loan";
            this.btnSearchLoan.UseVisualStyleBackColor = true;
            this.btnSearchLoan.Click += new System.EventHandler(this.btnSearchLoan_Click);
            // 
            // btnUncollected
            // 
            this.btnUncollected.Location = new System.Drawing.Point(201, 27);
            this.btnUncollected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUncollected.Name = "btnUncollected";
            this.btnUncollected.Size = new System.Drawing.Size(124, 78);
            this.btnUncollected.TabIndex = 5;
            this.btnUncollected.Text = "Pending Collections";
            this.btnUncollected.UseVisualStyleBackColor = true;
            this.btnUncollected.Click += new System.EventHandler(this.btnUncollected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnSearchLoan);
            this.groupBox1.Controls.Add(this.btnUncollected);
            this.groupBox1.Controls.Add(this.btnAddLoan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loans";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(546, 27);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 78);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewCustomer);
            this.groupBox2.Controls.Add(this.btnEditCustomer);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 120);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRate);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 120);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnSearchLoan;
        private System.Windows.Forms.Button btnUncollected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReport;
    }
}