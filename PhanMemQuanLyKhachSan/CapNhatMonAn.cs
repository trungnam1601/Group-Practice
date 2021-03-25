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

namespace PhanMemQuanLyKhachSan
{
    public partial class frmCapNhatMonAn : Form
    {
        public frmCapNhatMonAn()
        {
            InitializeComponent();
        }

        private void btnThoatCapNhatDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
