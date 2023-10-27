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
   public class DAL_Khoa
    {
        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public int InsertValue_Khoa(string maKhoa, string tenKhoa)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_Khoa", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaKhoa", maKhoa);
            sqlCmd.Parameters.AddWithValue("@sTenKhoa", tenKhoa);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i>=0)
                {
                    MessageBox.Show($"Thêm khoa {tenKhoa} thành công");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm khoa {tenKhoa} thất bại");
            }
            return -1;  
        }

        public DataTable getData_Khoa()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getDatabase_Khoa", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;

        }

        public DataTable Search_Khoa_TenKhoa(string tenKhoa)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("Search_Khoa_TenKhoa", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sTenKhoa", tenKhoa);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public DataTable Search_Khoa_MaKhoa(string maKhoa)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("Search_Khoa_MaKhoa", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaKhoa", maKhoa);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }
    }
}
