namespace QuanLyNhaHang
{
    partial class ThongKe
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
            this.lblDichVuKhachSan = new System.Windows.Forms.Label();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.dtgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.cbb_thongKe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDichVuKhachSan
            // 
            this.lblDichVuKhachSan.AutoSize = true;
            this.lblDichVuKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVuKhachSan.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuKhachSan.Location = new System.Drawing.Point(216, 25);
            this.lblDichVuKhachSan.Name = "lblDichVuKhachSan";
            this.lblDichVuKhachSan.Size = new System.Drawing.Size(171, 47);
            this.lblDichVuKhachSan.TabIndex = 1;
            this.lblDichVuKhachSan.Text = "Thống kê";
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Lime;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(12, 12);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(101, 45);
            this.btnThoatCapNhatDichVu.TabIndex = 3;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            // 
            // dtgv_ThongKe
            // 
            this.dtgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongKe.Location = new System.Drawing.Point(12, 186);
            this.dtgv_ThongKe.Name = "dtgv_ThongKe";
            this.dtgv_ThongKe.Size = new System.Drawing.Size(564, 243);
            this.dtgv_ThongKe.TabIndex = 4;
            this.dtgv_ThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbb_thongKe
            // 
            this.cbb_thongKe.FormattingEnabled = true;
            this.cbb_thongKe.Items.AddRange(new object[] {
            "Lương nhân viên",
            "Thực phẩm",
            "Món ăn"});
            this.cbb_thongKe.Location = new System.Drawing.Point(109, 111);
            this.cbb_thongKe.Name = "cbb_thongKe";
            this.cbb_thongKe.Size = new System.Drawing.Size(121, 21);
            this.cbb_thongKe.TabIndex = 5;
            this.cbb_thongKe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ ngày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến ngày";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 10;
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.BackColor = System.Drawing.Color.White;
            this.btnXoaMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btnXoaMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMonAn.Location = new System.Drawing.Point(490, 98);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(72, 45);
            this.btnXoaMonAn.TabIndex = 38;
            this.btnXoaMonAn.Text = "Hủy";
            this.btnXoaMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMonAn.UseVisualStyleBackColor = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_thongKe);
            this.Controls.Add(this.dtgv_ThongKe);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.lblDichVuKhachSan);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDichVuKhachSan;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.DataGridView dtgv_ThongKe;
        private System.Windows.Forms.ComboBox cbb_thongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnXoaMonAn;
    }
}