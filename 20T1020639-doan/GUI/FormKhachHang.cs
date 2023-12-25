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
using _20T1020639_doan.DTO;

namespace _20T1020639_doan.GUI
{
    public partial class FormKhachHang : Form
    {
        DataTable KH;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public FormKhachHang(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }


        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            new FormBanGiay();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            new FormHoaDon();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            new FormKhachHang();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            new FormNV();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dn.Show();
            Close();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            txtMakhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Khach";
            KH = Database.GetDataToDataTable(sql);  //Lấy dữ liệu từ bảng
            dgvKhachhang.DataSource = KH; //Hiển thị vào dataGridView
            dgvKhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachhang.Columns[1].HeaderText = "Tên khách";
            dgvKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachhang.Columns[0].Width = 100;
            dgvKhachhang.Columns[1].Width = 150;
            dgvKhachhang.Columns[2].Width = 150;
            dgvKhachhang.Columns[3].Width = 150;
            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKhachhang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakhach.Text = dgvKhachhang.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenkhach.Text = dgvKhachhang.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiachi.Text = dgvKhachhang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienThoai.Text = dgvKhachhang.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhach.Enabled = true;
            txtMakhach.Focus();
        }
        private void ResetValues()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            mtbDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKhach FROM Khach WHERE MaKhach=N'" + txtMakhach.Text.Trim() + "'";
            if (Database.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO Khach VALUES (N'" + txtMakhach.Text.Trim() +
                "',N'" + txtTenkhach.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mtbDienThoai.Text + "')";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            sql = "UPDATE Khach SET TenKhach=N'" + txtTenkhach.Text.Trim().ToString() + "',DiaChi=N'" +
                txtDiachi.Text.Trim().ToString() + "',DienThoai='" + mtbDienThoai.Text.ToString() +
                "' WHERE MaKhach=N'" + txtMakhach.Text + "'";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Khach WHERE MaKhach=N'" + txtMakhach.Text + "'";
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
            txtMakhach.Enabled = false;
        }
    }
}
