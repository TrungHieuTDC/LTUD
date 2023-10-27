
namespace GUI
{
    partial class frm_TimKiemSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.dtGV_ThongTin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaSinhVien = new System.Windows.Forms.Button();
            this.gB_Btn = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).BeginInit();
            this.gB_Btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm sinh viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(167, 108);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 43);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(348, 108);
            this.txtTuKhoa.Multiline = true;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(326, 37);
            this.txtTuKhoa.TabIndex = 2;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // dtGV_ThongTin
            // 
            this.dtGV_ThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_ThongTin.Location = new System.Drawing.Point(33, 262);
            this.dtGV_ThongTin.Name = "dtGV_ThongTin";
            this.dtGV_ThongTin.RowHeadersWidth = 62;
            this.dtGV_ThongTin.RowTemplate.Height = 28;
            this.dtGV_ThongTin.Size = new System.Drawing.Size(898, 263);
            this.dtGV_ThongTin.TabIndex = 3;
            this.dtGV_ThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_ThongTin_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(399, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(185, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(300, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(267, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(68, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(232, 38);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa thông tin sinh viên";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaSinhVien
            // 
            this.btnXoaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSinhVien.Location = new System.Drawing.Point(363, 79);
            this.btnXoaSinhVien.Name = "btnXoaSinhVien";
            this.btnXoaSinhVien.Size = new System.Drawing.Size(232, 38);
            this.btnXoaSinhVien.TabIndex = 6;
            this.btnXoaSinhVien.Text = "Xóa sinh viên";
            this.btnXoaSinhVien.UseVisualStyleBackColor = true;
            this.btnXoaSinhVien.Click += new System.EventHandler(this.btnXoaSinhVien_Click);
            // 
            // gB_Btn
            // 
            this.gB_Btn.Controls.Add(this.btnXoaSinhVien);
            this.gB_Btn.Controls.Add(this.label3);
            this.gB_Btn.Controls.Add(this.txtMaSV);
            this.gB_Btn.Controls.Add(this.btnSua);
            this.gB_Btn.Location = new System.Drawing.Point(144, 539);
            this.gB_Btn.Name = "gB_Btn";
            this.gB_Btn.Size = new System.Drawing.Size(625, 132);
            this.gB_Btn.TabIndex = 7;
            this.gB_Btn.TabStop = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(22, 33);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(165, 36);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frm_TimKiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 683);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.gB_Btn);
            this.Controls.Add(this.dtGV_ThongTin);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_TimKiemSinhVien";
            this.Text = "frm_TimKiemSinhVien";
            this.Load += new System.EventHandler(this.frm_TimKiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).EndInit();
            this.gB_Btn.ResumeLayout(false);
            this.gB_Btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridView dtGV_ThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoaSinhVien;
        private System.Windows.Forms.GroupBox gB_Btn;
        private System.Windows.Forms.Button btnQuayLai;
    }
}