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
    public partial class ThongKe : Form
    {
        DataSet GetThongKe()
        {
            DataSet data = new DataSet();
            string query = "";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public ThongKe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbb_thongKe.SelectedItem.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dtgv_ThongKe.DataSource = GetThongKe().Tables[0];
        }
    }
}
