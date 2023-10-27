using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
  public class BUS_MonHoc
    {
        DAL_MonHoc dal_monHoc = new DAL_MonHoc();
        public DataTable getData_MonHoc()
        {
            return dal_monHoc.getData_MonHoc();
        }

        public int InsertValue_MonHoc(MonHoc monHoc)
        {
            return dal_monHoc.InsertValue_MonHoc(monHoc.MaMH, monHoc.TenMH);
        }
    }
}
