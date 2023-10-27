using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Lop
    {
        private string maLop;
        private string tenLop;
        private string maKhoa;

        public Lop(string maLop, string tenLop, string maKhoa)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = maKhoa;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
