using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class Category
    {
        public Category(string maNhomMA, string tenNhomMA)
        {
            this.MaNhomMA = maNhomMA;
            this.TenNhomMA = tenNhomMA;
        }

        public Category(DataRow row)
        {
            this.MaNhomMA = row["MaNhomMA"].ToString();
            this.TenNhomMA = row["TenNhomMA"].ToString();
        }

        private string tenNhomMA;

        public string TenNhomMA
        {
            get { return tenNhomMA; }
            set { tenNhomMA = value; }
        }

        private string maNhomMA;

        public string MaNhomMA
        {
            get { return maNhomMA; }
            set { maNhomMA = value; }
        }
    }
}
