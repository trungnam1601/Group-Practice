using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.Helper;
using Menu = QuanLyNhaHang.Helper.Menu;

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
            LoadCategory();
            //SqlConnection conn = new Helper.Define().GetConnection();
            //conn.Open();
            //SqlCommand cmdNMA = new SqlCommand("SELECT * FROM NhomMonAn", conn);
            //SqlDataReader drNMA = cmdNMA.ExecuteReader();
            //while (drNMA.Read())
            //{
            //    cmbNhomMA.Items.Add(drNMA["TenNhomMA"]);
            //    nhomMA.Add(new NhomMA()
            //    {
            //        MaNhomMA = drNMA["MaNhomMA"] as string,
            //        TenNhomMA = drNMA["TenNhomMA"] as string
            //    });
            //}
            //conn.Close();

            //conn.Open();
            //SqlCommand cmdMA = new SqlCommand("SELECT * FROM MonAn", conn);
            //SqlDataReader drMA = cmdMA.ExecuteReader();
            //while (drMA.Read())
            //{
            //    monAn.Add(new MonAn()
            //    {
            //        MaMA = drMA["MaMA"] as string,
            //        TenMA = drMA["TenMA"] as string,
            //        DVT = drMA["DVT"] as string,
            //        GiaBan = ((int)drMA["GiaBan"]),
            //        MaNhomMA = drMA["MaNhomMA"] as string,
            //        TrangThai = drMA["TrangThai"] as string,
            //    });

            //}

            //conn.Close();

        }

        private string[] GetFoodByID(string maNhomMA)
        {
            return monAn.Where(line => line.MaNhomMA == maNhomMA).Select(l => l.TenMA).ToArray();
        }
        private string[] GetIDByFood(string maMA)
        {
            return monAn.Where(line => line.MaMA == maMA).Select(l => l.MaNhomMA).ToArray();
        }
        private string[] GetIdByName(string MaMA)
        {
            return monAn.Where(line => line.MaMA == MaMA).Select(l => l.TenMA).ToArray();
        }
        private int[] GetPriceByName(string TenMA)
        {
            return monAn.Where(line => line.TenMA == TenMA).Select(l => l.GiaBan).ToArray();
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
            string id = "";

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        DataSet GetRequest()
        {

            DataSet data = new DataSet();
            string query = "select MaPYC, MaMA, DonGiaMA, SoLuongMA, DonGiaMA*SoLuongMA as TongTien from ChiTietYeuCau Where MaPYC LIKE '%"+txtTimKiem.Text+"'";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            //dtgvCapNhatGoiMon.DataSource = GetRequest().Tables[0];
            ShowOrder(txtTimKiem.Text);
            txtDonGia.Text="";
            txtSoLuong.Text="";
            txtMaPYC.Text = "";
            cmbMA.Text = "";
            cmbNhomMA.Text = "";
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
                cmbMA.ValueMember = "MaMA";
                //cmbMA.Text=((MonAn)cmbMA.SelectedItem).MaMA;
                cmbMA.DataSource = monAn;
                cmbMA.DisplayMember = "TenMA";
                cmbMA.ValueMember = "MaMA";
                aa.SelectCommand.Parameters.Add("@MAMA", SqlDbType.VarChar, (10)).Value = cmbMA.SelectedValue;
                aa.SelectCommand.Parameters.Add("@DONGIA", SqlDbType.Int).Value = txtDonGia.Text;
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

        private void cmbMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            string TenMA = monAn[cmbMA.SelectedIndex].TenMA;
            foreach (int GiaBan in GetPriceByName(TenMA))
            {
                //cmbMA.ValueMember = "MaMA";
                // this.cmbMA.Items.Add(tenMA);
                //int ProductIndex = monAn[cmbMA.SelectedIndex].GiaBan;
                //txtDonGia.Text = cmbMA.Items[ProductIndex].ToString();
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_YEUCAUMONAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAPYC", SqlDbType.VarChar, (10)).Value = txtMaPYC.Text;

                cmbMA.DataSource = monAn;
                cmbMA.DisplayMember = "TenMA";
                cmbMA.ValueMember = "MaMA";
                aa.SelectCommand.Parameters.Add("@MAMA", SqlDbType.VarChar, (10)).Value = cmbMA.SelectedValue;
                
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvCapNhatGoiMon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            try
            {
                connection.Open();
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvCapNhatGoiMon.Rows[e.RowIndex];
                txtMaPYC.Text = row.Cells[0].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                cmbMA.DataSource = monAn;

                //string TenMA = monAn[cmbMA.SelectedIndex].TenMA;
                string MaMA = row.Cells[1].Value.ToString();
                cmbMA.Text = GetIdByName(MaMA).ToString();
                
                connection.Close();
            }
            catch (Exception)
            {

            }
        }

        void ShowOrder(string id)
        {
            lsvOrder.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenu(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvOrder.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;

            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbNhomMA.DataSource = listCategory;
            cmbNhomMA.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(string id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cmbMA.DataSource = listFood;
            cmbMA.DisplayMember = "Name";
        }
    }
}
