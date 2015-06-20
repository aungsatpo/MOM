namespace MOM
{
    partial class NewCustomer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustAddr = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(193, 32);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustName.MaxLength = 500;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(320, 26);
            this.txtCustName.TabIndex = 1;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(193, 90);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustPhone.MaxLength = 30;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(320, 26);
            this.txtCustPhone.TabIndex = 4;
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.Location = new System.Drawing.Point(193, 157);
            this.txtCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustAddr.MaxLength = 500;
            this.txtCustAddr.Multiline = true;
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.Size = new System.Drawing.Size(320, 99);
            this.txtCustAddr.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 293);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCustAddr);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustAddr;
        private System.Windows.Forms.Button btnClose;
    }
}

