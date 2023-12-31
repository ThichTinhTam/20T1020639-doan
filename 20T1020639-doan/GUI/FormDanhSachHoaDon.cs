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
    public partial class FormDanhSachHoaDon : Form
    {
        DataTable HDB;
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
            ResetValues();
            dgvHoaDon.DataSource = null;
            LoadDataGridView();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHDBan.Focus();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDBan.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaNhanVien.Text == "") && (txtMaKhach.Text == "") &&
               (txtTongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HDBan WHERE 1=1";
            if (txtMaHDBan.Text != "")
                sql = sql + " AND MaHDBan Like N'%" + txtMaHDBan.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txtNam.Text;
            if (txtMaNhanVien.Text != "")
                sql = sql + " AND MaNhanVien Like N'%" + txtMaNhanVien.Text + "%'";
            if (txtMaKhach.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtMaKhach.Text + "%'";
            if (txtTongTien.Text != "")
                sql = sql + " AND TongTien <=" + txtTongTien.Text;
            HDB = Database.GetDataToDataTable(sql);
            if (HDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + HDB.Rows.Count + " hóa đơn thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHoaDon.DataSource = HDB;
            ResetValues();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHDBan,MaNhanVien,NgayBan,MaKhach,TongTien FROM HDBan";
            HDB = Database.GetDataToDataTable(sql);

            // Đặt nguồn dữ liệu cho DataGridView trước khi thêm cột hình ảnh
            dgvHoaDon.DataSource = HDB;
            dgvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns[2].HeaderText = "Ngày bán";
            dgvHoaDon.Columns[3].HeaderText = "Mã khách";
            dgvHoaDon.Columns[4].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns[0].Width = 200;
            dgvHoaDon.Columns[1].Width = 200;
            dgvHoaDon.Columns[2].Width = 200;
            dgvHoaDon.Columns[3].Width = 200;
            dgvHoaDon.Columns[4].Width = 200;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataGridView();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void FormDanhSachHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvHoaDon.CurrentRow.Cells["MaHDBan"].Value.ToString();
                FormHienThiHoaDon frm = new FormHienThiHoaDon(tk, dn);
                frm.txtmahoadon.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien(tk, dn);
            nma.ShowDialog();
        }


        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();

        }

        private void btnDSNV_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien(tk, dn);
            nma.ShowDialog();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay nma = new FormDanhSachGiay(tk, dn);
            nma.ShowDialog();
        }

        private void btnLoaiGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormLoaiGiay nma = new FormLoaiGiay(tk, dn);
            nma.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe nma = new FormThongKe(tk, dn);
            nma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachHoaDon nma = new FormDanhSachHoaDon(tk, dn);
            nma.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmin nma = new FormAdmin(tk, dn);
            nma.ShowDialog();
        }
    }
}
