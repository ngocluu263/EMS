using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Electric_Management_System.App_Code;
using Electric_Management_System.Properties;
using System.Configuration;

namespace Electric_Management_System
{
    public partial class changeInvoiceForm : Form
    {
        public changeInvoiceForm()
        {
            InitializeComponent();
        }

        private void changeInvoiceForm_Load(object sender, EventArgs e)
        {
            if (Program.isUsingOldInvoice())
            {
                rdOldInvoice.Checked = true;
                rdNewInvoice.Checked = false;
            }
            else
            {
                rdOldInvoice.Checked = false;
                rdNewInvoice.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdOldInvoice.Checked)
                {
                    Settings.Default.InvoiceType = "old";
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.InvoiceType = "new";
                    Settings.Default.Save();
                }

                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thay đổi hóa đơn, mời bạn thử lại sau: " + ex.Message);
            }
        }
    }
}