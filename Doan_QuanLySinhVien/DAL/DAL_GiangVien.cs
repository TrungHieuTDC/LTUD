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
   public class DAL_GiangVien
    {

        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public DataTable getData_GiangVien()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getData_GiaoVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int InsertValue_GiangVien(string maGV,string tenGV,string email,string sdt,string maKhoa)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_GiangVien", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaGV", maGV);
            sqlCmd.Parameters.AddWithValue("@sTenGV", tenGV);
            sqlCmd.Parameters.AddWithValue("@sEmail", email);
            sqlCmd.Parameters.AddWithValue("@sSDT", sdt);
            sqlCmd.Parameters.AddWithValue("@sMaKhoa", maKhoa);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i>=0)
                {
                    MessageBox.Show($"Thêm giáo viên {tenGV} thành công");
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Thêm giáo viên {tenGV} thất bại + lỗi ==> {ex.Message}");
            }
            return -1;
        }
    }
}
