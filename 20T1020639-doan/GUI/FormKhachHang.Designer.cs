namespace _20T1020639_doan.GUI
{
    partial class FormKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBoqua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSKH = new Button();
            btnKhoGiay = new Button();
            btnHoaDon = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMakhach = new TextBox();
            txtTenkhach = new TextBox();
            txtDiachi = new TextBox();
            mtbDienThoai = new MaskedTextBox();
            dgvKhachhang = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).BeginInit();
            SuspendLayout();
            // 
            // btnBoqua
            // 
            btnBoqua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnBoqua.ForeColor = SystemColors.ActiveCaption;
            btnBoqua.Image = Properties.Resources.Button_Next_icon;
            btnBoqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoqua.Location = new Point(901, 566);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(148, 48);
            btnBoqua.TabIndex = 52;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            btnBoqua.Click += btnBoqua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaption;
            btnLuu.Image = Properties.Resources.save_32_32;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(772, 566);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 48);
            btnLuu.TabIndex = 51;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaption;
            btnXoa.Image = Properties.Resources.Button_Close;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(624, 566);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(126, 48);
            btnXoa.TabIndex = 50;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ActiveCaption;
            btnSua.Image = Properties.Resources.fix_1_32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(477, 566);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 48);
            btnSua.TabIndex = 49;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaption;
            btnThem.Image = Properties.Resources.Button_Add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(322, 566);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 48);
            btnThem.TabIndex = 48;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_645;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(-3, 374);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(320, 94);
            btnTrangChu.TabIndex = 46;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(43, 471);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 45;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_646;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-9, 537);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(326, 100);
            btnDangXuat.TabIndex = 44;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = Color.LightCoral;
            btnDSKH.Image = Properties.Resources.user_149_646;
            btnDSKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSKH.Location = new Point(-9, 190);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(326, 94);
            btnDSKH.TabIndex = 43;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_647;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(-9, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(326, 96);
            btnKhoGiay.TabIndex = 41;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCoral;
            btnHoaDon.Image = Properties.Resources.bill_5_641;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(-9, 92);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(326, 97);
            btnHoaDon.TabIndex = 42;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(509, 9);
            label2.Name = "label2";
            label2.Size = new Size(425, 40);
            label2.TabIndex = 53;
            label2.Text = "Danh Sách Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(352, 69);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 54;
            label3.Text = "Mã khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(352, 132);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 55;
            label4.Text = "Tên khách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(736, 69);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 56;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(736, 132);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 57;
            label6.Text = "Điện thoại";
            // 
            // txtMakhach
            // 
            txtMakhach.Location = new Point(447, 69);
            txtMakhach.Name = "txtMakhach";
            txtMakhach.Size = new Size(169, 31);
            txtMakhach.TabIndex = 58;
            // 
            // txtTenkhach
            // 
            txtTenkhach.Location = new Point(447, 129);
            txtTenkhach.Name = "txtTenkhach";
            txtTenkhach.Size = new Size(169, 31);
            txtTenkhach.TabIndex = 59;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(836, 69);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(193, 31);
            txtDiachi.TabIndex = 60;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(836, 129);
            mtbDienThoai.Mask = "(034) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(193, 31);
            mtbDienThoai.TabIndex = 61;
            // 
            // dgvKhachhang
            // 
            dgvKhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachhang.Location = new Point(323, 198);
            dgvKhachhang.Name = "dgvKhachhang";
            dgvKhachhang.RowHeadersWidth = 62;
            dgvKhachhang.RowTemplate.Height = 33;
            dgvKhachhang.Size = new Size(727, 336);
            dgvKhachhang.TabIndex = 62;
            dgvKhachhang.Click += dgvKhachhang_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.information_19_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 283);
            button1.Name = "button1";
            button1.Size = new Size(320, 92);
            button1.TabIndex = 63;
            button1.Text = "Thông Tin Nhân Viên";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1055, 637);
            Controls.Add(button1);
            Controls.Add(dgvKhachhang);
            Controls.Add(mtbDienThoai);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenkhach);
            Controls.Add(txtMakhach);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormKhachHang";
            Text = "Quản lý khách hàng";
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBoqua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSKH;
        private Button btnKhoGiay;
        private Button btnHoaDon;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMakhach;
        private TextBox txtTenkhach;
        private TextBox txtDiachi;
        private MaskedTextBox mtbDienThoai;
        private DataGridView dgvKhachhang;
        private Button button1;
    }
}