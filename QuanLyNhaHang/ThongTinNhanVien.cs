using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
namespace QuanLyNhaHang
{
    public partial class frmCapNhatThongTinNhanVien : Form
    {
        BindingSource nhanVienList = new BindingSource();
        public frmCapNhatThongTinNhanVien()
        {
            InitializeComponent();
            Load();
        }

        private void btnBackTTNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataSet GetNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select*from NhanVien";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

         void Load()
        {
            dtgvThongTinNhanVien.DataSource = nhanVienList;
            LoadListNhanVien();
            AddNhanVienBinding();
        }

        private void dtgvThongTinNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvThongTinNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[7].Value.ToString();
                txtTenNV.Text = row.Cells[6].Value.ToString();
                txtLuong.Text = row.Cells[5].Value.ToString();
                dateNgaySinh.Text = row.Cells[4].Value.ToString();
                cbxGioiTinh.Text = row.Cells[3].Value.ToString();
                txtDiachi.Text = row.Cells[2].Value.ToString();
                txtMaCN.Text = row.Cells[1].Value.ToString();
                txtMaBP.Text = row.Cells[0].Value.ToString();
            }
            catch(Exception)
            {

            }
        }
        void LoadListNhanVien()
        {
            nhanVienList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }

        void AddNhanVienBinding()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txtLuong.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "Luong", true, DataSourceUpdateMode.Never));
            dateNgaySinh.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            cbxGioiTinh.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtMaCN.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "MaCN", true, DataSourceUpdateMode.Never));
            txtMaBP.DataBindings.Add(new Binding("Text", dtgvThongTinNhanVien.DataSource, "MaBP", true, DataSourceUpdateMode.Never));
            
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string name = txtTenNV.Text;
            string luong = txtLuong.Text;
            string ngaySinh = dateNgaySinh.Text;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiachi.Text;
            string maCN = txtMaCN.Text;
            string maBP = txtMaBP.Text;

            if (NhanVienDAO.Instance.InsertEmployee(maNV, name, luong, ngaySinh, gioiTinh, diaChi, maCN, maBP))
            {
                MessageBox.Show("success!");
                LoadListNhanVien();
                if (insertEmployee != null)
                    insertEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }


        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string name = txtTenNV.Text;
            string luong = txtLuong.Text;
            string ngaySinh = dateNgaySinh.Text;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiachi.Text;
            string maCN = txtMaCN.Text;
            string maBP = txtMaBP.Text;
            if (NhanVienDAO.Instance.UpdateEmployee(maNV, name, luong, ngaySinh, gioiTinh, diaChi, maCN, maBP))
            {
                MessageBox.Show("success!");
                LoadListNhanVien();
                if (updateEmployee != null)
                    updateEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            
            if (NhanVienDAO.Instance.DeleteEmployee(maNV))
            {
                MessageBox.Show("success!");
                LoadListNhanVien();
                if (deleteEmployee != null)
                    deleteEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private event EventHandler insertEmployee;
        public event EventHandler InsertEmployee
        {
            add { insertEmployee += value; }
            remove { insertEmployee -= value; }
        }
        private event EventHandler deleteEmployee;
        public event EventHandler DeleteEmployee
        {
            add { deleteEmployee += value; }
            remove { deleteEmployee -= value; }
        }

        private event EventHandler updateEmployee;
        public event EventHandler UpdateEmployee
        {
            add { updateEmployee += value; }
            remove { updateEmployee -= value; }
        }

        
    }
}