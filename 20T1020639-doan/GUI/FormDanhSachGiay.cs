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
    public partial class FormDanhSachGiay : Form
    {
        DataTable DSGiay;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormDanhSachGiay()
        {
            InitializeComponent();
        }

        public FormDanhSachGiay(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }



        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay nma = new FormDanhSachGiay(tk,dn);
            nma.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin nma = new FormAdmin(tk,dn);
            nma.ShowDialog();

        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien(tk, dn);
            nma.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe nma = new FormThongKe();
            nma.ShowDialog();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



        private void btnLoaiGiay_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormLoaiGiay nma = new FormLoaiGiay(tk, dn);
            nma.ShowDialog();
        }

        

        private void FormDanhSachGiay_Load_1(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from Loai";
            txtMagiay.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            Database.FillCombo(sql, cboMaLoai, "MaLoai", "TenLoai");
            cboMaLoai.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMagiay.Text = "";
            txtTengiay.Text = "";
            cboMaLoai.Text = "";
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhichu.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Giay";
            DSGiay = Database.GetDataToDataTable(sql);
            dgvGiay.DataSource = DSGiay;
            dgvGiay.Columns[0].HeaderText = "Mã giày";
            dgvGiay.Columns[1].HeaderText = "Tên giày";
            dgvGiay.Columns[2].HeaderText = "loại";
            dgvGiay.Columns[3].HeaderText = "Số lượng";
            dgvGiay.Columns[4].HeaderText = "Đơn giá nhập";
            dgvGiay.Columns[5].HeaderText = "Đơn giá bán";
            dgvGiay.Columns[6].HeaderText = "Ảnh";
            dgvGiay.Columns[7].HeaderText = "Ghi chú";
            dgvGiay.Columns[0].Width = 100;
            dgvGiay.Columns[1].Width = 200;
            dgvGiay.Columns[2].Width = 100;
            dgvGiay.Columns[3].Width = 100;
            dgvGiay.Columns[4].Width = 200;
            dgvGiay.Columns[5].Width = 200;
            dgvGiay.Columns[6].Width = 200;
            dgvGiay.Columns[7].Width = 200;
            dgvGiay.AllowUserToAddRows = false;
            dgvGiay.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvGiay_Click(object sender, EventArgs e)
        {
            string MaLoai;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiay.Focus();
                return;
            }
            if (DSGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMagiay.Text = dgvGiay.CurrentRow.Cells["MaGiay"].Value.ToString();
            txtTengiay.Text = dgvGiay.CurrentRow.Cells["TenGiay"].Value.ToString();
            MaLoai = dgvGiay.CurrentRow.Cells["MaLoai"].Value.ToString();
            sql = "SELECT TenLoai FROM Loai WHERE MaLoai=N'" + MaLoai + "'";
            cboMaLoai.Text = Database.GetFieldValues(sql);
            txtSoluong.Text = dgvGiay.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDongianhap.Text = dgvGiay.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDongiaban.Text = dgvGiay.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Anh FROM Giay WHERE MaGiay=N'" + txtMagiay.Text + "'";
            txtAnh.Text = Database.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT GhiChu FROM Giay WHERE MaGiay = N'" + txtMagiay.Text + "'";
            txtGhichu.Text = Database.GetFieldValues(sql);
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
            txtMagiay.Enabled = true;
            txtMagiay.Focus();
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMagiay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiay.Focus();
                return;
            }
            if (txtTengiay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTengiay.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT MaGiay FROM Giay WHERE MaGiay=N'" + txtMagiay.Text.Trim() + "'";
            if (Database.CheckKey(sql))
            {
                MessageBox.Show("Mã giày này đã tồn tại, bạn phải chọn mã giày khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiay.Focus();
                return;
            }
            sql = "INSERT INTO Giay(MaGiay,TenGiay,MaLoai,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu) VALUES(N'"
                + txtMagiay.Text.Trim() + "',N'" + txtTengiay.Text.Trim() +
                "',N'" + cboMaLoai.SelectedValue.ToString() +
                "'," + txtSoluong.Text.Trim() + "," + txtDongianhap.Text +
                "," + txtDongiaban.Text + ",'" + txtAnh.Text + "',N'" + txtGhichu.Text.Trim() + "')";

            Database.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMagiay.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMagiay.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (DSGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMagiay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiay.Focus();
                return;
            }
            if (txtTengiay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTengiay.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE Giay SET TenGiay=N'" + txtTengiay.Text.Trim().ToString() +
                "',MaLoai=N'" + cboMaLoai.SelectedValue.ToString() +
                "',SoLuong=" + txtSoluong.Text +
                ",Anh='" + txtAnh.Text + "',GhiChu=N'" + txtGhichu.Text + "' WHERE MaGiay=N'" + txtMagiay.Text + "'";
            Database.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DSGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMagiay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Giay WHERE MaGiay=N'" + txtMagiay.Text + "'";
                Database.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMagiay.Text == "") && (txtTengiay.Text == "") && (cboMaLoai.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from Giay WHERE 1=1";
            if (txtMagiay.Text != "")
                sql += " AND MaGiay LIKE N'%" + txtMagiay.Text + "%'";
            if (txtTengiay.Text != "")
                sql += " AND TenGiay LIKE N'%" + txtTengiay.Text + "%'";
            if (cboMaLoai.Text != "")
                sql += " AND MaLoai LIKE N'%" + cboMaLoai.SelectedValue + "%'";
            DSGiay = Database.GetDataToDataTable(sql);
            if (DSGiay.Rows.Count == 0)
                MessageBox.Show("Không có sản phẩm thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + DSGiay.Rows.Count + " sản phẩm thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvGiay.DataSource = DSGiay;
            ResetValues();
        }

        private void btnHTDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaGiay,TenGiay,MaLoai,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu FROM giay";
            DSGiay = Database.GetDataToDataTable(sql);
            dgvGiay.DataSource = DSGiay;
        }
    }
}
