using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
   public class DAL_SinhVien
    {
        public static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public DataTable getData_SinhVien()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getDataSinhVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int InsertValue_SinhVien(string maSV,string hoTenSV,DateTime ngaySinh, string gioiTinh,string cccd,string khoaHoc,string email,string sdt,float diem, string tenCVHT,string maKhoa,string maLop)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_SinhVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@shoTen", hoTenSV);
            string ngay = $"{ngaySinh.Year}/{ngaySinh.Month}/{ngaySinh.Day}";
            sqlCmd.Parameters.AddWithValue("@sngaySinh", ngay);
            sqlCmd.Parameters.AddWithValue("@sGioiTinh", gioiTinh);
            sqlCmd.Parameters.AddWithValue("@sCCCD", cccd);
            sqlCmd.Parameters.AddWithValue("@sKhoaHoc", khoaHoc);
            sqlCmd.Parameters.AddWithValue("@sEmail", email);
            sqlCmd.Parameters.AddWithValue("@sSDT", sdt) ;
            sqlCmd.Parameters.AddWithValue("@sDiem", diem);
            sqlCmd.Parameters.AddWithValue("@sTenCVHT", tenCVHT);
            sqlCmd.Parameters.AddWithValue("@sMaKhoa", maKhoa);
            sqlCmd.Parameters.AddWithValue("@smaLop", maLop);
            int i = sqlCmd.ExecuteNonQuery();
           try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Them sinh viên {hoTenSV} thành công");
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Them sinh viên {hoTenSV} thất bại");
            }

            return -1;
        }

        public DataTable Search_Sv_MaSV(string maSV)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("Search_SinhVien_MaSV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int Update_SinhVien(string maSV, string tenSV, string CCCD,string email, string sdt,DateTime ngaySinh)
        {
            SqlCommand sqlCmd = new SqlCommand("Updata_SinhVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sTenSV",tenSV );
            sqlCmd.Parameters.AddWithValue("@sCCCD", CCCD);
            sqlCmd.Parameters.AddWithValue("@sEmail",email );
            sqlCmd.Parameters.AddWithValue("@sSDT", sdt);
            string ngay = $"{ngaySinh.Year}/{ngaySinh.Month}/{ngaySinh.Day}";
            sqlCmd.Parameters.AddWithValue("@sNgaySinh", ngay);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Sửa thông tin sinh viên {tenSV} thành công");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa thông tin sinh viên {tenSV} thất bại");
            }

            return -1;
        }

        public int Delete_SinhVien(string maSV)
        {
            SqlCommand sqlCmd = new SqlCommand("Delete_sinhVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Xóa sinh viên có mã {maSV} thành công");
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Xóa sinh viên có mã {maSV} thất bại");
            }
            return -1;
        }

        public int UpdateDiem_SV(string maSV, float diem)
        {
            SqlCommand sqlCmd = new SqlCommand("UpdateDiem_SV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sDiem", diem);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
            }
            return -1;
        }
        
    }
}
