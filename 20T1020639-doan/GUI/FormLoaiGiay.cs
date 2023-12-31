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
    public partial class FormLoaiGiay : Form
    {
        DataTable Loai; // tao bien toan cục

        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormLoaiGiay()
        {
            InitializeComponent();
        }

        public FormLoaiGiay(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormLoaiGiay nma = new FormLoaiGiay(tk, dn);
            nma.ShowDialog();
        }

        private void btnDangXuat_Click_2(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormAdmin nma = new FormAdmin(tk, dn);
            nma.ShowDialog();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay nma = new FormDanhSachGiay(tk, dn);
            nma.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe nma = new FormThongKe();
            nma.ShowDialog();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien(tk, dn);
            nma.ShowDialog();
        }

        private void FormLoaiGiay_Load(object sender, EventArgs e)
        {
            txtMaloai.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();

        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLoai, TenLoai FROM Loai";
            Loai = Database.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvLoai.DataSource = Loai; //Nguồn dữ liệu            
            dgvLoai.Columns[0].HeaderText = "Mã Loại";
            dgvLoai.Columns[1].HeaderText = "Mã Loại";
            dgvLoai.Columns[0].Width = 365;
            dgvLoai.Columns[1].Width = 365;
            dgvLoai.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvLoai.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void ResetValue()
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaloai.Enabled = true; //cho phép nhập mới
            txtMaloai.Focus();
        }

        private void dgvLoai_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }
            if (Loai.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaloai.Text = dgvLoai.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTenloai.Text = dgvLoai.CurrentRow.Cells["TenLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaloai.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenloai.Focus();
                return;
            }
            sql = "Select MaLoai From Loai where MaLoai=N'" + txtMaloai.Text.Trim() + "'";
            if (Database.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaloai.Focus();
                return;
            }

            sql = "INSERT INTO Loai VALUES(N'" +
                txtMaloai.Text + "',N'" + txtTenloai.Text + "')";
            Database.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (Loai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE Loai SET TenLoai=N'" +
                txtTenloai.Text.ToString() +
                "' WHERE MaLoai=N'" + txtMaloai.Text + "'";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (Loai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Loai WHERE MaLoai=N'" + txtMaloai.Text + "'";
                Database.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaloai.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachHoaDon nma = new FormDanhSachHoaDon(tk, dn);
            nma.ShowDialog();
        }
    }
}
