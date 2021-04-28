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

        DataSet GetChiNhanh()
        {
            DataSet data = new DataSet();
            string query = "select * from CHINHANH";

            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();

            }
            return data;

        }

        private void frmCapNhatChiNhanh_Load(object sender, EventArgs e)
        {
            dgvCapNhatChiNhanh.DataSource = GetChiNhanh().Tables[0];
        }

        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter cn = new SqlDataAdapter("Proc_Insert_Chinhanh", connection);
            try
            {
                connection.Open();
                cn.SelectCommand.CommandType = CommandType.StoredProcedure;
                cn.SelectCommand.Parameters.Add("@manc", SqlDbType.VarChar, (15)).Value = tb_maChiNhanh.Text;
                cn.SelectCommand.Parameters.Add("@tennc", SqlDbType.NVarChar, (50)).Value = tb_tenChiNhanh.Text;
                cn.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (100)).Value = tb_diaChi.Text;
                cn.SelectCommand.ExecuteNonQuery();
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
            tb_maChiNhanh.Text = "";
            tb_tenChiNhanh.Text = "";
            tb_diaChi.Text = "";
        }

        private void btnSuaChiNhanh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter cn = new SqlDataAdapter("Proc_Upate_Chinhanh", connection);
            try
            {
                connection.Open();
                cn.SelectCommand.CommandType = CommandType.StoredProcedure;
                cn.SelectCommand.Parameters.Add("@manc", SqlDbType.VarChar, (10)).Value = tb_maChiNhanh.Text;
                cn.SelectCommand.Parameters.Add("@tennc", SqlDbType.NVarChar, (50)).Value = tb_tenChiNhanh.Text;
                cn.SelectCommand.Parameters.Add("@diachi", SqlDbType.NVarChar, (10)).Value = tb_diaChi.Text;
                cn.SelectCommand.ExecuteNonQuery();
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
            SqlDataAdapter cn = new SqlDataAdapter("Proc_Delete_Chinhanh", connection);
            try
            {
                connection.Open();
                cn.SelectCommand.CommandType = CommandType.StoredProcedure;
                cn.SelectCommand.Parameters.Add("@macn", SqlDbType.VarChar, (10)).Value = tb_maChiNhanh.Text;
                cn.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
