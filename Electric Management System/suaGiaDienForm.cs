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
    public partial class suaGiaDienForm : Form
    {
        public int mucDichID;
        public string hoaDon;
        public string hoaDonID;
        public string giaDien;

        public suaGiaDienForm()
        {
            InitializeComponent();
        }

        private void SHTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String[] giaSH = SHTextBox.Text.Split(',');
                SH1TextBox.Text = giaSH[0].ToString();
                SH2TextBox.Text = giaSH[1].ToString();
                SH3TextBox.Text = giaSH[2].ToString();
                SH4TextBox.Text = giaSH[3].ToString();
                SH5TextBox.Text = giaSH[4].ToString();
                SH6TextBox.Text = giaSH[5].ToString();
            }
            catch
            {
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (checkInput(SH1TextBox) && checkInput(SH2TextBox) && checkInput(SH3TextBox) && checkInput(SH4TextBox) && checkInput(SH5TextBox) && checkInput(SH6TextBox) && checkInput(HCTextBox) && checkInput(KD1TextBox) && checkInput(KD2TextBox) && checkInput(SX1TextBox) && checkInput(SX2TextBox) && checkInput(SX3TextBox))
            {
                DataTier.editCurrentPrice("a770acf2-0f54-43ce-8695-10c7c4072c64", ngheoTextBox.Text);
                DataTier.editCurrentPrice("7e17ce3d-ea0c-4a6a-9048-47c563991fd6", tntTextBox.Text);
                DataTier.editCurrentPrice("e00f133e-f43c-4dc5-8ebb-a747200416c9", SH1TextBox.Text + "," + SH2TextBox.Text + "," + SH3TextBox.Text + "," + SH4TextBox.Text + "," + SH5TextBox.Text + "," + SH6TextBox.Text);
                DataTier.editCurrentPrice("068b5479-814c-4576-86ea-8684b07ffb4a", HCTextBox.Text);
                DataTier.editCurrentPrice("0cd8fc10-1369-4b21-9c59-806ada969bdb", KD1TextBox.Text);
                DataTier.editCurrentPrice("3f4627cb-3ae3-4fcf-86e1-117b1dfcac4d", KD2TextBox.Text);
                DataTier.editCurrentPrice("a8794644-b056-41dd-b515-bec60477947a", SX1TextBox.Text);
                DataTier.editCurrentPrice("d4770373-51bb-4d7a-90d1-327c7043cdeb", SX2TextBox.Text);
                DataTier.editCurrentPrice("422cf080-b750-411d-a895-9550b8950b66", SX3TextBox.Text);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillCurrentPrice()
        {
            ngheoTextBox.Text = DataTier.getPrice("a770acf2-0f54-43ce-8695-10c7c4072c64");
            tntTextBox.Text = DataTier.getPrice("7e17ce3d-ea0c-4a6a-9048-47c563991fd6");
            SHTextBox.Text = DataTier.getPrice("e00f133e-f43c-4dc5-8ebb-a747200416c9");
            //CCTextBox.Text = DataTier.getGiaDien(2);
            HCTextBox.Text = DataTier.getPrice("068b5479-814c-4576-86ea-8684b07ffb4a");
            KD1TextBox.Text = DataTier.getPrice("0cd8fc10-1369-4b21-9c59-806ada969bdb");
            KD2TextBox.Text = DataTier.getPrice("3f4627cb-3ae3-4fcf-86e1-117b1dfcac4d");
            SX1TextBox.Text = DataTier.getPrice("a8794644-b056-41dd-b515-bec60477947a");
            SX2TextBox.Text = DataTier.getPrice("d4770373-51bb-4d7a-90d1-327c7043cdeb");
            SX3TextBox.Text = DataTier.getPrice("422cf080-b750-411d-a895-9550b8950b66");
            //giaSX4Label.Text = DataTier.getGiaDien(9);
        }

        private bool checkInput(TextBox priceTextBox)
        {
            errorProvider1.Clear();
            bool result = false;
            if (priceTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(priceTextBox, "Giá điện không được bỏ trống!");
            }
            else
            {
                try
                {
                    if (int.Parse(priceTextBox.Text) <= 0)
                    {
                        errorProvider1.SetError(priceTextBox, "Giá điện phải lớn hơn 0!");
                    }
                    else
                    {
                        result = true;
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(priceTextBox, "Giá điện phải là kiểu số nguyên!");
                }
            }
            errorProvider1.SetIconAlignment(priceTextBox, ErrorIconAlignment.MiddleLeft);
            return result;
        }

        private void suaGiaDienForm_Load(object sender, EventArgs e)
        {
            fillCurrentPrice();
        }
    }
}