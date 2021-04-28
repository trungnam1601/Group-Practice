﻿namespace QuanLyNhaHang
{
    partial class frmQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuanLyKhachHang = new System.Windows.Forms.Label();
            this.dtgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyKhachHang
            // 
            this.lblQuanLyKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyKhachHang.Name = "lblQuanLyKhachHang";
            this.lblQuanLyKhachHang.Size = new System.Drawing.Size(1068, 51);
            this.lblQuanLyKhachHang.TabIndex = 0;
            this.lblQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.lblQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvQuanLyKhachHang
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvQuanLyKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanLyKhachHang.Location = new System.Drawing.Point(197, 237);
            this.dtgvQuanLyKhachHang.Name = "dtgvQuanLyKhachHang";
            this.dtgvQuanLyKhachHang.RowHeadersVisible = false;
            this.dtgvQuanLyKhachHang.RowHeadersWidth = 51;
            this.dtgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dtgvQuanLyKhachHang.Size = new System.Drawing.Size(668, 231);
            this.dtgvQuanLyKhachHang.TabIndex = 9;
            // 
            // btnTroVeCuaQLKH
            // 
            this.btnTroVeCuaQLKH.BackColor = System.Drawing.Color.Blue;
            this.btnTroVeCuaQLKH.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLKH.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLKH.Location = new System.Drawing.Point(2, 2);
            this.btnTroVeCuaQLKH.Name = "btnTroVeCuaQLKH";
            this.btnTroVeCuaQLKH.Size = new System.Drawing.Size(110, 37);
            this.btnTroVeCuaQLKH.TabIndex = 1;
            this.btnTroVeCuaQLKH.Text = "Trở về";
            this.btnTroVeCuaQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLKH.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLKH.Click += new System.EventHandler(this.btnTroVeCuaQLKH_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(253, 186);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(97, 30);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(406, 186);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(97, 30);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(558, 186);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(97, 30);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btReset.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.Location = new System.Drawing.Point(716, 186);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(95, 30);
            this.btReset.TabIndex = 21;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tb_maKH
            // 
            this.tb_maKH.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_maKH.Location = new System.Drawing.Point(379, 85);
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.Size = new System.Drawing.Size(166, 24);
            this.tb_maKH.TabIndex = 22;
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diaChi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_diaChi.Location = new System.Drawing.Point(699, 85);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(166, 24);
            this.tb_diaChi.TabIndex = 23;
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_tenKH.Location = new System.Drawing.Point(379, 137);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(166, 24);
            this.tb_tenKH.TabIndex = 25;
            // 
            // tb_SDT
            // 
            this.tb_SDT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_SDT.Location = new System.Drawing.Point(699, 138);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(166, 24);
            this.tb_SDT.TabIndex = 26;
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(194, 85);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(109, 18);
            this.lblMaNv.TabIndex = 30;
            this.lblMaNv.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(194, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(598, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(602, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "SĐT";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_tenKH);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.tb_maKH);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgvQuanLyKhachHang);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Controls.Add(this.lblQuanLyKhachHang);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyKhachHang;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.DataGridView dtgvQuanLyKhachHang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tb_maKH;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}