﻿using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmthucphamnhahang : Form
    {
        public frmthucphamnhahang()
        {
            InitializeComponent();
        }

        private void btnThoatCapNhatVatTu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataSet GetThucPham()
        {
            DataSet data = new DataSet();
            string query = "select*from ThucPham";
            using (SqlConnection connection = new SqlConnection(Helper.Define.dataSource))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void frmthucphamnhahang_Load(object sender, EventArgs e)
        {
            dgvCapNhatThucPham.DataSource = GetThucPham().Tables[0];
        }

        private void btnThemThucPham_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_INSERT_THUCPHAM", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MATP", SqlDbType.VarChar, (10)).Value = textMTP.Text;
                aa.SelectCommand.Parameters.Add("@TENTP", SqlDbType.NVarChar, (50)).Value = textTTP.Text;
                aa.SelectCommand.Parameters.Add("@DVT", SqlDbType.NVarChar, (10)).Value = textDVT.Text;
                aa.SelectCommand.Parameters.Add("@GIABAN", SqlDbType.Int).Value = textGB.Text;            
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //SqlDataReader dta = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaThucPham_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
            SqlDataAdapter aa = new SqlDataAdapter("PROC_DELETE_THUCPHAM", connection);
            try
            {
                connection.Open();
                aa.SelectCommand.CommandType = CommandType.StoredProcedure;
                aa.SelectCommand.Parameters.Add("@MATP", SqlDbType.VarChar, (10)).Value = textMTP.Text;
                aa.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuCapNhatThucPham_Click(object sender, EventArgs e)
        {
            dgvCapNhatThucPham.DataSource = GetThucPham().Tables[0];
        }
    }
}
