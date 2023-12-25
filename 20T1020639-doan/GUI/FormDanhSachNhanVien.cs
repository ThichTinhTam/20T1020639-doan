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
using System.Data.SqlClient;
using _20T1020639_doan.DAL;

namespace _20T1020639_doan.GUI
{
    public partial class FormDanhSachNhanVien : Form
    {
        DataTable NV;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public FormDanhSachNhanVien(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            new FormAdmin();
        }

        private void btnDangXuat_Click_2(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            new FormDanhSachGiay();
        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            new FormLoaiGiay();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new FormThongKe();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            new FormDanhSachNhanVien();
        }
        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkGioiTinh.Checked = false;
            txtDiachi.Text = "";
            dtpNgaysinh.Text = "";
            mtbDienthoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh FROM NhanVien";
            NV = Database.GetDataToDataTable(sql); //lấy dữ liệu
            dgvNhanVien.DataSource = NV;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 200;
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 150;
            dgvNhanVien.Columns[5].Width = 150;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTennhanvien.Text = dgvNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            if (dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nu") chbNu.Checked = true;
            else chbNu.Checked = false;
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienthoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            dtpNgaysinh.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienthoai.Focus();
                return;
            }
            if (dtpNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaysinh.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nu";
            if (chbNu.Checked == true)
                gt = "Nu";
            else
                gt = "Nam";
            sql = "SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Database.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien(MaNhanVien,TenNhanVien,GioiTinh, DiaChi,DienThoai, NgaySinh) VALUES (N'" + txtManhanvien.Text.Trim() + "',N'" + txtTennhanvien.Text.Trim() + "',N'" + gt + "',N'" + txtDiachi.Text.Trim() + "','" + mtbDienthoai.Text + "','" + Database.ConvertDateTime(dtpNgaysinh.Text) + "')";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienthoai.Focus();
                return;
            }
            if (dtpNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaysinh.Focus();
                return;
            }

            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nu";
            if (chbNu.Checked == true)
                gt = "Nu";
            else
                gt = "Nam";
            sql = "UPDATE NhanVien SET  TenNhanVien=N'" + txtTennhanvien.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',DienThoai='" + mtbDienthoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + Database.ConvertDateTime(dtpNgaysinh.Text) +
                    "' WHERE MaNhanVien=N'" + txtManhanvien.Text + "'";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNhanVien=N'" + txtManhanvien.Text + "'";
                Database.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }
    }
}

