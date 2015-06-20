using MOM.Reports;
namespace MOM
{
    partial class Report
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
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlYear = new System.Windows.Forms.ComboBox();
            this.mONTHLYYEARSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new MOM.ReportDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYearly = new System.Windows.Forms.Button();
            this.loaN_CUSTOMERTableAdapter1 = new MOM.MOMDataSetTableAdapters.LOAN_CUSTOMERTableAdapter();
            this.monthlY_YEARSTableAdapter1 = new MOM.ReportDataSetTableAdapters.MONTHLY_YEARSTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUnpaid = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHLYYEARSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Collected From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(159, 35);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(308, 26);
            this.dtpFrom.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(497, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 60);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "General Report";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(209, 433);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 60);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(159, 71);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(308, 26);
            this.dtpTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Collected To";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpTo);
            this.groupBox3.Controls.Add(this.dtpFrom);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 114);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnMonthly);
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 114);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Report";
            // 
            // ddlYear
            // 
            this.ddlYear.DataSource = this.mONTHLYYEARSBindingSource;
            this.ddlYear.DisplayMember = "YEARS";
            this.ddlYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlYear.FormattingEnabled = true;
            this.ddlYear.Location = new System.Drawing.Point(83, 52);
            this.ddlYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlYear.Name = "ddlYear";
            this.ddlYear.Size = new System.Drawing.Size(148, 28);
            this.ddlYear.TabIndex = 3;
            // 
            // mONTHLYYEARSBindingSource
            // 
            this.mONTHLYYEARSBindingSource.DataMember = "MONTHLY_YEARS";
            this.mONTHLYYEARSBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Year";
            // 
            // btnMonthly
            // 
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(266, 35);
            this.btnMonthly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(160, 60);
            this.btnMonthly.TabIndex = 33;
            this.btnMonthly.Text = "Monthly Report";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYearly);
            this.groupBox2.Location = new System.Drawing.Point(495, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 114);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly Report";
            // 
            // btnYearly
            // 
            this.btnYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearly.Location = new System.Drawing.Point(83, 35);
            this.btnYearly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYearly.Name = "btnYearly";
            this.btnYearly.Size = new System.Drawing.Size(160, 60);
            this.btnYearly.TabIndex = 33;
            this.btnYearly.Text = "Yearly Report";
            this.btnYearly.UseVisualStyleBackColor = true;
            this.btnYearly.Click += new System.EventHandler(this.btnYearly_Click);
            // 
            // loaN_CUSTOMERTableAdapter1
            // 
            this.loaN_CUSTOMERTableAdapter1.ClearBeforeFill = true;
            // 
            // monthlY_YEARSTableAdapter1
            // 
            this.monthlY_YEARSTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUnpaid);
            this.groupBox4.Controls.Add(this.btnPending);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 114);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Uncollected Reports";
            // 
            // btnUnpaid
            // 
            this.btnUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpaid.Location = new System.Drawing.Point(296, 35);
            this.btnUnpaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnpaid.Name = "btnUnpaid";
            this.btnUnpaid.Size = new System.Drawing.Size(160, 60);
            this.btnUnpaid.TabIndex = 34;
            this.btnUnpaid.Text = "Unpaid Report";
            this.btnUnpaid.UseVisualStyleBackColor = true;
            this.btnUnpaid.Click += new System.EventHandler(this.btnUnpaid_Click);
            // 
            // btnPending
            // 
            this.btnPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.Location = new System.Drawing.Point(83, 35);
            this.btnPending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(160, 60);
            this.btnPending.TabIndex = 33;
            this.btnPending.Text = "Pending Collection Report";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHLYYEARSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private MOMDataSetTableAdapters.LOAN_CUSTOMERTableAdapter loaN_CUSTOMERTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYearly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlYear;
        private MOM.ReportDataSetTableAdapters.MONTHLY_YEARSTableAdapter monthlY_YEARSTableAdapter1;
        private ReportDataSet ReportDataSet;
        private System.Windows.Forms.BindingSource mONTHLYYEARSBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnUnpaid;
    }
}