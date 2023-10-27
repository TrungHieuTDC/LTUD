using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class MonHoc
    {
        private string maMH;
        private string tenMH;

        public MonHoc(string maMH, string tenMH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
        }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
    }
}
