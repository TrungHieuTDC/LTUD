using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DangKyMonHoc
    {
        private string maMH;
        private string maSV;

        public DangKyMonHoc(string maMH, string maSV)
        {
            this.maMH = maMH;
            this.maSV = maSV;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string MaSV { get => maSV; set => maSV = value; }
    }
}
