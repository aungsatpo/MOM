namespace MOM.Reports
{
    partial class GeneralReport
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
            this.GENERALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new MOM.ReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GENERALTableAdapter = new MOM.ReportDataSetTableAdapters.GENERALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GENERALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GENERALBindingSource
            // 
            this.GENERALBindingSource.DataMember = "GENERAL";
            this.GENERALBindingSource.DataSource = this.ReportDataSet;
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
            reportDataSource1.Value = this.GENERALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOM.GeneralReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1008, 511);
            this.reportViewer1.TabIndex = 1;
            // 
            // GENERALTableAdapter
            // 
            this.GENERALTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralReport";
            this.Load += new System.EventHandler(this.GeneralReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GENERALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GENERALBindingSource;
        private ReportDataSet ReportDataSet;
        private MOM.ReportDataSetTableAdapters.GENERALTableAdapter GENERALTableAdapter;
    }
}