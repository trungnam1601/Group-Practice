using PhanMemQuanLyKhachSan.Model;
using QuanLyNhaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmCapNhatChiNhanh : Form
    {
        BindingSource chiNhanhList = new BindingSource();
        public frmCapNhatChiNhanh()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvCapNhatChiNhanh.DataSource = chiNhanhList;
            LoadListChiNhanh();
            AddChiNhanhBinding();
        }
        private void btnTroVeCuaCapNhatLichLamViec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvCapNhatChiNhanh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCapNhatChiNhanh.Rows[e.RowIndex];
                txtMaCN.Text = row.Cells[0].Value.ToString();
                txtTenCN.Text = row.Cells[1].Value.ToString();
                txtDiaChiCN.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        void LoadListChiNhanh()
        {
            chiNhanhList.DataSource = ChiNhanhDAO.Instance.GetListChiNhanh();
        }

        void AddChiNhanhBinding()
        {
            txtMaCN.DataBindings.Add(new Binding("Text", dgvCapNhatChiNhanh.DataSource, "MaCN", true, DataSourceUpdateMode.Never));
            txtTenCN.DataBindings.Add(new Binding("Text", dgvCapNhatChiNhanh.DataSource, "TenCN", true, DataSourceUpdateMode.Never));
            txtDiaChiCN.DataBindings.Add(new Binding("Text", dgvCapNhatChiNhanh.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));

        }
        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {
            string maCN = txtMaCN.Text;
            string tenCN = txtTenCN.Text;
            string diaChiCN = txtDiaChiCN.Text;
            if (ChiNhanhDAO.Instance.InsertBrand(maCN, tenCN,diaChiCN))
            {
                MessageBox.Show("success!");
                LoadListChiNhanh();
                if (insertBrand != null)
                    insertBrand(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }


        }

        private void btnSuaChiNhanh_Click(object sender, EventArgs e)
        {
            string tenCN = txtTenCN.Text;
            string maCN = txtMaCN.Text;
            string diaChiCN = txtDiaChiCN.Text;
            if (ChiNhanhDAO.Instance.UpdateBrand(maCN, tenCN, diaChiCN))
            {
                MessageBox.Show("success!");
                LoadListChiNhanh();
                if (updateBrand != null)
                    updateBrand(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private void btnXoaChiNhanh_Click(object sender, EventArgs e)
        {
            string maCN = txtMaCN.Text;

            if (ChiNhanhDAO.Instance.DeleteBrand(maCN))
            {
                MessageBox.Show("success!");
                LoadListChiNhanh();
                if (deleteBrand != null)
                    deleteBrand(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private event EventHandler insertBrand;
        public event EventHandler InsertBrand
        {
            add { insertBrand += value; }
            remove { insertBrand -= value; }
        }
        private event EventHandler deleteBrand;
        public event EventHandler DeleteBrand
        {
            add { deleteBrand += value; }
            remove { deleteBrand -= value; }
        }

        private event EventHandler updateBrand;
        public event EventHandler UpdateBrand
        {
            add { updateBrand += value; }
            remove { updateBrand -= value; }
        }
    }
}
