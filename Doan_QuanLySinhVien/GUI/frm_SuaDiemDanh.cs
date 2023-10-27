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
    public partial class frm_SuaDiemDanh : Form
    {
        private string maNV;
        private DateTime ngayDiemDanh;
        BUS_DiemDanh bus_DD = new BUS_DiemDanh();
        public frm_SuaDiemDanh()
        {
            InitializeComponent();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayDiemDanh { get => ngayDiemDanh; set => ngayDiemDanh = value; }

        private void frm_SuaDiemDanh_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = this.maNV;
            cbBTinhTrang.SelectedItem = null;  
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DiemDanh frmDD = new frm_DiemDanh();
            frmDD.ShowDialog();
            this.Close();

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbBTinhTrang.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn trình trạng cho nhân viên đó");
                return;
            }
            if (bus_DD.UpdateDiemDanh_SV(this.maNV,this.ngayDiemDanh,cbBTinhTrang.Text)>=0)
            {
                this.Hide();
                frm_DiemDanh frmDD = new frm_DiemDanh();
                frmDD.ShowDialog();
                this.Close();
            }
        }
    }
}
