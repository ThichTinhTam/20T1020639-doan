namespace _20T1020639_doan.GUI
{
    partial class FormDanhSachGiay
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
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSNV = new Button();
            btnThongKe = new Button();
            btnKhoGiay = new Button();
            btnLoaiGiay = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvGiay = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnBoqua = new Button();
            btnTimKiem = new Button();
            btnHTDS = new Button();
            picAnh = new PictureBox();
            cboMaLoai = new ComboBox();
            txtAnh = new TextBox();
            txtGhichu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGiay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(12, 416);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 89);
            btnTrangChu.TabIndex = 15;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(37, 517);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 14;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(12, 592);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 89);
            btnDangXuat.TabIndex = 13;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(12, 315);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(283, 89);
            btnDSNV.TabIndex = 12;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(12, 214);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 89);
            btnThongKe.TabIndex = 11;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(12, 12);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 89);
            btnKhoGiay.TabIndex = 10;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = SystemColors.ActiveCaption;
            btnLoaiGiay.Location = new Point(12, 113);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(283, 89);
            btnLoaiGiay.TabIndex = 16;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(323, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 17;
            label2.Text = "Mã giày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(323, 128);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 18;
            label3.Text = "Tên giày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(662, 12);
            label4.Name = "label4";
            label4.Size = new Size(271, 40);
            label4.TabIndex = 19;
            label4.Text = "Danh mục giày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(324, 177);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 20;
            label5.Text = "Mã loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(324, 226);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 21;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(324, 267);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 22;
            label7.Text = "Đơn giá nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(324, 315);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 23;
            label8.Text = "Đơn giá ban";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(710, 76);
            label9.Name = "label9";
            label9.Size = new Size(45, 25);
            label9.TabIndex = 24;
            label9.Text = "Ảnh";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(710, 174);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 25;
            label10.Text = "Ghi chú";
            // 
            // dgvGiay
            // 
            dgvGiay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiay.Location = new Point(324, 371);
            dgvGiay.Name = "dgvGiay";
            dgvGiay.RowHeadersWidth = 62;
            dgvGiay.RowTemplate.Height = 33;
            dgvGiay.Size = new Size(901, 239);
            dgvGiay.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 31);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(459, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 31);
            textBox2.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(459, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 31);
            textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(462, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 31);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(459, 309);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(231, 31);
            textBox6.TabIndex = 32;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.MediumTurquoise;
            btnThem.Location = new Point(324, 638);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 33;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.MediumTurquoise;
            btnSua.Location = new Point(442, 638);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 34;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.MediumTurquoise;
            btnXoa.Location = new Point(560, 638);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.MediumTurquoise;
            btnLuu.Location = new Point(678, 638);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoqua.ForeColor = Color.MediumTurquoise;
            btnBoqua.Location = new Point(796, 638);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(112, 34);
            btnBoqua.TabIndex = 37;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.MediumTurquoise;
            btnTimKiem.Location = new Point(914, 638);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHTDS
            // 
            btnHTDS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHTDS.ForeColor = Color.MediumTurquoise;
            btnHTDS.Location = new Point(1032, 638);
            btnHTDS.Name = "btnHTDS";
            btnHTDS.Size = new Size(179, 34);
            btnHTDS.TabIndex = 39;
            btnHTDS.Text = "&Hiển thị danh sách";
            btnHTDS.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(964, 80);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(270, 231);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 40;
            picAnh.TabStop = false;
            // 
            // cboMaLoai
            // 
            cboMaLoai.FormattingEnabled = true;
            cboMaLoai.Location = new Point(459, 174);
            cboMaLoai.Name = "cboMaLoai";
            cboMaLoai.Size = new Size(231, 33);
            cboMaLoai.TabIndex = 41;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(783, 73);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(175, 31);
            txtAnh.TabIndex = 42;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(787, 171);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(171, 31);
            txtGhichu.TabIndex = 43;
            // 
            // FormDanhSachGiay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 695);
            Controls.Add(txtGhichu);
            Controls.Add(txtAnh);
            Controls.Add(cboMaLoai);
            Controls.Add(picAnh);
            Controls.Add(btnHTDS);
            Controls.Add(btnTimKiem);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvGiay);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoaiGiay);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormDanhSachGiay";
            Text = "FormDanhSachGiay";
            ((System.ComponentModel.ISupportInitialize)dgvGiay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSNV;
        private Button btnThongKe;
        private Button btnKhoGiay;
        private Button btnLoaiGiay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dgvGiay;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoqua;
        private Button btnTimKiem;
        private Button btnHTDS;
        private PictureBox picAnh;
        private ComboBox cboMaLoai;
        private TextBox txtAnh;
        private TextBox txtGhichu;
    }
}