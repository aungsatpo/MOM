namespace MOM
{
    partial class PendingCollectionReport
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
            this.PENDINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new MOM.ReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PENDINGTableAdapter = new MOM.ReportDataSetTableAdapters.PENDINGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PENDINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PENDINGBindingSource
            // 
            this.PENDINGBindingSource.DataMember = "PENDING";
            this.PENDINGBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PENDINGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOM.PendingCollectionReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 511);
            this.reportViewer1.TabIndex = 2;
            // 
            // PENDINGTableAdapter
            // 
            this.PENDINGTableAdapter.ClearBeforeFill = true;
            // 
            // PendingCollectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PendingCollectionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PendingCollectionReport";
            this.Load += new System.EventHandler(this.PendingCollectionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PENDINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PENDINGBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.PENDINGTableAdapter PENDINGTableAdapter;
    }
}