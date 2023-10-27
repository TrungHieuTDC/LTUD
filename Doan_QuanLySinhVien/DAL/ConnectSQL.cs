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
   public class ConnectSQL
    {
        public static SqlConnection ConnectSQL_Database()
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source=LAPTOP-B4B29T3H;Initial Catalog=Doan;Integrated Security=True";
            try
            {

                sql.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mo database that bai =>> loi " + ex.Message);
            }
            return sql;
        }
    }
}
