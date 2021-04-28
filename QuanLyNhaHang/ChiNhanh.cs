using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class ChiNhanh
    {
        private string maCN;
        private string tenCN;
        private string diaChiCN;

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChiCN { get => diaChiCN; set => diaChiCN = value; }

        public ChiNhanh(string maCN, string tenCN,string diaChiCN)
        {
            this.MaCN = maCN;
            this.TenCN = tenCN;
            this.DiaChiCN = diaChiCN;
        }
        public ChiNhanh(DataRow row)
        {
            this.MaCN = row["MaCN"].ToString();
            this.TenCN = row["TenCN"].ToString();
            this.DiaChiCN = row["DiaChiCN"].ToString();
        }
    }
}
