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
   public class DAL_Lop
    {
        SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public int InsertValue_Lop(string maLop, string tenLop, string maKhoa)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_Lop", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@smaLop", maLop);
            sqlCmd.Parameters.AddWithValue("@sTenLop", tenLop);
            sqlCmd.Parameters.AddWithValue("@sMaKhoa", maKhoa);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                MessageBox.Show($"Thêm lớp học {tenLop} thành công");
                return 0;
            }
            catch
            {
                MessageBox.Show($"Thêm lớp học {tenLop} thất bại");
            }
            return -1;
        }

        public DataTable getData_LopHoc()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getDatabase_Lop", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public DataTable Search_Lop_TenLop(string tenLop)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("Search_Lop_TenLop", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sTenLop", tenLop);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public DataTable Search_Lop_MaLop(string maLop)
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("Search_Lop_MaLop", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaLop", maLop);
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }
    }
}
