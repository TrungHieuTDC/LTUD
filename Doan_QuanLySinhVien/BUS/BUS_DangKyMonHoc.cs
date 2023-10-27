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
    public class BUS_DangKyMonHoc
    {
        DAL_DangKyMonHoc dal_dkMh = new DAL_DangKyMonHoc();
        public DataTable getDataDangMyMH_SV(string maSV)
        {
            return dal_dkMh.getDangKyMonHoc_SV(maSV);
        }
    }
}
