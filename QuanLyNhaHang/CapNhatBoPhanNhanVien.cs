using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhaHang
{
    public partial class frmCapNhatBoPhanNhanVien : Form
    {
        public frmCapNhatBoPhanNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoatCapNhatDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatBoPhanNhanVien_Load(object sender, EventArgs e)
        {
            dgvCapNhatBoPhanNV.DataSource = GetBoPhanNhanVien().Tables[0];
        }
        DataSet GetBoPhanNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select*from BoPhanNhanVien";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_BOPHANNHANVIEN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MABP", SqlDbType.VarChar, (10)).Value = txtMaBP.Text;
                aa.SelectCommand.Parameters.Add("@TENBP", SqlDbType.NVarChar, (50)).Value = txtTenBP.Text;
                
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaBoPhan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_BOPHANNHANVIEN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MABP", SqlDbType.VarChar, (10)).Value = txtMaBP.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuCapNhatMonAn_Click(object sender, EventArgs e)
        {
            dgvCapNhatBoPhanNV.DataSource = GetBoPhanNhanVien().Tables[0];
        }

    }
}
