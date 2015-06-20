namespace MOM
{
    partial class NewRate
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
            this.txtCurrentRate = new System.Windows.Forms.TextBox();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 286);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 60);
            this.btnSave.TabIndex = 3;
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
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remarks";
            // 
            // txtCurrentRate
            // 
            this.txtCurrentRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentRate.Location = new System.Drawing.Point(193, 32);
            this.txtCurrentRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentRate.Name = "txtCurrentRate";
            this.txtCurrentRate.ReadOnly = true;
            this.txtCurrentRate.Size = new System.Drawing.Size(320, 26);
            this.txtCurrentRate.TabIndex = 6;
            // 
            // txtNewRate
            // 
            this.txtNewRate.Location = new System.Drawing.Point(193, 90);
            this.txtNewRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewRate.MaxLength = 10;
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(320, 26);
            this.txtNewRate.TabIndex = 1;
            this.txtNewRate.TextChanged += new System.EventHandler(this.txtNewRate_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(193, 152);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.MaxLength = 500;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(320, 99);
            this.txtRemarks.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(293, 286);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 378);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtNewRate);
            this.Controls.Add(this.txtCurrentRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adjust Interest Rate";
            this.Load += new System.EventHandler(this.NewRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentRate;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnClose;
    }
}

