using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_GiangVien
    {
        DAL_GiangVien dal_giangVien = new DAL_GiangVien();
        public DataTable getData_GiangVien()
        {
            return dal_giangVien.getData_GiangVien();
        }

        public int InsertValue_GiangVien(GiangVien giangVien)
        {
            return dal_giangVien.InsertValue_GiangVien(giangVien.MaGV, giangVien.TenGV, giangVien.Email, giangVien.Sdt, giangVien.MaKhoa);
        }
    }
}
