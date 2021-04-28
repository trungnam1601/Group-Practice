namespace QuanLyNhaHang
{
    partial class frmCapNhatChiNhanh
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
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnSuaChiNhanh = new System.Windows.Forms.Button();
            this.btnXoaChiNhanh = new System.Windows.Forms.Button();
            this.btnThemChiNhanh = new System.Windows.Forms.Button();
            this.btnTroVeCuaCapNhatLichLamViec = new System.Windows.Forms.Button();
            this.dgvCapNhatChiNhanh = new System.Windows.Forms.DataGridView();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.lblChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Location = new System.Drawing.Point(360, 18);
            this.lblChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(581, 55);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Các Chi Nhánh Của Nhà Hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1944, 314);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 358);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(2060, 272);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(88, 27);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnSuaChiNhanh
            // 
            this.btnSuaChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnSuaChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiNhanh.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnSuaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiNhanh.Location = new System.Drawing.Point(631, 114);
            this.btnSuaChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaChiNhanh.Name = "btnSuaChiNhanh";
            this.btnSuaChiNhanh.Size = new System.Drawing.Size(112, 43);
            this.btnSuaChiNhanh.TabIndex = 13;
            this.btnSuaChiNhanh.Text = "Sửa ";
            this.btnSuaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaChiNhanh.UseVisualStyleBackColor = false;
            this.btnSuaChiNhanh.Click += new System.EventHandler(this.btnSuaChiNhanh_Click);
            // 
            // btnXoaChiNhanh
            // 
            this.btnXoaChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnXoaChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiNhanh.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787423;
            this.btnXoaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaChiNhanh.Location = new System.Drawing.Point(631, 191);
            this.btnXoaChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaChiNhanh.Name = "btnXoaChiNhanh";
            this.btnXoaChiNhanh.Size = new System.Drawing.Size(111, 42);
            this.btnXoaChiNhanh.TabIndex = 12;
            this.btnXoaChiNhanh.Text = "Xóa ";
            this.btnXoaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaChiNhanh.UseVisualStyleBackColor = false;
            this.btnXoaChiNhanh.Click += new System.EventHandler(this.btnXoaChiNhanh_Click);
            // 
            // btnThemChiNhanh
            // 
            this.btnThemChiNhanh.BackColor = System.Drawing.Color.White;
            this.btnThemChiNhanh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiNhanh.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThemChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiNhanh.Location = new System.Drawing.Point(825, 114);
            this.btnThemChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemChiNhanh.Name = "btnThemChiNhanh";
            this.btnThemChiNhanh.Size = new System.Drawing.Size(111, 43);
            this.btnThemChiNhanh.TabIndex = 11;
            this.btnThemChiNhanh.Text = "Thêm ";
            this.btnThemChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChiNhanh.UseVisualStyleBackColor = false;
            this.btnThemChiNhanh.Click += new System.EventHandler(this.btnThemChiNhanh_Click);
            // 
            // btnTroVeCuaCapNhatLichLamViec
            // 
            this.btnTroVeCuaCapNhatLichLamViec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTroVeCuaCapNhatLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCapNhatLichLamViec.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaCapNhatLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCapNhatLichLamViec.Location = new System.Drawing.Point(16, 18);
            this.btnTroVeCuaCapNhatLichLamViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTroVeCuaCapNhatLichLamViec.Name = "btnTroVeCuaCapNhatLichLamViec";
            this.btnTroVeCuaCapNhatLichLamViec.Size = new System.Drawing.Size(135, 55);
            this.btnTroVeCuaCapNhatLichLamViec.TabIndex = 10;
            this.btnTroVeCuaCapNhatLichLamViec.Text = "Trở về";
            this.btnTroVeCuaCapNhatLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCapNhatLichLamViec.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCapNhatLichLamViec.Click += new System.EventHandler(this.btnTroVeCuaCapNhatLichLamViec_Click);
            // 
            // dgvCapNhatChiNhanh
            // 
            this.dgvCapNhatChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatChiNhanh.Location = new System.Drawing.Point(229, 262);
            this.dgvCapNhatChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCapNhatChiNhanh.Name = "dgvCapNhatChiNhanh";
            this.dgvCapNhatChiNhanh.RowHeadersWidth = 51;
            this.dgvCapNhatChiNhanh.Size = new System.Drawing.Size(721, 187);
            this.dgvCapNhatChiNhanh.TabIndex = 16;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(381, 165);
            this.txtTenCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(164, 22);
            this.txtTenCN.TabIndex = 30;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(383, 118);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(164, 22);
            this.txtMaCN.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Chi Nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã Chi Nhánh";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(383, 208);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(164, 22);
            this.txtDiachi.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "Địa chỉ";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Synchronize_2788321;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(824, 191);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 42);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmCapNhatChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 585);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenCN);
            this.Controls.Add(this.txtMaCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCapNhatChiNhanh);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnSuaChiNhanh);
            this.Controls.Add(this.btnXoaChiNhanh);
            this.Controls.Add(this.btnThemChiNhanh);
            this.Controls.Add(this.btnTroVeCuaCapNhatLichLamViec);
            this.Controls.Add(this.lblChiNhanh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCapNhatChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Chi Nhánh Nhà Hàng";
            this.Load += new System.EventHandler(this.frmCapNhatChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Button btnTroVeCuaCapNhatLichLamViec;
        private System.Windows.Forms.Button btnThemChiNhanh;
        private System.Windows.Forms.Button btnSuaChiNhanh;
        private System.Windows.Forms.Button btnXoaChiNhanh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvCapNhatChiNhanh;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
    }
}