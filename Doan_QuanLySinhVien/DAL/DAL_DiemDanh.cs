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
   public class DAL_DiemDanh
    {
        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public DataTable getData_DiemDanh()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getdData_DiemDanh", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int InsertValue_DiemDanh(string maSV,DateTime ngayDiemDanh, string tinhTrang)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertData_DiemDanh", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            string ngay = $"{ngayDiemDanh.Year}/{ngayDiemDanh.Month}/{ngayDiemDanh.Day}";
            sqlCmd.Parameters.AddWithValue("@sNgayDiemDanh", ngay);
            sqlCmd.Parameters.AddWithValue("@sTinhTrang", tinhTrang);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                MessageBox.Show($"Điểm danh sinh viên có mã {maSV} thành công");
                return 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Điểm danh sinh viên có mã{maSV} thất bại");
            }
            return -1;
        }

        public int InsertValue_DiemDanhAll(string maSV, DateTime ngayDiemDanh, string tinhTrang)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertData_DiemDanh", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            string ngay = $"{ngayDiemDanh.Year}/{ngayDiemDanh.Month}/{ngayDiemDanh.Day}";
            sqlCmd.Parameters.AddWithValue("@sNgayDiemDanh", ngay);
            sqlCmd.Parameters.AddWithValue("@sTinhTrang", tinhTrang);
            int i = sqlCmd.ExecuteNonQuery();
            try
            { 
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Điểm danh sinh viên có mã{maSV} thất bại");
            }
            return -1;
        }

        public DataTable SearchDiemDanh_Ngay(DateTime ngayDiemDanh)
        {
            DataTable dtTbl = new DataTable();
            string ngay = $"{ngayDiemDanh.Year}/{ngayDiemDanh.Month}/{ngayDiemDanh.Day}";
            SqlCommand sqlCmd = new SqlCommand("SearchDiemDanh_Ngay", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sNgayDiemDanh", ngay);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public DataTable Search_DiemDanh_SV(string maSV, DateTime ngayDiemDanh)
        {
            DataTable dtTbl = new DataTable();
            string ngay = $"{ngayDiemDanh.Year}/{ngayDiemDanh.Month}/{ngayDiemDanh.Day}";
            SqlCommand sqlCmd = new SqlCommand("SearchDiemDanh_SV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sNgayDiemDanh", ngay);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int UpdateDiemDanh_SV(string maSV,DateTime ngayDiemDanh,string tinhTrang)
        {
            SqlCommand sqlCmd = new SqlCommand("UpdateDiemDanh_SV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            string ngay = $"{ngayDiemDanh.Year}/{ngayDiemDanh.Month}/{ngayDiemDanh.Day}";
            sqlCmd.Parameters.AddWithValue("@sNgayDiemDanh", ngay);
            sqlCmd.Parameters.AddWithValue("@sTinhTrang", tinhTrang);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                MessageBox.Show($"Cập nhật điểm danh sinh viên có mã {maSV} thành công");
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật điểm danh sinh viên có mã{maSV} thất bại");
            }
            return -1;
        }

        public DataTable getNgayDaDiemDanh()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getData_DiemDanh_Ngay",conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

       
    }
}
