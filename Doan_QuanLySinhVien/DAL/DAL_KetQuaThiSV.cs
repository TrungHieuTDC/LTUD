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
   public class DAL_KetQuaThiSV
    {
        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();
        public int InsertValue_DiemThi(string maMH, string maSV, float diemThi)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_KetQuaSV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaMH", maMH);
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sdiemThi", diemThi);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Nhập điểm vào sinh viên có mã {maSV} cho môn học có mã{maMH} thành công");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nhập điểm vào sinh viên có mã {maSV} cho môn học có mã{maMH} thất bại");
            }
            return -1;
        }

        public DataTable getKetQuaThi(string maSV)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getDiemThi_SV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }
        
        public int UpdateDiemThi_SV(string maMH,string maSV, float diemThi)
        {
            SqlCommand sqlCmd = new SqlCommand("UpdateDiemThi_SV", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaMH", maMH);
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sDiemThi", diemThi);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Cập nhật điểm vào sinh viên có mã {maSV} cho môn học có mã{maMH} thành công");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật điểm vào sinh viên có mã {maSV} cho môn học có mã{maMH} thất bại");
            }
            return -1;
        }

        public DataTable SearchDataMonHoc(string maSV, string maMH)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("SearchDiemThi_Sv_Mon", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
            sqlCmd.Parameters.AddWithValue("@sMaMH", maMH);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }
    }
}
