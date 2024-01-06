using _20T1020639_doan.DAL;
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
    public partial class FormNV : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;

        public FormNV()
        {
            InitializeComponent();
        }

        public FormNV(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormBanGiay mna = new FormBanGiay(tk, dn);
            mna.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon mna = new FormHoaDon(tk, dn);
            mna.ShowDialog();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            Hide();
            FormKhachHang mna = new FormKhachHang(tk, dn);
            mna.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV mna = new FormNV(tk, dn);
            mna.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormThongTinNhanVien mna = new FormThongTinNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            string str;
            str = "SELECT TenNhanVien FROM NhanVien WHERE MaNhanVien = N'" + tk.Username + "'";
            textBox1.Text = Database.GetFieldValues(str);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormLichSuBanHang mna = new FormLichSuBanHang(tk, dn);
            mna.ShowDialog();
        }
    }
}
