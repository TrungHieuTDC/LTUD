using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class LichMonHoc
    {
        private string maGV;
        private string maMon;
        private DateTime ngayBDHoc;

        public LichMonHoc(string maGV, string maMon, DateTime ngayBDHoc)
        {
            this.maGV = maGV;
            this.maMon = maMon;
            this.ngayBDHoc = ngayBDHoc;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public DateTime NgayBDHoc { get => ngayBDHoc; set => ngayBDHoc = value; }
    }
}
