using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class Menu
    {
        public Menu(string maPYC, string foodName, int count, float price, float totalPrice=0)
        {
            this.MaPYC = maPYC;
            this.FoodName = foodName;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.Count = count;
        }
        public Menu(DataRow row)
        {
            this.MaPYC = row["MaPYC"].ToString(); 
            this.FoodName = row["TenMA"].ToString(); 
            this.Price = (float)Convert.ToDouble(row["GiaBan"]);
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"]);
            this.Count = (int)row["SoLuongMA"];
        }
        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private float price;
        public float Price
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

        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        private string maPYC;
        public string MaPYC
        {
            get { return maPYC; }
            set { maPYC = value; }
        }
    }
}
