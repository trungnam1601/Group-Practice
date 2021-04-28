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
        DataSet GetBanAn()
        {
            DataSet data = new DataSet();
            string query = "select*from BanAn";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void BtnTroVeCuaQLNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCapNhatBanAn_Load(object sender, EventArgs e)
        {
            dgvCapNhatBanAn.DataSource = GetBanAn().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
        SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_BANAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MABAN", SqlDbType.VarChar, (10)).Value = textMaBa.Text;
                aa.SelectCommand.Parameters.Add("@TANG", SqlDbType.VarChar, (3)).Value = textTang.Text;
                aa.SelectCommand.Parameters.Add("@KIEUBAN", SqlDbType.NVarChar, (50)).Value = textKB.Text;
                aa.SelectCommand.Parameters.Add("@SOGHE", SqlDbType.SmallInt).Value = textSG.Text;
                aa.SelectCommand.Parameters.Add("@MAPYC", SqlDbType.VarChar, (10)).Value = textBox1.Text;            
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_BANAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MABAN", SqlDbType.VarChar, (10)).Value = textMaBa.Text;               
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLuuCapNhatBanAn_Click(object sender, EventArgs e)
        {
            dgvCapNhatBanAn.DataSource = GetBanAn().Tables[0];
        }

        private void btnHuyCapNhatBanAn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_UPDATE_BANAN", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MABAN", SqlDbType.VarChar, (10)).Value = textMaBa.Text;
                aa.SelectCommand.Parameters.Add("@TANG", SqlDbType.VarChar, (3)).Value = textTang.Text;
                aa.SelectCommand.Parameters.Add("@KIEUBAN", SqlDbType.NVarChar, (50)).Value = textKB.Text;
                aa.SelectCommand.Parameters.Add("@SOGHE", SqlDbType.SmallInt).Value = textSG.Text;
                aa.SelectCommand.Parameters.Add("@MAPYC", SqlDbType.VarChar, (10)).Value = textBox1.Text;
                aa.SelectCommand.ExecuteNonQuery();
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
