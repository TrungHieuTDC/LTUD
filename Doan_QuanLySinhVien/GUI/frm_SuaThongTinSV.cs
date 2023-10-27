using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_SuaThongTinSV : Form
    {
        BUS_Khoa bus_khoa = new BUS_Khoa();
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_SinhVien bus_sinhVien = new BUS_SinhVien();
        private SinhVien sinhVien;
        public SinhVien SinhVien { get => sinhVien; set => sinhVien = value; }
        public frm_SuaThongTinSV()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string[] ds_ThongTinSua = new string[] { txtTenSV.Text, dtPK_NgaySinh.Text, txtCCCD.Text, txtEmail.Text, txtSoDT.Text };
            if (checkValue(ds_ThongTinSua) == false)
            {
                MessageBox.Show("Vui lòng đủ thông tin nhân viên");
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn chắn chắc muốn sửa thông tin sinh viên có mã {txtMaSV.Text} này chứ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int i = bus_sinhVien.Update_SinhVien(txtMaSV.Text, txtTenSV.Text, txtCCCD.Text, txtEmail.Text, txtSoDT.Text, dtPK_NgaySinh.Value);
                if (i >= 0)
                {
                    this.Hide();
                    frm_ThongTinSinhVien frmThongTinSV = new frm_ThongTinSinhVien();
                    frmThongTinSV.ShowDialog();
                    this.Close();
                }
            }
        }

        private bool checkValue(string [] ds_ThongTinSV)
        {
            foreach(string thongtin in ds_ThongTinSV)
            {
                if (thongtin == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        private void frm_SuaThongTinSV_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = sinhVien.MaSV;
            txtTenSV.Text = sinhVien.HoTenSV;
            dtPK_NgaySinh.Value = sinhVien.NgaySinh;
            txtGioiTinh.Text = sinhVien.GioiTinh;
            txtCCCD.Text = sinhVien.Cccd;
            txtKhoaHoc.Text = sinhVien.KhoaHoc;
            txtEmail.Text = sinhVien.Email;
            txtSoDT.Text = sinhVien.SDT;
            txtDiem.Text = Convert.ToString(sinhVien.Diem);
            txtTenCVHT.Text = sinhVien.TenCVHT;
            DataTable dt = bus_khoa.Search_Khoa_MaKhoa(sinhVien.MaKhoa);
            string tenKhoa = "";
            string tenLop = "";
            foreach(DataRow dtr in dt.Rows)
            {
                tenKhoa = Convert.ToString(dtr["TenKhoa"]);
            }
            txtKhoa.Text = tenKhoa;
            dt = bus_lop.Search_Lop_MaLop(sinhVien.MaLop);
            foreach(DataRow dtr in dt.Rows)
            {
                tenLop = Convert.ToString(dtr["TenLop"]);
            }
            txtLop.Text = tenLop;

        }

        private void dtPK_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCVHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoaHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThemSinhVien frmThongTinSV = new frm_ThemSinhVien();
            frmThongTinSV.ShowDialog();
            this.Close();
        }
    }
}
