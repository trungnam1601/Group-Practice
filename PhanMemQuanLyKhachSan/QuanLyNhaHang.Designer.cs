namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyPhong
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
            this.btnCapNhatThucPham = new System.Windows.Forms.Button();
            this.btnCapNhatMonAn = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.lblQuanLyPhong = new System.Windows.Forms.Label();
            this.dgvQuanLyNhaHang = new System.Windows.Forms.DataGridView();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatThucPham
            // 
            this.btnCapNhatThucPham.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatThucPham.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThucPham.Location = new System.Drawing.Point(26, 145);
            this.btnCapNhatThucPham.Name = "btnCapNhatThucPham";
            this.btnCapNhatThucPham.Size = new System.Drawing.Size(205, 50);
            this.btnCapNhatThucPham.TabIndex = 0;
            this.btnCapNhatThucPham.Text = "Cập Nhật Thực Phẩm";
            this.btnCapNhatThucPham.UseVisualStyleBackColor = false;
          
            // 
            // btnCapNhatMonAn
            // 
            this.btnCapNhatMonAn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMonAn.Location = new System.Drawing.Point(26, 240);
            this.btnCapNhatMonAn.Name = "btnCapNhatMonAn";
            this.btnCapNhatMonAn.Size = new System.Drawing.Size(205, 51);
            this.btnCapNhatMonAn.TabIndex = 1;
            this.btnCapNhatMonAn.Text = "Cập Nhật Món Ăn";
            this.btnCapNhatMonAn.UseVisualStyleBackColor = false;
          
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(26, 336);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(205, 49);
            this.btnCapNhatLoaiPhong.TabIndex = 2;
            this.btnCapNhatLoaiPhong.Text = "Cập Nhật Bàn Ăn";
            this.btnCapNhatLoaiPhong.UseVisualStyleBackColor = false;
          
            // 
            // lblQuanLyPhong
            // 
            this.lblQuanLyPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyPhong.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhong.Location = new System.Drawing.Point(393, 9);
            this.lblQuanLyPhong.Name = "lblQuanLyPhong";
            this.lblQuanLyPhong.Size = new System.Drawing.Size(338, 42);
            this.lblQuanLyPhong.TabIndex = 3;
            this.lblQuanLyPhong.Text = "Quản Lý Nhà Hàng";
            this.lblQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQuanLyNhaHang
            // 
            this.dgvQuanLyNhaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyNhaHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvQuanLyNhaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNhaHang.Location = new System.Drawing.Point(270, 123);
            this.dgvQuanLyNhaHang.Name = "dgvQuanLyNhaHang";
            this.dgvQuanLyNhaHang.ReadOnly = true;
            this.dgvQuanLyNhaHang.Size = new System.Drawing.Size(657, 368);
            this.dgvQuanLyNhaHang.TabIndex = 4;
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTroVeCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(12, 9);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(95, 36);
            this.btnTroVeCuaCTPP.TabIndex = 5;
            this.btnTroVeCuaCTPP.Text = "Trở về";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = false;
       
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cập Nhật Nhà Cung Cấp";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Controls.Add(this.dgvQuanLyNhaHang);
            this.Controls.Add(this.lblQuanLyPhong);
            this.Controls.Add(this.btnCapNhatLoaiPhong);
            this.Controls.Add(this.btnCapNhatMonAn);
            this.Controls.Add(this.btnCapNhatThucPham);
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Phòng";
       
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatThucPham;
        private System.Windows.Forms.Button btnCapNhatMonAn;
        private System.Windows.Forms.Button btnCapNhatLoaiPhong;
        private System.Windows.Forms.Label lblQuanLyPhong;
        private System.Windows.Forms.DataGridView dgvQuanLyNhaHang;
        private System.Windows.Forms.Button btnTroVeCuaCTPP;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button1;
    }
}