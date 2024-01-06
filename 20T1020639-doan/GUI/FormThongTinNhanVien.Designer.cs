namespace _20T1020639_doan.GUI
{
    partial class FormThongTinNhanVien
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
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSKH = new Button();
            btnHoaDon = new Button();
            btnKhoGiay = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtmanhanvien = new TextBox();
            dtpngaysinh = new DateTimePicker();
            txtDienthoai = new TextBox();
            txtdiachi = new TextBox();
            txtGioitinh = new TextBox();
            txtTennhanvien = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.information_19_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 284);
            button1.Name = "button1";
            button1.Size = new Size(320, 99);
            button1.TabIndex = 61;
            button1.Text = "Thông Tin Cá Nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_647;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 380);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(320, 100);
            btnTrangChu.TabIndex = 60;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(44, 499);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 59;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_648;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 580);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(320, 106);
            btnDangXuat.TabIndex = 58;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = Color.LightCoral;
            btnDSKH.Image = Properties.Resources.user_149_648;
            btnDSKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSKH.Location = new Point(0, 187);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(320, 101);
            btnDSKH.TabIndex = 57;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCoral;
            btnHoaDon.Image = Properties.Resources.bill_5_643;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 102);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(320, 89);
            btnHoaDon.TabIndex = 56;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_649;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(0, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(320, 110);
            btnKhoGiay.TabIndex = 55;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 22F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(512, 16);
            label2.Name = "label2";
            label2.Size = new Size(437, 54);
            label2.TabIndex = 62;
            label2.Text = "Thông tin cá nhân";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSalmon;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtmanhanvien);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(txtDienthoai);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtGioitinh);
            groupBox1.Controls.Add(txtTennhanvien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(347, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 464);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(88, 27);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 88;
            label3.Text = "Mã nhân viên";
            // 
            // txtmanhanvien
            // 
            txtmanhanvien.Location = new Point(270, 23);
            txtmanhanvien.Name = "txtmanhanvien";
            txtmanhanvien.Size = new Size(394, 31);
            txtmanhanvien.TabIndex = 87;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Format = DateTimePickerFormat.Short;
            dtpngaysinh.Location = new Point(272, 404);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(393, 31);
            dtpngaysinh.TabIndex = 86;
            dtpngaysinh.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(267, 327);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(394, 31);
            txtDienthoai.TabIndex = 85;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(267, 245);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(398, 31);
            txtdiachi.TabIndex = 84;
            // 
            // txtGioitinh
            // 
            txtGioitinh.Location = new Point(266, 161);
            txtGioitinh.Name = "txtGioitinh";
            txtGioitinh.Size = new Size(398, 31);
            txtGioitinh.TabIndex = 83;
            // 
            // txtTennhanvien
            // 
            txtTennhanvien.Location = new Point(267, 87);
            txtTennhanvien.Name = "txtTennhanvien";
            txtTennhanvien.Size = new Size(397, 31);
            txtTennhanvien.TabIndex = 82;
            txtTennhanvien.TextChanged += txtTennhanvien_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(90, 404);
            label8.Name = "label8";
            label8.Size = new Size(109, 22);
            label8.TabIndex = 81;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(90, 327);
            label7.Name = "label7";
            label7.Size = new Size(117, 22);
            label7.TabIndex = 80;
            label7.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(90, 245);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 79;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(88, 161);
            label5.Name = "label5";
            label5.Size = new Size(107, 22);
            label5.TabIndex = 78;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 11F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(85, 87);
            label4.Name = "label4";
            label4.Size = new Size(153, 22);
            label4.TabIndex = 77;
            label4.Text = "Tên nhân viên";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Button_Refresh_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(495, 580);
            button2.Name = "button2";
            button2.Size = new Size(209, 62);
            button2.TabIndex = 78;
            button2.Text = "&Đổi mật khẩu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1166, 684);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormThongTinNhanVien";
            Text = "FormThongTinNhanVien";
            Load += FormThongTinNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSKH;
        private Button btnHoaDon;
        private Button btnKhoGiay;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtmanhanvien;
        private DateTimePicker dtpngaysinh;
        private TextBox txtDienthoai;
        private TextBox txtdiachi;
        private TextBox txtGioitinh;
        private TextBox txtTennhanvien;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
    }
}