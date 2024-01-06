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
    public partial class FormLichSuBanHang : Form
    {
        DataTable LSBH;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;

        public FormLichSuBanHang()
        {
            InitializeComponent();
        }

        public FormLichSuBanHang(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormLichSuBanHang mna = new FormLichSuBanHang(tk, dn);
            mna.ShowDialog();
        }

        private void FormLichSuBanHang_Load(object sender, EventArgs e)
        {
            string str;
            str = "SELECT TenNhanVien FROM NhanVien WHERE MaNhanVien = N'" + tk.Username + "'";
            textBox1.Text = Database.GetFieldValues(str);
            LoadDataGridView();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormBanGiay mna = new FormBanGiay(tk, dn);
            mna.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon mna = new FormHoaDon(tk, dn);
            mna.ShowDialog();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            Hide();
            FormKhachHang mna = new FormKhachHang(tk, dn);
            mna.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongTinNhanVien mna = new FormThongTinNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV mna = new FormNV(tk, dn);
            mna.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHDBan,MaNhanVien,NgayBan,MaKhach,TongTien FROM HDBan WHERE MaNhanVien = N'" + tk.Username + "'";
            LSBH = Database.GetDataToDataTable(sql);

            // Đặt nguồn dữ liệu cho DataGridView trước khi thêm cột hình ảnh
            dgvHoaDon.DataSource = LSBH;
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

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            if (LSBH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHDBan.Text = dgvHoaDon.CurrentRow.Cells["MaHDBan"].Value.ToString();
            txtMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtMaKhach.Text = dgvHoaDon.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtThang.Text = dgvHoaDon.CurrentRow.Cells["NgayBan"].Value.ToString();
            txtTongTien.Text = dgvHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();
        }
    }
}
