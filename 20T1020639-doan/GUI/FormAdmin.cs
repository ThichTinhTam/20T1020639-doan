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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using _20T1020639_doan.BLL;




namespace _20T1020639_doan.GUI
{
    public partial class FormAdmin : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;


        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }



        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay mna = new FormDanhSachGiay(tk, dn);
            mna.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin mna = new FormAdmin(tk, dn);
            mna.ShowDialog();

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien mna = new FormDanhSachNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe mna = new FormThongKe(tk, dn);
            mna.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormLoaiGiay mna = new FormLoaiGiay(tk, dn);
            mna.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachHoaDon mna = new FormDanhSachHoaDon(tk, dn);
            mna.ShowDialog();
        }
    }
}
