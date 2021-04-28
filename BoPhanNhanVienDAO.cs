using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
namespace QuanLyNhaHang.DAO
{
    public class BoPhanNhanVienDAO
    {
        private static BoPhanNhanVienDAO instance;

        public static BoPhanNhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BoPhanNhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BoPhanNhanVienDAO()
        {
        }

        public List<BoPhanNhanVien> GetBoPhanNhanVienByMaBP(string MaBP)
        {
            List<BoPhanNhanVien> list = new List<BoPhanNhanVien>();

            string query = "select * from BoPhanNhanVien where MaBP = " + MaBP;

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                BoPhanNhanVien boPhanNhanVien = new BoPhanNhanVien(item);
                list.Add(boPhanNhanVien);
            }

            return list;
        }

        public List<BoPhanNhanVien> GetListBoPhanNhanVien()
        {
            List<BoPhanNhanVien> list = new List<BoPhanNhanVien>();

            string query = "select * from BoPhanNhanVien";

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                BoPhanNhanVien boPhanNhanVien = new BoPhanNhanVien(item);
                list.Add(boPhanNhanVien);
            }

            return list;
        }
        public bool InsertBPEmployee(string MaBP, string TenBP)
        {
            string query = string.Format("INSERT into dbo.BoPhanNhanVien(MaBP,TenBP)" +
                "VALUES(N'{0}',N'{1}')", MaBP,TenBP);
            int res = DataProvider.Instance.ExecuteNonQuery(query);

            return res > 0;
        }

        public bool UpdateBPEmployee(string TenBP, string MaBP)
        {
            string query = string.Format("UPDATE dbo.BoPhanNhanVien" +
                "SET TenBP = N'{0}'" +
                " WHERE MaBP = N'{1}'", TenBP, MaBP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBPEmployee(string MaBP)
        {
            string query = string.Format("Delete BoPhanNhanVien where MaBP = N'{0}'", MaBP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
