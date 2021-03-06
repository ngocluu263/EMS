namespace Electric_Management_System
{
    partial class changeInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeInvoiceForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rdOldInvoice = new System.Windows.Forms.RadioButton();
            this.rdNewInvoice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = global::Electric_Management_System.Properties.Resources.Close_Box_Red;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(18, 82);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "     &Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::Electric_Management_System.Properties.Resources.save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(213, 82);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "    &Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rdOldInvoice
            // 
            this.rdOldInvoice.AutoSize = true;
            this.rdOldInvoice.Location = new System.Drawing.Point(12, 12);
            this.rdOldInvoice.Name = "rdOldInvoice";
            this.rdOldInvoice.Size = new System.Drawing.Size(116, 24);
            this.rdOldInvoice.TabIndex = 4;
            this.rdOldInvoice.TabStop = true;
            this.rdOldInvoice.Text = "Hóa đơn cũ";
            this.rdOldInvoice.UseVisualStyleBackColor = true;
            // 
            // rdNewInvoice
            // 
            this.rdNewInvoice.AutoSize = true;
            this.rdNewInvoice.Location = new System.Drawing.Point(12, 42);
            this.rdNewInvoice.Name = "rdNewInvoice";
            this.rdNewInvoice.Size = new System.Drawing.Size(124, 24);
            this.rdNewInvoice.TabIndex = 4;
            this.rdNewInvoice.TabStop = true;
            this.rdNewInvoice.Text = "Hóa đơn mới";
            this.rdNewInvoice.UseVisualStyleBackColor = true;
            // 
            // changeInvoiceForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(351, 140);
            this.Controls.Add(this.rdNewInvoice);
            this.Controls.Add(this.rdOldInvoice);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "changeInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Hóa Đơn";
            this.Load += new System.EventHandler(this.changeInvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton rdOldInvoice;
        private System.Windows.Forms.RadioButton rdNewInvoice;
    }
}