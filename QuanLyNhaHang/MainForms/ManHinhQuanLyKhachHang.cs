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

        DataSet GetKhachHang()
        {
            DataSet data = new DataSet();
            string query = "select * from KHACHHANG";

            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();

            }
            return data;

        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dtgvQuanLyKhachHang.DataSource = GetKhachHang().Tables[0];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter kh = new SqlDataAdapter("Proc_Insert_Khachhang", connection);
            try
            {
                connection.Open();
                kh.SelectCommand.CommandType = CommandType.StoredProcedure;
                kh.SelectCommand.Parameters.Add("@makh", SqlDbType.VarChar, (15)).Value = tb_maKH.Text;
                kh.SelectCommand.Parameters.Add("@tenkh", SqlDbType.NVarChar, (50)).Value = tb_tenKH.Text;
                kh.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (100)).Value = tb_diaChi.Text;
                kh.SelectCommand.Parameters.Add("@sdt", SqlDbType.VarChar, (10)).Value = tb_SDT.Text;
                kh.SelectCommand.ExecuteNonQuery();
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
            SqlDataAdapter kh = new SqlDataAdapter("Proc_Update_Khachhang", connection);
            try
            {
                connection.Open();
                kh.SelectCommand.CommandType = CommandType.StoredProcedure;
                kh.SelectCommand.Parameters.Add("@makh", SqlDbType.VarChar, (15)).Value = tb_maKH.Text;
                kh.SelectCommand.Parameters.Add("@tenkh", SqlDbType.NVarChar, (50)).Value = tb_tenKH.Text;
                kh.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (100)).Value = tb_diaChi.Text;
                kh.SelectCommand.Parameters.Add("@sdt", SqlDbType.VarChar, (10)).Value = tb_SDT.Text;
                kh.SelectCommand.ExecuteNonQuery();
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
            SqlDataAdapter kh = new SqlDataAdapter("Proc_Insert_Khachhang", connection);
            try
            {
                connection.Open();
                kh.SelectCommand.CommandType = CommandType.StoredProcedure;
                kh.SelectCommand.Parameters.Add("@makh", SqlDbType.VarChar, (15)).Value = tb_maKH.Text;
                kh.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tb_maKH.Text = "";
            tb_tenKH.Text = "";
            tb_diaChi.Text = "";
            tb_SDT.Text = "";
        }
    }
}