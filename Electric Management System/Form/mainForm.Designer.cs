namespace Electric_Management_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.hoaDonPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hoaDonCuButton = new System.Windows.Forms.Button();
            this.hoaDonMoiButton = new System.Windows.Forms.Button();
            this.khachHangPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.qlKhachHangButton = new System.Windows.Forms.Button();
            this.baoCaoPanel = new System.Windows.Forms.Panel();
            this.BCTongHopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BCMDKButton = new System.Windows.Forms.Button();
            this.BCSHButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuyChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.baoCaoPictureBox = new System.Windows.Forms.PictureBox();
            this.khachHangPictureBox = new System.Windows.Forms.PictureBox();
            this.hoaDonPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonPanel.SuspendLayout();
            this.khachHangPanel.SuspendLayout();
            this.baoCaoPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainMenuContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoaDonPanel
            // 
            this.hoaDonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.hoaDonPanel.Controls.Add(this.label1);
            this.hoaDonPanel.Controls.Add(this.hoaDonCuButton);
            this.hoaDonPanel.Controls.Add(this.hoaDonMoiButton);
            this.hoaDonPanel.Location = new System.Drawing.Point(12, 78);
            this.hoaDonPanel.Name = "hoaDonPanel";
            this.hoaDonPanel.Size = new System.Drawing.Size(150, 91);
            this.hoaDonPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Điện";
            // 
            // hoaDonCuButton
            // 
            this.hoaDonCuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoaDonCuButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.hoaDonCuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hoaDonCuButton.Image = global::Electric_Management_System.Properties.Resources.old_invoice;
            this.hoaDonCuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoaDonCuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hoaDonCuButton.Location = new System.Drawing.Point(3, 58);
            this.hoaDonCuButton.Name = "hoaDonCuButton";
            this.hoaDonCuButton.Size = new System.Drawing.Size(144, 30);
            this.hoaDonCuButton.TabIndex = 2;
            this.hoaDonCuButton.Text = "     Xem Hóa Đơn Cũ";
            this.toolTip.SetToolTip(this.hoaDonCuButton, "Xem hóa đơn đã lập");
            this.hoaDonCuButton.UseVisualStyleBackColor = true;
            this.hoaDonCuButton.Click += new System.EventHandler(this.hoaDonCuButton_Click);
            // 
            // hoaDonMoiButton
            // 
            this.hoaDonMoiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoaDonMoiButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.hoaDonMoiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hoaDonMoiButton.Image = global::Electric_Management_System.Properties.Resources.new_invoice;
            this.hoaDonMoiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoaDonMoiButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hoaDonMoiButton.Location = new System.Drawing.Point(3, 22);
            this.hoaDonMoiButton.Name = "hoaDonMoiButton";
            this.hoaDonMoiButton.Size = new System.Drawing.Size(144, 30);
            this.hoaDonMoiButton.TabIndex = 1;
            this.hoaDonMoiButton.Text = "     Lập Hóa Đơn Mới";
            this.toolTip.SetToolTip(this.hoaDonMoiButton, "Lập hóa đơn mới");
            this.hoaDonMoiButton.UseVisualStyleBackColor = true;
            this.hoaDonMoiButton.Click += new System.EventHandler(this.hoaDonMoiButton_Click);
            // 
            // khachHangPanel
            // 
            this.khachHangPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.khachHangPanel.Controls.Add(this.label2);
            this.khachHangPanel.Controls.Add(this.qlKhachHangButton);
            this.khachHangPanel.Location = new System.Drawing.Point(12, 175);
            this.khachHangPanel.Name = "khachHangPanel";
            this.khachHangPanel.Size = new System.Drawing.Size(150, 55);
            this.khachHangPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng";
            // 
            // qlKhachHangButton
            // 
            this.qlKhachHangButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qlKhachHangButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.qlKhachHangButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qlKhachHangButton.Image = global::Electric_Management_System.Properties.Resources.customer;
            this.qlKhachHangButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlKhachHangButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.qlKhachHangButton.Location = new System.Drawing.Point(3, 22);
            this.qlKhachHangButton.Name = "qlKhachHangButton";
            this.qlKhachHangButton.Size = new System.Drawing.Size(144, 30);
            this.qlKhachHangButton.TabIndex = 1;
            this.qlKhachHangButton.Text = "    Q.Lý Khách Hàng";
            this.toolTip.SetToolTip(this.qlKhachHangButton, "Quản lý danh sách khách hàng sử dụng điện");
            this.qlKhachHangButton.UseVisualStyleBackColor = true;
            this.qlKhachHangButton.Click += new System.EventHandler(this.qlKhachHangButton_Click);
            // 
            // baoCaoPanel
            // 
            this.baoCaoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.baoCaoPanel.Controls.Add(this.BCTongHopButton);
            this.baoCaoPanel.Controls.Add(this.label3);
            this.baoCaoPanel.Controls.Add(this.BCMDKButton);
            this.baoCaoPanel.Controls.Add(this.BCSHButton);
            this.baoCaoPanel.Location = new System.Drawing.Point(12, 236);
            this.baoCaoPanel.Name = "baoCaoPanel";
            this.baoCaoPanel.Size = new System.Drawing.Size(150, 127);
            this.baoCaoPanel.TabIndex = 3;
            // 
            // BCTongHopButton
            // 
            this.BCTongHopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCTongHopButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BCTongHopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BCTongHopButton.Image = global::Electric_Management_System.Properties.Resources.total_report;
            this.BCTongHopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCTongHopButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BCTongHopButton.Location = new System.Drawing.Point(3, 94);
            this.BCTongHopButton.Name = "BCTongHopButton";
            this.BCTongHopButton.Size = new System.Drawing.Size(144, 30);
            this.BCTongHopButton.TabIndex = 2;
            this.BCTongHopButton.Text = "     Báo Cáo Tổng Hợp";
            this.toolTip.SetToolTip(this.BCTongHopButton, "Xem báo cáo tổng hợp hàng tháng");
            this.BCTongHopButton.UseVisualStyleBackColor = true;
            this.BCTongHopButton.Click += new System.EventHandler(this.BCTongHopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Báo Cáo";
            // 
            // BCMDKButton
            // 
            this.BCMDKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCMDKButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BCMDKButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BCMDKButton.Image = global::Electric_Management_System.Properties.Resources.monthly_report;
            this.BCMDKButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCMDKButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BCMDKButton.Location = new System.Drawing.Point(3, 58);
            this.BCMDKButton.Name = "BCMDKButton";
            this.BCMDKButton.Size = new System.Drawing.Size(144, 30);
            this.BCMDKButton.TabIndex = 1;
            this.BCMDKButton.Text = "    Báo Cáo MĐK";
            this.BCMDKButton.UseVisualStyleBackColor = true;
            this.BCMDKButton.Click += new System.EventHandler(this.BCMDKButton_Click);
            // 
            // BCSHButton
            // 
            this.BCSHButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCSHButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BCSHButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BCSHButton.Image = global::Electric_Management_System.Properties.Resources.monthly_report;
            this.BCSHButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCSHButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BCSHButton.Location = new System.Drawing.Point(3, 22);
            this.BCSHButton.Name = "BCSHButton";
            this.BCSHButton.Size = new System.Drawing.Size(144, 30);
            this.BCSHButton.TabIndex = 1;
            this.BCSHButton.Text = "    Báo Cáo Sinh Hoạt";
            this.toolTip.SetToolTip(this.BCSHButton, "Xem báo cáo sử dụng điện hàng tháng");
            this.BCSHButton.UseVisualStyleBackColor = true;
            this.BCSHButton.Click += new System.EventHandler(this.BCSHButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.tuyChonToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(794, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.sendMailToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.helpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // huongDanToolStripMenuItem
            // 
            this.huongDanToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.huongDanToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.help;
            this.huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            this.huongDanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.huongDanToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.huongDanToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            this.huongDanToolStripMenuItem.Click += new System.EventHandler(this.huongDanToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.aboutToolStripMenuItem.Text = "Thông Tin Về Chương Trình";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sendMailToolStripMenuItem
            // 
            this.sendMailToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Mail_16x16;
            this.sendMailToolStripMenuItem.Name = "sendMailToolStripMenuItem";
            this.sendMailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.sendMailToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.sendMailToolStripMenuItem.Text = "Gửi Thư Cho Tác Giả";
            this.sendMailToolStripMenuItem.Click += new System.EventHandler(this.sendMailToolStripMenuItem_Click);
            // 
            // tuyChonToolStripMenuItem
            // 
            this.tuyChonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePriceToolStripMenuItem,
            this.changeDateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.thoatToolStripMenuItem});
            this.tuyChonToolStripMenuItem.Name = "tuyChonToolStripMenuItem";
            this.tuyChonToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tuyChonToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // changePriceToolStripMenuItem
            // 
            this.changePriceToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Dollar__Green;
            this.changePriceToolStripMenuItem.Name = "changePriceToolStripMenuItem";
            this.changePriceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.changePriceToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.changePriceToolStripMenuItem.Text = "Thay Đổi Giá Điện";
            this.changePriceToolStripMenuItem.Click += new System.EventHandler(this.changePriceToolStripMenuItem_Click);
            // 
            // changeDateToolStripMenuItem
            // 
            this.changeDateToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Calendar_16x16;
            this.changeDateToolStripMenuItem.Name = "changeDateToolStripMenuItem";
            this.changeDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.changeDateToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.changeDateToolStripMenuItem.Text = "Thay Đổi Ngày Tháng";
            this.changeDateToolStripMenuItem.Click += new System.EventHandler(this.changeDateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(246, 22);
            this.toolStripMenuItem2.Text = "-------------------------------------------";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Log_Out_16x16;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.exitPictureBox);
            this.mainPanel.Controls.Add(this.baoCaoPictureBox);
            this.mainPanel.Controls.Add(this.khachHangPictureBox);
            this.mainPanel.Controls.Add(this.hoaDonPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(168, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(614, 524);
            this.mainPanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(433, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thoát";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(123, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Báo Cáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(409, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(125, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hóa Đơn";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = global::Electric_Management_System.Properties.Resources.exit_deactive;
            this.exitPictureBox.Location = new System.Drawing.Point(380, 309);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(150, 150);
            this.exitPictureBox.TabIndex = 4;
            this.exitPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.exitPictureBox, "Thoát khỏi chương trình");
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseDown);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseHover += new System.EventHandler(this.exitPictureBox_MouseHover);
            this.exitPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseUp);
            // 
            // baoCaoPictureBox
            // 
            this.baoCaoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baoCaoPictureBox.Image = global::Electric_Management_System.Properties.Resources.report_deactive;
            this.baoCaoPictureBox.Location = new System.Drawing.Point(84, 309);
            this.baoCaoPictureBox.Name = "baoCaoPictureBox";
            this.baoCaoPictureBox.Size = new System.Drawing.Size(150, 150);
            this.baoCaoPictureBox.TabIndex = 4;
            this.baoCaoPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.baoCaoPictureBox, "Xem báo cáo sử dụng điện hàng tháng");
            this.baoCaoPictureBox.Click += new System.EventHandler(this.baoCaoPictureBox_Click);
            this.baoCaoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baoCaoPictureBox_MouseDown);
            this.baoCaoPictureBox.MouseLeave += new System.EventHandler(this.baoCaoPictureBox_MouseLeave);
            this.baoCaoPictureBox.MouseHover += new System.EventHandler(this.baoCaoPictureBox_MouseHover);
            this.baoCaoPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baoCaoPictureBox_MouseUp);
            // 
            // khachHangPictureBox
            // 
            this.khachHangPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.khachHangPictureBox.Image = global::Electric_Management_System.Properties.Resources.customer_deactive;
            this.khachHangPictureBox.Location = new System.Drawing.Point(380, 61);
            this.khachHangPictureBox.Name = "khachHangPictureBox";
            this.khachHangPictureBox.Size = new System.Drawing.Size(150, 150);
            this.khachHangPictureBox.TabIndex = 4;
            this.khachHangPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.khachHangPictureBox, "Quản lý danh sách khách hàng sử dụng điện");
            this.khachHangPictureBox.Click += new System.EventHandler(this.khachHangPictureBox_Click);
            this.khachHangPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.khachHangPictureBox_MouseDown);
            this.khachHangPictureBox.MouseLeave += new System.EventHandler(this.khachHangPictureBox_MouseLeave);
            this.khachHangPictureBox.MouseHover += new System.EventHandler(this.khachHangPictureBox_MouseHover);
            this.khachHangPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.khachHangPictureBox_MouseUp);
            // 
            // hoaDonPictureBox
            // 
            this.hoaDonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoaDonPictureBox.Image = global::Electric_Management_System.Properties.Resources.invoice_deactive;
            this.hoaDonPictureBox.Location = new System.Drawing.Point(84, 61);
            this.hoaDonPictureBox.Name = "hoaDonPictureBox";
            this.hoaDonPictureBox.Size = new System.Drawing.Size(150, 150);
            this.hoaDonPictureBox.TabIndex = 4;
            this.hoaDonPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.hoaDonPictureBox, "Lập hóa đơn mới");
            this.hoaDonPictureBox.Click += new System.EventHandler(this.hoaDonPictureBox_Click);
            this.hoaDonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hoaDonPictureBox_MouseDown);
            this.hoaDonPictureBox.MouseLeave += new System.EventHandler(this.hoaDonPictureBox_MouseLeave);
            this.hoaDonPictureBox.MouseHover += new System.EventHandler(this.hoaDonPictureBox_MouseHover);
            this.hoaDonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hoaDonPictureBox_MouseUp);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeButton.Image = global::Electric_Management_System.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(144, 30);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "     Màn Hình Chính";
            this.toolTip.SetToolTip(this.homeButton, "Về màn hình chính");
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(207)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 36);
            this.panel1.TabIndex = 3;
            // 
            // mainMenuContextMenuStrip
            // 
            this.mainMenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordToolStripMenuItem,
            this.priceToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.toolStripSeparator1,
            this.hdsdToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.mainMenuContextMenuStrip.Name = "mainMenuContextMenuStrip";
            this.mainMenuContextMenuStrip.Size = new System.Drawing.Size(251, 170);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Key_16x16;
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F1";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.passwordToolStripMenuItem.Text = "Thay đổi mật khẩu";
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Dollar__Green;
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F2";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.priceToolStripMenuItem.Text = "Thay đổi giá điện";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.changePriceToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Calendar_16x16;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F3";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.dateToolStripMenuItem.Text = "Thay đổi ngày tháng";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.changeDateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // hdsdToolStripMenuItem
            // 
            this.hdsdToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.help;
            this.hdsdToolStripMenuItem.Name = "hdsdToolStripMenuItem";
            this.hdsdToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.hdsdToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.hdsdToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hdsdToolStripMenuItem.Click += new System.EventHandler(this.huongDanToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.info;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+I";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.infoToolStripMenuItem.Text = "Thông tin về chương trình";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Mail_16x16;
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.mailToolStripMenuItem.Text = "Gửi Thư Cho Tác Giả";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.sendMailToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Electric_Management_System.Properties.Resources.Log_Out_16x16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.exitToolStripMenuItem.Text = "Thoát khỏi chương trình";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Electric_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.ContextMenuStrip = this.mainMenuContextMenuStrip;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.baoCaoPanel);
            this.Controls.Add(this.khachHangPanel);
            this.Controls.Add(this.hoaDonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electric Management System 4.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.hoaDonPanel.ResumeLayout(false);
            this.hoaDonPanel.PerformLayout();
            this.khachHangPanel.ResumeLayout(false);
            this.khachHangPanel.PerformLayout();
            this.baoCaoPanel.ResumeLayout(false);
            this.baoCaoPanel.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.mainMenuContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel hoaDonPanel;
        private System.Windows.Forms.Button hoaDonCuButton;
        private System.Windows.Forms.Button hoaDonMoiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel khachHangPanel;
        private System.Windows.Forms.Button qlKhachHangButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel baoCaoPanel;
        private System.Windows.Forms.Button BCTongHopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BCSHButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tuyChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.PictureBox hoaDonPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox baoCaoPictureBox;
        private System.Windows.Forms.PictureBox khachHangPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem changePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDateToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ContextMenuStrip mainMenuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hdsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.Button BCMDKButton;
    }
}

