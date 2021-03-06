using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;
using Electric_Management_System.Properties;
using Electric_Management_System.Reports;

namespace Electric_Management_System
{
    public partial class hoaDonMoiForm : Form
    {
        private PrintInvoice hd;
        private PrintInvoiceSX3 hd2;
        private int soKhachTrongTram = 0;
        private DialogResult dialogResult = new DialogResult();
        private ketQuaSHForm ketQuaSH = new ketQuaSHForm();
        private ketQuaMDKForm ketQuaMDK = new ketQuaMDKForm();
        private ketQuaSX3Form ketQuaSX3 = new ketQuaSX3Form();

        public hoaDonMoiForm()
        {
            InitializeComponent();
        }

        private void hoaDonMoiForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.savePath == "")
            {
                Settings.Default.savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            pathTextBox.Text = Settings.Default.savePath;
            thangComboBox.Text = DateTime.Today.Month.ToString();
            namComboBox.Text = DateTime.Today.Year.ToString();
            fillTram();
            soMoiTextBox.Focus();
        }

        private void thoatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuatHoaDonButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (checkSTTKH())
            {
                if (checkInput())
                {
                    if (int.Parse(soMoiTextBox.Text) < int.Parse(soCuTextBox.Text))
                    {
                        DialogResult = MessageBox.Show("Số công tơ mới nhỏ hơn số công tơ cũ!\n\nNếu bạn chắc chắn đã nhập đúng thì hãy nhấn nút OK, chương trình sẽ tự động tính theo trường hợp công tơ hết vòng số.\nCòn nếu bạn phát hiện đây là nhầm lẫn, hãy bấm Cancel và sửa lại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        if (DialogResult == DialogResult.OK)
                        {
                            if (congToChetCheckBox.Checked)
                            {
                                if (int.Parse(soMoi2TextBox.Text) < int.Parse(soCu2TextBox.Text))
                                {
                                    DialogResult = MessageBox.Show("Số công tơ mới nhỏ hơn số công tơ cũ trong công tơ thay thế!\n\nNếu bạn chắc chắn đã nhập đúng thì hãy nhấn nút OK, chương trình sẽ tự động tính theo trường hợp công tơ hết vòng số.\nCòn nếu bạn phát hiện đây là nhầm lẫn, hãy bấm Cancel và sửa lại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                    if (DialogResult == DialogResult.OK)
                                    {
                                        createInvoice();
                                    }
                                    else
                                    {
                                        soMoi2TextBox.Focus();
                                        soMoi2TextBox.SelectAll();
                                    }
                                }
                                else
                                {
                                    createInvoice();
                                }
                            }
                            else
                            {
                                createInvoice();
                            }
                        }
                        else
                        {
                            soMoiTextBox.Focus();
                            soMoiTextBox.SelectAll();
                        }
                    }
                    else
                    {
                        if (congToChetCheckBox.Checked)
                        {
                            if (int.Parse(soMoi2TextBox.Text) < int.Parse(soCu2TextBox.Text))
                            {
                                DialogResult = MessageBox.Show("Số công tơ mới nhỏ hơn số công tơ cũ trong công tơ thay thế!\n\nNếu bạn chắc chắn đã nhập đúng thì hãy nhấn nút OK, chương trình sẽ tự động tính theo trường hợp công tơ hết vòng số.\nCòn nếu bạn phát hiện đây là nhầm lẫn, hãy bấm Cancel và sửa lại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                if (DialogResult == DialogResult.OK)
                                {
                                    createInvoice();
                                }
                                else
                                {
                                    soMoi2TextBox.Focus();
                                    soMoi2TextBox.SelectAll();
                                }
                            }
                            else
                            {
                                createInvoice();
                            }
                        }
                        else
                        {
                            createInvoice();
                        }
                    }
                }
            }
        }

        private void tramComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (tramComboBox.Items.Count > 0)
            {
                fillSTTKH();
            }
        }

        private void thangComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (tramComboBox.Items.Count > 0)
            {
                fillSTTKH();
            }
        }

