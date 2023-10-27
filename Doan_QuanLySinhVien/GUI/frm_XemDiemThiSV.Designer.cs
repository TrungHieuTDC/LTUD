
namespace GUI
{
    partial class frm_XemDiemThiSV
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
            this.dtGv_ThongTin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnSuaDiem = new System.Windows.Forms.Button();
            this.gBSuaDiem = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGv_ThongTin)).BeginInit();
            this.gBSuaDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGv_ThongTin
            // 
            this.dtGv_ThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGv_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGv_ThongTin.Location = new System.Drawing.Point(32, 100);
            this.dtGv_ThongTin.Name = "dtGv_ThongTin";
            this.dtGv_ThongTin.ReadOnly = true;
            this.dtGv_ThongTin.RowHeadersWidth = 62;
            this.dtGv_ThongTin.RowTemplate.Height = 28;
            this.dtGv_ThongTin.Size = new System.Drawing.Size(953, 200);
            this.dtGv_ThongTin.TabIndex = 0;
            this.dtGv_ThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGv_ThongTin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm thi sinh viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 18);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(179, 36);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDiem.Location = new System.Drawing.Point(122, 323);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(235, 40);
            this.btnSuaDiem.TabIndex = 3;
            this.btnSuaDiem.Text = "Sửa điểm thi";
            this.btnSuaDiem.UseVisualStyleBackColor = true;
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // gBSuaDiem
            // 
            this.gBSuaDiem.Controls.Add(this.btnSua);
            this.gBSuaDiem.Controls.Add(this.txtDiemThi);
            this.gBSuaDiem.Controls.Add(this.label2);
            this.gBSuaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSuaDiem.Location = new System.Drawing.Point(450, 323);
            this.gBSuaDiem.Name = "gBSuaDiem";
            this.gBSuaDiem.Size = new System.Drawing.Size(378, 179);
            this.gBSuaDiem.TabIndex = 4;
            this.gBSuaDiem.TabStop = false;
            this.gBSuaDiem.Text = "Sửa điểm thi";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(88, 114);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(197, 39);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Xác nhận";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(137, 46);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(172, 26);
            this.txtDiemThi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm thi:";
            // 
            // frm_XemDiemThiSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1016, 514);
            this.Controls.Add(this.gBSuaDiem);
            this.Controls.Add(this.btnSuaDiem);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGv_ThongTin);
            this.Name = "frm_XemDiemThiSV";
            this.Text = "frm_XemDiemThiSV";
            this.Load += new System.EventHandler(this.frm_XemDiemThiSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGv_ThongTin)).EndInit();
            this.gBSuaDiem.ResumeLayout(false);
            this.gBSuaDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGv_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnSuaDiem;
        private System.Windows.Forms.GroupBox gBSuaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Button btnSua;
    }
}