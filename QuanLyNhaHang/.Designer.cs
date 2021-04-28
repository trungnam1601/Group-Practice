namespace QuanLyNhaHang
{
    partial class frmNhaCungCap
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
            this.btnTroVeCuaThongKe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCapNhatNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnSuaCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnLuuCapNhatBanAn = new System.Windows.Forms.Button();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SDT = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Nhà Cung Cấp";
            // 
            // btnTroVeCuaThongKe
            // 
            this.btnTroVeCuaThongKe.BackColor = System.Drawing.Color.Lime;
            this.btnTroVeCuaThongKe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaThongKe.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaThongKe.Location = new System.Drawing.Point(16, 14);
            this.btnTroVeCuaThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTroVeCuaThongKe.Name = "btnTroVeCuaThongKe";
            this.btnTroVeCuaThongKe.Size = new System.Drawing.Size(135, 46);
            this.btnTroVeCuaThongKe.TabIndex = 10;
            this.btnTroVeCuaThongKe.Text = "Trở về";
            this.btnTroVeCuaThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaThongKe.UseVisualStyleBackColor = false;
            this.btnTroVeCuaThongKe.Click += new System.EventHandler(this.btnTroVeCuaThongKe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 65;
            this.label9.Text = "Địa Chỉ";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(389, 110);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(164, 22);
            this.txtMaNCC.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 27);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tên Nhà Cung Cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 27);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mã Nhà Cung Cấp";
            // 
            // dgvCapNhatNhaCungCap
            // 
            this.dgvCapNhatNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatNhaCungCap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatNhaCungCap.Location = new System.Drawing.Point(176, 286);
            this.dgvCapNhatNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCapNhatNhaCungCap.Name = "dgvCapNhatNhaCungCap";
            this.dgvCapNhatNhaCungCap.ReadOnly = true;
            this.dgvCapNhatNhaCungCap.RowHeadersWidth = 51;
            this.dgvCapNhatNhaCungCap.Size = new System.Drawing.Size(713, 162);
            this.dgvCapNhatNhaCungCap.TabIndex = 61;
            // 
            // btnSuaCapNhatBanAn
            // 
            this.btnSuaCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnSuaCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnSuaCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCapNhatBanAn.Location = new System.Drawing.Point(776, 110);
            this.btnSuaCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaCapNhatBanAn.Name = "btnSuaCapNhatBanAn";
            this.btnSuaCapNhatBanAn.Size = new System.Drawing.Size(113, 49);
            this.btnSuaCapNhatBanAn.TabIndex = 60;
            this.btnSuaCapNhatBanAn.Text = "Sửa";
            this.btnSuaCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCapNhatBanAn.UseVisualStyleBackColor = false;
            this.btnSuaCapNhatBanAn.Click += new System.EventHandler(this.btnSuaCapNhatBanAn_Click);
            // 
            // btnLuuCapNhatBanAn
            // 
            this.btnLuuCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnLuuCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Save_278762;
            this.btnLuuCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatBanAn.Location = new System.Drawing.Point(601, 110);
            this.btnLuuCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuCapNhatBanAn.Name = "btnLuuCapNhatBanAn";
            this.btnLuuCapNhatBanAn.Size = new System.Drawing.Size(113, 49);
            this.btnLuuCapNhatBanAn.TabIndex = 59;
            this.btnLuuCapNhatBanAn.Text = "Lưu";
            this.btnLuuCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatBanAn.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatBanAn.Click += new System.EventHandler(this.btnLuuCapNhatBanAn_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(388, 160);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(164, 22);
            this.txtTenNCC.TabIndex = 66;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(388, 212);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(164, 22);
            this.txtDiachi.TabIndex = 67;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(601, 183);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 49);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SDT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(185, 255);
            this.SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(51, 27);
            this.SDT.TabIndex = 70;
            this.SDT.Text = "SDT";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(388, 255);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(164, 22);
            this.txtsdt.TabIndex = 71;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(776, 177);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 55);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.ClientSize = new System.Drawing.Size(1089, 529);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCapNhatNhaCungCap);
            this.Controls.Add(this.btnSuaCapNhatBanAn);
            this.Controls.Add(this.btnLuuCapNhatBanAn);
            this.Controls.Add(this.btnTroVeCuaThongKe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroVeCuaThongKe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCapNhatNhaCungCap;
        private System.Windows.Forms.Button btnSuaCapNhatBanAn;
        private System.Windows.Forms.Button btnLuuCapNhatBanAn;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnXoa;
    }
}