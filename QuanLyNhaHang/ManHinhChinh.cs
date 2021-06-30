using PhanMemQuanLyKhachSan.Model;
using QuanLyNhaHang.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyNhaHang.Helper.Menu;
namespace QuanLyNhaHang
{
    public partial class frmManHinhChinh : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmManHinhChinh()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // lblTitleChildForm.Text = childForm.Text;
        }
        private void QuanLyNhaHang_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            OpenChildForm(new frmQuanLyNhaHang());

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            OpenChildForm(new frmQuanLyNhanVien());
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            OpenChildForm(new frmQuanLyKhachHang());
        }
        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            OpenChildForm(new frmLienHe());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
           
        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.MaBan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TrangThai)
                {
                    case "Đang Sử Dụng":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.IndianRed;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Table).MaBan;
            lsvOrder.Tag = (sender as Button).Tag;
            ShowOrder(tableID);
        }
        void ShowOrder(string id)
        {
            lsvOrder.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenu(id);
            float totalPrice = 0;
            
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaPYC.ToString());
                lsvItem.SubItems.Add(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                txtMaPYC.Text = item.MaPYC.ToString();
                totalPrice += item.TotalPrice;
                lsvOrder.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            Thread.CurrentThread.CurrentCulture = culture;

            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbNhomMA.DataSource = listCategory;
            cmbNhomMA.DisplayMember = "TenNhomMA";
        }

        void LoadFoodListByCategoryID(string id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cmbMA.DataSource = listFood;
            cmbMA.DisplayMember = "TenMA";
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            Table table = lsvOrder.Tag as Table;

            string idOrder = OrderDAO.Instance.GetUncheckOrderID(table.MaBan);
            string foodID = (cmbMA.SelectedItem as Food).MaMA;
            int count = (int)nmFoodCount.Value;

            if (idOrder == "-1")
            {
                OrderDAO.Instance.InsertOrder(table.MaBan);
                OrderDetailDAO.Instance.InsertOrderInfo(OrderDAO.Instance.GetMaxIDOrder(), foodID, count);
            }
            else
            {
                OrderDetailDAO.Instance.InsertOrderInfo(idOrder, foodID, count);
            }

            ShowOrder(table.MaBan);
        }

        private void cmbNhomMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.MaNhomMA;

            LoadFoodListByCategoryID(id);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvOrder.Tag as Table;

            string idBill = OrderDAO.Instance.GetUncheckOrderID(table.MaBan);

            if (idBill != "-1")
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.MaBan, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    OrderDAO.Instance.CheckOut(idBill);
                    ShowOrder(table.MaBan);

                    LoadTable();
                }
            }
        }
    }
}
