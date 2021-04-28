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
    public partial class frmCapNhatBanAn : Form
    {
        public frmCapNhatBanAn()
        {
            InitializeComponent();
        }

        private void BtnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataSet GetBanAN()
        {
            DataSet data = new DataSet();
            string query = "select*from BANAN";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCapNhatBanAn_Load(object sender, EventArgs e)
        {
            dtgvCapNhatBanAn.DataSource = GetBanAN().Tables[0];
        }
    }
}
