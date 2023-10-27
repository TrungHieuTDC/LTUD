using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop dal_lop = new DAL_Lop();
        public DataTable getData_Lop()
        {
            return dal_lop.getData_LopHoc();
        }

        public int InsertValue_Lop(Lop lop)
        {
            string maLop = lop.MaLop;
            string tenLop = lop.TenLop;
            string maKhoa = lop.MaKhoa;

            return dal_lop.InsertValue_Lop(maLop, tenLop, maKhoa);
        }

        public DataTable Search_Lop_TenLop(string tenLop)
        {
            return dal_lop.Search_Lop_TenLop(tenLop);
        }

        public DataTable Search_Lop_MaLop(string maLop)
        {
            return dal_lop.Search_Lop_MaLop(maLop);
        }
    }
}
