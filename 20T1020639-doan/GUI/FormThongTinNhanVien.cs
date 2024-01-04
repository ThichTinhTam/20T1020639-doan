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
    public partial class FormThongTinNhanVien : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;

        public FormThongTinNhanVien()
        {
            InitializeComponent();
        }

        public FormThongTinNhanVien(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongTinNhanVien mna = new FormThongTinNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV mna = new FormNV(tk, dn);
            mna.ShowDialog();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            Hide();
            FormKhachHang mna = new FormKhachHang(tk, dn);
            mna.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon mna = new FormHoaDon(tk, dn);
            mna.ShowDialog();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormBanGiay mna = new FormBanGiay(tk, dn);
            mna.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }
    }
}
