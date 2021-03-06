namespace Electric_Management_System
{
    partial class sendMailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendMailForm));
            this.label1 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mesageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.attachmentsTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa &chỉ email gửi đến";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(138, 21);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(384, 21);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.Text = "Tác giả EMS (Email: ThuongNguyenHuy@gmail.com)";
            this.toolTip1.SetToolTip(this.toTextBox, "Địa chỉ email của tác giả EMS (Nguyễn Huy Thường)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ email của &bạn";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(138, 48);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(384, 21);
            this.fromTextBox.TabIndex = 3;
            this.fromTextBox.Text = "Công ty TNHH Nghĩa Xuân (NghiaXuan.CatQue@gmail.com)";
            this.toolTip1.SetToolTip(this.fromTextBox, "Địa chỉ email của bạn");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.subjectTextBox);
            this.groupBox1.Controls.Add(this.fromTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin gửi/nhận";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "* Lưu ý: Bạn phải nhập chính xác địa chỉ email của mình để tác giả có thể gửi thư" +
    " trả lời vào địa chỉ email mà bạn cung cấp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiê&u đề thư";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(138, 105);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(384, 21);
            this.subjectTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.subjectTextBox, "Tiêu đề thư");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mesageTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Nội dung thư";
            // 
            // mesageTextBox
            // 
            this.mesageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mesageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesageTextBox.Location = new System.Drawing.Point(6, 21);
            this.mesageTextBox.Multiline = true;
            this.mesageTextBox.Name = "mesageTextBox";
            this.mesageTextBox.Size = new System.Drawing.Size(516, 118);
            this.mesageTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.mesageTextBox, "Nội dung thư mà bạn muốn gửi đến tác giả");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.attachmentsTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các file đính kèm";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Image = global::Electric_Management_System.Properties.Resources.mail_attachment;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(411, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 25);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "      Đính &kèm file";
            this.toolTip1.SetToolTip(this.addButton, "Thêm file đính kèm");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // attachmentsTextBox
            // 
            this.attachmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentsTextBox.Location = new System.Drawing.Point(6, 23);
            this.attachmentsTextBox.Name = "attachmentsTextBox";
            this.attachmentsTextBox.ReadOnly = true;
            this.attachmentsTextBox.Size = new System.Drawing.Size(399, 21);
            this.attachmentsTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.attachmentsTextBox, "Các file được gửi kèm theo thư của bạn");
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Image = global::Electric_Management_System.Properties.Resources.Forward_16x16;
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.Location = new System.Drawing.Point(465, 405);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 25);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "    &Gửi";
            this.toolTip1.SetToolTip(this.sendButton, "Gửi thư đi");
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = global::Electric_Management_System.Properties.Resources.Close_Box_Red;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(12, 405);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "     Đó&ng";
            this.toolTip1.SetToolTip(this.cancelButton, "Thoát khỏi chương trình gửi thư");
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "Desktop";
            this.openFileDialog1.Multiselect = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(552, 442);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 420);
            this.Name = "sendMailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Gửi Thư Cho Tác Giả";
            this.Shown += new System.EventHandler(this.sendMailForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mesageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox attachmentsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}