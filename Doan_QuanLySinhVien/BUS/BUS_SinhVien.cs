using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Windows.Forms;
namespace BUS
{
    public class BUS_SinhVien
    {
        private DAL_SinhVien dal_SinhVien = new DAL_SinhVien();
        public DataTable getData_SinhVien()
        {
            return dal_SinhVien.getData_SinhVien();
        }

        public int InsertValue_SinhVien(SinhVien sinhVien)
        {
            
            return dal_SinhVien.InsertValue_SinhVien(sinhVien.MaSV, sinhVien.HoTenSV, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.Cccd, sinhVien.KhoaHoc, sinhVien.Email, sinhVien.SDT, sinhVien.Diem, sinhVien.TenCVHT, sinhVien.MaKhoa, sinhVien.MaLop);
        }

        public DataTable Search_SV_MaSV(string maSV)
        {
            return dal_SinhVien.Search_Sv_MaSV(maSV);
        }

        public int Update_SinhVien(string maSV, string tenSV, string CCCD,string email, string SDT, DateTime ngaySinh)
        {
            return dal_SinhVien.Update_SinhVien(maSV, tenSV, CCCD, email, SDT, ngaySinh);
        }

        public int Delete_SinhVien(string maSV)
        {
            return dal_SinhVien.Delete_SinhVien(maSV);
        }

        public int UpdateDiem_SV(string maSV, float diem)
        {
            return dal_SinhVien.UpdateDiem_SV(maSV, diem);
        }

        

    }
}
