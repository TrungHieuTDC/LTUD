
namespace GUI
{
    partial class frm_XemMonHocDK
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
            this.dtGV_ThongTin = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.gBNhapDiem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).BeginInit();
            this.gBNhapDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách môn học sinh viên đã đăng ký";
            // 
            // dtGV_ThongTin
            // 
            this.dtGV_ThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_ThongTin.Location = new System.Drawing.Point(87, 139);
            this.dtGV_ThongTin.Name = "dtGV_ThongTin";
            this.dtGV_ThongTin.RowHeadersWidth = 62;
            this.dtGV_ThongTin.RowTemplate.Height = 28;
            this.dtGV_ThongTin.Size = new System.Drawing.Size(878, 228);
            this.dtGV_ThongTin.TabIndex = 1;
            this.dtGV_ThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_ThongTin_CellClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(156, 37);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(300, 91);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(219, 26);
            this.txtMaSV.TabIndex = 4;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDiem.Location = new System.Drawing.Point(115, 387);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(353, 36);
            this.btnNhapDiem.TabIndex = 5;
            this.btnNhapDiem.Text = "Nhập điểm thi";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // gBNhapDiem
            // 
            this.gBNhapDiem.Controls.Add(this.btnXacNhan);
            this.gBNhapDiem.Controls.Add(this.txtDiem);
            this.gBNhapDiem.Controls.Add(this.label3);
            this.gBNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNhapDiem.Location = new System.Drawing.Point(493, 387);
            this.gBNhapDiem.Name = "gBNhapDiem";
            this.gBNhapDiem.Size = new System.Drawing.Size(472, 205);
            this.gBNhapDiem.TabIndex = 6;
            this.gBNhapDiem.TabStop = false;
            this.gBNhapDiem.Text = "Nhập điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(130, 62);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(190, 30);
            this.txtDiem.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(107, 121);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(232, 48);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.Location = new System.Drawing.Point(115, 438);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(353, 36);
            this.btnXemDiem.TabIndex = 5;
            this.btnXemDiem.Text = "Xem điểm thi";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // frm_XemMonHocDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.gBNhapDiem);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.dtGV_ThongTin);
            this.Controls.Add(this.label1);
            this.Name = "frm_XemMonHocDK";
            this.Text = "frm_XemMonHocDK";
            this.Load += new System.EventHandler(this.frm_XemMonHocDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_ThongTin)).EndInit();
            this.gBNhapDiem.ResumeLayout(false);
            this.gBNhapDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGV_ThongTin;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.GroupBox gBNhapDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnXemDiem;
    }
}