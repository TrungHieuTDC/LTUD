using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_DiemDanh : Form
    {
        private string maSV = null;
        DateTime tgian = new DateTime();
        BUS_DiemDanh bus_diemDanh = new BUS_DiemDanh();
        BUS_SinhVien bus_sinhVien = new BUS_SinhVien();
        public frm_DiemDanh()
        {
            InitializeComponent();
        }

        private void frm_DiemDanh_Load(object sender, EventArgs e)
        {
            gBDiemDanh.Visible = true;
            cbBNgayDD.DataSource = bus_diemDanh.getNgayDaDiemDanh();
            cbBNgayDD.ValueMember = "NgayDiemDanh";
            cbBNgayDD.DisplayMember = "NgayDiemDanh";
            cbBNgayDD.SelectedItem = null;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            maSV = dtGV_ThongTin.Rows[iDong].Cells[0].Value.ToString();
            gBDiemDanh.Visible = true;
            txtMaSV.Text = maSV;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime ngayDD = DateTime.Now;
            DataTable dtTbl = bus_diemDanh.SearchDiemDanhSV_MaSV(txtMaSV.Text, ngayDD);
            if (dtTbl.Rows.Count > 0)
            {
                MessageBox.Show($"Sinh viên có mã {txtMaSV.Text} đã điểm danh rồi");
            }
            else
            {
                bus_diemDanh.InsertDiemDanh_SV(txtMaSV.Text, ngayDD, cbBTinhTrang.Text);
            }
                txtMaSV.Text = null;
                cbBTinhTrang.SelectedItem = null;
            dtGV_ThongTin.DataSource = bus_diemDanh.getData_DiemDanh();
           cbBNgayDD.DataSource =  bus_diemDanh.getNgayDaDiemDanh();
            cbBNgayDD.ValueMember = "NgayDiemDanh";
            cbBNgayDD.DisplayMember = "NgayDiemDanh";
            cbBNgayDD.SelectedItem = null;

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
            frmTTSV.ShowDialog();
            this.Close();
        }

        private void btnSuaDiemDanh_Click(object sender, EventArgs e)
        {
            
            if(txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần sửa điểm danh");
                return;
            }
            this.Hide();
            frm_SuaDiemDanh frmSuaDD = new frm_SuaDiemDanh();
            frmSuaDD.MaNV = txtMaSV.Text;
            frmSuaDD.NgayDiemDanh = tgian;
            frmSuaDD.ShowDialog();
            this.Close();
        }

        private void btnXacNhanNgay_Click(object sender, EventArgs e)
        {
            if (cbBNgayDD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn ngày cần hiện danh sách sinh viên điểm danh");
                return;
            }
            string[] tg = cbBNgayDD.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(tg[2]), int.Parse(tg[1]), int.Parse(tg[0]));
            dtGV_ThongTin.DataSource = bus_diemDanh.SearchDiemDanhSV_NgayDD
                (dt);
            tgian = dt;
        }

        private void btnKetThucDiemDanh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu điểm danh không ?","Thong bao",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dtTbl = bus_sinhVien.getData_SinhVien();
                foreach (DataRow dtR in dtTbl.Rows)
                {
                    DataTable dtTbl1 = bus_diemDanh.SearchDiemDanhSV_MaSV(Convert.ToString(dtR["MaSV"]), DateTime.Now);
                    if (dtTbl1.Rows.Count <= 0)
                    {
                        bus_diemDanh.InsertDiemDanh_SVAll(Convert.ToString(dtR["MaSV"]), DateTime.Now, "Vang khong phep");
                    }
                }
                this.Hide();
                frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
                frmTTSV.ShowDialog();
                this.Close();
            }

        }
    }
}
