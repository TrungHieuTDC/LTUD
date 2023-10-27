using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDanh
    {
        private string maSV;
        private DateTime ngayDiemDanh;
        private string tinhTrang;

        public DiemDanh(string maSV, DateTime ngayDiemDanh, string tinhTrang)
        {
            this.maSV = maSV;
            this.ngayDiemDanh = ngayDiemDanh;
            this.tinhTrang = tinhTrang;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public DateTime NgayDiemDanh { get => ngayDiemDanh; set => ngayDiemDanh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
