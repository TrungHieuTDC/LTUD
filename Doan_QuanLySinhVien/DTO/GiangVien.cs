using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        private string maGV;
        private string tenGV;
        private string email;
        private string sdt;
        private string maKhoa;

        public GiangVien(string maGV, string tenGV, string email, string sdt, string maKhoa)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.email = email;
            this.sdt = sdt;
            this.maKhoa = maKhoa;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
