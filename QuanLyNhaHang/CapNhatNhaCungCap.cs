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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataSet GetNCC()
        {
            DataSet data = new DataSet();
            string query = "select*from NhaCungCap";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvCapNhatNhaCungCap.DataSource = GetNCC().Tables[0];
        }

        private void btnLuuCapNhatBanAn_Click(object sender, EventArgs e)
        {
            dgvCapNhatNhaCungCap.DataSource = GetNCC().Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PRO_INSERT_NCC", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MANCC", SqlDbType.VarChar, (10)).Value = txtMaNCC.Text;
                aa.SelectCommand.Parameters.Add("@TENNCC", SqlDbType.NVarChar, (50)).Value = txtTenNCC.Text;
                aa.SelectCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, (10)).Value = txtDiachi.Text;
                aa.SelectCommand.Parameters.Add("@SDT", SqlDbType.Int).Value = txtsdt.Text;              
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaCapNhatBanAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_UPDATE_NCC", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MANCC", SqlDbType.VarChar, (10)).Value = txtMaNCC.Text;
                aa.SelectCommand.Parameters.Add("@TENNCC", SqlDbType.NVarChar, (50)).Value = txtTenNCC.Text;
                aa.SelectCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, (10)).Value = txtDiachi.Text;
                aa.SelectCommand.Parameters.Add("@SDT", SqlDbType.Int).Value = txtsdt.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_NCC", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MANCC", SqlDbType.VarChar, (10)).Value = txtMaNCC.Text;             
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
