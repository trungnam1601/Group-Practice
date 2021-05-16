using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.Helper;
namespace QuanLyNhaHang
{
    public partial class frmCapNhatGoiMon : Form
    {
        List<NhomMA> nhomMA = new List<NhomMA>();
        List<MonAn> monAn = new List<MonAn>();
        public frmCapNhatGoiMon()
        {
            InitializeComponent();
        }
        
        private void frmCapNhatGoiMon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new Helper.Define().GetConnection();
            conn.Open();
            SqlCommand cmdNMA = new SqlCommand("SELECT * FROM NhomMonAn", conn);
            SqlDataReader drNMA = cmdNMA.ExecuteReader();
            while (drNMA.Read())
            {
                cmbNhomMA.Items.Add(drNMA["TenNhomMA"]);
                nhomMA.Add(new NhomMA()
                {
                    MaNhomMA = drNMA["MaNhomMA"] as string,
                    TenNhomMA = drNMA["TenNhomMA"] as string
                });
            }
            conn.Close();

            conn.Open();
            SqlCommand cmdMA = new SqlCommand("SELECT * FROM MonAn", conn);
            SqlDataReader drMA = cmdMA.ExecuteReader();
            while (drMA.Read())
            {
                monAn.Add(new MonAn()
                {
                    MaMA=drMA["MaMA"]as string,
                    TenMA= drMA["TenMA"] as string,
                    DVT = drMA["DVT"] as string,
                    GiaBan = ((int)drMA["GiaBan"]),
                    MaNhomMA = drMA["MaNhomMA"] as string,
                    TrangThai = drMA["TrangThai"] as string,
                });
            }
            conn.Close();
            
        }

        private string[] GetFoodByID(string maNhomMA)
        {
            return monAn.Where(line => line.MaNhomMA == maNhomMA).Select(l => l.TenMA).ToArray();
        }
        private string[] GetIdByName(string TenMA)
        {
            return monAn.Where(line => line.TenMA == TenMA).Select(l => l.MaMA).ToArray();
        }

        [Serializable]
        class NhomMA
        {
            public string MaNhomMA { get; set; }
            public string TenNhomMA { get; set; }
        }
        [Serializable]
        class MonAn
        {
            public string MaMA { get; set; }
            public string TenMA { get; set; }
            public string DVT { get; set; }
            public int GiaBan { get; set; }
            public string MaNhomMA { get; set; }
            public string TrangThai { get; set; }
        }

        private void cmbNhomMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMA.Items.Clear();
            string MaNhomMA = nhomMA[cmbNhomMA.SelectedIndex].MaNhomMA;
            foreach (string tenMA in GetFoodByID(MaNhomMA))
            {
                cmbMA.ValueMember = "MaMA";
                this.cmbMA.Items.Add(tenMA);
            }
        }

        DataSet GetRequest()
        {
            DataSet data = new DataSet();
            string query = "select MaMA, DonGiaMA, SoLuongMA, DonGiaMA*SoLuongMA as TongTien from ChiTietYeuCau Where MaPYC = '"+txtMaPYC.Text+"'";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgvCapNhatGoiMon.DataSource = GetRequest().Tables[0];
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_YEUCAU", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAPYC", SqlDbType.VarChar, (10)).Value = txtMaPYC.Text;
                //cmbMA.ValueMember = "MAMA";
                cmbMA.Text=((MonAn)cmbMA.SelectedItem).MaMA;
                aa.SelectCommand.Parameters.Add("@MAMA", SqlDbType.VarChar, (10)).Value = cmbMA.Text;
                //aa.SelectCommand.Parameters.Add("@DONGIAMA", SqlDbType.Int).Value = txtLuong.Text;
                aa.SelectCommand.Parameters.Add("@SOLUONGMA", SqlDbType.Int).Value = txtSoLuong.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
