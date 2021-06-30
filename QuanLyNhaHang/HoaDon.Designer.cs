namespace QuanLyNhaHang
{
    partial class HoaDon
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaTienHD = new System.Windows.Forms.TextBox();
            this.txtNgayHD = new System.Windows.Forms.TextBox();
            this.btnTroVeCuaQLKH = new System.Windows.Forms.Button();
            this.lblQuanLyHoaDon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.txtMAKH_HD = new System.Windows.Forms.TextBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.txtSoLuongHD = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgv_CapNhatHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapNhatHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(551, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(123, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Ngày hóa đơn";
            // 
            // txtGiaTienHD
            // 
            this.txtGiaTienHD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtGiaTienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTienHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGiaTienHD.Location = new System.Drawing.Point(684, 98);
            this.txtGiaTienHD.Name = "txtGiaTienHD";
            this.txtGiaTienHD.Size = new System.Drawing.Size(166, 24);
            this.txtGiaTienHD.TabIndex = 69;
            // 
            // txtNgayHD
            // 
            this.txtNgayHD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNgayHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNgayHD.Location = new System.Drawing.Point(271, 181);
            this.txtNgayHD.Name = "txtNgayHD";
            this.txtNgayHD.Size = new System.Drawing.Size(166, 24);
            this.txtNgayHD.TabIndex = 68;
            // 
            // btnTroVeCuaQLKH
            // 
            this.btnTroVeCuaQLKH.BackColor = System.Drawing.Color.Blue;
            this.btnTroVeCuaQLKH.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLKH.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLKH.Location = new System.Drawing.Point(12, 12);
            this.btnTroVeCuaQLKH.Name = "btnTroVeCuaQLKH";
            this.btnTroVeCuaQLKH.Size = new System.Drawing.Size(110, 37);
            this.btnTroVeCuaQLKH.TabIndex = 67;
            this.btnTroVeCuaQLKH.Text = "Trở về";
            this.btnTroVeCuaQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLKH.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLKH.Click += new System.EventHandler(this.btnTroVeCuaQLKH_Click);
            // 
            // lblQuanLyHoaDon
            // 
            this.lblQuanLyHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyHoaDon.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyHoaDon.Name = "lblQuanLyHoaDon";
            this.lblQuanLyHoaDon.Size = new System.Drawing.Size(979, 81);
            this.lblQuanLyHoaDon.TabIndex = 66;
            this.lblQuanLyHoaDon.Text = "Hóa Đơn";
            this.lblQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(551, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(551, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(123, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tên hóa đơn";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(123, 98);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(87, 18);
            this.lblMaNv.TabIndex = 62;
            this.lblMaNv.Text = "Mã hóa đơn";
            // 
            // txtMAKH_HD
            // 
            this.txtMAKH_HD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMAKH_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKH_HD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMAKH_HD.Location = new System.Drawing.Point(684, 181);
            this.txtMAKH_HD.Name = "txtMAKH_HD";
            this.txtMAKH_HD.Size = new System.Drawing.Size(166, 24);
            this.txtMAKH_HD.TabIndex = 61;
            // 
            // txtTenHD
            // 
            this.txtTenHD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenHD.Location = new System.Drawing.Point(271, 139);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(166, 24);
            this.txtTenHD.TabIndex = 60;
            // 
            // txtSoLuongHD
            // 
            this.txtSoLuongHD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSoLuongHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSoLuongHD.Location = new System.Drawing.Point(684, 139);
            this.txtSoLuongHD.Name = "txtSoLuongHD";
            this.txtSoLuongHD.Size = new System.Drawing.Size(166, 24);
            this.txtSoLuongHD.TabIndex = 59;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMaHD.Location = new System.Drawing.Point(271, 98);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(166, 24);
            this.txtMaHD.TabIndex = 58;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(696, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(538, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 30);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(386, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 30);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(233, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 30);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgv_CapNhatHoaDon
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_CapNhatHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_CapNhatHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_CapNhatHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CapNhatHoaDon.Location = new System.Drawing.Point(126, 260);
            this.dtgv_CapNhatHoaDon.Name = "dtgv_CapNhatHoaDon";
            this.dtgv_CapNhatHoaDon.RowHeadersVisible = false;
            this.dtgv_CapNhatHoaDon.RowHeadersWidth = 51;
            this.dtgv_CapNhatHoaDon.RowTemplate.Height = 24;
            this.dtgv_CapNhatHoaDon.Size = new System.Drawing.Size(766, 215);
            this.dtgv_CapNhatHoaDon.TabIndex = 53;
            this.dtgv_CapNhatHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CapNhatHoaDon_CellContentClick);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b1;
            this.ClientSize = new System.Drawing.Size(979, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiaTienHD);
            this.Controls.Add(this.txtNgayHD);
            this.Controls.Add(this.btnTroVeCuaQLKH);
            this.Controls.Add(this.lblQuanLyHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.txtMAKH_HD);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.txtSoLuongHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgv_CapNhatHoaDon);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CapNhatHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaTienHD;
        private System.Windows.Forms.TextBox txtNgayHD;
        private System.Windows.Forms.Button btnTroVeCuaQLKH;
        private System.Windows.Forms.Label lblQuanLyHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.TextBox txtMAKH_HD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.TextBox txtSoLuongHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgv_CapNhatHoaDon;
    }
}