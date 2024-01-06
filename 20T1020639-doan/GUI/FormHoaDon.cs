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
using System.Reflection.Metadata;
using Word = Microsoft.Office.Interop.Word;


namespace _20T1020639_doan.GUI
{
    public partial class FormHoaDon : Form
    {
        DataTable HoaDon;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        private String maHDBan;
        private string Magiay;
        public FormHoaDon(String MaGiay)
        {

            InitializeComponent();
            this.Magiay = MaGiay;

            // this.magiay = magiay;
            //cboMaGiay.SelectedValue = magiay;
        }
        public FormHoaDon(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.dn = dn;
            this.tk = tk;
            InitializeComponent();
            //  LoadDataToListView();
        }
        private void LoadProductDetails()
        {
            DataTable productDetails = Database.GetProductDetails(Magiay);
            if (productDetails.Rows.Count > 0)
            {
                // Hiển thị thông tin chi tiết sản phẩm lên form
                cboMaGiay.Text = productDetails.Rows[0]["MaGiay"].ToString();
                txttengiay.Text = productDetails.Rows[0]["TenGiay"].ToString();
                txtDonGiaBan.Text = productDetails.Rows[0]["DonGiaBan"].ToString();
            }
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenKhachhang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienThoai.ReadOnly = true;
            txttengiay.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtgiamgia.Text = "0";
            txtTongtien.Text = "0";
            Database.FillCombo("SELECT MaKhach, TenKhach FROM Khach", cboMaKhachHang, "MaKhach", "MaKhach");
            cboMaKhachHang.SelectedIndex = -1;
            Database.FillCombo("SELECT MaNhanVien, TenNhanVien FROM NhanVien", cboMaNhanVien, "MaNhanVien", "MaNhanVien");
            cboMaNhanVien.Text = tk.Username;
            // cboMaNhanVien.SelectedIndex = -1;
            Database.FillCombo("SELECT MaGiay, TenGiay FROM Giay", cboMaGiay, "MaGiay", "MaGiay");
            cboMaGiay.SelectedIndex = -1;
            LoadProductDetails();
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahoadon.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            LoadDataGridView();

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
        private void ResetValuesHang()
        {
            cboMaGiay.Text = "";
            txtSoLuong.Text = "";
            txtgiamgia.Text = "0";
            txtThanhtien.Text = "0";
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
            FormKhachHang nma = new FormKhachHang(tk, dn);
            nma.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV nma = new FormNV(tk, dn);
            nma.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();
            dn.Show();
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnIn.Enabled = false;
            ResetValues();
            txtmahoadon.Text = Database.CreateKey("TNV");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtmahoadon.Text = "";
            dtpngayban.Text = DateTime.Now.ToShortDateString();
            cboMaNhanVien.Text = "";
            cboMaKhachHang.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            //   cboMaGiay.Text = "";
            txtSoLuong.Text = "";
            txtgiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM HDBan WHERE MaHDBan=N'" + txtmahoadon.Text + "'";
            if (!Database.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpngayban.Focus();
                    return;
                }
                if (cboMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNhanVien.Focus();
                    return;
                }
                if (cboMaKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKhachHang.Focus();
                    return;
                }
                sql = "INSERT INTO HDBan(MaHDBan, NgayBan, MaNhanVien, MaKhach, TongTien) VALUES (N'" + txtmahoadon.Text.Trim() + "','" +
                        Database.ConvertDateTime(dtpngayban.Text.Trim()) + "',N'" + cboMaNhanVien.SelectedValue + "',N'" +
                        cboMaKhachHang.SelectedValue + "'," + txtTongtien.Text + ")";
                Database.RunSQL(sql);
            }
            // Lưu thông tin của các mặt giày
            if (cboMaGiay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaGiay.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            if (txtgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiamgia.Focus();
                return;
            }
            sql = "SELECT MaGiay FROM ChiTietHDBan WHERE MaGiay=N'" + cboMaGiay.SelectedValue + "' AND MaHDBan = N'" + txtmahoadon.Text.Trim() + "'";
            if (Database.CheckKey(sql))
            {
                MessageBox.Show("Mã giày này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaGiay.Focus();
                return;
            }
            // Kiểm tra xem số lượng giày trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Database.GetFieldValues("SELECT SoLuong FROM Giay WHERE MaGiay = N'" + cboMaGiay.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng giày này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHDBan(MaHDBan,MaGiay,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txtmahoadon.Text.Trim() + "',N'" + cboMaGiay.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGiaBan.Text + "," + txtgiamgia.Text + "," + txtThanhtien.Text + ")";
            Database.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt giày vào bảng Giay
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE Giay SET SoLuong =" + SLcon + " WHERE MaGiay= N'" + cboMaGiay.SelectedValue + "'";
            Database.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Database.GetFieldValues("SELECT TongTien FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE HDBan SET TongTien =" + Tongmoi + " WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            Database.RunSQL(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Database.ChuyenSoSangChu(Double.Parse(Tongmoi.ToString()));
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
        }

        private void cboMaNhanVien_TextChanged(object sender, EventArgs e)
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

        private void cboMaGiay_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaGiay.Text == "")
            {
                txttengiay.Text = "";
                txtDonGiaBan.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenGiay FROM Giay WHERE MaGiay =N'" + cboMaGiay.SelectedValue + "'";
            txttengiay.Text = Database.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM Giay WHERE MaGiay =N'" + cboMaGiay.SelectedValue + "'";
            txtDonGiaBan.Text = Database.GetFieldValues(str);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHDBan.Focus();
                return;
            }
            txtmahoadon.Text = cboMaHDBan.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cboMaHDBan.SelectedIndex = -1;
        }

        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }

