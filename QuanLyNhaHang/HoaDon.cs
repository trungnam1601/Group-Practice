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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        DataSet GetHoaDon()
        {
            DataSet data = new DataSet();
            string query = "select*from HoaDon";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        void loadData()
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select*from Hoadon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgv_CapNhatHoaDon.DataSource = table;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dtgv_CapNhatHoaDon.DataSource = GetHoaDon().Tables[0];
        }

        private void btnTroVeCuaQLKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_HOADON", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAHD", SqlDbType.VarChar, (10)).Value = txtMaHD.Text;
                aa.SelectCommand.Parameters.Add("@TENHD", SqlDbType.NVarChar, (50)).Value = txtTenHD.Text;
                aa.SelectCommand.Parameters.Add("@NGAYHD", SqlDbType.Date, (100)).Value = txtNgayHD.Text;
                aa.SelectCommand.Parameters.Add("@GIATIEN", SqlDbType.Int).Value = txtGiaTienHD.Text;
                aa.SelectCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txtSoLuongHD.Text;
                aa.SelectCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, (50)).Value = txtMAKH_HD.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
                string S_name = txtTenHD.Text;
                string noti = "Thêm thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_UPDATE_HOADON", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAHD", SqlDbType.VarChar, (10)).Value = txtMaHD.Text;
                aa.SelectCommand.Parameters.Add("@TENHD", SqlDbType.NVarChar, (50)).Value = txtTenHD.Text;
                aa.SelectCommand.Parameters.Add("@NGAYHD", SqlDbType.Date, (100)).Value = txtNgayHD.Text;
                aa.SelectCommand.Parameters.Add("@GIATIEN", SqlDbType.Int).Value = txtGiaTienHD.Text;
                aa.SelectCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txtSoLuongHD.Text;
                aa.SelectCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, (50)).Value = txtMAKH_HD.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
                string S_name = txtTenHD.Text;
                string noti = "Sửa thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_HOADON", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MAHD", SqlDbType.VarChar, (10)).Value = txtMaHD.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                string S_name = txtTenHD.Text;
                string noti = "Xóa thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtTenHD.Text = "";
            txtNgayHD.Text = "";
            txtGiaTienHD.Text = "";
            txtSoLuongHD.Text = "";
            txtMAKH_HD.Text = "";
        }

        private void dtgv_CapNhatHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_CapNhatHoaDon.CurrentRow.Index;
            txtMaHD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[0].Value.ToString();
            txtTenHD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[1].Value.ToString();
            txtNgayHD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[2].Value.ToString();
            txtGiaTienHD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[3].Value.ToString();
            txtSoLuongHD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[4].Value.ToString();
            txtMAKH_HD.Text = dtgv_CapNhatHoaDon.Rows[i].Cells[5].Value.ToString();
        }
    }
}
