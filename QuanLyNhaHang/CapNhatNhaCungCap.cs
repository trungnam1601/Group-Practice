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
            string query = "select*from NHACUNGCAP";
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
            dtgvCapNhatNhaCungCap.DataSource = GetNCC().Tables[0];
        }
    }
}
