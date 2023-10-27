
namespace GUI
{
    partial class frm_DiemDanh
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
            this.dtGV_ThongTin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBTinhTrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.gBDiemDanh = new System.Windows.Forms.GroupBox();
            this.btnSuaDiemDanh = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBNgayDD = new System.Windows.Forms.ComboBox();
            this.btnXacNhanNgay = new System.Windows.Forms.Button();
            this.btnKetThucDiemDanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).BeginInit();
            this.gBDiemDanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGV_ThongTin
            // 
            this.dtGV_ThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_ThongTin.Location = new System.Drawing.Point(42, 210);
            this.dtGV_ThongTin.Name = "dtGV_ThongTin";
            this.dtGV_ThongTin.RowHeadersWidth = 62;
            this.dtGV_ThongTin.RowTemplate.Height = 28;
            this.dtGV_ThongTin.Size = new System.Drawing.Size(952, 265);
            this.dtGV_ThongTin.TabIndex = 0;
            this.dtGV_ThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm danh sinh viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(200, 40);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tình trạng:";
            // 
            // cbBTinhTrang
            // 
            this.cbBTinhTrang.FormattingEnabled = true;
            this.cbBTinhTrang.Items.AddRange(new object[] {
            "Vang khong phep",
            "Vang co phep",
            "Vao tre"});
            this.cbBTinhTrang.Location = new System.Drawing.Point(199, 77);
            this.cbBTinhTrang.Name = "cbBTinhTrang";
            this.cbBTinhTrang.Size = new System.Drawing.Size(223, 28);
            this.cbBTinhTrang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(199, 28);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(223, 26);
            this.txtMaSV.TabIndex = 6;
            // 
            // gBDiemDanh
            // 
            this.gBDiemDanh.Controls.Add(this.btnSuaDiemDanh);
            this.gBDiemDanh.Controls.Add(this.btnXacNhan);
            this.gBDiemDanh.Controls.Add(this.label3);
            this.gBDiemDanh.Controls.Add(this.cbBTinhTrang);
            this.gBDiemDanh.Controls.Add(this.txtMaSV);
            this.gBDiemDanh.Controls.Add(this.label2);
            this.gBDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDiemDanh.Location = new System.Drawing.Point(42, 499);
            this.gBDiemDanh.Name = "gBDiemDanh";
            this.gBDiemDanh.Size = new System.Drawing.Size(599, 193);
            this.gBDiemDanh.TabIndex = 7;
            this.gBDiemDanh.TabStop = false;
            this.gBDiemDanh.Text = "Điểm danh sinh viên";
            // 
            // btnSuaDiemDanh
            // 
            this.btnSuaDiemDanh.Location = new System.Drawing.Point(294, 132);
            this.btnSuaDiemDanh.Name = "btnSuaDiemDanh";
            this.btnSuaDiemDanh.Size = new System.Drawing.Size(275, 39);
            this.btnSuaDiemDanh.TabIndex = 7;
            this.btnSuaDiemDanh.Text = "Sửa điểm danh nhân viên";
            this.btnSuaDiemDanh.UseVisualStyleBackColor = true;
            this.btnSuaDiemDanh.Click += new System.EventHandler(this.btnSuaDiemDanh_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(74, 132);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(190, 39);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày điểm danh";
            // 
            // cbBNgayDD
            // 
            this.cbBNgayDD.FormattingEnabled = true;
            this.cbBNgayDD.Location = new System.Drawing.Point(381, 122);
            this.cbBNgayDD.Name = "cbBNgayDD";
            this.cbBNgayDD.Size = new System.Drawing.Size(340, 28);
            this.cbBNgayDD.TabIndex = 9;
            // 
            // btnXacNhanNgay
            // 
            this.btnXacNhanNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanNgay.Location = new System.Drawing.Point(743, 118);
            this.btnXacNhanNgay.Name = "btnXacNhanNgay";
            this.btnXacNhanNgay.Size = new System.Drawing.Size(145, 35);
            this.btnXacNhanNgay.TabIndex = 10;
            this.btnXacNhanNgay.Text = "Xác nhận";
            this.btnXacNhanNgay.UseVisualStyleBackColor = true;
            this.btnXacNhanNgay.Click += new System.EventHandler(this.btnXacNhanNgay_Click);
            // 
            // btnKetThucDiemDanh
            // 
            this.btnKetThucDiemDanh.Location = new System.Drawing.Point(700, 530);
            this.btnKetThucDiemDanh.Name = "btnKetThucDiemDanh";
            this.btnKetThucDiemDanh.Size = new System.Drawing.Size(275, 91);
            this.btnKetThucDiemDanh.TabIndex = 7;
            this.btnKetThucDiemDanh.Text = "Lưu điểm danh";
            this.btnKetThucDiemDanh.UseVisualStyleBackColor = true;
            this.btnKetThucDiemDanh.Click += new System.EventHandler(this.btnKetThucDiemDanh_Click);
            // 
            // frm_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1020, 704);
            this.Controls.Add(this.btnKetThucDiemDanh);
            this.Controls.Add(this.btnXacNhanNgay);
            this.Controls.Add(this.cbBNgayDD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gBDiemDanh);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGV_ThongTin);
            this.Name = "frm_DiemDanh";
            this.Text = "frm_DiemDanh";
            this.Load += new System.EventHandler(this.frm_DiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).EndInit();
            this.gBDiemDanh.ResumeLayout(false);
            this.gBDiemDanh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGV_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBTinhTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox gBDiemDanh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSuaDiemDanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBNgayDD;
        private System.Windows.Forms.Button btnXacNhanNgay;
        private System.Windows.Forms.Button btnKetThucDiemDanh;
    }
}