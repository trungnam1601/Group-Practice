using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;
namespace QuanLyNhaHang
{
    public partial class frmCapNhatBoPhanNhanVien : Form
    {
        BindingSource boPhanNhanVienList = new BindingSource();
        public frmCapNhatBoPhanNhanVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvCapNhatBoPhanNV.DataSource = boPhanNhanVienList;
            LoadListBoPhanNhanVien();
            AddBoPhanNhanVienBinding();
        }
        private void btnTroVeBPNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCapNhatBoPhanNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCapNhatBoPhanNV.Rows[e.RowIndex];
                txtMaBP.Text = row.Cells[1].Value.ToString();
                txtTenBP.Text = row.Cells[0].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }
        void LoadListBoPhanNhanVien()
        {
            boPhanNhanVienList.DataSource = BoPhanNhanVienDAO.Instance.GetListBoPhanNhanVien();
        }

        void AddBoPhanNhanVienBinding()
        {
            txtMaBP.DataBindings.Add(new Binding("Text", dgvCapNhatBoPhanNV.DataSource, "MaBP", true, DataSourceUpdateMode.Never));
            txtTenBP.DataBindings.Add(new Binding("Text", dgvCapNhatBoPhanNV.DataSource, "TenBP", true, DataSourceUpdateMode.Never));
           
        }
        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            string maBP = txtMaBP.Text;
            string tenBP = txtTenBP.Text;

            if (BoPhanNhanVienDAO.Instance.InsertBPEmployee(maBP, tenBP))
            {
                MessageBox.Show("success!");
                LoadListBoPhanNhanVien();
                if (insertBPEmployee != null)
                    insertBPEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }


        }

        private void btnSuaBoPhan_Click(object sender, EventArgs e)
        {
            string tenBP = txtTenBP.Text;
            string maBP = txtMaBP.Text;
            if (BoPhanNhanVienDAO.Instance.UpdateBPEmployee(tenBP, maBP))
            {
                MessageBox.Show("success!");
                LoadListBoPhanNhanVien();
                if (updateBPEmployee != null)
                    updateBPEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private void btnXoaBoPhan_Click(object sender, EventArgs e)
        {
            string maBP = txtMaBP.Text;

            if (BoPhanNhanVienDAO.Instance.DeleteBPEmployee(maBP))
            {
                MessageBox.Show("success!");
                LoadListBoPhanNhanVien();
                if (deleteBPEmployee != null)
                    deleteBPEmployee(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Something's wrong");
            }
        }
        private event EventHandler insertBPEmployee;
        public event EventHandler InsertBPEmployee
        {
            add { insertBPEmployee += value; }
            remove { insertBPEmployee -= value; }
        }
        private event EventHandler deleteBPEmployee;
        public event EventHandler DeleteBPEmployee
        {
            add { deleteBPEmployee += value; }
            remove { deleteBPEmployee -= value; }
        }

        private event EventHandler updateBPEmployee;
        public event EventHandler UpdateBPEmployee
        {
            add { updateBPEmployee += value; }
            remove { updateBPEmployee -= value; }
        }

    }
}
