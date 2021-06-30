using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return OrderDAO.instance; }
            private set { OrderDAO.instance = value; }
        }

        private OrderDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUncheckOrderID(string id)
        {
            DataTable data = Define.Instance.ExecuteQuery("SELECT * FROM dbo.PhieuYeuCau WHERE MaBan = '" + id+ "' AND TrangThai = 0");

            if (data.Rows.Count > 0)
            {
                Order bill = new Order(data.Rows[0]);
                return bill.ID;
            }

            return "-1";
        }
        public void CheckOut(string id)
        {
            string query = "UPDATE dbo.PhieuYeuCau SET TrangThai = 1 WHERE MaPYC = '" + id + "'";
            Define.Instance.ExecuteNonQuery(query);
        }
        public void InsertOrder(string id)
        {
            Define.Instance.ExecuteNonQuery("exec PROC_INSERT_ORDER @MABAN", new object[] { id });
        }

        public string GetMaxIDOrder()
        {
            try
            {
                return Define.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.PhieuYeuCau").ToString();
            }
            catch
            {
                return "1";
            }
        }
    }
}
