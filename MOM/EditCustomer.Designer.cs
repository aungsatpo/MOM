namespace MOM
{
    partial class EditCustomer
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
            this.txtCustAddr = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlOld = new System.Windows.Forms.ComboBox();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddr.Location = new System.Drawing.Point(193, 215);
            this.txtCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustAddr.MaxLength = 500;
            this.txtCustAddr.Multiline = true;
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.Size = new System.Drawing.Size(320, 99);
            this.txtCustAddr.TabIndex = 15;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPhone.Location = new System.Drawing.Point(193, 152);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustPhone.MaxLength = 30;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(320, 26);
            this.txtCustPhone.TabIndex = 14;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(193, 85);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustName.MaxLength = 500;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(320, 26);
            this.txtCustName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 60);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Old Customer Name";
            // 
            // ddlOld
            // 
            this.ddlOld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddlOld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlOld.FormattingEnabled = true;
            this.ddlOld.Location = new System.Drawing.Point(193, 17);
            this.ddlOld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlOld.Name = "ddlOld";
            this.ddlOld.Size = new System.Drawing.Size(320, 28);
            this.ddlOld.TabIndex = 17;
            this.ddlOld.DropDown += new System.EventHandler(this.ddlOld_DropDown);
            this.ddlOld.SelectedIndexChanged += new System.EventHandler(this.ddlOld_SelectedIndexChanged);
            this.ddlOld.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ddlOld_PreviewKeyDown);
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(318, 349);
            this.txtCustNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(164, 26);
            this.txtCustNo.TabIndex = 18;
            this.txtCustNo.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(209, 396);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 60);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 396);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 60);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.ddlOld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustAddr);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustAddr;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlOld;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}