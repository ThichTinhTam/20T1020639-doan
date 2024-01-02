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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _20T1020639_doan.GUI
{
    public partial class FormChucVu : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        DataTable CV;


        public FormChucVu()
        {
            InitializeComponent();
        }
        public FormChucVu(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {

            txtID.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Username,Password,Phanquyen FROM TaiKhoan";
            CV = Database.GetDataToDataTable(sql); //lấy dữ liệu
            dgvTaiKhoan.DataSource = CV;
            dgvTaiKhoan.Columns[0].HeaderText = "Username";
            dgvTaiKhoan.Columns[1].HeaderText = "Password";
            dgvTaiKhoan.Columns[2].HeaderText = "PhanQuyen";
            dgvTaiKhoan.Columns[0].Width = 300;
            dgvTaiKhoan.Columns[1].Width = 300;
            dgvTaiKhoan.Columns[2].Width = 300;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {

            if (CV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtID.Text = dgvTaiKhoan.CurrentRow.Cells["Username"].Value.ToString();
            txtPass.Text = dgvTaiKhoan.CurrentRow.Cells["Password"].Value.ToString();
            if (dgvTaiKhoan.CurrentRow.Cells["Phanquyen"].Value.ToString() == "admin") chkPhanQuyen.Checked = true;
            else chkPhanQuyen.Checked = false;
            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (CV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }


            if (chkPhanQuyen.Checked == true)
                gt = "admin";
            else
                gt = "";

            sql = "UPDATE TaiKhoan SET  Password=N'" + txtPass.Text.Trim().ToString() +
                    "',Phanquyen=N'" + gt +
                    "' WHERE Username=N'" + txtID.Text + "'";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }
        private void ResetValues()
        {
            txtID.Text = "";
            txtPass.Text = "";
            chkPhanQuyen.Checked = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnSua.Enabled = true;
            txtID.Enabled = false;
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay nma = new FormDanhSachGiay();
            nma.ShowDialog();
        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormLoaiGiay nma = new FormLoaiGiay();
            nma.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe nma = new FormThongKe();
            nma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachHoaDon nma = new FormDanhSachHoaDon();
            nma.ShowDialog();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien();
            nma.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin nma = new FormAdmin();
            nma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormChucVu nma = new FormChucVu();
            nma.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }
    }
}
