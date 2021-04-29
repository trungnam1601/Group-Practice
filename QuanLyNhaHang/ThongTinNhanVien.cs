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

namespace QuanLyNhaHang
{
    public partial class frmCapNhatThongTinNhanVien : Form
    {
        BindingSource nhanVienList = new BindingSource();
        public frmCapNhatThongTinNhanVien()
        {
            InitializeComponent();
            
        }

        private void btnBackTTNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            dtgvThongTinNhanVien.DataSource = GetNhanVien().Tables[0];
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

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_NHANVIEN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MANV", SqlDbType.VarChar, (10)).Value = txtMaNV.Text;
                aa.SelectCommand.Parameters.Add("@TENNV", SqlDbType.NVarChar, (50)).Value = txtTenNV.Text;
                aa.SelectCommand.Parameters.Add("@LUONG", SqlDbType.NVarChar, (10)).Value = txtLuong.Text;
                aa.SelectCommand.Parameters.Add("@NGAYSINH", SqlDbType.Int).Value = dateNgaySinh.Text;
                aa.SelectCommand.Parameters.Add("@GIOITINH", SqlDbType.VarChar, (10)).Value = cbxGioiTinh.Text;
                aa.SelectCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, (50)).Value = txtDiachi.Text;
                aa.SelectCommand.Parameters.Add("@MACN", SqlDbType.NVarChar, (50)).Value = txtMaCN.Text;
                aa.SelectCommand.Parameters.Add("@MABP", SqlDbType.NVarChar, (50)).Value = txtMaBP.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_NHANVIEN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MANV", SqlDbType.VarChar, (10)).Value = txtMaNV.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            dtgvThongTinNhanVien.DataSource = GetNhanVien().Tables[0];
        }
    }
}