        private void namComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (tramComboBox.Items.Count > 0)
            {
                fillSTTKH();
            }
        }

        private void soThuTuComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (soThuTuComboBox.Items.Count > 0)
            {
                fillKHDetails();
            }
        }

        private void suaSoCuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (suaSoCuCheckBox.Checked)
            {
                soCuTextBox.Enabled = true;
                soCuTextBox.Focus();
                soCuTextBox.SelectAll();
            }
            else
            {
                soCuTextBox.Enabled = false;
            }
        }

        private void heSoNhanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (heSoNhanCheckBox.Checked)
            {
                heSoNhanTextBox.Enabled = true;
                heSoNhanTextBox.Focus();
                heSoNhanTextBox.SelectAll();
            }
            else
            {
                heSoNhanTextBox.Enabled = false;
            }
        }

        private void congToChetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (congToChetCheckBox.Checked)
            {
                congToChetGroupBox.Visible = true;
            }
            else
            {
                congToChetGroupBox.Visible = false;
                soCu2TextBox.Text = "0";
                soMoi2TextBox.Text = "0";
            }
        }

        private void mayInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mayInCheckBox.Checked == false && vanBanCheckBox.Checked == false)
            {
                xuatHoaDonButton.Text = "     &Lưu Hóa Đơn";
                printToolStripMenuItem.Text = "     &Lưu Hóa Đơn";
            }
            else
            {
                xuatHoaDonButton.Text = "    &Xuất Hóa Đơn";
                printToolStripMenuItem.Text = "    &Xuất Hóa Đơn";
            }
        }

        private void vanBanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vanBanCheckBox.Checked)
            {
                pathTextBox.Enabled = true;
                changePathButton.Enabled = true;
                changePathToolStripMenuItem.Enabled = true;
            }
            else
            {
                pathTextBox.Enabled = false;
                changePathButton.Enabled = false;
                changePathToolStripMenuItem.Enabled = false;
            }
            if (mayInCheckBox.Checked == false && vanBanCheckBox.Checked == false)
            {
                xuatHoaDonButton.Text = "     &Lưu Hóa Đơn";
                printToolStripMenuItem.Text = "     &Lưu Hóa Đơn";
            }
            else
            {
                xuatHoaDonButton.Text = "    &Xuất Hóa Đơn";
                printToolStripMenuItem.Text = "    &Xuất Hóa Đơn";
            }
        }

        private void soCuTextBox_Leave(object sender, EventArgs e)
        {
            suaSoCuCheckBox.Checked = false;
        }

        private void heSoNhanTextBox_Leave(object sender, EventArgs e)
        {
            heSoNhanCheckBox.Checked = false;
        }

        private void changePathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.savePath = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
                pathTextBox.Text = Settings.Default.savePath;
            }
        }

        private void fillTram()
        {
            tramComboBox.DataSource = DataTier.getStation();
            tramComboBox.DisplayMember = "Name";
            tramComboBox.ValueMember = "StationID";
            if (tramComboBox.Items.Count > 0)
            {
                tramComboBox.SelectedIndex = 0;
                fillSTTKH();
            }
            else
            {
                soThuTuComboBox.DataSource = null;
                soThuTuComboBox.Items.Clear();
                clearTextBoxes();
            }
            fillGiaDien();
        }

        private void fillSTTKH()
        {
            DataTable khachHangCLHD = DataTier.getUnbilledCustomer(tramComboBox.SelectedValue.ToString(), int.Parse(thangComboBox.Text), int.Parse(namComboBox.Text));
            soThuTuComboBox.DataSource = khachHangCLHD;
            soThuTuComboBox.DisplayMember = "CustomerNumber";
            soThuTuComboBox.ValueMember = "CustomerID";
            if (soThuTuComboBox.Items.Count > 0)
            {
                soThuTuComboBox.SelectedIndex = 0;
                fillKHDetails();
                xuatHoaDonButton.Visible = true;
                printToolStripMenuItem.Enabled = true;
                mayInCheckBox.Enabled = true;
                vanBanCheckBox.Enabled = true;
            }
            else
            {
                soThuTuComboBox.Text = string.Empty;
                clearTextBoxes();
                xuatHoaDonButton.Visible = false;
                printToolStripMenuItem.Enabled = false;
                mayInCheckBox.Enabled = false;
                vanBanCheckBox.Enabled = false;
            }
            soKhachTrongTram = DataTier.XacDinhSTTMax(tramComboBox.SelectedValue.ToString());
            messageLabel.Text = "Có " + khachHangCLHD.Rows.Count.ToString() + " khách chưa lập hóa đơn trong tháng " + thangComboBox.Text + "/" + namComboBox .Text;
        }

        private void fillKHDetails()
        {
            tenKhachTextBox.DataBindings.Clear();
            diaChiTextBox.DataBindings.Clear();
            soHoKhauTextBox.DataBindings.Clear();
            maSoThueTextBox.DataBindings.Clear();

            Object khachHangDetails = DataTier.getCustomerDetails(soThuTuComboBox.SelectedValue.ToString());
            tenKhachTextBox.DataBindings.Add("Text", khachHangDetails, "Name");
            diaChiTextBox.DataBindings.Add("Text", khachHangDetails, "Address");
            soHoKhauTextBox.DataBindings.Add("Text", khachHangDetails, "HKNumber");
            maSoThueTextBox.DataBindings.Add("Text", khachHangDetails, "TaxNumber");

            fillSoCu();
        }

        private void fillSoCu()
        {
            string[] soCu = DataTier.getOldNumber(soThuTuComboBox.SelectedValue.ToString(), int.Parse(thangComboBox.Text), int.Parse(namComboBox.Text));
            soCuTextBox.Text = soCu[0];
            heSoNhanTextBox.Text = soCu[1];
            if (soCu[2] == "a770acf2-0f54-43ce-8695-10c7c4072c64")
            {
                poorRadioButton.Checked = true;
            }
            else if (soCu[2] == "7e17ce3d-ea0c-4a6a-9048-47c563991fd6")
            {
                lowIncomeRadioButton.Checked = true;
            }
            else if (soCu[2] == "e00f133e-f43c-4dc5-8ebb-a747200416c9")
            {
                sinhHoatRadioButton.Checked = true;
            }
            else if (soCu[2] == "068b5479-814c-4576-86ea-8684b07ffb4a")
            {
                hanhChinhRadioButton.Checked = true;
            }
            else if (soCu[2] == "0cd8fc10-1369-4b21-9c59-806ada969bdb")
            {
                kinhDoanh1RadioButton.Checked = true;
            }
            else if (soCu[2] == "3f4627cb-3ae3-4fcf-86e1-117b1dfcac4d")
            {
                kinhDoanh2RadioButton.Checked = true;
            }
            else if (soCu[2] == "a8794644-b056-41dd-b515-bec60477947a")
            {
                sanXuat1RadioButton.Checked = true;
            }
            else if (soCu[2] == "d4770373-51bb-4d7a-90d1-327c7043cdeb")
            {
                sanXuat2RadioButton.Checked = true;
            }
            else if (soCu[2] == "422cf080-b750-411d-a895-9550b8950b66")
            {
                sanXuat3RadioButton.Checked = true;
            }
            poorRadioButton.Enabled = true;
            lowIncomeRadioButton.Enabled = true;
        }

        private void fillGiaDien()
        {
            giaPoorLabel.Text = DataTier.getPrice("a770acf2-0f54-43ce-8695-10c7c4072c64");
            giaLowIncome.Text = DataTier.getPrice("7e17ce3d-ea0c-4a6a-9048-47c563991fd6");
            String[] giaSH = DataTier.getPrice("e00f133e-f43c-4dc5-8ebb-a747200416c9").Split(',');
            giaSH1Label.Text = giaSH[0];
            giaSH2Label.Text = giaSH[1];
            giaSH3Label.Text = giaSH[2];
            giaSH4Label.Text = giaSH[3];
            giaSH5Label.Text = giaSH[4];
            giaSH6Label.Text = giaSH[5];
            giaHCLabel.Text = DataTier.getPrice("068b5479-814c-4576-86ea-8684b07ffb4a");
            giaKD1Label.Text = DataTier.getPrice("0cd8fc10-1369-4b21-9c59-806ada969bdb");
            giaKD2Label.Text = DataTier.getPrice("3f4627cb-3ae3-4fcf-86e1-117b1dfcac4d");
            giaSX1Label.Text = DataTier.getPrice("a8794644-b056-41dd-b515-bec60477947a");
            giaSX2Label.Text = DataTier.getPrice("d4770373-51bb-4d7a-90d1-327c7043cdeb");
            giaSX3Label.Text = DataTier.getPrice("422cf080-b750-411d-a895-9550b8950b66");
        }

        private void clearTextBoxes()
        {
            tenKhachTextBox.Clear();
            diaChiTextBox.Clear();
            soHoKhauTextBox.Clear();
            maSoThueTextBox.Clear();
            noCuTextBox.Text = "0";
            soCuTextBox.Clear();
            soMoiTextBox.Clear();
            soCu2TextBox.Clear();
            soMoi2TextBox.Clear();
            heSoNhanTextBox.Clear();
        }

        private bool checkSTTKH()
        {
            errorProvider.Clear();
            bool result = false;
            if (soThuTuComboBox.Text == string.Empty)
            {
                errorProvider.SetError(soThuTuComboBox, "Số thứ tự không thể bỏ trống, bạn hãy nhập lại!");
                errorProvider.SetIconAlignment(soThuTuComboBox, ErrorIconAlignment.MiddleLeft);
            }
            else
            {
                try
                {
                    if (int.Parse(soThuTuComboBox.Text) <= 0 || int.Parse(soThuTuComboBox.Text) > soKhachTrongTram)
                    {
                        errorProvider.SetError(soThuTuComboBox, "Không có khách hàng nào có số thứ tự là \"" + soThuTuComboBox.Text + "\" trong trạm này!");
                        errorProvider.SetIconAlignment(soThuTuComboBox, ErrorIconAlignment.MiddleLeft);
                    }
                    else
                    {
                        if (soThuTuComboBox.SelectedValue == null)
                        {
                            errorProvider.SetError(soThuTuComboBox, "Số thứ tự khách hàng không đúng với tên khách, bạn hãy chọn lại!\n\nSau khi nhập số thứ tự khách hàng, bạn phải bấm phím mũi tên xuống\nđể chương trình tải đúng khách hàng với số thứ tự mà bạn vừa nhập vào.");
                            errorProvider.SetIconAlignment(soThuTuComboBox, ErrorIconAlignment.MiddleLeft);
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
                catch
                {
                    errorProvider.SetError(soThuTuComboBox, "Số thứ tự khách hàng phải là số nguyên!");
                    errorProvider.SetIconAlignment(soThuTuComboBox, ErrorIconAlignment.MiddleLeft);
                }
            }
            return result;
        }

        private bool checkInput()
        {
            bool result = false;
            if (tenKhachTextBox.Text == string.Empty)
            {
                errorProvider.SetError(tenKhachTextBox, "Tên khách không thể bỏ trống, mời bạn nhập lại!");
                errorProvider.SetIconAlignment(tenKhachTextBox, ErrorIconAlignment.MiddleLeft);
                tenKhachTextBox.Focus();
            }
            else if (poorRadioButton.Checked == false && lowIncomeRadioButton.Checked == false && sinhHoatRadioButton.Checked == false && hanhChinhRadioButton.Checked == false && kinhDoanh1RadioButton.Checked == false && kinhDoanh2RadioButton.Checked == false && sanXuat1RadioButton.Checked == false && sanXuat2RadioButton.Checked == false && sanXuat3RadioButton.Checked == false/* && sanXuat4RadioButton.Checked == false*/)
            {
                errorProvider.SetError(mucDichGroupBox, "Bạn chưa chọn mục đích sử dụng điện!");
            }
            else if (soCuTextBox.Text == string.Empty)
            {
                errorProvider.SetError(soCuTextBox, "Số công tơ cũ không thể bỏ trống!");
            }
            else if (soMoiTextBox.Text == string.Empty)
            {
                errorProvider.SetError(soMoiTextBox, "Số công tơ mới không thể bỏ trống!");
            }
            else if (heSoNhanTextBox.Text == string.Empty)
            {
                errorProvider.SetError(heSoNhanTextBox, "Hệ số nhân không thể bỏ trống!");
            }
            else
            {
                try
                {
                    if (int.Parse(soCuTextBox.Text) < 0)
                    {
                        errorProvider.SetError(soCuTextBox, "Số công tơ cũ phải lớn hơn hoặc bằng 0!");
                    }
                    else
                    {
                        try
                        {
                            if (int.Parse(soMoiTextBox.Text) < 0)
                            {
                                errorProvider.SetError(soMoiTextBox, "Số công tơ mới phải lớn hơn hoặc bằng 0!");
                            }
                            else
                            {
                                try
                                {
                                    if (int.Parse(heSoNhanTextBox.Text) <= 0)
                                    {
                                        errorProvider.SetError(heSoNhanTextBox, "Hệ số nhân phải lớn hơn 0!");
                                    }
                                    else
                                    {
                                        if (congToChetCheckBox.Checked)
                                        {
                                            if (soCu2TextBox.Text == string.Empty)
                                            {
                                                errorProvider.SetError(soCu2TextBox, "Số công tơ cũ thay thế không thể bỏ trống!");
                                                errorProvider.SetIconAlignment(soCu2TextBox, ErrorIconAlignment.MiddleLeft);
                                            }
                                            else if (soMoi2TextBox.Text == string.Empty)
                                            {
                                                errorProvider.SetError(soMoi2TextBox, "Số công tơ mới thay thế không thể bỏ trống!");
                                                errorProvider.SetIconAlignment(soMoi2TextBox, ErrorIconAlignment.MiddleLeft);
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    if (int.Parse(soCu2TextBox.Text) < 0)
                                                    {
                                                        errorProvider.SetError(soCu2TextBox, "Số công tơ cũ thay thế phải lớn hơn hoặc bằng 0!");
                                                        errorProvider.SetIconAlignment(soCu2TextBox, ErrorIconAlignment.MiddleLeft);
                                                    }
                                                    else
                                                    {
                                                        try
                                                        {
                                                            if (int.Parse(soMoi2TextBox.Text) < 0)
                                                            {
                                                                errorProvider.SetError(soMoi2TextBox, "Số công tơ mới thay thế phải lớn hơn hoặc bằng 0!");
                                                                errorProvider.SetIconAlignment(soMoi2TextBox, ErrorIconAlignment.MiddleLeft);
                                                            }
                                                            else
                                                            {
                                                                try
                                                                {
                                                                    if (noCuTextBox.Text == String.Empty)
                                                                    {
                                                                        noCuTextBox.Text = "0";
                                                                        result = true;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (int.Parse(noCuTextBox.Text) < 0)
                                                                        {
                                                                            errorProvider.SetError(noCuTextBox, "Số nợ cũ phải lớn hơn hoặc bằng 0!");
                                                                            errorProvider.SetIconAlignment(noCuTextBox, ErrorIconAlignment.MiddleLeft);
                                                                        }
                                                                        else
                                                                        {
                                                                        result = true;
                                                                        }
                                                                    }
                                                                }
                                                                catch
                                                                {
                                                                    errorProvider.SetError(noCuTextBox, "Số nợ cũ phải là số nguyên!");
                                                                    errorProvider.SetIconAlignment(noCuTextBox, ErrorIconAlignment.MiddleLeft);
                                                                }
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            errorProvider.SetError(soMoi2TextBox, "Số công tơ mới thay thế phải là số nguyên!");
                                                            errorProvider.SetIconAlignment(soMoi2TextBox, ErrorIconAlignment.MiddleLeft);
                                                        }
                                                    }
                                                }
                                                catch
                                                {
                                                    errorProvider.SetError(soCu2TextBox, "Số công tơ cũ thay thế phải là số nguyên!");
                                                    errorProvider.SetIconAlignment(soCu2TextBox, ErrorIconAlignment.MiddleLeft);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if (noCuTextBox.Text == String.Empty)
                                                {
                                                    noCuTextBox.Text = "0";
                                                    result = true;
                                                }
                                                else
                                                {
                                                    if (int.Parse(noCuTextBox.Text) < 0)
                                                    {
                                                        errorProvider.SetError(noCuTextBox, "Số nợ cũ phải lớn hơn hoặc bằng 0!");
                                                        errorProvider.SetIconAlignment(noCuTextBox, ErrorIconAlignment.MiddleLeft);
                                                    }
                                                    else
                                                    {
                                                        result = true;
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                errorProvider.SetError(noCuTextBox, "Số nợ cũ phải là số nguyên!");
                                                errorProvider.SetIconAlignment(noCuTextBox, ErrorIconAlignment.MiddleLeft);
                                            }
                                        }
                                    }
                                }
                                catch
                                {
                                    errorProvider.SetError(heSoNhanTextBox, "Hệ số nhân phải là số nguyên!");
                                }
                            }
                        }
                        catch
                        {
                            errorProvider.SetError(soMoiTextBox, "Số công tơ mới phải là số nguyên!");
                        }
                    }
                }
                catch
                {
                    errorProvider.SetError(soCuTextBox, "Số công tơ cũ phải là số nguyên!");
                }
            }
            return result;
        }

        private void createInvoice()
        {
            try 
            {
                string mucDichID = "";
                string mucDichSD = "";
                if (poorRadioButton.Checked)
                {
                    mucDichID = "a770acf2-0f54-43ce-8695-10c7c4072c64";
                    mucDichSD = "Hộ nghèo";
                }
                else if (lowIncomeRadioButton.Checked)
                {
                    mucDichID = "7e17ce3d-ea0c-4a6a-9048-47c563991fd6";
                    mucDichSD = "Hộ thu nhập thấp";
                }
                else if (sinhHoatRadioButton.Checked)
                {
                    mucDichID = "e00f133e-f43c-4dc5-8ebb-a747200416c9";
                    mucDichSD = "Sinh hoạt";
                }
                else if (hanhChinhRadioButton.Checked)
                {
                    mucDichID = "068b5479-814c-4576-86ea-8684b07ffb4a";
                    mucDichSD = "Hành chính";
                }
                else if (kinhDoanh1RadioButton.Checked)
                {
                    mucDichID = "0cd8fc10-1369-4b21-9c59-806ada969bdb";
                    mucDichSD = "Kinh doanh 1";
                }
                else if (kinhDoanh2RadioButton.Checked)
                {
                    mucDichID = "3f4627cb-3ae3-4fcf-86e1-117b1dfcac4d";
                    mucDichSD = "Kinh doanh 2";
                }
                else if (sanXuat1RadioButton.Checked)
                {
                    mucDichID = "a8794644-b056-41dd-b515-bec60477947a";
                    mucDichSD = "Sản xuất 1";
                }
                else if (sanXuat2RadioButton.Checked)
                {
                    mucDichID = "d4770373-51bb-4d7a-90d1-327c7043cdeb";
                    mucDichSD = "Sản xuất 2";
                }
                else if (sanXuat3RadioButton.Checked)
                {
                    mucDichID = "422cf080-b750-411d-a895-9550b8950b66";
                    mucDichSD = "Sản xuất 3";
                }
                Customer kh = new Customer(soThuTuComboBox.SelectedValue.ToString(), tenKhachTextBox.Text, diaChiTextBox.Text, soHoKhauTextBox.Text, maSoThueTextBox.Text);
                if (!kh.edit())
                {
                    MessageBox.Show("Việc thay đổi thông tin của khách hàng đã thất bại!\nBạn hãy thử thay đổi thông tin khách hàng trong form khách hàng rồi quay lại làm lại hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    Invoice hoaDon;
                    if (congToChetCheckBox.Checked == true)
                    {
                        hoaDon = new Invoice(soThuTuComboBox.SelectedValue.ToString(), mucDichID, int.Parse(thangComboBox.Text), int.Parse(namComboBox.Text), int.Parse(soCuTextBox.Text), int.Parse(soMoiTextBox.Text), int.Parse(soCu2TextBox.Text), int.Parse(soMoi2TextBox.Text), int.Parse(heSoNhanTextBox.Text), int.Parse(noCuTextBox.Text), 0);
                    }
                    else
                    {
                        hoaDon = new Invoice(soThuTuComboBox.SelectedValue.ToString(), mucDichID, int.Parse(thangComboBox.Text), int.Parse(namComboBox.Text), int.Parse(soCuTextBox.Text), int.Parse(soMoiTextBox.Text), 0, 0, int.Parse(heSoNhanTextBox.Text), int.Parse(noCuTextBox.Text), 0);
                    }
                    Program.tinhHoaDon(tramComboBox.Text.Split(' '), hoaDon.NewNumber, hoaDon.OldNumber, hoaDon.NewNumber2, hoaDon.OldNumber2, hoaDon.Multiplier, poorRadioButton.Checked, giaPoorLabel.Text, lowIncomeRadioButton.Checked, giaLowIncome.Text, sinhHoatRadioButton.Checked, DataTier.getPrice("e00f133e-f43c-4dc5-8ebb-a747200416c9").Split(','), hanhChinhRadioButton.Checked, giaHCLabel.Text, kinhDoanh1RadioButton.Checked, giaKD1Label.Text, kinhDoanh2RadioButton.Checked, giaKD2Label.Text, sanXuat1RadioButton.Checked, giaSX1Label.Text, sanXuat2RadioButton.Checked, giaSX2Label.Text, sanXuat3RadioButton.Checked, giaSX3Label.Text, thangComboBox.Text, namComboBox.Text, int.Parse(noCuTextBox.Text));
                    string title = "Hóa đơn của khách hàng số " + soThuTuComboBox.Text + ", " + tramComboBox.Text + ", tháng " + thangComboBox.Text + ", năm " + namComboBox.Text + ", mục đích " + mucDichSD;
                    if (mucDichSD == "Sinh hoạt")
                    {
                        Program.fillKetQuaSH(ketQuaSH);
                        ketQuaSH.Text = title;
                        dialogResult = ketQuaSH.ShowDialog();
                    }
                    else if (mucDichSD == "Sản xuất 3")
                    {
                        ketQuaSX3Form.mucDichSD = mucDichSD;
                        Program.fillKetQuaSX3(ketQuaSX3);
                        ketQuaSX3.Text = title;
                        dialogResult = ketQuaSX3.ShowDialog();
                    }
                    else
                    {
                        ketQuaMDKForm.mucDichSD = mucDichSD;
                        Program.fillKetQuaMDK(ketQuaMDK);
                        if (mucDichSD == "Hộ nghèo" || mucDichSD == "Hộ thu nhập thấp")
                        {
                            title = "Hóa đơn của khách hàng số " + soThuTuComboBox.Text + ", " + tramComboBox.Text + ", tháng " + thangComboBox.Text + ", năm " + namComboBox.Text + " (" + mucDichSD + ")";
                        }
                        ketQuaMDK.Text = title;
                        dialogResult = ketQuaMDK.ShowDialog();
                    }
                    if (dialogResult == DialogResult.OK)
                    {
                        if (hoaDon.createHoaDon())
                        {
                            if (mayInCheckBox.Checked)
                            {
                                if (mucDichSD == "Sản xuất 3")
                                {
                                    hd2 = new PrintInvoiceSX3();
                                    Program.fillPrintHDSX3(hoaDon.getHoaDonID(), hd2);
                                    hd2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                                    hd2.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                                    hd2.PrintToPrinter(1, false, 1, 1);
                                    hd2.Dispose();
                                }
                                else
                                {
                                    hd = new PrintInvoice();
                                    Program.fillPrintHD(hoaDon.getHoaDonID(), hd);
                                    hd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                                    hd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                                    hd.PrintToPrinter(1, false, 1, 1);
                                    hd.Dispose();
                                }
                            }
                            if (vanBanCheckBox.Checked)
                            {
                                if (mucDichSD == "Sản xuất 3")
                                {
                                    hd2 = new PrintInvoiceSX3();
                                    Program.fillPrintHDSX3(hoaDon.getHoaDonID(), hd2);
                                    hd2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                                    hd2.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                                    string[] tram = tramComboBox.Text.Split(' ');
                                    hd2.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, pathTextBox.Text + "\\HD so " + soThuTuComboBox.Text + " - tram " + tram[1].ToString() + " - thang " + thangComboBox.Text + " - nam " + namComboBox.Text + ".doc");
                                    hd2.Dispose();
                                }
                                else
                                {
                                    hd = new PrintInvoice();
                                    Program.fillPrintHD(hoaDon.getHoaDonID(), hd);
                                    hd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                                    hd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                                    string[] tram = tramComboBox.Text.Split(' ');
                                    hd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, pathTextBox.Text + "\\HD so " + soThuTuComboBox.Text + " - tram " + tram[1].ToString() + " - thang " + thangComboBox.Text + " - nam " + namComboBox.Text + ".doc");
                                    hd.Dispose();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xuất hóa đơn thất bại! Bạn hãy thử nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Xuất hóa đơn thất bại! Bạn hãy thử nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show(ex.Message);
            }
            clearTextBoxes();
            congToChetCheckBox.Checked = false;
            fillSTTKH();
            soMoiTextBox.Focus();
        }

        private void poorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (poorRadioButton.Checked == true)
            {
                hanhChinhRadioButton.Checked = false;
                kinhDoanh1RadioButton.Checked = false;
                kinhDoanh2RadioButton.Checked = false;
                sanXuat1RadioButton.Checked = false;
                sanXuat2RadioButton.Checked = false;
                sanXuat3RadioButton.Checked = false;
            }
        }

        private void lowIncomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lowIncomeRadioButton.Checked == true)
            {
                hanhChinhRadioButton.Checked = false;
                kinhDoanh1RadioButton.Checked = false;
                kinhDoanh2RadioButton.Checked = false;
                sanXuat1RadioButton.Checked = false;
                sanXuat2RadioButton.Checked = false;
                sanXuat3RadioButton.Checked = false;
            }
        }

        private void sinhHoatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sinhHoatRadioButton.Checked == true)
            {
                hanhChinhRadioButton.Checked = false;
                kinhDoanh1RadioButton.Checked = false;
                kinhDoanh2RadioButton.Checked = false;
                sanXuat1RadioButton.Checked = false;
                sanXuat2RadioButton.Checked = false;
                sanXuat3RadioButton.Checked = false;
            }
        }

        private void hanhChinhRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hanhChinhRadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
            }
        }

        private void kinhDoanh1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kinhDoanh1RadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
            }
        }

        private void kinhDoanh2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kinhDoanh2RadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
            }
        }

        private void sanXuat1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sanXuat1RadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
            }
        }

        private void sanXuat2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sanXuat2RadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
            }
        }

        private void sanXuat3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sanXuat3RadioButton.Checked == true)
            {
                poorRadioButton.Checked = false;
                lowIncomeRadioButton.Checked = false;
                sinhHoatRadioButton.Checked = false;
                SX3Label.Text = "30% giá " + giaKD1Label.Text + ", 70% giá " + giaSX3Label.Text;
            }
            else
            {
                SX3Label.Text = "";
            }
        }

        private void autoIdentify()
        {
            try
            {
                int dienNangTT = Program.tinhDienNangTT(int.Parse(soMoiTextBox.Text), int.Parse(soCuTextBox.Text), int.Parse(soMoi2TextBox.Text), int.Parse(soCu2TextBox.Text), int.Parse(heSoNhanTextBox.Text));
                if (dienNangTT > 50)
                {
                    poorRadioButton.Enabled = false;
                    lowIncomeRadioButton.Enabled = false;
                    if (poorRadioButton.Checked == true || lowIncomeRadioButton.Checked == true)
                    {
                        poorRadioButton.Checked = false;
                        lowIncomeRadioButton.Checked = false;
                        sinhHoatRadioButton.Checked = true;
                    }
                }
                else
                {
                    poorRadioButton.Enabled = true;
                    lowIncomeRadioButton.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void soMoiTextBox_TextChanged(object sender, EventArgs e)
        {
            autoIdentify();
        }

        private void noCuTextBox_Leave(object sender, EventArgs e)
        {
            if (noCuTextBox.Text == String.Empty)
            {
                noCuTextBox.Text = "0";
            }
        }
    }
}