using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return OrderDetailDAO.instance; }
            private set { OrderDetailDAO.instance = value; }
        }

        private OrderDetailDAO() { }

        public List<OrderDetail> GetListOrderInfo(string id)
        {
            List<OrderDetail> InsertOrderInfo = new List<OrderDetail>();

            DataTable data = Define.Instance.ExecuteQuery("SELECT * FROM dbo.ChiTietYeuCau WHERE MaPYC = '" + id +"'");

            foreach (DataRow item in data.Rows)
            {
                OrderDetail info = new OrderDetail(item);
                InsertOrderInfo.Add(info);
            }

            return InsertOrderInfo;
        }

        public void InsertOrderInfo(string idOrder, string idFood, int count)
        {
            Define.Instance.ExecuteNonQuery("PROC_INSERT_ORDERINFO @MAPYC , @MAMA , @SOLUONGMA", new object[] { idOrder, idFood, count });
        }
    }
}
