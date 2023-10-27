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
   public class BUS_Khoa
    {
        DAL_Khoa dal_Khoa = new DAL_Khoa();
        public DataTable getData_Khoa()
        {
            return dal_Khoa.getData_Khoa();
        }

        public int InsertValue_Khoa(Khoa khoa)
        {
            string maKhoa = khoa.MaKhoa;
            string tenKhoa = khoa.TenKhoa;

            return dal_Khoa.InsertValue_Khoa(maKhoa, tenKhoa);
        }

        public DataTable Search_Khoa_TenKhoa(string tenKhoa)
        {
            return dal_Khoa.Search_Khoa_TenKhoa(tenKhoa);
        }

        public DataTable Search_Khoa_MaKhoa(string maKhoa)
        {
            return dal_Khoa.Search_Khoa_MaKhoa(maKhoa);
        }
    }
}
