using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class Food
    {
        public Food(string maMA, string tenMA, string maNhomMA, int giaBan, string dvt,string trangThai)
        {
            this.MaMA = maMA;
            this.TenMA = tenMA;
            this.MaNhomMA = maNhomMA;
            this.GiaBan = giaBan;
            this.Dvt = dvt;
            this.TrangThai = trangThai;
        }

        public Food(DataRow row)
        {
            this.MaMA = row["MaMA"].ToString();
            this.TenMA = row["TenMA"].ToString();
            this.MaNhomMA = row["MaNhomMA"].ToString();
            this.GiaBan = (int)row["GiaBan"];
            this.Dvt = row["dvt"].ToString();
            this.TrangThai = row["trangThai"].ToString();
        }

        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private string dvt;

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }

        private int giaBan;

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        private string maNhomMA;

        public string MaNhomMA
        {
            get { return maNhomMA; }
            set { maNhomMA = value; }
        }

        private string tenMA;

        public string TenMA
        {
            get { return tenMA; }
            set { tenMA = value; }
        }

        private string maMA;

        public string MaMA
        {
            get { return maMA; }
            set { maMA = value; }
        }
    }
}
