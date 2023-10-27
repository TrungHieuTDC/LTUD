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
    public class BUS_DiemDanh
    {
        DAL_DiemDanh dal_diemDanh = new DAL_DiemDanh();
        public DataTable getData_DiemDanh()
        {
            return dal_diemDanh.getData_DiemDanh();
        }
        public int InsertDiemDanh_SV(string maSV, DateTime ngayDiemDanh, string tinhTrang)
        {
            return dal_diemDanh.InsertValue_DiemDanh(maSV, ngayDiemDanh, tinhTrang);
        }

        public int InsertDiemDanh_SVAll(string maSV, DateTime ngayDiemDanh, string tinhTrang)
        {
            return dal_diemDanh.InsertValue_DiemDanhAll(maSV, ngayDiemDanh, tinhTrang);
        }

        public DataTable SearchDiemDanhSV_NgayDD(DateTime ngayDiemDanh)
        {
            return dal_diemDanh.SearchDiemDanh_Ngay(ngayDiemDanh);
        }

        public DataTable SearchDiemDanhSV_MaSV(string maSV,DateTime ngayDiemDanh)
        {
            return dal_diemDanh.Search_DiemDanh_SV(maSV, ngayDiemDanh);
        }

        public int UpdateDiemDanh_SV(string maSV, DateTime ngayDiemDanh, string tinhTrang)
        {
            return dal_diemDanh.UpdateDiemDanh_SV(maSV, ngayDiemDanh, tinhTrang);
        }

        public DataTable getNgayDaDiemDanh()
        {
            return dal_diemDanh.getNgayDaDiemDanh();
        }
    }
}
