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
    public partial class frm_TimKiemSinhVien : Form
    {
        BUS_SinhVien bus_sinhvien = new BUS_SinhVien();
        public frm_TimKiemSinhVien()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa");
                return;
            }
            DataTable dt = bus_sinhvien.Search_SV_MaSV(txtMaSV.Text);
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

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn muốn xóa nhân viên có mã {txtMaSV.Text} này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = bus_sinhvien.Delete_SinhVien(txtMaSV.Text);
                if (i >= 0)
                {
                    this.Hide();
                    frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
                    frmTTSV.ShowDialog();
                    this.Close();
                }
            }
           
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //DataTable dt = bus_sinhvien.Search_SinhVien(txtTuKhoa.Text);
            DataTable dt = bus_sinhvien.Search_SV_MaSV(txtTuKhoa.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy kết quả cho từ khóa{txtTuKhoa.Text}");
                txtTuKhoa.Text = null;
            }
            else
            {
                dtGV_ThongTin.DataSource = dt;
                gB_Btn.Visible = true;
            }
            
        }

        private void frm_TimKiemSinhVien_Load(object sender, EventArgs e)
        {
            gB_Btn.Visible = false;
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Focus())
            {
                gB_Btn.Visible = false;
                dtGV_ThongTin.DataSource = null;
            }
        }

        private void dtGV_ThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            txtMaSV.Text = dtGV_ThongTin.Rows[iDong].Cells[0].Value.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
            frmTTSV.ShowDialog();
            this.Close();
        }
    }
}
