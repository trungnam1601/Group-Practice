using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaQLKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvQuanLyKhachHang.DataSource = GetKhachHang().Tables[0];
        }
        DataSet GetKhachHang()
        {
            DataSet data = new DataSet();
            string query = "select*from KhachHang";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            dgvQuanLyKhachHang.DataSource = GetKhachHang().Tables[0];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_KHACHHANG", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, (10)).Value = txtMaKh.Text;
                aa.SelectCommand.Parameters.Add("@TENKH", SqlDbType.NVarChar, (50)).Value = txtTenKh.Text;
                aa.SelectCommand.Parameters.Add("@DIACHIKH", SqlDbType.NVarChar, (100)).Value = txtDiaChi.Text;
                aa.SelectCommand.Parameters.Add("@SDT", SqlDbType.Text).Value = txtPhone.Text;                
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_KHACHHANG", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, (10)).Value = txtMaKh.Text;                
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_UPDATE_KHACHHANG", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, (10)).Value = txtMaKh.Text;
                aa.SelectCommand.Parameters.Add("@TENKH", SqlDbType.NVarChar, (50)).Value = txtTenKh.Text;
                aa.SelectCommand.Parameters.Add("@DIACHIKH", SqlDbType.NVarChar, (100)).Value = txtDiaChi.Text;
                aa.SelectCommand.Parameters.Add("@SDT", SqlDbType.Text).Value = txtPhone.Text;
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