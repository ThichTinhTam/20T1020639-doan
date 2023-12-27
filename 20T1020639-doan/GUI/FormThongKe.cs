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
    public partial class FormThongKe : Form
    {
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        private DataTable ThongKeData;
        public FormThongKe()
        {
            InitializeComponent();
        }

        public FormThongKe(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }



        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachGiay nma = new FormDanhSachGiay();
            nma.ShowDialog();
        }



        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormThongKe nma = new FormThongKe();
            nma.ShowDialog();
        }

        private void btnDSNV_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormDanhSachNhanVien nma = new FormDanhSachNhanVien();
            nma.ShowDialog();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }
        private void ThucHienThongKe()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;

            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $"SELECT\r\n    " +
                $"SUM(cthd.SoLuong) AS TongSoLuongSanPhamBanRa,\r\n    " +
                $"SUM(hd.TongTien) AS TongDoanhThuTrongNgay,\r\n    " +
                $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongNgay\r\n" +
                $"FROM\r\n    " +
                $"ChiTietHDBan cthd\r\nJOIN\r\n    " +
                $"HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\n" +
                $"WHERE\r\n    " +
                $"CONVERT(DATE, hd.NgayBan) = " +
                $"'{ngayThongKe:yyyy-MM-dd}'";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongSanPhamBanRa"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongNgay"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongNgay"].Width = 300;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThucHienThongKeThang();
        }
        private void ThucHienThongKeThang()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;
            int thang = ngayThongKe.Month;
            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $"SELECT\r\n    " +
                $"SUM(cthd.SoLuong) AS TongSoLuongTrongThang,\r\n    " +
                $"SUM(hd.TongTien) AS TongDoanhThuTrongThang,\r\n" +
                $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongThang\r\n" +
                $"FROM\r\n    " +
                $"ChiTietHDBan cthd\r\n" +
                $"JOIN\r\n   " +
                $" HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\n" +
                $"WHERE\r\n    " +
                $"MONTH(hd.NgayBan) = " +
                $"'{thang}'";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongTrongThang"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongThang"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongThang"].Width = 300;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThucHienThongKeNam();
        }
        private void ThucHienThongKeNam()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;
            int nam = ngayThongKe.Year;

            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $"SELECT\r\n    " +
              $"SUM(cthd.SoLuong) AS TongSoLuongTrongNam,\r\n    " +
              $"SUM(hd.TongTien) AS TongDoanhThuTrongNam,\r\n" +
              $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongNam\r\nFROM\r\n    " +
              $"ChiTietHDBan cthd\r\nJOIN\r\n   " +
              $" HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\n" +
              $"WHERE\r\n    " +
              $"YEAR(hd.NgayBan) = " +
              $"'{nam}'";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongTrongNam"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongNam"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongNam"].Width = 300;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThucHienThongKeThangTruoc();
        }
        private void ThucHienThongKeThangTruoc()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;
            int nam = ngayThongKe.Year;

            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $"SELECT\r\n    " +
                $"SUM(cthd.SoLuong) AS TongSoLuongTrongThangTruoc,\r\n    " +
                $"SUM(hd.TongTien) AS TongDoanhThuTrongThangTruoc,\r\n" +
                $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongThangTruoc\r\nFROM\r\n    " +
                $"ChiTietHDBan cthd\r\nJOIN\r\n    " +
                $"HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\nWHERE\r\n    " +
                $"MONTH(hd.NgayBan) = MONTH(DATEADD(MONTH, -1, GETDATE()))\r\n    " +
                $"AND YEAR(hd.NgayBan) = YEAR(DATEADD(MONTH, -1, GETDATE()));";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongTrongThangTruoc"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongThangTruoc"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongThangTruoc"].Width = 300;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThucHienThongKeNamTruoc();
        }
        private void ThucHienThongKeNamTruoc()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;
            int nam = ngayThongKe.Year;

            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $"SELECT\r\n    " +
                $"SUM(cthd.SoLuong) AS TongSoLuongSanPhamBanRa,\r\n    " +
                $"SUM(hd.TongTien) AS TongDoanhThuTrongNamTruoc,\r\n" +
                $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongNamTruoc\r\n" +
                $"FROM\r\n    " +
                $" ChiTietHDBan cthd\r\nJOIN\r\n    " +
                $"HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\n" +
                $"WHERE\r\n " +
                $"YEAR(hd.NgayBan) = YEAR(DATEADD(YEAR, -1, GETDATE()));";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongSanPhamBanRa"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongNamTruoc"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongNamTruoc"].Width = 300;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThucHienThongKeHomQua();
        }
        private void ThucHienThongKeHomQua()
        {
            // Lấy ngày cần thống kê từ DateTimePicker
            DateTimePicker dateTimePickerNgayThongKe = new DateTimePicker();
            DateTime ngayThongKe = dateTimePickerNgayThongKe.Value;
            int nam = ngayThongKe.Year;

            // Thực hiện truy vấn dữ liệu từ CSDL dựa trên ngày thống kê
            string sql = $" SELECT\r\n    " +
                $"SUM(cthd.SoLuong) AS TongSoLuongTrongHomQua,\r\n    " +
                $"SUM(hd.TongTien) AS TongDoanhThuTrongHomQua,\r\n" +
                $"COUNT(DISTINCT hd.MaHDBan) AS SoLuongHoaDonTrongHomQua\r\n" +
                $"FROM\r\n    " +
                $"ChiTietHDBan cthd\r\nJOIN\r\n    " +
                $"HDBan hd ON cthd.MaHDBan = hd.MaHDBan\r\n" +
                $"WHERE\r\n    " +
                $"CONVERT(DATE, hd.NgayBan) = CONVERT(DATE, GETDATE() - 1);";
            ThongKeData = Database.GetDataToDataTable(sql);

            // Hiển thị kết quả thống kê lên DataGridView
            dgvThongke.DataSource = ThongKeData;
            dgvThongke.Columns["TongSoLuongTrongHomQua"].Width = 300;
            dgvThongke.Columns["TongDoanhThuTrongHomQua"].Width = 300;
            dgvThongke.Columns["SoLuongHoaDonTrongHomQua"].Width = 300;
        }
    }
}
