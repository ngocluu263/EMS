using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Electric_Management_System.App_Code
{
    class DataTier
    {
        protected static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSDBConnectionString"].ConnectionString);
        protected static SqlDataAdapter da;
        protected static SqlDataReader rd;
        protected static SqlCommand cmd;
        protected static DataTable dt;
        protected static String sqlCmd;

        //Lay ra cac tram co trong csdl
        public static DataTable getStation()
        {
            sqlCmd = "SELECT StationID,Name,Duration,InvoiceDate,SignDate,ReportDate FROM tbl_Station WHERE Status=1 ORDER BY Name ASC";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Lấy ra ngày chốt số
        public static string getDuration(string stationID)
        {
            sqlCmd = "SELECT Duration FROM tbl_Station WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return cmd.ExecuteScalar().ToString();
        }

        //Lấy ra ngày lập hóa đơn
        public static string getInvoiceDate(string stationID)
        {
            sqlCmd = "SELECT InvoiceDate FROM tbl_Station WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return cmd.ExecuteScalar().ToString();
        }

        //Lấy ra ngày ký
        public static string getSignDate(string stationID)
        {
            sqlCmd = "SELECT SignDate FROM tbl_Station WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return cmd.ExecuteScalar().ToString();
        }

        //Lấy ra ngày lập báo cáo
        public static string getReportDate(string stationID)
        {
            sqlCmd = "SELECT ReportDate FROM tbl_Station WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return cmd.ExecuteScalar().ToString();
        }

        //Lay ra STT khach hang co trong tram
        public static DataTable getCustomerList(String StationID)
        {
            sqlCmd = "SELECT CustomerID,CustomerNumber,Name FROM tbl_Customer WHERE StationID=@StationID AND Status=1 ORDER BY CustomerNumber";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.Fill(dt);
            return dt;
        }

        //Xác định số thứ tự lớn nhất trong danh sách khách hàng của trạm hiện tại
        public static int XacDinhSTTMax(String StationID)
        {
            sqlCmd = "SELECT MAX(CustomerNumber) FROM tbl_Customer WHERE StationID=@StationID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", StationID);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return (int)cmd.ExecuteScalar();
        }

        //Lay ra danh sach khach hang co trong tram
        public static DataTable getCustomer(String StationID)
        {
            sqlCmd = "SELECT CustomerNumber,Name,Address,HKNumber,TaxNumber FROM tbl_Customer WHERE StationID=@StationID AND Status=1 ORDER BY CustomerNumber";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.Fill(dt);
            return dt;
        }

        //Lay ra thong tin chi tiet cua mot khach hang
        public static DataTable getCustomerDetails(String CustomerID)
        {
            sqlCmd = "SELECT Name,Address,HKNumber,TaxNumber FROM tbl_Customer WHERE CustomerID=@CustomerID";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
            da.Fill(dt);
            return dt;
        }

        //Lay ra cac khach hang da lap hoa don trong thang
        public static DataTable getBilledCustomer(String StationID, int Month, int Year)
        {
            sqlCmd = "SELECT c.CustomerNumber,i.InvoiceID,i.CustomerID FROM tbl_Customer AS c INNER JOIN tbl_Invoice AS i ON c.CustomerID=i.CustomerID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND c.Status=1 ORDER BY c.CustomerNumber";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.SelectCommand.Parameters.AddWithValue("@Month", Month);
            da.SelectCommand.Parameters.AddWithValue("@Year", Year);
            da.Fill(dt);
            return dt;
        }

        //Lay ra cac khach hang chua lap hoa don trong thang
        public static DataTable getUnbilledCustomer(String StationID, int Month, int Year)
        {
            sqlCmd = " SELECT CustomerID, CustomerNumber FROM tbl_Customer WHERE CustomerID NOT IN (SELECT c.CustomerID FROM tbl_Customer AS c INNER JOIN tbl_Invoice AS i ON c.CustomerID=i.CustomerID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND c.Status=1) AND StationID=@StationID AND Status=1 ORDER BY CustomerNumber";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.SelectCommand.Parameters.AddWithValue("@Month", Month);
            da.SelectCommand.Parameters.AddWithValue("@Year", Year);
            da.Fill(dt);
            return dt;
        }

        //Lay ra so ho su dung dien trong thang theo muc dich su dung
        public static int getInvoiceByPurpose(String StationID, int Month, int Year, String Purpose)
        {
            if (Purpose == "0" || Purpose == "1")
            {
                sqlCmd = "SELECT i.InvoiceID,c.CustomerID FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID = c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID = p.PurposeID WHERE c.StationID = @StationID AND i.Month = @Month AND i.Year = @Year AND p.Type = @Purpose";
            }
            else
            {
                sqlCmd = "SELECT i.InvoiceID,c.CustomerID FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID = c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID = p.PurposeID WHERE c.StationID = @StationID AND i.Month = @Month AND i.Year = @Year AND p.PurposeID = @Purpose";
            }
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.SelectCommand.Parameters.AddWithValue("@Month", Month);
            da.SelectCommand.Parameters.AddWithValue("@Year", Year);
            da.SelectCommand.Parameters.AddWithValue("@Purpose", Purpose);
            da.Fill(dt);
            return dt.Rows.Count;
        }

        //Lay ra thong tin chi tiet cua mot hoa don
        public static DataTable getHoaDonDetails(string invoiceID)
        {
            sqlCmd = "SELECT PurposeID,OldNumber,NewNumber,OldNumber2,NewNumber2,Multiplier,Debt,PublicECost FROM tbl_Invoice WHERE InvoiceID=@InvoiceID";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
            da.Fill(dt);
            return dt;
        }

        //Lay ra cung luc thong tin cua hoa don & khach hang de hien thi tren hoa don
        public static DataTable fillHoaDon(string invoiceID)
        {
            sqlCmd = "Proc_Fill_Invoice";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
            da.Fill(dt);
            return dt;
        }

        //Lay ra bao cao thang
        public static DataTable fillMonthlyReport(string stationID, int month, int year, int purpose)
        {
            sqlCmd = "SELECT i.OldNumber,i.NewNumber,i.OldNumber2,i.NewNumber2,i.Multiplier,i.Debt,i.PurposeID,c.CustomerNumber,c.Name,c.Address,c.HKNumber,c.TaxNumber FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND p.Type=@Type";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@StationID", stationID);
            da.SelectCommand.Parameters.AddWithValue("@Month", month);
            da.SelectCommand.Parameters.AddWithValue("@Year", year);
            da.SelectCommand.Parameters.AddWithValue("@Type", purpose);
            da.Fill(dt);
            return dt;
        }

        //Lay ra tong dien nang thu duoc o cac ho theo muc dich su dung
        public static int getTongDienByMD(string StationID, int Month, int Year, string Purpose)
        {
            if (Purpose == "all") //Lay ra tong dien cua tat ca cac hoa don
            {
                sqlCmd = "SELECT i.NewNumber,i.OldNumber,i.NewNumber2,i.OldNumber2,i.Multiplier FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year";
            }
            else if (Purpose == "0" || Purpose == "1") //Lay ra tong dien cua cac hoa don theo loai muc dich khac hay sinh hoat
            {
                sqlCmd = "SELECT i.NewNumber,i.OldNumber,i.NewNumber2,i.OldNumber2,i.Multiplier FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND p.Type=@Purpose";
            }
            else //Lay ra tong dien cua cac hoa don theo tung muc dich su dung
            {
                sqlCmd = "SELECT i.NewNumber,i.OldNumber,i.NewNumber2,i.OldNumber2,i.Multiplier FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND i.PurposeID=@Purpose";
            }
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", StationID);
            cmd.Parameters.AddWithValue("@Month", Month);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Purpose", Purpose);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            int tongDienThu = 0;
            while (rd.Read())
            {
                tongDienThu += Program.tinhDienNangTT(int.Parse(rd[0].ToString()), int.Parse(rd[1].ToString()), int.Parse(rd[2].ToString()), int.Parse(rd[3].ToString()), int.Parse(rd[4].ToString()));
            }
            rd.Close();
            con.Close();
            return tongDienThu;
        }

        //Lay ra gia dien cua 1 loai muc dich su dung dien
        public static string getPrice(string purposeID)
        {
            sqlCmd = "SELECT Price FROM tbl_Purpose WHERE PurposeID=@PurposeID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@PurposeID", purposeID);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            rd = cmd.ExecuteReader();
            string giaDien = "";
            while (rd.Read())
            {
                giaDien = rd[0].ToString();
            }
            rd.Close();
            con.Close();
            return giaDien;
        }

        //Lay ra so dien, he so va muc dich su dung cua thang truoc
        public static string[] getOldNumber(string customerID, int month, int year)
        {
            string[] soCu = {"0", "1", "1"};
            int thang = 0;
            int nam = 0;
            if (month == 1)
            {
                thang = 12;
                nam = year - 1;
            }
            else
            {
                thang = month - 1;
                nam = year;
            }
            sqlCmd = "SELECT NewNumber,NewNumber2,Multiplier,PurposeID FROM tbl_Invoice WHERE CustomerID=@CustomerID AND Month=@Month AND Year=@Year";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@CustomerID", customerID);
            cmd.Parameters.AddWithValue("@Month", thang);
            cmd.Parameters.AddWithValue("@Year", nam);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    if (rd.GetInt32(1) > 0)
                    {
                        soCu[0] = rd.GetValue(1).ToString();
                    }
                    else
                    {
                        soCu[0] = rd.GetValue(0).ToString();
                    }                    
                    soCu[1] = rd.GetValue(2).ToString();
                    soCu[2] = rd.GetValue(3).ToString();
                }
            }
            rd.Close();
            con.Close();
            return soCu;
        }

        //Lay ra cac tram co trong csdl
        public static DataTable getBCTH(String StationID, int Month, int Year)
        {
            sqlCmd = "SELECT TotalReportID,TotalReceived,LivingPurpose,Poor,LowIncome,OtherPurpose,TotalPaid FROM tbl_TotalReport WHERE StationID=@StationID AND Month=@Month AND Year=@Year";
            da = new SqlDataAdapter(sqlCmd, con);
            dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@Month", Month);
            da.SelectCommand.Parameters.AddWithValue("@Year", Year);
            da.SelectCommand.Parameters.AddWithValue("@StationID", StationID);
            da.Fill(dt);
            return dt;
        }

        //Lấy ra tổng tiền phát sinh trong tháng
        public static double getTongTienPhatSinh(string stationID, int month, int year, string purpose)
        {
            if (purpose == "all")
            {
                sqlCmd = "SELECT i.NewNumber,i.OldNumber,i.NewNumber2,i.OldNumber2,i.Multiplier,i.PurposeID,p.Price FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year";
            }
            else
            {
                sqlCmd = "SELECT i.NewNumber,i.OldNumber,i.NewNumber2,i.OldNumber2,i.Multiplier,i.PurposeID,p.Price FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND p.Type=@Purpose";
            }
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            cmd.Parameters.AddWithValue("@Month", month);
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Purpose", purpose);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            double total = 0;
            while (rd.Read())
            {
                double amount = 0;
                int dienNangTT = Program.tinhDienNangTT(int.Parse(rd[0].ToString()), int.Parse(rd[1].ToString()), int.Parse(rd[2].ToString()), int.Parse(rd[3].ToString()), int.Parse(rd[4].ToString()));
                if (rd[5].ToString() == "e00f133e-f43c-4dc5-8ebb-a747200416c9")
                {
                    string[] giaSH = rd[6].ToString().Split(',');
                    if (dienNangTT > 0 && dienNangTT <= 50)
                    {
                        amount = dienNangTT * int.Parse(giaSH[0].ToString());
                    }
                    else if (dienNangTT <= 100)
                    {
                        amount = (50 * int.Parse(giaSH[0].ToString())) + ((dienNangTT - 50) * int.Parse(giaSH[1].ToString()));
                    }
                    else if (dienNangTT <= 200)
                    {
                        amount = (50 * int.Parse(giaSH[0].ToString())) + (50 * int.Parse(giaSH[1].ToString())) + ((dienNangTT - 100) * int.Parse(giaSH[2].ToString()));
                    }
                    else if (dienNangTT <= 300)
                    {
                        amount = (50 * int.Parse(giaSH[0].ToString())) + (50 * int.Parse(giaSH[1].ToString())) + (100 * int.Parse(giaSH[2].ToString())) + ((dienNangTT - 200) * int.Parse(giaSH[3].ToString()));
                    }
                    else if (dienNangTT <= 400)
                    {
                        amount = (50 * int.Parse(giaSH[0].ToString())) + (50 * int.Parse(giaSH[1].ToString())) + (100 * int.Parse(giaSH[2].ToString())) + (100 * int.Parse(giaSH[3].ToString())) + ((dienNangTT - 300) * int.Parse(giaSH[4].ToString()));
                    }
                    else
                    {
                        amount = (50 * int.Parse(giaSH[0].ToString())) + (50 * int.Parse(giaSH[1].ToString())) + (100 * int.Parse(giaSH[2].ToString())) + (100 * int.Parse(giaSH[3].ToString())) + (100 * int.Parse(giaSH[4].ToString())) + ((dienNangTT - 400) * int.Parse(giaSH[5].ToString()));
                    }
                }
                else if (rd[5].ToString() == "422cf080-b750-411d-a895-9550b8950b66")
                {
                    int soDien30 = int.Parse(Math.Round(decimal.Parse((dienNangTT * 0.3).ToString())).ToString());
                    amount = ((dienNangTT - soDien30) * int.Parse(rd[6].ToString())) + (soDien30 * 2285);
                }
                else
                {
                    amount = dienNangTT * int.Parse(rd[6].ToString());
                }
                total += amount;
            }
            rd.Close();
            con.Close();
            return Math.Round(total * 1.1);
        }

        //Lấy ra tổng nợ trong tháng
        public static double getTongNo(string stationID, int month, int year, string purpose)
        {
            if (purpose == "all")
            {
                sqlCmd = "SELECT SUM(i.Debt) FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year";
            }
            else
            {
                sqlCmd = "SELECT SUM(i.Debt) FROM tbl_Invoice AS i INNER JOIN tbl_Customer AS c ON i.CustomerID=c.CustomerID INNER JOIN tbl_Purpose AS p ON i.PurposeID=p.PurposeID WHERE c.StationID=@StationID AND i.Month=@Month AND i.Year=@Year AND p.Type=@Purpose";
            }
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@StationID", stationID);
            cmd.Parameters.AddWithValue("@Month", month);
            cmd.Parameters.AddWithValue("@Year", year);
            cmd.Parameters.AddWithValue("@Purpose", purpose);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            int tongNo = 0;
            while (rd.Read())
            {
                tongNo = int.Parse(rd[0].ToString());
            }
            rd.Close();
            con.Close();
            return tongNo;
        }

        //Sua gia dien hien tai
        public static bool editCurrentPrice(string PurposeID, string Price)
        {
            sqlCmd = "UPDATE tbl_Purpose SET Price=@Price WHERE PurposeID=@PurposeID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@PurposeID", PurposeID);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua gia dien thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua gia dien that bai
            return false;
        }

        //Lay ra mat khau
        public static string getPassword()
        {
            sqlCmd = "SELECT value FROM tbl_Program WHERE [key]='password'";
            cmd = new SqlCommand(sqlCmd, con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            string password = "";
            while (rd.Read())
            {
                password = rd[0].ToString();
            }
            rd.Close();
            con.Close();
            return password;
        }

        //Dang nhap
        public static bool login(string password)
        {
            sqlCmd = "SELECT * FROM tbl_Program WHERE [key]='password' AND value=@password";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@password", password);
            if (con.State == ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                con.Close();
                return true;
            }
            rd.Close();
            con.Close();
            return false;
        }

        //Thay doi mat khau
        public static bool editPassword(string password)
        {
            sqlCmd = "UPDATE tbl_Program SET value=@password WHERE [key]='password'";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@password", password);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Sua mat khau thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Sua mat khau that bai
            return false;
        }

        public static bool UpdateHHDV(Guid hhdvID, DateTime ngayGhiSo, int soKWDienMuaVao, decimal tongTienMuaVao, decimal thueMuaVao, int soKWDienBanRa, decimal tongTienBanRa, decimal thueBanRa, decimal thueGTGTPhaiNop, decimal thueGTGTDaNop, decimal thueTNDN)
        {
            sqlCmd = "UPDATE tbl_TheoDoiHHDV SET NgayGhiSo = @ngayGhiSo, SoKWDienMuaVao = @soKWDienMuaVao, TongTienMuaVao = @tongTienMuaVao, ThueMuaVao = @thueMuaVao, SoKWDienBanRa = @soKWDienBanRa, TongTienBanRa = @tongTienBanRa, ThueBanRa = @thueBanRa, ThueGTGTPhaiNop = @thueGTGTPhaiNop, ThueGTGTDaNop = @thueGTGTDaNop, ThueTNDN = @thueTNDN WHERE HHDVID = @hhdvID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@hhdvID", hhdvID);
            cmd.Parameters.AddWithValue("@ngayGhiSo", ngayGhiSo);
            cmd.Parameters.AddWithValue("@soKWDienMuaVao", soKWDienMuaVao);
            cmd.Parameters.AddWithValue("@tongTienMuaVao", tongTienMuaVao);
            cmd.Parameters.AddWithValue("@thueMuaVao", thueMuaVao);
            cmd.Parameters.AddWithValue("@soKWDienBanRa", soKWDienBanRa);
            cmd.Parameters.AddWithValue("@tongTienBanRa", tongTienBanRa);
            cmd.Parameters.AddWithValue("@thueBanRa", thueBanRa);
            cmd.Parameters.AddWithValue("@thueGTGTPhaiNop", thueGTGTPhaiNop);
            cmd.Parameters.AddWithValue("@thueGTGTDaNop", thueGTGTDaNop);
            cmd.Parameters.AddWithValue("@thueTNDN", thueTNDN);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Update thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Update that bai
            return false;
        }

        public static bool UpdateGTGT(Guid thueGTGTID, string soChungTu, DateTime ngayChungTu, DateTime ngayGhiSo, decimal dauRa, decimal dauVao, decimal phaiNop, decimal daNop, decimal conPhaiNop, decimal nopThua, string description)
        {
            sqlCmd = "UPDATE tbl_TheoDoiGTGT SET SoHieuChungTu = @soHieuChungTu, ChungTuDate = @chungTuDate, NgayGhiSo = @ngayGhiSo, DauRaPhatSinh = @dauRaPhatSinh, DauVaoPhatSinh = @dauVaoPhatSinh, PhaiNop = @phaiNop, DaNop = @daNop, ConPhaiNop = @conPhaiNop, NopThua = @nopThua, Description = @description WHERE ThueGTGTID = @thueGTGTID";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@thueGTGTID", thueGTGTID);
            cmd.Parameters.AddWithValue("@soHieuChungTu", soChungTu);
            cmd.Parameters.AddWithValue("@chungTuDate", ngayChungTu);
            cmd.Parameters.AddWithValue("@ngayGhiSo", ngayGhiSo);
            cmd.Parameters.AddWithValue("@dauRaPhatSinh", dauRa);
            cmd.Parameters.AddWithValue("@dauVaoPhatSinh", dauVao);
            cmd.Parameters.AddWithValue("@phaiNop", phaiNop);
            cmd.Parameters.AddWithValue("@daNop", daNop);
            cmd.Parameters.AddWithValue("@conPhaiNop", conPhaiNop);
            cmd.Parameters.AddWithValue("@nopThua", nopThua);
            cmd.Parameters.AddWithValue("@description", description);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            rd = cmd.ExecuteReader();
            rd.Close();
            con.Close();
            //Update thanh cong
            if (rd.RecordsAffected > 0)
                return true;
            //Update that bai
            return false;
        }

        //Lay ra so thu tu co the dung trong bang nhat ky chung
        public static string getLastestSTTNhatKyChung(string year)
        {
            sqlCmd = "SELECT TOP(1) STT FROM tbl_NhatKyChung WHERE STT IS NOT NULL AND YEAR(NgayGhiSo) = @year AND Status = 1 ORDER BY STT DESC";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@year", year);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            rd = cmd.ExecuteReader();
            string stt = "";
            if (!rd.HasRows)
            {
                stt = "0";
            }
            else
            {
                while (rd.Read())
                {
                    stt = rd[0].ToString();
                }
            }
            rd.Close();
            con.Close();
            return (int.Parse(stt) + 1).ToString();
        }

        //Lay ra so thu tu co the dung trong bang nhat ky chung
        public static bool sttNhatKyChungExisted(string year, string stt)
        {
            sqlCmd = "SELECT COUNT(*) FROM tbl_NhatKyChung WHERE YEAR(NgayGhiSo) = @year AND STT = @stt AND Status = 1";
            cmd = new SqlCommand(sqlCmd, con);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@stt", stt);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            rd = cmd.ExecuteReader();
            bool sttExisted = false;
            while (rd.Read())
            {
                sttExisted = (int)rd[0] > 0;
            }
            rd.Close();
            con.Close();
            return sttExisted;
        }
    }
}
