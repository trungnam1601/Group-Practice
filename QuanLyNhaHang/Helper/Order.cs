using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class Order
    {
        public Order(string id, int trangThai)
        {
            this.ID = id;
            this.TrangThai = trangThai;
        }

        public Order(DataRow row)
        {
            this.ID = row["MaPYC"].ToString();
            this.TrangThai = (int)row["TrangThai"];
        }

        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
