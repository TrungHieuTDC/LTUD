
namespace GUI
{
    partial class frm_ThongTinSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDV_ThongTin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.btnSuaThongTinSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnChiTietSV = new System.Windows.Forms.Button();
            this.btnXemMHDK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDV_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDV_ThongTin
            // 
            this.dtDV_ThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDV_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDV_ThongTin.Location = new System.Drawing.Point(12, 79);
            this.dtDV_ThongTin.Name = "dtDV_ThongTin";
            this.dtDV_ThongTin.RowHeadersWidth = 62;
            this.dtDV_ThongTin.RowTemplate.Height = 28;
            this.dtDV_ThongTin.Size = new System.Drawing.Size(1039, 364);
            this.dtDV_ThongTin.TabIndex = 0;
            this.dtDV_ThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDV_ThongTin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(380, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sinh viên ";
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSinhVien.Location = new System.Drawing.Point(43, 539);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(294, 33);
            this.btnThemSinhVien.TabIndex = 2;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // btnSuaThongTinSV
            // 
            this.btnSuaThongTinSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongTinSV.Location = new System.Drawing.Point(43, 578);
            this.btnSuaThongTinSV.Name = "btnSuaThongTinSV";
            this.btnSuaThongTinSV.Size = new System.Drawing.Size(294, 33);
            this.btnSuaThongTinSV.TabIndex = 2;
            this.btnSuaThongTinSV.Text = "Sửa thông tin sinh viên";
            this.btnSuaThongTinSV.UseVisualStyleBackColor = true;
            this.btnSuaThongTinSV.Click += new System.EventHandler(this.btnSuaThongTinSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSV.Location = new System.Drawing.Point(357, 539);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(294, 33);
            this.btnXoaSV.TabIndex = 2;
            this.btnXoaSV.Text = "Xóa sinh viên";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(357, 578);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(294, 33);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm sinh viên";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(847, 662);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(381, 491);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(338, 26);
            this.txtMaSV.TabIndex = 4;
            // 
            // btnChiTietSV
            // 
            this.btnChiTietSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietSV.Location = new System.Drawing.Point(43, 617);
            this.btnChiTietSV.Name = "btnChiTietSV";
            this.btnChiTietSV.Size = new System.Drawing.Size(294, 33);
            this.btnChiTietSV.TabIndex = 2;
            this.btnChiTietSV.Text = "Chi tiết sinh viên";
            this.btnChiTietSV.UseVisualStyleBackColor = true;
            this.btnChiTietSV.Click += new System.EventHandler(this.btnChiTietSV_Click);
            // 
            // btnXemMHDK
            // 
            this.btnXemMHDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemMHDK.Location = new System.Drawing.Point(357, 616);
            this.btnXemMHDK.Name = "btnXemMHDK";
            this.btnXemMHDK.Size = new System.Drawing.Size(294, 34);
            this.btnXemMHDK.TabIndex = 5;
            this.btnXemMHDK.Text = "xem môn học đăng ky";
            this.btnXemMHDK.UseVisualStyleBackColor = true;
            this.btnXemMHDK.Click += new System.EventHandler(this.btnXemMHDK_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(674, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Điểm danh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXemMHDK);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiTietSV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnSuaThongTinSV);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDV_ThongTin);
            this.Name = "frm_ThongTinSinhVien";
            this.Text = "frm_ThongTinSinhVien";
            this.Load += new System.EventHandler(this.frm_ThongTinSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDV_ThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDV_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.Button btnSuaThongTinSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnChiTietSV;
        private System.Windows.Forms.Button btnXemMHDK;
        private System.Windows.Forms.Button button1;
    }
}