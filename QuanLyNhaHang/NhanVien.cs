using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string luong;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string maCN;
        private string maBP;

        public string MaBP { get => maBP; set => maBP = value; }
        public string MaCN { get => maCN; set => maCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Luong { get => luong; set => luong = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public NhanVien(string maNV, string tenNV, string luong, string ngaySinh, string gioiTinh, string diaChi, string maCN, string maBP)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.Luong = luong;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.MaCN = maCN;
            this.MaBP = maBP;
        }
        public NhanVien(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["HoTenNV"].ToString();
            this.Luong = row["Luong"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.MaCN = row["MaCN"].ToString();
            this.MaBP = row["MaBP"].ToString();
        }
    }
}
