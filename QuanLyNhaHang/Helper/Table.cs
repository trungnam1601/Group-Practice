using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class Table
    {
        public Table(string maBan, string trangThai)
        {
            this.MaBan = maBan;
            this.TrangThai = trangThai;
        }

        public Table(DataRow row)
        {
            this.MaBan = row["MaBan"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private string maBan;

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
    }
}
