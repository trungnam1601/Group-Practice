﻿namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyNhanVien
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
            this.pnlQuanLyNhanVien = new System.Windows.Forms.Panel();
            this.btCapNhatBoPhanNV = new System.Windows.Forms.Button();
            this.btnCapNhatChiNhanh = new System.Windows.Forms.Button();
            this.btnCapNhatThongTinNV = new System.Windows.Forms.Button();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.cdrQLNV = new System.Windows.Forms.MonthCalendar();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.pnlQuanLyNhanVien.SuspendLayout();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuanLyNhanVien
            // 
            this.pnlQuanLyNhanVien.BackColor = System.Drawing.Color.Honeydew;
            this.pnlQuanLyNhanVien.Controls.Add(this.btCapNhatBoPhanNV);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatChiNhanh);
            this.pnlQuanLyNhanVien.Controls.Add(this.btnCapNhatThongTinNV);
            this.pnlQuanLyNhanVien.Location = new System.Drawing.Point(24, 83);
            this.pnlQuanLyNhanVien.Name = "pnlQuanLyNhanVien";
            this.pnlQuanLyNhanVien.Size = new System.Drawing.Size(225, 225);
            this.pnlQuanLyNhanVien.TabIndex = 0;
            // 
            // btCapNhatBoPhanNV
            // 
            this.btCapNhatBoPhanNV.BackColor = System.Drawing.Color.Turquoise;
            this.btCapNhatBoPhanNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatBoPhanNV.Location = new System.Drawing.Point(3, 164);
            this.btCapNhatBoPhanNV.Name = "btCapNhatBoPhanNV";
            this.btCapNhatBoPhanNV.Size = new System.Drawing.Size(219, 46);
            this.btCapNhatBoPhanNV.TabIndex = 3;
            this.btCapNhatBoPhanNV.Text = "Cập nhật bộ phận nhân viên";
            this.btCapNhatBoPhanNV.UseVisualStyleBackColor = false;
            // 
            // btnCapNhatChiNhanh
            // 
            this.btnCapNhatChiNhanh.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatChiNhanh.Location = new System.Drawing.Point(3, 89);
            this.btnCapNhatChiNhanh.Name = "btnCapNhatChiNhanh";
            this.btnCapNhatChiNhanh.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatChiNhanh.TabIndex = 2;
            this.btnCapNhatChiNhanh.Text = "Cập nhật chi nhánh";
            this.btnCapNhatChiNhanh.UseVisualStyleBackColor = false;
            this.btnCapNhatChiNhanh.Click += new System.EventHandler(this.BtnCapnhatlichlvnv_Click);
            // 
            // btnCapNhatThongTinNV
            // 
            this.btnCapNhatThongTinNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatThongTinNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTinNV.Location = new System.Drawing.Point(3, 15);
            this.btnCapNhatThongTinNV.Name = "btnCapNhatThongTinNV";
            this.btnCapNhatThongTinNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatThongTinNV.TabIndex = 0;
            this.btnCapNhatThongTinNV.Text = "Cập nhật thông tin nhân viên";
            this.btnCapNhatThongTinNV.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTinNV.Click += new System.EventHandler(this.btnCapnhatthongtinnv_Click);
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(539, 31);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(340, 39);
            this.lblQuanLyNhanVien.TabIndex = 1;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cdrQLNV
            // 
            this.cdrQLNV.Location = new System.Drawing.Point(24, 360);
            this.cdrQLNV.Name = "cdrQLNV";
            this.cdrQLNV.TabIndex = 2;
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.BackColor = System.Drawing.Color.SeaShell;
            this.pnlQLNV.Controls.Add(this.label2);
            this.pnlQLNV.Controls.Add(this.dgvLichLamViec);
            this.pnlQLNV.Location = new System.Drawing.Point(263, 83);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(898, 452);
            this.pnlQLNV.TabIndex = 3;
            this.pnlQLNV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLNV_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Location = new System.Drawing.Point(15, 55);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.Size = new System.Drawing.Size(860, 384);
            this.dgvLichLamViec.TabIndex = 0;
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(94, 32);
            this.btnTroVeCuaQLNV.TabIndex = 4;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.btnTrovecuaqlnv_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b1;
            this.ClientSize = new System.Drawing.Size(1200, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.cdrQLNV);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.pnlQuanLyNhanVien);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.pnlQuanLyNhanVien.ResumeLayout(false);
            this.pnlQLNV.ResumeLayout(false);
            this.pnlQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyNhanVien;
        private System.Windows.Forms.Button btnCapNhatThongTinNV;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.MonthCalendar cdrQLNV;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Button btnCapNhatChiNhanh;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCapNhatBoPhanNV;
    }
}