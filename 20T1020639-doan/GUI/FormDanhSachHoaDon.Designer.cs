namespace _20T1020639_doan.GUI
{
    partial class FormDanhSachHoaDon
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
            button1 = new Button();
            btnLoaiGiay = new Button();
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSNV = new Button();
            btnThongKe = new Button();
            btnKhoGiay = new Button();
            label2 = new Label();
            btnTimKiem = new Button();
            btnTimlai = new Button();
            btnxemlaithongke = new Button();
            dgvHoaDon = new DataGridView();
            txtMaHDBan = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            txtMaNhanVien = new TextBox();
            txtMaKhach = new TextBox();
            txtTongTien = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.bill_5_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-7, 261);
            button1.Name = "button1";
            button1.Size = new Size(311, 94);
            button1.TabIndex = 19;
            button1.Text = "Danh Sách Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = Color.LightCoral;
            btnLoaiGiay.Image = Properties.Resources.canvas_shoe_25_641;
            btnLoaiGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiGiay.Location = new Point(-7, 78);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(311, 86);
            btnLoaiGiay.TabIndex = 18;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_64;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(-7, 436);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(311, 78);
            btnTrangChu.TabIndex = 17;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(29, 526);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 16;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_641;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-7, 594);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(311, 105);
            btnDangXuat.TabIndex = 15;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = Color.LightCoral;
            btnDSNV.Image = Properties.Resources.user_149_641;
            btnDSNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSNV.Location = new Point(-7, 352);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(311, 86);
            btnDSNV.TabIndex = 14;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click_1;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.LightCoral;
            btnThongKe.Image = Properties.Resources.statistical_chart_7_641;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(-7, 165);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(311, 96);
            btnThongKe.TabIndex = 13;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_642;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(-7, -6);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(311, 86);
            btnKhoGiay.TabIndex = 12;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(379, 2);
            label2.Name = "label2";
            label2.Size = new Size(749, 89);
            label2.TabIndex = 20;
            label2.Text = "Danh Sách Hóa Đơn";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.IndianRed;
            btnTimKiem.Image = Properties.Resources.Search_icon;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(423, 619);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(184, 51);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnTimlai
            // 
            btnTimlai.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimlai.ForeColor = Color.IndianRed;
            btnTimlai.Image = Properties.Resources.Search_icon;
            btnTimlai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimlai.Location = new Point(656, 619);
            btnTimlai.Name = "btnTimlai";
            btnTimlai.Size = new Size(178, 51);
            btnTimlai.TabIndex = 28;
            btnTimlai.Text = "Tìm lại";
            btnTimlai.UseVisualStyleBackColor = true;
            btnTimlai.Click += btnTimlai_Click;
            // 
            // btnxemlaithongke
            // 
            btnxemlaithongke.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnxemlaithongke.ForeColor = Color.IndianRed;
            btnxemlaithongke.Image = Properties.Resources.statistical_chart_7_32;
            btnxemlaithongke.ImageAlign = ContentAlignment.MiddleLeft;
            btnxemlaithongke.Location = new Point(884, 619);
            btnxemlaithongke.Name = "btnxemlaithongke";
            btnxemlaithongke.Size = new Size(300, 51);
            btnxemlaithongke.TabIndex = 29;
            btnxemlaithongke.Text = "Thông kê hôm nay";
            btnxemlaithongke.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(310, 275);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.RowTemplate.Height = 33;
            dgvHoaDon.Size = new Size(912, 314);
            dgvHoaDon.TabIndex = 30;
            dgvHoaDon.DoubleClick += dgvHoaDon_DoubleClick;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(477, 106);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(357, 31);
            txtMaHDBan.TabIndex = 31;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(477, 170);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(130, 31);
            txtThang.TabIndex = 32;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(678, 173);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(156, 31);
            txtNam.TabIndex = 33;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(477, 227);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(357, 31);
            txtMaNhanVien.TabIndex = 34;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(1023, 103);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(199, 31);
            txtMaKhach.TabIndex = 35;
            txtMaKhach.TextChanged += textBox5_TextChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1023, 170);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(202, 31);
            txtTongTien.TabIndex = 36;
            txtTongTien.KeyPress += txtTongTien_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(847, 106);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 24;
            label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(850, 173);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 25;
            label7.Text = "Tổng tiền";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(613, 173);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 26;
            label8.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(317, 114);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 21;
            label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(317, 170);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 22;
            label4.Text = "Tháng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(317, 227);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 23;
            label5.Text = "Mã nhân viên";
            // 
            // FormDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1234, 695);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaKhach);
            Controls.Add(txtMaNhanVien);
            Controls.Add(txtNam);
            Controls.Add(txtThang);
            Controls.Add(txtMaHDBan);
            Controls.Add(dgvHoaDon);
            Controls.Add(btnxemlaithongke);
            Controls.Add(btnTimlai);
            Controls.Add(btnTimKiem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnLoaiGiay);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormDanhSachHoaDon";
            Text = "FormDanhSachHoaDon";
            FormClosing += FormDanhSachHoaDon_FormClosing;
            Load += FormDanhSachHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnLoaiGiay;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSNV;
        private Button btnThongKe;
        private Button btnKhoGiay;
        private Label label2;
        private Button btnTimKiem;
        private Button btnTimlai;
        private Button btnxemlaithongke;
        private DataGridView dgvHoaDon;
        private TextBox txtMaHDBan;
        private TextBox txtThang;
        private TextBox txtNam;
        private TextBox txtMaNhanVien;
        private TextBox txtMaKhach;
        private TextBox txtTongTien;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}