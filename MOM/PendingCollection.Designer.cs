namespace MOM
{
    partial class PendingCollection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUncollected = new System.Windows.Forms.DataGridView();
            this.loanAdapter = new MOM.MOMDataSetTableAdapters.LOANTableAdapter();
            this.dSet = new MOM.MOMDataSet();
            this.uncollecteD_LOANTableAdapter1 = new MOM.MOMDataSetTableAdapters.LOAN_CUSTOMERTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUncollected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUncollected
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUncollected.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUncollected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUncollected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUncollected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUncollected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUncollected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvUncollected.Location = new System.Drawing.Point(12, 12);
            this.dgvUncollected.MultiSelect = false;
            this.dgvUncollected.Name = "dgvUncollected";
            this.dgvUncollected.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUncollected.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUncollected.Size = new System.Drawing.Size(984, 449);
            this.dgvUncollected.TabIndex = 0;
            this.dgvUncollected.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUncollected_RowHeaderMouseClick);
            this.dgvUncollected.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUncollected_RowHeaderMouseDoubleClick);
            // 
            // loanAdapter
            // 
            this.loanAdapter.ClearBeforeFill = true;
            // 
            // dSet
            // 
            this.dSet.DataSetName = "MOMDataSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uncollecteD_LOANTableAdapter1
            // 
            this.uncollecteD_LOANTableAdapter1.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(442, 469);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PendingCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUncollected);
            this.Name = "PendingCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pending Collection";
            this.Load += new System.EventHandler(this.Uncollected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUncollected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MOMDataSetTableAdapters.LOANTableAdapter loanAdapter;
        private System.Windows.Forms.DataGridView dgvUncollected;
        private MOMDataSet dSet;
        private MOMDataSetTableAdapters.LOAN_CUSTOMERTableAdapter uncollecteD_LOANTableAdapter1;
        private System.Windows.Forms.Button btnClose;

    }
}