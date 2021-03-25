namespace PhanMemQuanLyKhachSan
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
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCapNhatNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnHuyCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnLuuCapNhatBanAn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Nhà Cung Cấp";
            // 
            // btnTroVeCuaThongKe
            // 
            this.btnTroVeCuaThongKe.BackColor = System.Drawing.Color.Lime;
            this.btnTroVeCuaThongKe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaThongKe.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaThongKe.Location = new System.Drawing.Point(12, 11);
            this.btnTroVeCuaThongKe.Name = "btnTroVeCuaThongKe";
            this.btnTroVeCuaThongKe.Size = new System.Drawing.Size(101, 37);
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
            this.label9.Location = new System.Drawing.Point(594, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "Địa Chỉ";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(746, 140);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(124, 20);
            this.textBox10.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(593, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tên Nhà Cung Cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(593, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 22);
            this.label11.TabIndex = 62;
            this.label11.Text = "Mã Nhà Cung Cấp";
            // 
            // dgvCapNhatNhaCungCap
            // 
            this.dgvCapNhatNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatNhaCungCap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatNhaCungCap.Location = new System.Drawing.Point(52, 91);
            this.dgvCapNhatNhaCungCap.Name = "dgvCapNhatNhaCungCap";
            this.dgvCapNhatNhaCungCap.ReadOnly = true;
            this.dgvCapNhatNhaCungCap.Size = new System.Drawing.Size(516, 427);
            this.dgvCapNhatNhaCungCap.TabIndex = 61;
            // 
            // btnHuyCapNhatBanAn
            // 
            this.btnHuyCapNhatBanAn.BackColor = System.Drawing.Color.Lime;
            this.btnHuyCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatBanAn.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconHuy;
            this.btnHuyCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatBanAn.Location = new System.Drawing.Point(785, 325);
            this.btnHuyCapNhatBanAn.Name = "btnHuyCapNhatBanAn";
            this.btnHuyCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnHuyCapNhatBanAn.TabIndex = 60;
            this.btnHuyCapNhatBanAn.Text = "Hủy";
            this.btnHuyCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // btnLuuCapNhatBanAn
            // 
            this.btnLuuCapNhatBanAn.BackColor = System.Drawing.Color.Lime;
            this.btnLuuCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatBanAn.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatBanAn.Location = new System.Drawing.Point(607, 325);
            this.btnLuuCapNhatBanAn.Name = "btnLuuCapNhatBanAn";
            this.btnLuuCapNhatBanAn.Size = new System.Drawing.Size(85, 40);
            this.btnLuuCapNhatBanAn.TabIndex = 59;
            this.btnLuuCapNhatBanAn.Text = "Lưu";
            this.btnLuuCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatBanAn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(746, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 67;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 541);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCapNhatNhaCungCap);
            this.Controls.Add(this.btnHuyCapNhatBanAn);
            this.Controls.Add(this.btnLuuCapNhatBanAn);
            this.Controls.Add(this.btnTroVeCuaThongKe);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroVeCuaThongKe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCapNhatNhaCungCap;
        private System.Windows.Forms.Button btnHuyCapNhatBanAn;
        private System.Windows.Forms.Button btnLuuCapNhatBanAn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}