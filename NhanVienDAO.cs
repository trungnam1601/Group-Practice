using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.Helper;
using QuanLyNhaHang.DTO;
using System.Data;

namespace QuanLyNhaHang.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private NhanVienDAO()
        {
        }

        public List<NhanVien> GetNhanVienByMaNV(string MaNV)
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from NhanVien where MaNV = " + MaNV;

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }

            return list;
        }

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from NhanVien";

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }

            return list;
        }

        public bool InsertEmployee(string MaNV,string TenNV, string Luong, string NgaySinh,string GioiTinh,string DiaChi,string MaCN, string MaBP)
        {
            string query = string.Format("INSERT into dbo.NhanVien(MaNV,HoTenNV,Luong,NgaySinh,GioiTinh,DiaChi,MaCN,MaBP)"+
                "VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",MaNV,TenNV, Luong,NgaySinh,GioiTinh,DiaChi,MaCN,MaBP);
            int res = DataProvider.Instance.ExecuteNonQuery(query);
                        
            return res > 0;
        }

        public bool UpdateEmployee(string MaNV, string TenNV, string Luong, string NgaySinh, string GioiTinh, string DiaChi, string MaCN, string MaBP)
        {
            string query = string.Format("UPDATE dbo.NhanVien"+
                "SET HoTenNV = N'{0}', Luong = N'{1}', NgaySinh = N'{2}', GioiTinh = N'{3'}, DiaChi = N'{4}', MaCN = N'{5}',MaBP = N'{6}'" +
                " WHERE MaNV = N'{7}'", TenNV, Luong, NgaySinh, GioiTinh, DiaChi, MaCN, MaBP, MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteEmployee(string MaNV)
        {
            string query = string.Format("Delete NhanVien where MaNV = N'{0}'", MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
