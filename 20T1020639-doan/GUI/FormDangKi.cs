using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20T1020639_doan.BLL;
using _20T1020639_doan.DTO;


namespace _20T1020639_doan.GUI
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtID.Text == "") && (txtMK.Text == "") || (txtID.Text == "") || (txtMK.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập đầy đủ thông tin đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool flag = true;
            string id;
            bllTaiKhoan bllTaiKhoan = new bllTaiKhoan();

            id = txtID.Text.Trim();
            foreach (string ma in bllTaiKhoan.DanhSachID())
            {
                if (id.Equals(ma))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                dtoTaiKhoan taiKhoan = new dtoTaiKhoan();
                taiKhoan.Username = txtID.Text.Trim();
                taiKhoan.Password = txtMK.Text.Trim();
                if (chkAdmin.Checked)
                {
                    taiKhoan.Phanquyen = "admin";
                }
                else
                {
                    taiKhoan.Phanquyen = "";
                }

                if (bllTaiKhoan.ThemTK(taiKhoan))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Mã ID đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangNhap mna = new FormDangNhap();
            mna.ShowDialog();
        }
    }
}
