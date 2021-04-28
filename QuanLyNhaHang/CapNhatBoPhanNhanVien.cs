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
    public partial class frmCapNhatBoPhanNhanVien : Form
    {
        public frmCapNhatBoPhanNhanVien()
        {
            InitializeComponent();
        }

        DataSet GetBPNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from BOPHANNHANVIEN";

            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();

            }
            return data;

        }

        private void btnTroVeBPNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatBoPhanNhanVien_Load(object sender, EventArgs e)
        {
            dtgvCapNhatBoPhanNV.DataSource = GetBPNhanVien().Tables[0];
        }

        private void btResetBoPhan_Click(object sender, EventArgs e)
        {
            tb_maBP.Text = "";
            tb_tenBP.Text = "";
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter bpnv = new SqlDataAdapter("Proc_Insert_BPNhanVien", connection);
            try
            {
                connection.Open();
                bpnv.SelectCommand.CommandType = CommandType.StoredProcedure;
                bpnv.SelectCommand.Parameters.Add("@mabp", SqlDbType.VarChar, (10)).Value = tb_maBP.Text;
                bpnv.SelectCommand.Parameters.Add("@tenbp", SqlDbType.NVarChar, (50)).Value = tb_tenBP.Text;
                bpnv.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaBoPhan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter bpnv = new SqlDataAdapter("Proc_Update_BPNhanVien", connection);
            try
            {
                connection.Open();
                bpnv.SelectCommand.CommandType = CommandType.StoredProcedure;
                bpnv.SelectCommand.Parameters.Add("@mabp", SqlDbType.VarChar, (10)).Value = tb_maBP.Text;
                bpnv.SelectCommand.Parameters.Add("@tenbp", SqlDbType.NVarChar, (50)).Value = tb_tenBP.Text;
                bpnv.SelectCommand.ExecuteNonQuery();
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
            SqlDataAdapter bpnv = new SqlDataAdapter("Proc_Update_BPNhanVien", connection);
            try
            {
                connection.Open();
                bpnv.SelectCommand.CommandType = CommandType.StoredProcedure;
                bpnv.SelectCommand.Parameters.Add("@mabp", SqlDbType.VarChar, (10)).Value = tb_maBP.Text;
                bpnv.SelectCommand.ExecuteNonQuery();
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
