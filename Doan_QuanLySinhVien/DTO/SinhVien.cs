using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace DTO
{
   public class SinhVien
    {
        private string maSV;
        private string hoTenSV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string cccd;
        private string khoaHoc;
        private string email;
        private string sDT;
        private float diem;
        private string tenCVHT;
        private string maKhoa;
        private string maLop;

        //public SinhVien(string hoTenSV, DateTime ngaySinh, string gioiTinh, string cccd, string khoaHoc, string email, string sDT, string tenCVHT, string maKhoa, string maLop)
        //{
           
        //    this.maSV = "SV" + RanDomMaSV();
        //    this.hoTenSV = hoTenSV;
        //    this.ngaySinh = ngaySinh;
        //    this.gioiTinh = gioiTinh;
        //    this.cccd = cccd;
        //    this.khoaHoc = khoaHoc;
        //    this.email = email;
        //    this.sDT = sDT;
        //    this.diem = 0.0f;
        //    this.tenCVHT = tenCVHT;
        //    this.maKhoa = maKhoa;
        //    this.maLop = maLop;
        //}

        //private string RanDomMaSV()
        //{
        //    int kq = 0;
        //    string maSV = "";
        //    Random rd = new Random();
        //    for(int i =1;i<=4;i++)
        //    {
        //        kq = rd.Next(0, 10);
        //        maSV = string.Concat(maSV, Convert.ToString(kq));
        //    }
        //    if (maSV == "0000" || checkMaSV("SV"+maSV).Rows.Count ==0)
        //    {
        //        RanDomMaSV();
        //    }
        //    return maSV;
        //}

        //private DataTable checkMaSV(string maSV)
        //{
        //    ConnectSQL();
        //    DataTable dtTbl = new DataTable();
        //    SqlCommand sqlCmd = new SqlCommand("SearchMaSV", conn);
        //    sqlCmd.CommandType = CommandType.StoredProcedure;
        //    sqlCmd.Parameters.AddWithValue("@sMaSV", maSV);
        //    SqlDataAdapter sqldtAp = new SqlDataAdapter(sqlCmd);
        //    sqldtAp.Fill(dtTbl);
        //    return dtTbl;
        //}

       

        public SinhVien(string maSV, string hoTenSV, DateTime ngaySinh, string gioiTinh, string cccd, string khoaHoc, string email, string sDT, float diem, string tenCVHT, string maKhoa, string maLop)
        {
            this.maSV = maSV;
            this.hoTenSV = hoTenSV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = cccd;
            this.khoaHoc = khoaHoc;
            this.email = email;
            this.sDT = sDT;
            this.diem = diem;
            this.tenCVHT = tenCVHT;
            this.maKhoa = maKhoa;
            this.maLop = maLop;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTenSV { get => hoTenSV; set => hoTenSV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public float Diem { get => diem; set => diem = value; }
        public string TenCVHT { get => tenCVHT; set => tenCVHT = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}
