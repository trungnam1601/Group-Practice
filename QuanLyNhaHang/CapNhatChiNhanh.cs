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
    public partial class frmCapNhatChiNhanh : Form
    {
        public frmCapNhatChiNhanh()
        {
            InitializeComponent();
        }

        private void btnTroVeCuaCapNhatLichLamViec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmCapNhatChiNhanh_Load(object sender, EventArgs e)
        {
            dgvCapNhatChiNhanh.DataSource = GetChiNhanh().Tables[0];
        }
        DataSet GetChiNhanh()
        {
            DataSet data = new DataSet();
            string query = "select*from ChiNhanh";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_CHINHANH", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MACN", SqlDbType.VarChar, (10)).Value = txtMaCN.Text;
                aa.SelectCommand.Parameters.Add("@TENCN", SqlDbType.NVarChar, (50)).Value = txtTenCN.Text;
                aa.SelectCommand.Parameters.Add("@DIACHICN", SqlDbType.NVarChar, (10)).Value = txtDiachi.Text;
                
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaChiNhanh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_CHINHANH", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MACN", SqlDbType.VarChar, (10)).Value = txtMaCN.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatChiNhanh_Click(object sender, EventArgs e)
        {
            dgvCapNhatChiNhanh.DataSource = GetChiNhanh().Tables[0];
        }
    }
}
