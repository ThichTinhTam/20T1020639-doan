﻿using _20T1020639_doan.DAL;
using _20T1020639_doan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20T1020639_doan.GUI
{
    public partial class FormBanGiay : Form
    {
        DataTable ShopGiay;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        string magiay;
        String Magiay;

        public FormBanGiay()
        {
            InitializeComponent();
        }

        public FormBanGiay(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaGiay, TenGiay, MaLoai, DonGiaBan, Anh, GhiChu FROM Giay";
            ShopGiay = Database.GetDataToDataTable(sql);

            // Đặt nguồn dữ liệu cho DataGridView trước khi thêm cột hình ảnh
            dgvGiay.DataSource = ShopGiay;

            dgvGiay.Columns[0].HeaderText = "Mã giày";
            dgvGiay.Columns[1].HeaderText = "Tên giày";
            dgvGiay.Columns[2].HeaderText = "Loại";
            dgvGiay.Columns[3].HeaderText = "Đơn giá bán";
            dgvGiay.Columns[4].HeaderText = "Ảnh";
            dgvGiay.Columns[5].HeaderText = "Ghi chú";
            dgvGiay.Columns[0].Width = 150;
            dgvGiay.Columns[1].Width = 200;
            dgvGiay.Columns[2].Width = 150;
            dgvGiay.Columns[3].Width = 200;
            dgvGiay.Columns[4].Width = 200;
            dgvGiay.Columns[5].Width = 200;

            dgvGiay.AllowUserToAddRows = false;
            dgvGiay.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void FormBanGiay_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon nma = new FormHoaDon(Magiay);
            nma.ShowDialog();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormBanGiay nma = new FormBanGiay();
            nma.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon nma = new FormHoaDon(Magiay);
            nma.ShowDialog();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            Hide();
            FormKhachHang nma = new FormKhachHang();
            nma.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV nma = new FormNV();
            nma.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangNhap nma = new FormDangNhap();
            nma.ShowDialog();
        }

        private void dgvGiay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvGiay.Rows.Count)
            {
                //  Lấy mã giày từ ô đã nhấp đúp
                string maGiay = dgvGiay.Rows[e.RowIndex].Cells["MaGiay"].Value.ToString();

                //   Hiển thị form chi tiết sản phẩm
                FormChiTietSanPham formChiTiet = new FormChiTietSanPham(maGiay);
                formChiTiet.ShowDialog();
            }
        }

        // khong truyen du lieu cua magiayquadc li do do da set ben cbomaygiay ben kia 
        private void dgvGiay_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn mua đôi giày này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                Magiay = dgvGiay.CurrentRow.Cells["MaGiay"].Value.ToString(); // thu auto bang ma nhan vien
                FormHoaDon frm = new FormHoaDon(Magiay);
                frm.cboMaGiay.SelectedValue = Magiay;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();

            }
        }

        private void dgvGiay_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongTinNhanVien mna = new FormThongTinNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormLichSuBanHang mna = new FormLichSuBanHang(tk, dn);
            mna.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon nma = new FormHoaDon(Magiay);
            nma.ShowDialog();
        }
    }
}
