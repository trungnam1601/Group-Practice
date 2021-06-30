using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class OrderDetail
    {
        public OrderDetail(string id, string foodID,int price,int count)
        {
            this.ID = id;
            this.FoodID = foodID;
            this.Price = price;
            this.Count = count;
        }

        public OrderDetail(DataRow row)
        {
            this.ID = row["MaPYC"].ToString();
            this.FoodID = row["MaMA"].ToString();
            this.Price = (int)row["DonGiaMA"];
            this.Count = (int)row["SoLuongMA"];
        }

        private string foodID;

        public string FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
