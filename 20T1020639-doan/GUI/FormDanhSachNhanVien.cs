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
    public partial class FormDanhSachNhanVien : Form
    {

        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public FormDanhSachNhanVien(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            new FormAdmin();
        }

        private void btnDangXuat_Click_2(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            new FormDanhSachGiay();
        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            new FormLoaiGiay();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new FormThongKe();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            new FormDanhSachNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

