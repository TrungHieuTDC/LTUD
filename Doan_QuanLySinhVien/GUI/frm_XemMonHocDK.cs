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
    public partial class frm_XemMonHocDK : Form
    {
        BUS_DangKyMonHoc bus_MHDK_SV = new BUS_DangKyMonHoc();
        BUS_KetQuaDiemThiSV bus_kqDiemThi = new BUS_KetQuaDiemThiSV();
        BUS_SinhVien bus_Sv = new BUS_SinhVien();
        private string maSV = "";
        private string maMH = "";
        public frm_XemMonHocDK()
        {
            InitializeComponent();
        }

        public string MaSV { get => maSV; set => maSV = value; }

        private void frm_XemMonHocDK_Load(object sender, EventArgs e)
        {
            txtMaSV.Text = this.maSV;
            dtGV_ThongTin.DataSource = bus_MHDK_SV.getDataDangMyMH_SV(maSV);
            gBNhapDiem.Visible = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
            frmTTSV.ShowDialog();
            this.Close();
        }

        private void dtGV_ThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idong = e.RowIndex;
            maMH = dtGV_ThongTin.Rows[idong].Cells[2].Value.ToString();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (maMH == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn môn học cần nhập điểm");
                return;
            }
            gBNhapDiem.Visible = true;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            float diem = 0;
            int i = 0;
            DataTable dt = bus_kqDiemThi.SearchDataMonHocSV(maSV, maMH);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Môn học này đã có điểm");
                return;
            }
            else 
            {
                KetQuaThiSV kqDiemThi = new KetQuaThiSV(maMH, maSV, float.Parse(txtDiem.Text));
                bus_kqDiemThi.InsertValueDiemThi_SV(kqDiemThi);
                DataTable dtTbl = bus_kqDiemThi.getDataDiemThi_SV(MaSV);
                foreach (DataRow dtR in dtTbl.Rows)
                {
                    diem += float.Parse(Convert.ToString(dtR["DiemThi"]));
                    i++;
                }

                bus_Sv.UpdateDiem_SV(maSV, diem / i);
                txtDiem.Text = null;
            }

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_XemDiemThiSV frmXemDiem = new frm_XemDiemThiSV();
            frmXemDiem.MaSV = txtMaSV.Text;
            frmXemDiem.ShowDialog();
            this.Close();
        }
    }
}
