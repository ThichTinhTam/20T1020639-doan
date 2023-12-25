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
        private Form currentFormChild;
        //private Guna2GradientButton currentButton;

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
    }
}
