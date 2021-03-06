using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;

namespace Electric_Management_System
{
    public partial class mainForm : Form
    {
        private hoaDonMoiForm hdMoi = new hoaDonMoiForm();
        private hoaDonCuForm hdCu = new hoaDonCuForm();
        private khachHangForm khachHang = new khachHangForm();
        private reportForm baoCao = new reportForm();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            //if (DataTier.getPassword() != String.Empty)
            //{
            //    loginForm login = new loginForm();
            //    login.ShowDialog();
            //}
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void huongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được hoàn thiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendMailForm sendMail = new sendMailForm();
            sendMail.ShowDialog();
        }

        private void changePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == hdCu.Name || childForm.Name == hdMoi.Name)
                {
                    childForm.Close();
                    mainPanel.Visible = true;
                }
            }
            suaGiaDienForm changePrice = new suaGiaDienForm();
            changePrice.ShowDialog();
        }

        private void changeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeDateForm changeDate = new changeDateForm();
            changeDate.ShowDialog();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            mainPanel.Show();
        }

        private void hoaDonMoiButton_Click(object sender, EventArgs e)
        {
            hdMoi = new hoaDonMoiForm();
            hdMoi.MdiParent = this;
            mainPanel.Hide();
            hdMoi.Show();
        }

        private void hoaDonCuButton_Click(object sender, EventArgs e)
        {

            hdCu = new hoaDonCuForm();
            hdCu.MdiParent = this;
            mainPanel.Hide();
            hdCu.Show();
        }

        private void qlKhachHangButton_Click(object sender, EventArgs e)
        {

            khachHang = new khachHangForm();
            khachHang.MdiParent = this;
            mainPanel.Hide();
            khachHang.Show();
        }

        private void BCSHButton_Click(object sender, EventArgs e)
        {
            bool status = checkForm(baoCao.Name);
            if (status == true)
            {
                baoCao.shRadioButton.Checked = true;
            }
            else
            {
                baoCao = new reportForm();
                baoCao.MdiParent = this;
                mainPanel.Hide();
                baoCao.shRadioButton.Checked = true;
                baoCao.Show();
            }
        }

        private void BCMDKButton_Click(object sender, EventArgs e)
        {
            bool status = checkForm(baoCao.Name);
            if (status == true)
            {
                baoCao.mdkRadioButton.Checked = true;
            }
            else
            {
                baoCao = new reportForm();
                baoCao.MdiParent = this;
                mainPanel.Hide();
                baoCao.mdkRadioButton.Checked = true;
                baoCao.Show();
            }
        }

        private void BCTongHopButton_Click(object sender, EventArgs e)
        {
            bool status = checkForm(baoCao.Name);
            if (status == true)
            {
                baoCao.tongHopRadioButton.Checked = true;
            }
            else
            {
                baoCao = new reportForm();
                baoCao.MdiParent = this;
                mainPanel.Hide();
                baoCao.tongHopRadioButton.Checked = true;
                baoCao.Show();
            }
        }

        private void hoaDonPictureBox_Click(object sender, EventArgs e)
        {
            hdMoi = new hoaDonMoiForm();
            hdMoi.MdiParent = this;
            mainPanel.Hide();
            hdMoi.Show();
        }

        private void hoaDonPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            hoaDonPictureBox.Image = Electric_Management_System.Properties.Resources.invoice_click;
        }

        private void hoaDonPictureBox_MouseHover(object sender, EventArgs e)
        {
            hoaDonPictureBox.Image = Electric_Management_System.Properties.Resources.invoice_active;
        }

        private void hoaDonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            hoaDonPictureBox.Image = Electric_Management_System.Properties.Resources.invoice_deactive;
        }

        private void hoaDonPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            hoaDonPictureBox.Image = Electric_Management_System.Properties.Resources.invoice_active;
        }

        private void khachHangPictureBox_Click(object sender, EventArgs e)
        {

            khachHang = new khachHangForm();
            khachHang.MdiParent = this;
            mainPanel.Hide();
            khachHang.Show();
        }

        private void khachHangPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            khachHangPictureBox.Image = Electric_Management_System.Properties.Resources.customer_click;
        }

        private void khachHangPictureBox_MouseHover(object sender, EventArgs e)
        {
            khachHangPictureBox.Image = Electric_Management_System.Properties.Resources.customer_active;
        }

        private void khachHangPictureBox_MouseLeave(object sender, EventArgs e)
        {
            khachHangPictureBox.Image = Electric_Management_System.Properties.Resources.customer_deactive;
        }

        private void khachHangPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            khachHangPictureBox.Image = Electric_Management_System.Properties.Resources.customer_active;
        }

        private void baoCaoPictureBox_Click(object sender, EventArgs e)
        {
            bool status = checkForm(baoCao.Name);
            if (status == true)
            {

                baoCao.reportTabControl.SelectedIndex = 0;
                baoCao.shRadioButton.Checked = true;
            }
            else
            {
                baoCao = new reportForm();
                baoCao.MdiParent = this;
                mainPanel.Hide();
                baoCao.reportTabControl.SelectedIndex = 0;
                baoCao.shRadioButton.Checked = true;
                baoCao.Show();
            }
        }

        private void baoCaoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            baoCaoPictureBox.Image = Electric_Management_System.Properties.Resources.report_click;
        }

        private void baoCaoPictureBox_MouseHover(object sender, EventArgs e)
        {
            baoCaoPictureBox.Image = Electric_Management_System.Properties.Resources.report_active;
        }

        private void baoCaoPictureBox_MouseLeave(object sender, EventArgs e)
        {
            baoCaoPictureBox.Image = Electric_Management_System.Properties.Resources.report_deactive;
        }

        private void baoCaoPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            baoCaoPictureBox.Image = Electric_Management_System.Properties.Resources.report_active;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Electric_Management_System.Properties.Resources.exit_click;
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Image = Electric_Management_System.Properties.Resources.exit_active;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Electric_Management_System.Properties.Resources.exit_deactive;
        }

        private void exitPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Electric_Management_System.Properties.Resources.exit_active;
        }

        public Boolean checkForm(String formName)
        {
            bool status = false;
            foreach (Form openningForm in this.MdiChildren)
            {
                if (openningForm == null)
                {
                    status = false;
                    mainPanel.Visible = true;
                }
                else if (openningForm.Name == formName)
                {
                    status = true;
                }
                else
                {
                    openningForm.Close();
                    status = false;
                }
            }
            return status;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            loginForm dlgPassword = new loginForm();
            dlgPassword.Show();
        }

        private void dsChotSoDienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsChotSoDienForm dsChotSoDien = new dsChotSoDienForm();
            dsChotSoDien.Show();
        }

        private void hhdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theoDoiHHDVForm theoDoiHHDV = new theoDoiHHDVForm();
            theoDoiHHDV.Show();
        }

        private void gtgtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theoDoiGTGTForm theoDoiGTGT = new theoDoiGTGTForm();
            theoDoiGTGT.Show();
        }

        private void nhatKyChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soNhatKyChungForm nhatKyChung = new soNhatKyChungForm();
            nhatKyChung.Show();
        }

        private void theoDoiChuyenTienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theoDoiChuyenTienForm theoDoiChuyenTien = new theoDoiChuyenTienForm();
            theoDoiChuyenTien.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeInvoiceForm changeInvoice = new changeInvoiceForm();
            changeInvoice.Show();
        }
    }
}