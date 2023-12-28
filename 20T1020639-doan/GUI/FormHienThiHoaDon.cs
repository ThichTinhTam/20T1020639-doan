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
    public partial class FormHienThiHoaDon : Form
    {
        DataTable HoaDon;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormHienThiHoaDon()
        {
            InitializeComponent();
        }
        public FormHienThiHoaDon(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
        }


        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaGiay, b.TenGiay, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM ChiTietHDBan AS a, Giay AS b WHERE a.MaHDBan = N'" + txtmahoadon.Text + "' AND a.MaGiay=b.MaGiay";
            HoaDon = Database.GetDataToDataTable(sql);
            dgvHoadon.DataSource = HoaDon;
            dgvHoadon.Columns[0].HeaderText = "Mã giày";
            dgvHoadon.Columns[1].HeaderText = "Tên giày";
            dgvHoadon.Columns[2].HeaderText = "Số lượng";
            dgvHoadon.Columns[3].HeaderText = "Đơn giá";
            dgvHoadon.Columns[4].HeaderText = "Giảm giá %";
            dgvHoadon.Columns[5].HeaderText = "Thành tiền";
            dgvHoadon.Columns[0].Width = 200;
            dgvHoadon.Columns[1].Width = 200;
            dgvHoadon.Columns[2].Width = 200;
            dgvHoadon.Columns[3].Width = 200;
            dgvHoadon.Columns[4].Width = 200;
            dgvHoadon.Columns[5].Width = 200;
            dgvHoadon.AllowUserToAddRows = false;
            dgvHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            dtpngayban.Text = Database.ConvertDateTime(Database.GetFieldValues(str));
            str = "SELECT MaNhanVien FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            cboMaNhanVien.Text = Database.GetFieldValues(str);
            str = "SELECT MaKhach FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            cboMaKhachHang.Text = Database.GetFieldValues(str);
            str = "SELECT TongTien FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            txtTongtien.Text = Database.GetFieldValues(str);
            lblBangchu.Text = "Bằng chữ: " + Database.ChuyenSoSangChu(Double.Parse(txtTongtien.Text));

        }




        private void ResetValues()
        {
            txtmahoadon.Text = "";
            dtpngayban.Text = DateTime.Now.ToShortDateString();
            cboMaNhanVien.Text = "";
            cboMaKhachHang.Text = "";
        }

        private void FormHienThiHoaDon_Load_1(object sender, EventArgs e)
        {
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenKhachhang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienThoai.ReadOnly = true;
            Database.FillCombo("SELECT MaKhach, TenKhach FROM Khach", cboMaKhachHang, "MaKhach", "MaKhach");
            cboMaKhachHang.SelectedIndex = -1;
            Database.FillCombo("SELECT MaNhanVien, TenNhanVien FROM NhanVien", cboMaNhanVien, "MaNhanVien", "MaNhanVien");
            cboMaNhanVien.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahoadon.Text != "")
            {
                LoadInfoHoaDon();
            }
            LoadDataGridView();
        }

        private void cboMaNhanVien_TextChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cboMaNhanVien.Text == "")
                txttennhanvien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNhanVien from NhanVien where MaNhanVien =N'" + cboMaNhanVien.SelectedValue + "'";
            txttennhanvien.Text = Database.GetFieldValues(str);
        }



        private void cboMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMaKhachHang_TextChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cboMaKhachHang.Text == "")
            {
                txttenKhachhang.Text = "";
                txtDiachi.Text = "";
                mskDienThoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKhach from Khach where MaKhach = N'" + cboMaKhachHang.SelectedValue + "'";
            txttenKhachhang.Text = Database.GetFieldValues(str);
            str = "Select DiaChi from Khach where MaKhach = N'" + cboMaKhachHang.SelectedValue + "'";
            txtDiachi.Text = Database.GetFieldValues(str);
            str = "Select DienThoai from Khach where MaKhach= N'" + cboMaKhachHang.SelectedValue + "'";
            mskDienThoai.Text = Database.GetFieldValues(str);
        }
    }

}