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
    public partial class FormThongKe : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormThongKe()
        {
            InitializeComponent();
        }

        public FormThongKe(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }



        private void btnKhoGiay_Click(object sender, EventArgs e)
        {

            new FormDanhSachGiay();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            new FormAdmin();

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            new FormDanhSachNhanVien();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new FormThongKe();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }
    }
}
