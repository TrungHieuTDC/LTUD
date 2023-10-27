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
   public class DAL_LichMonHoc
    {
        private static SqlConnection conn = ConnectSQL.ConnectSQL_Database();

        public DataTable getDataLichMH_GV_Mh()
        {
            DataTable dtTbl = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("getData_LichMonHoc_GV_MH", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDTAP = new SqlDataAdapter(sqlCmd);
            sqlDTAP.Fill(dtTbl);
            return dtTbl;
        }
    }
}
