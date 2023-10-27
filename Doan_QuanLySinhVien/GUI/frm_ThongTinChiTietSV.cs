using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_ThongTinChiTietSV : Form
    {
        private SinhVien sinhVien;

        public SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }

        public frm_ThongTinChiTietSV()
        {
            InitializeComponent();
        }

        private void frm_ThongTinChiTietSV_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = sinhVien.MaSV;
            txtHoTenSV.Text = sinhVien.HoTenSV;
            txtNgaySinh.Text = sinhVien.NgaySinh.ToString();
            txtGioiTinh.Text = sinhVien.GioiTinh;
            txtCCCD.Text = sinhVien.Cccd;
            txtKhoaHoc.Text = sinhVien.KhoaHoc;
            txtEmail.Text = sinhVien.Email;
            txtSDT.Text = sinhVien.SDT;
            txtDiem.Text = Convert.ToString(sinhVien.Diem);
            txtTenCVHT.Text = sinhVien.TenCVHT;
            txtMaKhoa.Text = sinhVien.MaKhoa;
            txtMaLop.Text = sinhVien.MaLop;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinSinhVien frmThongTinSV = new frm_ThongTinSinhVien();
            frmThongTinSV.ShowDialog();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SuaThongTinSV frmSuaSV = new frm_SuaThongTinSV();
            frmSuaSV.SinhVien = sinhVien;
            frmSuaSV.ShowDialog();
            this.Close();

        }
    }
}
