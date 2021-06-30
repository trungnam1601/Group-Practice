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
        void loadData()
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select*from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvQuanLyKhachHang.DataSource = table;
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaKh.Text = "";
            txtTenKh.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtSearchKH.Text = "";
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
                string S_name = txtTenKh.Text;
                string noti = "Thêm thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
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
                string S_name = txtTenKh.Text;
                string noti = "Xóa thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
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
                string S_name = txtTenKh.Text;
                string noti = "Sửa thành công\n" + S_name;
                MessageBox.Show(noti, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQuanLyKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQuanLyKhachHang.CurrentRow.Index;
            txtMaKh.Text = dgvQuanLyKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKh.Text = dgvQuanLyKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvQuanLyKhachHang.Rows[i].Cells[2].Value.ToString();
            txtPhone.Text = dgvQuanLyKhachHang.Rows[i].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);

            connection.Open();
            string sqlCode1 = "select * from DBO.SEARCH_KH_TENKH(N'" + txtSearchKH.Text + "')";

            SqlCommand cmd = new SqlCommand(sqlCode1, connection);

            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();

            dataTable.Load(dataReader);
            dgvQuanLyKhachHang.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}