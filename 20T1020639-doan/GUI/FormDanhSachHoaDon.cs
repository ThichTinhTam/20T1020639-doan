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
    public partial class FormDanhSachHoaDon : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;


        public FormDanhSachHoaDon()
        {
            InitializeComponent();
        }
        public FormDanhSachHoaDon(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }


        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
