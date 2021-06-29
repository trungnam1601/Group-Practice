using System;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    partial class frmCapNhatBanAn
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
            this.lblCapNhatBanAn = new System.Windows.Forms.Label();
            this.btnLuuCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnHuyCapNhatBanAn = new System.Windows.Forms.Button();
            this.btnTroVeCuaQLNV = new System.Windows.Forms.Button();
            this.dgvCapNhatBanAn = new System.Windows.Forms.DataGridView();
            this.textSG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMaBa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            this.textTang = new System.Windows.Forms.TextBox();
            this.textKB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCapNhatBanAn
            // 
            this.lblCapNhatBanAn.AutoSize = true;
            this.lblCapNhatBanAn.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatBanAn.Location = new System.Drawing.Point(388, 11);
            this.lblCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatBanAn.Name = "lblCapNhatBanAn";
            this.lblCapNhatBanAn.Size = new System.Drawing.Size(306, 50);
            this.lblCapNhatBanAn.TabIndex = 0;
            this.lblCapNhatBanAn.Text = "Quản Lý Bàn Ăn";
            // 
            // btnLuuCapNhatBanAn
            // 
            this.btnLuuCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnLuuCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Save_278762;
            this.btnLuuCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatBanAn.Location = new System.Drawing.Point(645, 101);
            this.btnLuuCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuCapNhatBanAn.Name = "btnLuuCapNhatBanAn";
            this.btnLuuCapNhatBanAn.Size = new System.Drawing.Size(113, 49);
            this.btnLuuCapNhatBanAn.TabIndex = 7;
            this.btnLuuCapNhatBanAn.Text = "Lưu";
            this.btnLuuCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatBanAn.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatBanAn.Click += new System.EventHandler(this.btnLuuCapNhatBanAn_Click);
            // 
            // btnHuyCapNhatBanAn
            // 
            this.btnHuyCapNhatBanAn.BackColor = System.Drawing.Color.White;
            this.btnHuyCapNhatBanAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatBanAn.Image = global::QuanLyNhaHang.Properties.Resources.edit;
            this.btnHuyCapNhatBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatBanAn.Location = new System.Drawing.Point(843, 101);
            this.btnHuyCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyCapNhatBanAn.Name = "btnHuyCapNhatBanAn";
            this.btnHuyCapNhatBanAn.Size = new System.Drawing.Size(113, 49);
            this.btnHuyCapNhatBanAn.TabIndex = 8;
            this.btnHuyCapNhatBanAn.Text = "Sửa";
            this.btnHuyCapNhatBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatBanAn.UseVisualStyleBackColor = false;
            this.btnHuyCapNhatBanAn.Click += new System.EventHandler(this.btnHuyCapNhatBanAn_Click);
            // 
            // btnTroVeCuaQLNV
            // 
            this.btnTroVeCuaQLNV.BackColor = System.Drawing.Color.Lime;
            this.btnTroVeCuaQLNV.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaQLNV.Image = global::QuanLyNhaHang.Properties.Resources.iconBack;
            this.btnTroVeCuaQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaQLNV.Location = new System.Drawing.Point(16, 11);
            this.btnTroVeCuaQLNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVeCuaQLNV.Name = "btnTroVeCuaQLNV";
            this.btnTroVeCuaQLNV.Size = new System.Drawing.Size(125, 41);
            this.btnTroVeCuaQLNV.TabIndex = 9;
            this.btnTroVeCuaQLNV.Text = "Trở về";
            this.btnTroVeCuaQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaQLNV.UseVisualStyleBackColor = false;
            this.btnTroVeCuaQLNV.Click += new System.EventHandler(this.BtnTroVeCuaQLNV_Click);
            // 
            // dgvCapNhatBanAn
            // 
            this.dgvCapNhatBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatBanAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCapNhatBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatBanAn.Location = new System.Drawing.Point(198, 324);
            this.dgvCapNhatBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCapNhatBanAn.Name = "dgvCapNhatBanAn";
            this.dgvCapNhatBanAn.ReadOnly = true;
            this.dgvCapNhatBanAn.RowHeadersWidth = 51;
            this.dgvCapNhatBanAn.Size = new System.Drawing.Size(757, 167);
            this.dgvCapNhatBanAn.TabIndex = 10;
            this.dgvCapNhatBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhatBanAn_CellContentClick);
            // 
            // textSG
            // 
            this.textSG.Location = new System.Drawing.Point(395, 231);
            this.textSG.Margin = new System.Windows.Forms.Padding(4);
            this.textSG.Name = "textSG";
            this.textSG.Size = new System.Drawing.Size(164, 22);
            this.textSG.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số ghế";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 27);
            this.label9.TabIndex = 53;
            this.label9.Text = "Kiểu Bàn";
            // 
            // textMaBa
            // 
            this.textMaBa.Location = new System.Drawing.Point(396, 101);
            this.textMaBa.Margin = new System.Windows.Forms.Padding(4);
            this.textMaBa.Name = "textMaBa";
            this.textMaBa.Size = new System.Drawing.Size(164, 22);
            this.textMaBa.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 27);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tầng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(192, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 27);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mã Bàn Ăn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(645, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 59;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.BackColor = System.Drawing.Color.White;
            this.btnXoaMonAn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonAn.Image = global::QuanLyNhaHang.Properties.Resources.iconfinder_Remove_2787424;
            this.btnXoaMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMonAn.Location = new System.Drawing.Point(843, 180);
            this.btnXoaMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(113, 55);
            this.btnXoaMonAn.TabIndex = 60;
            this.btnXoaMonAn.Text = "Xóa ";
            this.btnXoaMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMonAn.UseVisualStyleBackColor = false;
            this.btnXoaMonAn.Click += new System.EventHandler(this.btnXoaMonAn_Click);
            // 
            // textTang
            // 
            this.textTang.Location = new System.Drawing.Point(397, 140);
            this.textTang.Margin = new System.Windows.Forms.Padding(4);
            this.textTang.Name = "textTang";
            this.textTang.Size = new System.Drawing.Size(164, 22);
            this.textTang.TabIndex = 61;
            // 
            // textKB
            // 
            this.textKB.Location = new System.Drawing.Point(396, 190);
            this.textKB.Margin = new System.Windows.Forms.Padding(4);
            this.textKB.Name = "textKB";
            this.textKB.Size = new System.Drawing.Size(164, 22);
            this.textKB.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã Phiếu Yêu Cầu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 277);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 64;
            // 
            // frmCapNhatBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.b13;
            this.ClientSize = new System.Drawing.Size(1156, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKB);
            this.Controls.Add(this.textTang);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textMaBa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCapNhatBanAn);
            this.Controls.Add(this.btnTroVeCuaQLNV);
            this.Controls.Add(this.btnHuyCapNhatBanAn);
            this.Controls.Add(this.btnLuuCapNhatBanAn);
            this.Controls.Add(this.lblCapNhatBanAn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Bàn Ăn";
            this.Load += new System.EventHandler(this.frmCapNhatBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatBanAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvCapNhatBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblCapNhatBanAn;
        private System.Windows.Forms.Button btnLuuCapNhatBanAn;
        private System.Windows.Forms.Button btnHuyCapNhatBanAn;
        private System.Windows.Forms.Button btnTroVeCuaQLNV;
        private System.Windows.Forms.DataGridView dgvCapNhatBanAn;
        private System.Windows.Forms.TextBox textSG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMaBa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaMonAn;
        private System.Windows.Forms.TextBox textTang;
        private System.Windows.Forms.TextBox textKB;
        private Label label1;
        private TextBox textBox1;
    }
}