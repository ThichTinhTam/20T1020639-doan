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
    public partial class FormDoiMatKhau : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        public FormDoiMatKhau(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            string str;
            str = "SELECT * FROM NhanVien WHERE MaNhanVien = N'" + tk.Username + "'";
            txtID.Text = Database.GetFieldValues(str);
        }
        private void ResetValuesHang()
        {
            txtPass.Text = "";
            txtenterpassword.Text = "";
        }
        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            if ((txtPass.Text == "") && (txtenterpassword.Text == "") || (txtPass.Text == "") || (txtenterpassword.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập đầy đủ thông tin để đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if((txtPass.Text == txtenterpassword.Text))
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // return;
                ResetValuesHang();
            }
            if ((txtPass.Text == tk.Password))
            {
                string tnv;
                tnv = "UPDATE TaiKhoan SET Password = N'" + txtenterpassword.Text.Trim().ToString() + "' WHERE Username = N'" + tk.Username + "'";
                Database.RunSQL(tnv);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return;
                ResetValuesHang();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtenterpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
