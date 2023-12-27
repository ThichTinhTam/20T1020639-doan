using _20T1020639_doan.DAL;
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
    public partial class FormChiTietSanPham : Form
    {
        private string maGiay;
        public FormChiTietSanPham(string maGiay)
        {
            InitializeComponent();
            this.maGiay = maGiay;
            LoadProductDetails();

        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {

        }

        private void LoadProductDetails()
        {
            DataTable productDetails = Database.GetProductDetails(maGiay);
            if (productDetails.Rows.Count > 0)
            {
                // Hiển thị thông tin chi tiết sản phẩm lên form
                txtmagiay.Text = productDetails.Rows[0]["MaGiay"].ToString();
                txttengiay.Text = productDetails.Rows[0]["TenGiay"].ToString();
                txtmaloai.Text = productDetails.Rows[0]["MaLoai"].ToString();

                txtdongia.Text = productDetails.Rows[0]["DonGiaBan"].ToString();
                txtghichu.Text = productDetails.Rows[0]["GhiChu"].ToString();
                txtAnh.Text = productDetails.Rows[0]["Anh"].ToString();
                picAnh.Image = Image.FromFile(txtAnh.Text);


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttenloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
