namespace Electric_Management_System
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.changePasswordGroupBox.SuspendLayout();
            this.createPasswordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(125, 21);
            this.oldPasswordTextBox.MaxLength = 255;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(155, 21);
            this.oldPasswordTextBox.TabIndex = 1;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // changePasswordGroupBox
            // 
            this.changePasswordGroupBox.Controls.Add(this.label3);
            this.changePasswordGroupBox.Controls.Add(this.label2);
            this.changePasswordGroupBox.Controls.Add(this.label1);
            this.changePasswordGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.changePasswordGroupBox.Controls.Add(this.newPasswordTextBox);
            this.changePasswordGroupBox.Controls.Add(this.oldPasswordTextBox);
            this.changePasswordGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordGroupBox.Location = new System.Drawing.Point(12, 13);
            this.changePasswordGroupBox.Name = "changePasswordGroupBox";
            this.changePasswordGroupBox.Size = new System.Drawing.Size(286, 102);
            this.changePasswordGroupBox.TabIndex = 0;
            this.changePasswordGroupBox.TabStop = false;
            this.changePasswordGroupBox.Text = "Thay Đổi Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận mật &khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu &mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu &cũ";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(125, 75);
            this.confirmPasswordTextBox.MaxLength = 255;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(155, 21);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(125, 48);
            this.newPasswordTextBox.MaxLength = 255;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(155, 21);
            this.newPasswordTextBox.TabIndex = 3;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // createPasswordGroupBox
            // 
            this.createPasswordGroupBox.Controls.Add(this.label4);
            this.createPasswordGroupBox.Controls.Add(this.passwordTextBox);
            this.createPasswordGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPasswordGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createPasswordGroupBox.Name = "createPasswordGroupBox";
            this.createPasswordGroupBox.Size = new System.Drawing.Size(286, 48);
            this.createPasswordGroupBox.TabIndex = 1;
            this.createPasswordGroupBox.TabStop = false;
            this.createPasswordGroupBox.Text = "Đặt Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Nhập mật khẩu";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(125, 21);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(155, 21);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::Electric_Management_System.Properties.Resources.save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(218, 121);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 26);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "    &Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = global::Electric_Management_System.Properties.Resources.Close_Box_Red;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(12, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 26);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "     Đó&ng";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Image = global::Electric_Management_System.Properties.Resources.Delete_16x16;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(101, 121);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 26);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "     &Xóa mật khẩu";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // changePasswordForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(310, 159);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changePasswordGroupBox);
            this.Controls.Add(this.createPasswordGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "changePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Thay Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            this.changePasswordGroupBox.ResumeLayout(false);
            this.changePasswordGroupBox.PerformLayout();
            this.createPasswordGroupBox.ResumeLayout(false);
            this.createPasswordGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.GroupBox changePasswordGroupBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox createPasswordGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}