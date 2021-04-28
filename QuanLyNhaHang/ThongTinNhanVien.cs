using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class frmCapNhatThongTinNhanVien : Form
    {
        public frmCapNhatThongTinNhanVien()
        {
            InitializeComponent();
        }

        DataSet GetNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from NHANVIEN";

            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();

            }
            return data;

        }

        private void btnBackTTNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatThongTinNhanVien_Load(object sender, EventArgs e)
        {
            dtgvCapNhatNhanVien.DataSource = GetNhanVien().Tables[0];
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter nv = new SqlDataAdapter("Proc_Insert_NhanVien", connection);
            try
            {
                connection.Open();
                nv.SelectCommand.CommandType = CommandType.StoredProcedure;
                nv.SelectCommand.Parameters.Add("@manv", SqlDbType.VarChar, (10)).Value = tb_maNV.Text;
                nv.SelectCommand.Parameters.Add("@tennv", SqlDbType.NVarChar, (50)).Value = tb_tenNV.Text;
                nv.SelectCommand.Parameters.Add("@luong", SqlDbType.Int).Value = tb_luong.Text;
                nv.SelectCommand.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = date_ngaySinh.Text;
                nv.SelectCommand.Parameters.Add("@gioitinh", SqlDbType.NVarChar, (3)).Value = cbb_gioiTinh.Text;
                nv.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (100)).Value = tb_diaChi.Text;
                nv.SelectCommand.Parameters.Add("@macn", SqlDbType.VarChar, (15)).Value = tb_maCN.Text;
                nv.SelectCommand.Parameters.Add("@mabp", SqlDbType.VarChar, (15)).Value = tb_maBP.Text;
                nv.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            dtgvCapNhatNhanVien.DataSource = GetNhanVien().Tables[0];
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter nv = new SqlDataAdapter("Proc_Update_NhanVien", connection);
            try
            {
                connection.Open();
                nv.SelectCommand.CommandType = CommandType.StoredProcedure;
                nv.SelectCommand.Parameters.Add("@manv", SqlDbType.VarChar, (10)).Value = tb_maNV.Text;
                nv.SelectCommand.Parameters.Add("@tennv", SqlDbType.NVarChar, (50)).Value = tb_tenNV.Text;
                nv.SelectCommand.Parameters.Add("@luong", SqlDbType.Int).Value = tb_luong.Text;
                nv.SelectCommand.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = date_ngaySinh.Text;
                nv.SelectCommand.Parameters.Add("@gioitinh", SqlDbType.NVarChar, (3)).Value = cbb_gioiTinh.Text;
                nv.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (100)).Value = tb_diaChi.Text;
                nv.SelectCommand.Parameters.Add("@macn", SqlDbType.VarChar, (15)).Value = tb_maCN.Text;
                nv.SelectCommand.Parameters.Add("@mabp", SqlDbType.VarChar, (15)).Value = tb_maBP.Text;
                nv.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter nv = new SqlDataAdapter("Proc_Delete_NhanVien", connection);
            try
            {
                connection.Open();
                nv.SelectCommand.CommandType = CommandType.StoredProcedure;
                nv.SelectCommand.Parameters.Add("@manv", SqlDbType.VarChar, (10)).Value = tb_maNV.Text;
                nv.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemTTNV_Click(object sender, EventArgs e)
        {

        }
    }
}