using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KetQuaThiSV
    {
        private string maMH;
        private string maSV;
        private float diemThi;

        public KetQuaThiSV(string maMH, string maSV, float diemThi)
        {
            this.maMH = maMH;
            this.maSV = maSV;
            this.diemThi = diemThi;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
    }
}
