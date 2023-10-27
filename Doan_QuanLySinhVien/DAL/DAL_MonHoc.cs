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
   public class DAL_MonHoc
    { 
        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public DataTable getData_MonHoc()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getData_MonHoc", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }

        public int InsertValue_MonHoc(string maMH, string tenMH)
        {
            SqlCommand sqlCmd = new SqlCommand("InsertValue_MonHoc", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@sMaMH", maMH);
            sqlCmd.Parameters.AddWithValue("@sTenMH", tenMH);
            int i = sqlCmd.ExecuteNonQuery();
            try
            {
                if (i >= 0)
                {
                    MessageBox.Show($"Thêm môn học {tenMH} thành công");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm môn học {tenMH} thất bại");
            }
            return -1;

        }
    }
}
