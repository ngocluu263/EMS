using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Electric_Management_System.App_Code;
using Electric_Management_System.Properties;
using Electric_Management_System.Reports;
using Microsoft.VisualBasic.ApplicationServices;

namespace Electric_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainForm());
            SingleInstance.SingleInstanceApplication.Run(new mainForm());
        }

        //public static Boolean loggedIn;
        //public static String password;

        public static string moneyReader(string money)
        {
            long moneyNumber = long.Parse(money);
            if (money.Length > 12)
            {
                MessageBox.Show("Không đọc được số tiền quá lớn", "Co Loi Xay Ra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return "";
            }

            if (moneyNumber == 0)
            {
                return "Không";
            }

            string[] numbers = new string[10];
            numbers[1] = " một";
            numbers[2] = " hai";
            numbers[3] = " ba";
            numbers[4] = " bốn";
            numbers[5] = " năm";
            numbers[6] = " sáu";
            numbers[7] = " bảy";
            numbers[8] = " tám";
            numbers[9] = " chín";

            string[] digit = new string[5];
            digit[2] = " nghìn";
            digit[3] = " triệu";
            digit[4] = " tỷ";

            string text = "";
            int index = 1;
            int underThoundsand = 0;
            int unit = 0;
            int ten = 0;
            int hundred = 0;

            while (index < 5)
            {
                long temp = moneyNumber % 1000;
                underThoundsand = int.Parse(temp.ToString());
                moneyNumber = moneyNumber / 1000;
                unit = underThoundsand % 10;
                ten = underThoundsand / 10 % 10;
                hundred = underThoundsand / 100;

                if (text.Length > 12 && underThoundsand != 0)
                {
                    text = digit[index] + "," + text;
                }

                if (text.Length < 12 && underThoundsand != 0)
                {
                    text = digit[index] + text;
                }

                index += 1;
                if (index > 1)
                {
                    switch (unit)
                    {
                        case 1:
                            if (ten > 1)
                            {
                                text = " mốt" + text;
                            }
                            else
                            {
                                text = " một" + text;
                            }
                            break;
                        case 5:
                            if (ten == 0)
                            {
                                text = " năm" + text;
                            }
                            else
                            {
                                text = " lăm" + text;
                            }
                            break;
                        //case 4:
                        //    if (text.Length > 1)
                        //    {
                        //        text = " tư" + text;
                        //    }
                        //    else
                        //    {
                        //        text = " bốn" + text;
                        //    }
                        //    break;
                        default:
                            text = numbers[unit] + text;
                            break;
                    }
                    switch (ten)
                    {
                        case 1:
                            text = " mười" + text;
                            break;
                        case 0:
                            if ((moneyNumber != 0 || hundred != 0) && unit != 0)
                            {
                                text = " linh" + text;
                            }
                            break;
                        default:
                            text = numbers[ten] + " mươi" + text;
                            break;
                    }
                }
                switch (hundred)
                {
                    case 0:
                        if (moneyNumber != 0 && (unit != 0 || ten != 0))
                        {
                            text = " không trăm" + text;
                        }
                        if (moneyNumber != 0 && index > 2 && underThoundsand == 0 && unit == 0 && ten == 0 && hundred == 0 && text.Length <= 12)
                        {
                            text += text;
                        }
                        break;
                    default:
                        text = numbers[hundred] + " trăm" + text;
                        break;
                }

            }
            return text.Trim(' ').Substring(0, 1).ToUpper() + text.Substring(text.Length - (text.Trim(' ').Length - 1)) + " đồng";
        }

        private static string soTram;
        private static long dienNangTT;
        private static long soDien;
        private static long soDienSX3_2;
        private static long mucSH1;
        private static long mucSH2;
        private static long mucSH3;
        private static long mucSH4;
        private static long mucSH5;
        private static long mucSH6;
        private static long giaDien;
        private static long giaDienSX3_2;
        private static long giaSH1;
        private static long giaSH2;
        private static long giaSH3;
        private static long giaSH4;
        private static long giaSH5;
        private static long giaSH6;
        private static long tienDien;
        private static long tienDienSX3_2;
        private static long tienSH1;
        private static long tienSH2;
        private static long tienSH3;
        private static long tienSH4;
        private static long tienSH5;
        private static long tienSH6;
        private static long tongTienDien;
        private static long thueGTGT;
        private static long tongTienSauThue;
        private static long noCu;
        private static long tongTienThanhToan;
        private static string docChu;
        private static string ngayBatDau;
        private static string ngayKetThuc;
        private static string ngayLapHD;
        private static string thangLapHD;
        private static string namLapHD;
        private static string ngayKy;
        private static string thangKy;
        private static string namKy;

        private static void clearHDValues()
        {
            soTram = "";
            dienNangTT = 0;
            soDien = 0;
            mucSH1 = 0;
            mucSH2 = 0;
            mucSH3 = 0;
            mucSH4 = 0;
            mucSH5 = 0;
            mucSH6 = 0;
            giaDien = 0;
            giaSH1 = 0;
            giaSH2 = 0;
            giaSH3 = 0;
            giaSH4 = 0;
            giaSH5 = 0;
            giaSH6 = 0;
            tienDien = 0;
            tienSH1 = 0;
            tienSH2 = 0;
            tienSH3 = 0;
            tienSH4 = 0;
            tienSH5 = 0;
            tienSH6 = 0;
            tongTienDien = 0;
            thueGTGT = 0;
            tongTienSauThue = 0;
            noCu = 0;
            tongTienThanhToan = 0;
            docChu = "";
            ngayBatDau = "";
            ngayKetThuc = "";
            ngayLapHD = "";
            thangLapHD = "";
            namLapHD = "";
            ngayKy = "";
            thangKy = "";
            namKy = "";
        }

        private static string checkNumber(long number, bool isMoney)
        {
            if (number == 0)
                return "";
            else if (isMoney)
                return number.ToString("N0") + " đ";
            return number.ToString();
        }

        public static int tinhDienNangTT(int soMoi, int soCu, int soMoiTT, int soCuTT, int heSo)
        {
            int dienNangTT = 0;
            if (soMoiTT == 0 && soCuTT == 0)
            {
                if (soMoi < soCu)
                {
                    if (soCu > 99999)
                    {
                        dienNangTT = ((soMoi + 1000000) - soCu) * heSo;
                    }
                    else
                    {
                        dienNangTT = ((soMoi + 100000) - soCu) * heSo;
                    }
                }
                else
                {
                    dienNangTT = (soMoi - soCu) * heSo;
                }
            }
            else
            {
                int congToCu = 0;
                int congToMoi = 0;
                if (soMoi < soCu)
                {
                    if (soCu > 99999)
                    {
                        congToCu = (soMoi + 1000000) - soCu;
                    }
                    else
                    {
                        congToCu = (soMoi + 100000) - soCu;
                    }
                }
                else
                {
                    congToCu = soMoi - soCu;
                }
                if (soMoiTT < soCuTT)
                {
                    if (soCuTT > 99999)
                    {
                        congToMoi = (soMoiTT + 1000000) - soCuTT;
                    }
                    else
                    {
                        congToMoi = (soMoiTT + 100000) - soCuTT;
                    }
                }
                else
                {
                    congToMoi = soMoiTT - soCuTT;
                }
                dienNangTT = (congToCu + congToMoi) * heSo;
            }
            return dienNangTT;
        }

        public static void calculateInvoice(string[] tram, int soMoi, int soCu, int soMoiTT, int soCuTT, int heSo, bool poor, string giaPoor, bool lowIncome, string giaLowIncome, bool sinhHoat, string[] giaSH, bool hanhChinh, string giaHC, bool KD1, string giaKD1, bool KD2, string giaKD2, bool SX1, string giaSX1, bool SX2, string giaSX2, bool SX3, string giaSX3, string thang, string nam, int debt)
        {
            clearHDValues();
            soTram = tram[1];
            dienNangTT = tinhDienNangTT(soMoi, soCu, soMoiTT, soCuTT, heSo);
            noCu = debt;
            if (sinhHoat)
            {
                if (dienNangTT > 0 && dienNangTT <= 50)
                {
                    mucSH1 = dienNangTT;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    tienSH1 = dienNangTT * giaSH1;
                    tongTienDien = tienSH1;
                }
                else if (dienNangTT <= 100)
                {
                    mucSH1 = 50;
                    mucSH2 = dienNangTT - 50;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    giaSH2 = int.Parse(giaSH[1].ToString());
                    tienSH1 = mucSH1 * giaSH1;
                    tienSH2 = mucSH2 * giaSH2;
                    tongTienDien = tienSH1 + tienSH2;
                }
                else if (dienNangTT <= 200)
                {
                    mucSH1 = 50;
                    mucSH2 = 50;
                    mucSH3 = dienNangTT - 100;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    giaSH2 = int.Parse(giaSH[1].ToString());
                    giaSH3 = int.Parse(giaSH[2].ToString());
                    tienSH1 = mucSH1 * giaSH1;
                    tienSH2 = mucSH2 * giaSH2;
                    tienSH3 = mucSH3 * giaSH3;
                    tongTienDien = tienSH1 + tienSH2 + tienSH3;
                }
                else if (dienNangTT <= 300)
                {
                    mucSH1 = 50;
                    mucSH2 = 50;
                    mucSH3 = 100;
                    mucSH4 = dienNangTT - 200;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    giaSH2 = int.Parse(giaSH[1].ToString());
                    giaSH3 = int.Parse(giaSH[2].ToString());
                    giaSH4 = int.Parse(giaSH[3].ToString());
                    tienSH1 = mucSH1 * giaSH1;
                    tienSH2 = mucSH2 * giaSH2;
                    tienSH3 = mucSH3 * giaSH3;
                    tienSH4 = mucSH4 * giaSH4;
                    tongTienDien = tienSH1 + tienSH2 + tienSH3 + tienSH4;
                }
                else if (dienNangTT <= 400)
                {
                    mucSH1 = 50;
                    mucSH2 = 50;
                    mucSH3 = 100;
                    mucSH4 = 100;
                    mucSH5 = dienNangTT - 300;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    giaSH2 = int.Parse(giaSH[1].ToString());
                    giaSH3 = int.Parse(giaSH[2].ToString());
                    giaSH4 = int.Parse(giaSH[3].ToString());
                    giaSH5 = int.Parse(giaSH[4].ToString());
                    tienSH1 = mucSH1 * giaSH1;
                    tienSH2 = mucSH2 * giaSH2;
                    tienSH3 = mucSH3 * giaSH3;
                    tienSH4 = mucSH4 * giaSH4;
                    tienSH5 = mucSH5 * giaSH5;
                    tongTienDien = tienSH1 + tienSH2 + tienSH3 + tienSH4 + tienSH5;
                }
                else
                {
                    mucSH1 = 50;
                    mucSH2 = 50;
                    mucSH3 = 100;
                    mucSH4 = 100;
                    mucSH5 = 100;
                    mucSH6 = dienNangTT - 400;
                    giaSH1 = int.Parse(giaSH[0].ToString());
                    giaSH2 = int.Parse(giaSH[1].ToString());
                    giaSH3 = int.Parse(giaSH[2].ToString());
                    giaSH4 = int.Parse(giaSH[3].ToString());
                    giaSH5 = int.Parse(giaSH[4].ToString());
                    giaSH6 = int.Parse(giaSH[5].ToString());
                    tienSH1 = mucSH1 * giaSH1;
                    tienSH2 = mucSH2 * giaSH2;
                    tienSH3 = mucSH3 * giaSH3;
                    tienSH4 = mucSH4 * giaSH4;
                    tienSH5 = mucSH5 * giaSH5;
                    tienSH6 = mucSH6 * giaSH6;
                    tongTienDien = tienSH1 + tienSH2 + tienSH3 + tienSH4 + tienSH5 + tienSH6;
                }
            }
            else if (SX3)
            {
                soDien = Int64.Parse(Math.Round(decimal.Parse((dienNangTT * 0.3).ToString())).ToString());
                soDienSX3_2 = dienNangTT - soDien;
                giaDien = int.Parse(giaKD1);
                giaDienSX3_2 = int.Parse(giaSX3);
                tienDien = soDien * giaDien;
                tienDienSX3_2 = soDienSX3_2 * giaDienSX3_2;
                tongTienDien = tienDien + tienDienSX3_2;
            }
            else
            {
                soDien = dienNangTT;
                if (poor)
                {
                    giaDien = int.Parse(giaPoor);
                }
                else if (lowIncome)
                {
                    giaDien = int.Parse(giaLowIncome);
                }
                else if (hanhChinh)
                {
                    giaDien = int.Parse(giaHC);
                }
                else if (KD1)
                {
                    giaDien = int.Parse(giaKD1);
                }
                else if (KD2)
                {
                    giaDien = int.Parse(giaKD2);
                }
                else if (SX1)
                {
                    giaDien = int.Parse(giaSX1);
                }
                else if (SX2)
                {
                    giaDien = int.Parse(giaSX2);
                }
                else if (SX3)
                {
                    giaDien = int.Parse(giaSX3);
                }
                tienDien = soDien * giaDien;
                tongTienDien = tienDien;
            }
            thueGTGT = long.Parse(decimal.Round(decimal.Parse((tongTienDien * 0.1).ToString())).ToString());
            tongTienSauThue = tongTienDien + thueGTGT;
            tongTienThanhToan = tongTienDien + thueGTGT + noCu;
            docChu = Program.moneyReader(tongTienThanhToan.ToString());
            string duration = "";
            if (soTram == "4")
            {
                duration = DataTier.getDuration("83C40B2E-21A0-4ED6-8570-271FF431FFCA");
                ngayLapHD = DataTier.getInvoiceDate("83C40B2E-21A0-4ED6-8570-271FF431FFCA");
                ngayKy = DataTier.getSignDate("83C40B2E-21A0-4ED6-8570-271FF431FFCA");
            }
            else if (soTram == "7")
            {
                duration = DataTier.getDuration("F0DCB145-8C0D-44DD-B47C-97CD25F3E05B");
                ngayLapHD = DataTier.getInvoiceDate("F0DCB145-8C0D-44DD-B47C-97CD25F3E05B");
                ngayKy = DataTier.getSignDate("F0DCB145-8C0D-44DD-B47C-97CD25F3E05B");
            }
            else if (soTram == "11")
            {
                duration = DataTier.getDuration("176EAB85-54FD-4B5E-9B57-B1732948749B");
                ngayLapHD = DataTier.getInvoiceDate("176EAB85-54FD-4B5E-9B57-B1732948749B");
                ngayKy = DataTier.getSignDate("176EAB85-54FD-4B5E-9B57-B1732948749B");
            }
            if (int.Parse(thang) == 1)
            {
                ngayBatDau = duration + "/12/" + (int.Parse(nam) - 1).ToString();
            }
            else
            {
                ngayBatDau = duration + "/" + (int.Parse(thang) - 1).ToString() + "/" + nam;
            }
            ngayKetThuc = duration + "/" + thang + "/" + nam;
            thangLapHD = thang;
            namLapHD = nam;
            thangKy = thang;
            namKy = nam;
        }

        public static void fillViewHD(string hoaDonID, ViewInvoice hd)
        {
            hd.SetDataSource(DataTier.fillHoaDon(hoaDonID));
            hd.SetParameterValue("ngayBatDau", ngayBatDau);
            hd.SetParameterValue("ngayKetThuc", ngayKetThuc);
            hd.SetParameterValue("giaDien", giaDien);
            hd.SetParameterValue("giaDien1", giaSH1);
            hd.SetParameterValue("giaDien2", giaSH2);
            hd.SetParameterValue("giaDien3", giaSH3);
            hd.SetParameterValue("giaDien4", giaSH4);
            hd.SetParameterValue("giaDien5", giaSH5);
            hd.SetParameterValue("giaDien6", giaSH6);
            hd.SetParameterValue("ngayKyHD", "Ngày " + ngayKy + "/" + thangKy + "/" + namKy);
            hd.SetParameterValue("ngayKyHD2", "Ngày " + ngayKy + " tháng " + thangKy + " năm " + namKy);
            hd.SetParameterValue("tongTienBangChu", docChu);
        }

        public static void fillViewHDSX3(string hoaDonID, ViewInvoiceSX3 hd)
        {
            hd.SetDataSource(DataTier.fillHoaDon(hoaDonID));
            hd.SetParameterValue("ngayBatDau", ngayBatDau);
            hd.SetParameterValue("ngayKetThuc", ngayKetThuc);
            hd.SetParameterValue("giaDien1", giaDien);
            hd.SetParameterValue("giaDien2", giaDienSX3_2);
            hd.SetParameterValue("ngayKyHD", "Ngày " + ngayKy + "/" + thangKy + "/" + namKy);
            hd.SetParameterValue("ngayKyHD2", "Ngày " + ngayKy + " tháng " + thangKy + " năm " + namKy);
            hd.SetParameterValue("tongTienBangChu", docChu);
        }

        public static void setInvoiceParams(string hoaDonID, CrystalDecisions.CrystalReports.Engine.ReportClass hd)
        {
            hd.SetDataSource(DataTier.fillHoaDon(hoaDonID));
            hd.SetParameterValue("ngayBatDau", ngayBatDau);
            hd.SetParameterValue("ngayKetThuc", ngayKetThuc);
            hd.SetParameterValue("giaDien", giaDien);
            hd.SetParameterValue("giaDien1", giaSH1);
            hd.SetParameterValue("giaDien2", giaSH2);
            hd.SetParameterValue("giaDien3", giaSH3);
            hd.SetParameterValue("giaDien4", giaSH4);
            hd.SetParameterValue("giaDien5", giaSH5);
            hd.SetParameterValue("giaDien6", giaSH6);
            hd.SetParameterValue("ngayKyHD", "Ngày " + ngayKy + "/" + thangKy + "/" + namKy);
            hd.SetParameterValue("ngayKyHD2", "Ngày " + ngayKy + " tháng " + thangKy + " năm " + namKy);
            hd.SetParameterValue("tongTienBangChu", docChu);
        }

        public static void setSX3InvoiceParams(string hoaDonID, CrystalDecisions.CrystalReports.Engine.ReportClass hd)
        {
            hd.SetDataSource(DataTier.fillHoaDon(hoaDonID));
            hd.SetParameterValue("ngayBatDau", ngayBatDau);
            hd.SetParameterValue("ngayKetThuc", ngayKetThuc);
            hd.SetParameterValue("giaDien1", giaDien);
            hd.SetParameterValue("giaDien2", giaDienSX3_2);
            hd.SetParameterValue("ngayKyHD", "Ngày " + ngayKy + "/" + thangKy + "/" + namKy);
            hd.SetParameterValue("ngayKyHD2", "Ngày " + ngayKy + " tháng " + thangKy + " năm " + namKy);
            hd.SetParameterValue("tongTienBangChu", docChu);
        }

        public static int tinhCongToHetVongSo(int soCu, int soMoi, int soCuTT, int soMoiTT)
        {
            return 0;
        }

        public static void fillKetQuaSH(ketQuaSHForm ketQuaSH)
        {
            ketQuaSH.mucDichTextBox.Text = "Sinh hoạt";
            ketQuaSH.dienNangTextBox.Text = dienNangTT.ToString();

            ketQuaSH.soDien1TextBox.Text = mucSH1.ToString();
            ketQuaSH.soDien2TextBox.Text = mucSH2.ToString();
            ketQuaSH.soDien3TextBox.Text = mucSH3.ToString();
            ketQuaSH.soDien4TextBox.Text = mucSH4.ToString();
            ketQuaSH.soDien5TextBox.Text = mucSH5.ToString();
            ketQuaSH.soDien6TextBox.Text = mucSH6.ToString();

            ketQuaSH.gia1TextBox.Text = giaSH1.ToString("N0");
            ketQuaSH.gia2TextBox.Text = giaSH2.ToString("N0");
            ketQuaSH.gia3TextBox.Text = giaSH3.ToString("N0");
            ketQuaSH.gia4TextBox.Text = giaSH4.ToString("N0");
            ketQuaSH.gia5TextBox.Text = giaSH5.ToString("N0");
            ketQuaSH.gia6TextBox.Text = giaSH6.ToString("N0");

            ketQuaSH.tien1TextBox.Text = tienSH1.ToString("N0");
            ketQuaSH.tien2TextBox.Text = tienSH2.ToString("N0");
            ketQuaSH.tien3TextBox.Text = tienSH3.ToString("N0");
            ketQuaSH.tien4TextBox.Text = tienSH4.ToString("N0");
            ketQuaSH.tien5TextBox.Text = tienSH5.ToString("N0");
            ketQuaSH.tien6TextBox.Text = tienSH6.ToString("N0");

            ketQuaSH.tongTienTextBox.Text = tongTienDien.ToString("N0");
            ketQuaSH.thueTextBox.Text = thueGTGT.ToString("N0");
            ketQuaSH.tienSauThueTextBox.Text = tongTienSauThue.ToString("N0");
            ketQuaSH.noCuTextBox.Text = noCu.ToString("N0");
            ketQuaSH.thanhToanTextBox.Text = tongTienThanhToan.ToString("N0");
        }

        public static void fillKetQuaMDK(ketQuaMDKForm ketQuaMDK)
        {
            ketQuaMDK.mucDichTextBox.Text = ketQuaMDKForm.mucDichSD;
            ketQuaMDK.giaDienTextBox.Text = giaDien.ToString("N0");
            ketQuaMDK.dienNangTextBox.Text = dienNangTT.ToString();
            ketQuaMDK.tongTienTextBox.Text = tongTienDien.ToString("N0");
            ketQuaMDK.thueTextBox.Text = thueGTGT.ToString("N0");
            ketQuaMDK.tienSauThueTextBox.Text = tongTienSauThue.ToString("N0");
            ketQuaMDK.noCuTextBox.Text = noCu.ToString("N0");
            ketQuaMDK.thanhToanTextBox.Text = tongTienThanhToan.ToString("N0");
        }

        public static void fillKetQuaSX3(ketQuaSX3Form ketQuaSX3)
        {
            ketQuaSX3.mucDichTextBox.Text = ketQuaSX3Form.mucDichSD;
            ketQuaSX3.soDienTextBox.Text = soDien.ToString();
            ketQuaSX3.giaDienTextBox.Text = giaDien.ToString("N0");
            ketQuaSX3.thanhTienTextBox.Text = tienDien.ToString("N0");
            ketQuaSX3.soDien2TextBox.Text = soDienSX3_2.ToString();
            ketQuaSX3.giaDien2TextBox.Text = giaDienSX3_2.ToString("N0");
            ketQuaSX3.thanhTien2TextBox.Text = tienDienSX3_2.ToString("N0");
            ketQuaSX3.tongTienTextBox.Text = tongTienDien.ToString("N0");
            ketQuaSX3.thueTextBox.Text = thueGTGT.ToString("N0");
            ketQuaSX3.tienSauThueTextBox.Text = tongTienSauThue.ToString("N0");
            ketQuaSX3.noCuTextBox.Text = noCu.ToString("N0");
            ketQuaSX3.thanhToanTextBox.Text = tongTienThanhToan.ToString("N0");
        }

        public static bool isUsingOldInvoice()
        {
            var fd = Settings.Default.InvoiceType;

            if (string.Equals(fd, "old", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}