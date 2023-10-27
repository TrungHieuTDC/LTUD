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
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_XemDiemThiSV : Form
    {
        BUS_SinhVien bus_SV = new BUS_SinhVien();
        string maSV = "";
        BUS_KetQuaDiemThiSV bus_kqDiemThi = new BUS_KetQuaDiemThiSV();
        private string maMH = "";
        public frm_XemDiemThiSV()
        {
            InitializeComponent();
        }

        public string MaSV { get => maSV; set => maSV = value; }

        private void frm_XemDiemThiSV_Load(object sender, EventArgs e)
        {
            DataTable dtTbl = bus_kqDiemThi.getDataDiemThi_SV(maSV);
            dtGv_ThongTin.DataSource = dtTbl;
            if (dtTbl.Rows.Count <= 0)
            {
                MessageBox.Show($"Sinh viên có mã {maSV} chưa có điểm thi môn nào");
                return;
            }
            
                gBSuaDiem.Visible = false;
            
         
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_XemMonHocDK frmMHDK = new frm_XemMonHocDK();
            frmMHDK.MaSV = this.maSV;
            frmMHDK.ShowDialog();
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            gBSuaDiem.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float diem = 0;
            int i = 0;
            if (txtDiemThi.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập điểm vào");
            }
            else if (maMH == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn Môn học cần sửa điểm");
            }
            else
            {
                KetQuaThiSV kq = new KetQuaThiSV(maMH, maSV, float.Parse(txtDiemThi.Text));
                if (bus_kqDiemThi.UpdateDiemThi_SV(kq) >= 0)
                {
                    //dtGv_ThongTin.DataSource = bus_kqDiemThi.getDataDiemThi_SV(maSV);
                    DataTable dtTbl = bus_kqDiemThi.getDataDiemThi_SV(MaSV);
                    foreach (DataRow dtR in dtTbl.Rows)
                    {
                        diem += float.Parse(Convert.ToString(dtR["DiemThi"]));
                        i++;
                    }

                    bus_SV.UpdateDiem_SV(maSV, diem / i);

                }
                dtGv_ThongTin.DataSource = bus_kqDiemThi.getDataDiemThi_SV(maSV);
                txtDiemThi.Text = null;
                gBSuaDiem.Visible = false;
            }

        }

        private void dtGv_ThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            maMH = dtGv_ThongTin.Rows[i].Cells[1].Value.ToString();
        }
    }
}
