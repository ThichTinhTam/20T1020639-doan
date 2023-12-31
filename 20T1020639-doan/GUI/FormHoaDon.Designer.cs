namespace _20T1020639_doan.GUI
{
    partial class FormHoaDon
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
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSKH = new Button();
            btnHoaDon = new Button();
            btnKhoGiay = new Button();
            groupBox1 = new GroupBox();
            dtpngayban = new DateTimePicker();
            mskDienThoai = new MaskedTextBox();
            txtDiachi = new TextBox();
            txttenKhachhang = new TextBox();
            txttennhanvien = new TextBox();
            txtmahoadon = new TextBox();
            cboMaKhachHang = new ComboBox();
            cboMaNhanVien = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtTongtien = new TextBox();
            label19 = new Label();
            lblBangchu = new Label();
            txtThanhtien = new TextBox();
            txtDonGiaBan = new TextBox();
            txtgiamgia = new TextBox();
            txttengiay = new TextBox();
            txtSoLuong = new TextBox();
            cboMaGiay = new ComboBox();
            label17 = new Label();
            dgvHoadon = new DataGridView();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label2 = new Label();
            label18 = new Label();
            cboMaHDBan = new ComboBox();
            btnTimkiem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoadon).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaption;
            btnLuu.Location = new Point(652, 411);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(155, 34);
            btnLuu.TabIndex = 62;
            btnLuu.Text = "&Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaption;
            btnXoa.Location = new Point(457, 411);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 34);
            btnXoa.TabIndex = 61;
            btnXoa.Text = "&Xóa hóa đơn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaption;
            btnThem.ImageAlign = ContentAlignment.TopLeft;
            btnThem.Location = new Point(256, 411);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 34);
            btnThem.TabIndex = 59;
            btnThem.Text = "&Thêm hóa đơn";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(12, 406);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(239, 121);
            btnTrangChu.TabIndex = 58;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 543);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 57;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(12, 629);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(239, 118);
            btnDangXuat.TabIndex = 56;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = SystemColors.ActiveCaption;
            btnDSKH.Location = new Point(12, 268);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(239, 132);
            btnDSKH.TabIndex = 55;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = SystemColors.ActiveCaption;
            btnHoaDon.Location = new Point(12, 140);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(239, 122);
            btnHoaDon.TabIndex = 54;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(12, 12);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(239, 122);
            btnKhoGiay.TabIndex = 53;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpngayban);
            groupBox1.Controls.Add(mskDienThoai);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txttenKhachhang);
            groupBox1.Controls.Add(txttennhanvien);
            groupBox1.Controls.Add(txtmahoadon);
            groupBox1.Controls.Add(cboMaKhachHang);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(263, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 196);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // dtpngayban
            // 
            dtpngayban.Format = DateTimePickerFormat.Short;
            dtpngayban.Location = new Point(173, 65);
            dtpngayban.Name = "dtpngayban";
            dtpngayban.Size = new Size(300, 31);
            dtpngayban.TabIndex = 15;
            // 
            // mskDienThoai
            // 
            mskDienThoai.Location = new Point(786, 157);
            mskDienThoai.Mask = "(098) 000-0000";
            mskDienThoai.Name = "mskDienThoai";
            mskDienThoai.ReadOnly = true;
            mskDienThoai.Size = new Size(253, 31);
            mskDienThoai.TabIndex = 14;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(786, 113);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.ReadOnly = true;
            txtDiachi.Size = new Size(253, 31);
            txtDiachi.TabIndex = 13;
            // 
            // txttenKhachhang
            // 
            txttenKhachhang.Location = new Point(786, 65);
            txttenKhachhang.Name = "txttenKhachhang";
            txttenKhachhang.ReadOnly = true;
            txttenKhachhang.Size = new Size(253, 31);
            txttenKhachhang.TabIndex = 12;
            // 
            // txttennhanvien
            // 
            txttennhanvien.Location = new Point(173, 150);
            txttennhanvien.Name = "txttennhanvien";
            txttennhanvien.ReadOnly = true;
            txttennhanvien.Size = new Size(300, 31);
            txttennhanvien.TabIndex = 11;
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(173, 27);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.ReadOnly = true;
            txtmahoadon.Size = new Size(300, 31);
            txtmahoadon.TabIndex = 10;
            // 
            // cboMaKhachHang
            // 
            cboMaKhachHang.FormattingEnabled = true;
            cboMaKhachHang.Location = new Point(786, 24);
            cboMaKhachHang.Name = "cboMaKhachHang";
            cboMaKhachHang.Size = new Size(253, 33);
            cboMaKhachHang.TabIndex = 9;
            cboMaKhachHang.TextChanged += cboMaKhachHang_TextChanged;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(173, 111);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(300, 33);
            cboMaNhanVien.TabIndex = 8;
            cboMaNhanVien.TextChanged += cboMaNhanVien_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(634, 154);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 7;
            label10.Text = "Điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(633, 111);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 6;
            label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(633, 65);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 5;
            label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(634, 27);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 4;
            label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(38, 154);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 3;
            label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(38, 111);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(38, 65);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Ngày bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(38, 27);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongtien);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(lblBangchu);
            groupBox2.Controls.Add(txtThanhtien);
            groupBox2.Controls.Add(txtDonGiaBan);
            groupBox2.Controls.Add(txtgiamgia);
            groupBox2.Controls.Add(txttengiay);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(cboMaGiay);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dgvHoadon);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Location = new Point(257, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1078, 451);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtTongtien
            // 
            txtTongtien.Location = new Point(787, 348);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.ReadOnly = true;
            txtTongtien.Size = new Size(223, 31);
            txtTongtien.TabIndex = 80;
            txtTongtien.TextChanged += txtTongtien_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ActiveCaption;
            label19.Location = new Point(669, 351);
            label19.Name = "label19";
            label19.Size = new Size(87, 25);
            label19.TabIndex = 79;
            label19.Text = "Tổng tiền";
            // 
            // lblBangchu
            // 
            lblBangchu.AutoSize = true;
            lblBangchu.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBangchu.ForeColor = SystemColors.ActiveCaption;
            lblBangchu.Location = new Point(45, 368);
            lblBangchu.Name = "lblBangchu";
            lblBangchu.Size = new Size(92, 24);
            lblBangchu.TabIndex = 78;
            lblBangchu.Text = "Bằng chữ";
            // 
            // txtThanhtien
            // 
            txtThanhtien.Location = new Point(787, 73);
            txtThanhtien.Name = "txtThanhtien";
            txtThanhtien.ReadOnly = true;
            txtThanhtien.Size = new Size(223, 31);
            txtThanhtien.TabIndex = 77;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(786, 29);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.ReadOnly = true;
            txtDonGiaBan.Size = new Size(224, 31);
            txtDonGiaBan.TabIndex = 76;
            // 
            // txtgiamgia
            // 
            txtgiamgia.Location = new Point(457, 73);
            txtgiamgia.Name = "txtgiamgia";
            txtgiamgia.Size = new Size(194, 31);
            txtgiamgia.TabIndex = 75;
            txtgiamgia.TextChanged += txtgiamgia_TextChanged;
            txtgiamgia.KeyPress += txtgiamgia_KeyPress;
            // 
            // txttengiay
            // 
            txttengiay.Location = new Point(457, 29);
            txttengiay.Name = "txttengiay";
            txttengiay.ReadOnly = true;
            txttengiay.Size = new Size(194, 31);
            txttengiay.TabIndex = 74;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(123, 73);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(182, 31);
            txtSoLuong.TabIndex = 73;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // cboMaGiay
            // 
            cboMaGiay.FormattingEnabled = true;
            cboMaGiay.Location = new Point(123, 29);
            cboMaGiay.Name = "cboMaGiay";
            cboMaGiay.Size = new Size(182, 33);
            cboMaGiay.TabIndex = 72;
            cboMaGiay.TextChanged += cboMaGiay_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.IndianRed;
            label17.Location = new Point(45, 332);
            label17.Name = "label17";
            label17.Size = new Size(230, 25);
            label17.TabIndex = 71;
            label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // dgvHoadon
            // 
            dgvHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoadon.Location = new Point(6, 117);
            dgvHoadon.Name = "dgvHoadon";
            dgvHoadon.RowHeadersWidth = 62;
            dgvHoadon.RowTemplate.Height = 33;
            dgvHoadon.Size = new Size(1066, 212);
            dgvHoadon.TabIndex = 70;
            dgvHoadon.DoubleClick += dgvHoadon_DoubleClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaption;
            label16.Location = new Point(669, 73);
            label16.Name = "label16";
            label16.Size = new Size(94, 25);
            label16.TabIndex = 69;
            label16.Text = "Thành tiền";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ActiveCaption;
            label15.Location = new Point(669, 37);
            label15.Name = "label15";
            label15.Size = new Size(75, 25);
            label15.TabIndex = 68;
            label15.Text = "Đơn giá";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ActiveCaption;
            label14.Location = new Point(340, 73);
            label14.Name = "label14";
            label14.Size = new Size(102, 25);
            label14.TabIndex = 67;
            label14.Text = "Giảm giá %";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ActiveCaption;
            label13.Location = new Point(340, 37);
            label13.Name = "label13";
            label13.Size = new Size(76, 25);
            label13.TabIndex = 66;
            label13.Text = "Tên giày";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(30, 73);
            label12.Name = "label12";
            label12.Size = new Size(85, 25);
            label12.TabIndex = 65;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(30, 37);
            label11.Name = "label11";
            label11.Size = new Size(75, 25);
            label11.TabIndex = 64;
            label11.Text = "Mã giày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(653, 12);
            label2.Name = "label2";
            label2.Size = new Size(371, 50);
            label2.TabIndex = 66;
            label2.Text = "Hóa đơn bán giày";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ActiveCaption;
            label18.Location = new Point(868, 717);
            label18.Name = "label18";
            label18.Size = new Size(109, 25);
            label18.TabIndex = 67;
            label18.Text = "Mã hóa đơn";
            // 
            // cboMaHDBan
            // 
            cboMaHDBan.FormattingEnabled = true;
            cboMaHDBan.Location = new Point(996, 714);
            cboMaHDBan.Name = "cboMaHDBan";
            cboMaHDBan.Size = new Size(182, 33);
            cboMaHDBan.TabIndex = 68;
            cboMaHDBan.DropDown += cboMaHDBan_DropDown;
            // 
            // btnTimkiem
            // 
            btnTimkiem.ForeColor = SystemColors.ActiveCaption;
            btnTimkiem.Location = new Point(1217, 714);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(112, 34);
            btnTimkiem.TabIndex = 69;
            btnTimkiem.Text = "&Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1347, 759);
            Controls.Add(btnTimkiem);
            Controls.Add(cboMaHDBan);
            Controls.Add(label18);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormHoaDon";
            Text = "Hóa đơn";
            FormClosing += FormHoaDon_FormClosing;
            Load += FormHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSKH;
        private Button btnHoaDon;
        private Button btnKhoGiay;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private DataGridView dgvHoadon;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private ComboBox cboMaKhachHang;
        private ComboBox cboMaNhanVien;
        private Label label17;
        private Label label18;
        private ComboBox cboMaHDBan;
        private Button btnTimkiem;
        public ComboBox cboMaGiay;
        private MaskedTextBox mskDienThoai;
        private TextBox txtDiachi;
        private TextBox txttenKhachhang;
        private TextBox txttennhanvien;
        private TextBox txtmahoadon;
        private DateTimePicker dtpngayban;
        private TextBox txtThanhtien;
        private TextBox txtDonGiaBan;
        private TextBox txtgiamgia;
        private TextBox txttengiay;
        private TextBox txtSoLuong;
        private TextBox txtTongtien;
        private Label label19;
        private Label lblBangchu;
    }
}