        private void dgvHoadon_DoubleClick(object sender, EventArgs e)
        {
            string MaGiayxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (HoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaGiayxoa = dgvHoadon.CurrentRow.Cells["MaGiay"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHoadon.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHoadon.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE ChiTietHDBan WHERE MaHDBan=N'" + txtmahoadon.Text + "' AND MaGiay = N'" + MaGiayxoa + "'";
                Database.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Database.GetFieldValues("SELECT SoLuong FROM Giay WHERE MaGiay = N'" + MaGiayxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE Giay SET SoLuong =" + slcon + " WHERE MaGiay= N'" + MaGiayxoa + "'";
                Database.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Database.GetFieldValues("SELECT TongTien FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HDBan SET TongTien =" + tongmoi + " WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
                Database.RunSQL(sql);
                txtTongtien.Text = tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + Database.ChuyenSoSangChu(Double.Parse(tongmoi.ToString()));
                LoadDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaGiay,SoLuong FROM ChiTietHDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
                DataTable Giay = Database.GetDataToDataTable(sql);
                for (int giay = 0; giay <= Giay.Rows.Count - 1; giay++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Database.GetFieldValues("SELECT SoLuong FROM Giay WHERE MaGiay = N'" + Giay.Rows[giay][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(Giay.Rows[giay][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Giay SET SoLuong =" + slcon + " WHERE MaGiay= N'" + Giay.Rows[giay][0].ToString() + "'";
                    Database.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE ChiTietHDBan WHERE MaHDBan=N'" + txtmahoadon.Text + "'";
                Database.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE HDBan WHERE MaHDBan=N'" + txtmahoadon.Text + "'";
                Database.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void cboMaHDBan_DropDown(object sender, EventArgs e)
        {
            Database.FillCombo("SELECT MaHDBan FROM HDBan", cboMaHDBan, "MaHDBan", "MaHDBan");
            cboMaHDBan.SelectedIndex = -1;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            // Thêm dữ liệu từ hóa đơn vào văn bản Word
            doc.Content.Text += "Hóa Đơn Bán Giày\n\n";
            doc.Content.Text += "Mã Hóa Đơn: " + txtmahoadon.Text + "\n";
            doc.Content.Text += "Ngày Bán: " + dtpngayban.Text + "\n";
            doc.Content.Text += "Khách Hàng: " + txttenKhachhang.Text + "\n";
            doc.Content.Text += "Nhân Viên: " + txttennhanvien.Text + "\n";

            // Thêm chi tiết hóa đơn từ DataGridView
            doc.Content.Text += "\nChi Tiết Hóa Đơn:\n";
            foreach (DataGridViewRow row in dgvHoadon.Rows)
            {
                doc.Content.Text += row.Cells["MaGiay"].Value + "\t" +
                                    row.Cells["SoLuong"].Value + "\t" +
                                    row.Cells["DonGiaBan"].Value + "\t" +
                                    row.Cells["GiamGia"].Value + "\t" +
                                    row.Cells["ThanhTien"].Value + "\n";
            }

            // Lưu văn bản Word ra file
            string filePath = "C:\\filein\\" + txtmahoadon.Text + ".docx";
            doc.SaveAs2(filePath);

            // Đóng ứng dụng Word
            wordApp.Quit();

            MessageBox.Show("Đã in hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongTinNhanVien mna = new FormThongTinNhanVien(tk, dn);
            mna.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDataToListView()
        {


        }

    }
}


