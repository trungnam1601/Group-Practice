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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuanLyKhachHang = new System.Windows.Forms.Label();
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaKh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
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
            // dgvQuanLyKhachHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuanLyKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(149, 237);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.RowHeadersVisible = false;
            this.dgvQuanLyKhachHang.RowHeadersWidth = 51;
            this.dgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(751, 231);
            this.dgvQuanLyKhachHang.TabIndex = 9;
            this.dgvQuanLyKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKhachHang_CellContentClick);
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
            this.btThem.Location = new System.Drawing.Point(230, 186);
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
            this.btSua.Location = new System.Drawing.Point(333, 186);
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
            this.btXoa.Location = new System.Drawing.Point(436, 186);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(97, 30);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(545, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btReset_Click);
            // 
            // txtMaKh
            // 
            this.txtMaKh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMaKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMaKh.Location = new System.Drawing.Point(379, 85);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.Size = new System.Drawing.Size(166, 24);
            this.txtMaKh.TabIndex = 22;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDiaChi.Location = new System.Drawing.Point(699, 85);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(166, 24);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtTenKh
            // 
            this.txtTenKh.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenKh.Location = new System.Drawing.Point(379, 137);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(166, 24);
            this.txtTenKh.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPhone.Location = new System.Drawing.Point(699, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 24);
            this.txtPhone.TabIndex = 26;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyNhaHang.Properties.Resources.b1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(149, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearchKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearchKH.Location = new System.Drawing.Point(646, 189);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.Size = new System.Drawing.Size(166, 24);
            this.txtSearchKH.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(818, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tìm kiếm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchKH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTenKh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaKh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Controls.Add(this.lblQuanLyKhachHang);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyKhachHang;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMaKh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchKH;
        private System.Windows.Forms.Label label4;
    }
}