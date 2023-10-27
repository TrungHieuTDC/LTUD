using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_ThemSinhVien : Form
    {
        BUS_Khoa bus_khoa = new BUS_Khoa();
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_SinhVien bus_sinhVien=  new BUS_SinhVien();
        public frm_ThemSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = Random_MaSV();
            string hoTen = txtHoTen.Text;
            string mKh = "";
            string ml = "";
            DataTable dt = bus_khoa.Search_Khoa_TenKhoa(cbB_Khoa.Text);
            foreach (DataRow dtr in dt.Rows)
            {
                mKh = Convert.ToString(dtr["MaKhoa"]);
            }

            dt = bus_lop.Search_Lop_TenLop(cbB_Lop.Text);
            foreach(DataRow dtr in dt.Rows)
            {
                ml = Convert.ToString(dtr["MaLop"]);
            }
            DateTime ngaySinh = dtPK_NgaySinh.Value;
            string gioiTinh = cbB_gioiTinh.SelectedItem.ToString();
            string cccd = txtCCCD.Text;
            float diem = 0.0f;
            string khoahoc = cbB_Khoahoc.Text;
            string email = txtemail.Text;
            string sdt = txtSDT.Text;
            string tenCVHT = txtCVHT.Text;
            string maKhoa = mKh;
            string maLop = ml;
            string[] ds_ThongTinSV = new string[] { hoTen, gioiTinh, cccd, khoahoc, email, sdt, tenCVHT, mKh, ml };
            if (checkValue(ds_ThongTinSV) == false)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin sinh viên");
                return;
            }
            SinhVien sinhVien = new SinhVien(maSV,hoTen, ngaySinh, gioiTinh, cccd, khoahoc, email, sdt,diem, tenCVHT, mKh, ml);

           int i = bus_sinhVien.InsertValue_SinhVien(sinhVien);
            
            if(i >= 0)
            {

                this.Hide();
                frm_ThongTinSinhVien frmThongTinSV = new 
                frm_ThongTinSinhVien();
                frmThongTinSV.ShowDialog();
                this.Close();
                
            }


        }

        private string Random_MaSV()
        {
            Random rd = new Random();
            int kq = 0;
            string maSV = "SV";
            for (int i =1;i<=4;i++)
            {
                kq = rd.Next(0, 10);
                maSV = string.Concat(maSV, Convert.ToString(kq));
            }
            return maSV;
        }

        //private bool SearchMaSV(string maSV)
        //{
        //    MessageBox.Show(maSV);
        //    DataTable dt = new DataTable();
        //    dt = bus_sinhVien.Search_SV_MaSV("SV2439");
        //    foreach(DataRow dtr in dt.Rows)
        //    {
        //        MessageBox.Show($"{dtr["MaSV"]}");
        //    }
        //    return false;
        //}

        private bool checkValue(string [] ds_ThongTinSV)
        {
            foreach(string thongTin in ds_ThongTinSV)
            {
                if (thongTin == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
        private void form_ThemSinhVien_Load(object sender, EventArgs e)
        {
            
            cbB_Khoa.DataSource = bus_khoa.getData_Khoa();
            cbB_Lop.DataSource = bus_lop.getData_Lop();
            cbB_Khoa.ValueMember = "MaKhoa";
            cbB_Khoa.DisplayMember = "TenKhoa";
            cbB_Khoa.SelectedItem = null;
            cbB_Lop.ValueMember = "MaLop";
            cbB_Lop.DisplayMember = "TenLop";
            cbB_Lop.SelectedItem = null;
        }

        private void btnDanhSachSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinSinhVien frmThongTinSV = new frm_ThongTinSinhVien();
            frmThongTinSV.ShowDialog();
            this.Close();

        }
    }
}
