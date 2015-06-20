namespace MOM
{
    partial class UnpaidReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportDataSet = new MOM.ReportDataSet();
            this.UNPAIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNPAIDTableAdapter = new MOM.ReportDataSetTableAdapters.UNPAIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNPAIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UNPAIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOM.UnpaidReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 511);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UNPAIDBindingSource
            // 
            this.UNPAIDBindingSource.DataMember = "UNPAID";
            this.UNPAIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // UNPAIDTableAdapter
            // 
            this.UNPAIDTableAdapter.ClearBeforeFill = true;
            // 
            // UnpaidReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UnpaidReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unpaid Report";
            this.Load += new System.EventHandler(this.UnpaidReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNPAIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UNPAIDBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.UNPAIDTableAdapter UNPAIDTableAdapter;
    }
}