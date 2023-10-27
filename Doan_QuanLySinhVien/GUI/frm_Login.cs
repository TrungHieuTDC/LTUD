using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập email vào");
            }
            else if (txtMK.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu vào");
            }
            else
            {
                if (txtEmail.Text == "nva@gmail.com" && txtMK.Text == "1234")
                {
                    this.Hide();
                    frm_ThongTinSinhVien frmTTSV = new frm_ThongTinSinhVien();
                    frmTTSV.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu và email");
                    txtMK.Clear();
                    txtEmail.Clear();
                }
                
            }
             
        }
    }
}
