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
    public partial class FormBanGiay : Form
    {
        DataTable ShopGiay;
        private dtoTaiKhoan tk;
        private FormDangNhap dn;
        public FormBanGiay()
        {
            InitializeComponent();
        }

        public FormBanGiay(dtoTaiKhoan tk, FormDangNhap dn)
        {
            this.tk = tk;
            this.dn = dn;
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Giay";
            ShopGiay = Database.GetDataToDataTable(sql);

            // Đặt nguồn dữ liệu cho DataGridView trước khi thêm cột hình ảnh
            dgvGiay.DataSource = ShopGiay;

            // Thêm cột hình ảnh vào DataGridView
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Anh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Để hiển thị hình ảnh đầy đủ trong ô
            dgvGiay.Columns.Add(imageColumn);

            foreach (DataRow row in ShopGiay.Rows)
            {
                string imagePath = row["Anh"].ToString(); // Giả sử cột ảnh có tên là "Anh"
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Load hình ảnh từ đường dẫn
                    Image image = Image.FromFile(imagePath);

                    // Thêm hình ảnh vào cột hình ảnh của dòng tương ứng
                    int rowIndex = dgvGiay.Rows.Add(row.ItemArray);
                    dgvGiay.Rows[rowIndex].Cells["Anh"].Value = image;
                }
            }

            // Tiếp tục thiết lập các thuộc tính khác cho DataGridView
            dgvGiay.Columns[0].HeaderText = "Mã giày";
            dgvGiay.Columns[1].HeaderText = "Tên giày";
            dgvGiay.Columns[2].HeaderText = "Loại";
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

        private void FormBanGiay_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon nma = new FormHoaDon();
            nma.ShowDialog();
        }

        private void btnKhoGiay_Click(object sender, EventArgs e)
        {
            Hide();
            FormBanGiay nma = new FormBanGiay();
            nma.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDon nma = new FormHoaDon();
            nma.ShowDialog();
        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            Hide();
            FormKhachHang nma = new FormKhachHang();
            nma.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Hide();
            FormNV nma = new FormNV();
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
