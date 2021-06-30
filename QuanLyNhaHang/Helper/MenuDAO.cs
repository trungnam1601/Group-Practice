using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Helper
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenu(string id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT bi.MaPYC, f.TenMA, bi.SoLuongMA, f.GiaBan, f.GiaBan*bi.SoLuongMA AS totalPrice FROM dbo.ChiTietYeuCau AS bi, dbo.PhieuYeuCau AS b, dbo.MonAn AS f WHERE bi.MaPYC = b.MaPYC AND bi.MaMA = f.MaMA AND b.TrangThai=0 AND b.MaBan = '" + id + "'";
            DataTable data = Define.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
