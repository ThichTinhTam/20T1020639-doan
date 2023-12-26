using _20T1020639_doan.BLL;
using _20T1020639_doan.DTO;
using _20T1020639_doan.GUI;

namespace _20T1020639_doan
{
    public partial class FormDangNhap : Form
    {
        private FormDangNhap dn;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            dtoTaiKhoan tk = new dtoTaiKhoan();
            tk.Username = txtUser.Text.Trim();
            tk.Password = txtPass.Text.Trim();

            dn = this;

            //Kiểm tra đối tượng đăng nhập
            bllTaiKhoan btk = new bllTaiKhoan();
            bool kt = btk.DangNhap(tk);

            //Nếu đúng thực hiện chuyển đổi form
            if (kt)
            {
                string admin = btk.TaiKhoanDangNhap(tk).Phanquyen;
                dn = this;
                if (admin == "admin")
                {
                    Hide();
                    txtPass.Clear();
                    FormAdmin mna = new FormAdmin(tk, dn);
                    mna.ShowDialog();
                }
                else
                {
                    Hide();
                    txtPass.Clear();
                    FormNV mn = new FormNV(tk, dn);
                    mn.ShowDialog();
                }
            }
            else
            {
                //hiển thị thông báo khi mật khẩu hoặc tên đăng nhập sai
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void button1_Click_2(object sender, EventArgs e)
        {
            Hide();
            FormDangKi mna = new FormDangKi();
            mna.ShowDialog();
        }
    }
}