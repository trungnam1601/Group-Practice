using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
namespace QuanLyNhaHang.DAO
{
    public class ChiNhanhDAO
    {
        private static ChiNhanhDAO instance;

        public static ChiNhanhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiNhanhDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private ChiNhanhDAO()
        {
        }

        public List<ChiNhanh> GetChiNhanhByMaCN(string MaCN)
        {
            List<ChiNhanh> list = new List<ChiNhanh>();

            string query = "select * from ChiNhanh where MaCN = " + MaCN;

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiNhanh chiNhanh = new ChiNhanh(item);
                list.Add(chiNhanh);
            }

            return list;
        }

        public List<ChiNhanh> GetListChiNhanh()
        {
            List<ChiNhanh> list = new List<ChiNhanh>();

            string query = "select * from ChiNhanh";

            DataTable data = DataProvider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiNhanh chiNhanh = new ChiNhanh(item);
                list.Add(chiNhanh);
            }

            return list;
        }
        public bool InsertBrand(string MaCN, string TenCN,string DiaChiCN)
        {
            string query = string.Format("INSERT into dbo.ChiNhanh(MaCN,TenCN,DiaChiCN)" +
                "VALUES(N'{0}',N'{1}',N'{2})", MaCN, TenCN,DiaChiCN);
            int res = DataProvider.Instance.ExecuteNonQuery(query);

            return res > 0;
        }

        public bool UpdateBrand(string MaCN, string TenCN, string DiaChiCN)
        {
            string query = string.Format("UPDATE dbo.ChiNhanh" +
                "SET TenCN = N'{0}',DiaChiCN=N'{1}'" +
                " WHERE MaCN = N'{2}'", TenCN,DiaChiCN, MaCN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBrand(string MaCN)
        {
            string query = string.Format("Delete dbo.ChiNhanh where MaCN = N'{0}'", MaCN);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
