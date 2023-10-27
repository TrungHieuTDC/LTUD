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
    public partial class frm_ThongTinSinhVien : Form
    {
        BUS_SinhVien bus_sinhVien = new BUS_SinhVien();
        frm_ThemSinhVien frmThemSV = new frm_ThemSinhVien();
        public frm_ThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemSV.ShowDialog();
            this.Close();
            
        }

        private void frm_ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            dtDV_ThongTin.DataSource = bus_sinhVien.getData_SinhVien();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThemSinhVien frmThemSV = new frm_ThemSinhVien();
            frmThemSV.ShowDialog();
            this.Close();
        }

        private void btnSuaThongTinSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa");
                return;
            }
            DataTable dt = bus_sinhVien.Search_SV_MaSV(txtMaSV.Text);
            string maSV = "";
            string tenSV = "";
            DateTime ngaySinh = new DateTime();
            string gioiTinh = "";
            string cccd = "";
            string khoaHoc = "";
            string email = "";
            string sdt = "";
            float diem = 0.0f;
            string tenCVHT = "";
            string maKhoa = "";
            string maLop = "";
            foreach (DataRow dtr in dt.Rows)
            {
                maSV = Convert.ToString(dtr["MaSV"]);
                tenSV = Convert.ToString(dtr["HoTenSV"]);
                ngaySinh = (DateTime)dtr["NgaySinh"];
                gioiTinh = Convert.ToString(dtr["GioiTinh"]);
                cccd = Convert.ToString(dtr["CCCD"]);
                khoaHoc = Convert.ToString(dtr["KhoaHoc"]);
                email = Convert.ToString(dtr["Email"]);
                sdt = Convert.ToString(dtr["SDT"]);
                diem = float.Parse(Convert.ToString(dtr["Diem"]));
                tenCVHT = Convert.ToString(dtr["TenCVHT"]);
                maKhoa = Convert.ToString(dtr["MaKhoa"]);
                maLop = Convert.ToString(dtr["MaLop"]);
            }

            SinhVien sinhVien = new SinhVien(maSV, tenSV, ngaySinh, gioiTinh, cccd, khoaHoc, email, sdt, diem, tenCVHT, maKhoa, maLop);
            this.Hide();
            frm_SuaThongTinSV frmSuaSV = new frm_SuaThongTinSV();
            frmSuaSV.SinhVien = sinhVien;
            frmSuaSV.ShowDialog();
            this.Close();

        }

        private void dtDV_ThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaSV.Text = dtDV_ThongTin.Rows[iDong].Cells[0].Value.ToString();
        }

        private void btnChiTietSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xem thông tin chi tiết");
                return;
            }

            DataTable dt = bus_sinhVien.Search_SV_MaSV(txtMaSV.Text);
            string maSV = "";
            string tenSV = "";
            DateTime ngaySinh = new DateTime();
            string gioiTinh = "";
            string cccd = "";
            string khoaHoc = "";
            string email = "";
            string sdt = "";
            float diem = 0.0f;
            string tenCVHT = "";
            string maKhoa = "";
            string maLop = "";
            foreach (DataRow dtr in dt.Rows)
            {
                maSV = Convert.ToString(dtr["MaSV"]);
                tenSV = Convert.ToString(dtr["HoTenSV"]);
                ngaySinh = (DateTime)dtr["NgaySinh"];
                gioiTinh = Convert.ToString(dtr["GioiTinh"]);
                cccd = Convert.ToString(dtr["CCCD"]);
                khoaHoc = Convert.ToString(dtr["KhoaHoc"]);
                email = Convert.ToString(dtr["Email"]);
                sdt = Convert.ToString(dtr["SDT"]);
                diem = float.Parse(Convert.ToString(dtr["Diem"]));
                tenCVHT = Convert.ToString(dtr["TenCVHT"]);
                maKhoa = Convert.ToString(dtr["MaKhoa"]);
                maLop = Convert.ToString(dtr["MaLop"]);
            }

            SinhVien sinhVien = new SinhVien(maSV, tenSV, ngaySinh, gioiTinh, cccd, khoaHoc, email, sdt, diem, tenCVHT, maKhoa, maLop);
            this.Hide();
            frm_ThongTinChiTietSV frmChiTietSV = new frm_ThongTinChiTietSV();
            frmChiTietSV.SinhVien = sinhVien;
            frmChiTietSV.ShowDialog();
            this.Close();

        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần xóa");
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn muốn xóa sinh viên có mã {txtMaSV.Text} này không","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = bus_sinhVien.Delete_SinhVien(txtMaSV.Text);
                if (i >= 0)
                {
                    dtDV_ThongTin.DataSource = bus_sinhVien.getData_SinhVien();

                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TimKiemSinhVien frmTKSV = new frm_TimKiemSinhVien();
            frmTKSV.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemMHDK_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xem môn học đã đăng ký");
                return;
            }
            this.Hide();
            frm_XemMonHocDK frmMHDK = new frm_XemMonHocDK();
            frmMHDK.MaSV = txtMaSV.Text;
            frmMHDK.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DiemDanh frmDD = new frm_DiemDanh();
            frmDD.ShowDialog();
            this.Close();
        }
    }
}
