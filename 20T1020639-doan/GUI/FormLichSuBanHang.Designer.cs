namespace _20T1020639_doan.GUI
{
    partial class FormLichSuBanHang
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
            button2 = new Button();
            button1 = new Button();
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSKH = new Button();
            btnHoaDon = new Button();
            btnKhoGiay = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            txtTongTien = new TextBox();
            txtMaKhach = new TextBox();
            txtMaNhanVien = new TextBox();
            txtThang = new TextBox();
            txtMaHDBan = new TextBox();
            dgvHoaDon = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Image = Properties.Resources.history_15_48;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(2, 354);
            button2.Name = "button2";
            button2.Size = new Size(320, 85);
            button2.TabIndex = 64;
            button2.Text = "Lịch Sử Bán Hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.information_19_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(2, 261);
            button1.Name = "button1";
            button1.Size = new Size(320, 96);
            button1.TabIndex = 63;
            button1.Text = "Thông Tin Cá Nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_647;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(2, 436);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(320, 84);
            btnTrangChu.TabIndex = 62;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 537);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 61;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_648;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(2, 615);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(320, 85);
            btnDangXuat.TabIndex = 60;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = Color.LightCoral;
            btnDSKH.Image = Properties.Resources.user_149_648;
            btnDSKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSKH.Location = new Point(2, 180);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(320, 84);
            btnDSKH.TabIndex = 59;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCoral;
            btnHoaDon.Image = Properties.Resources.bill_5_643;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(2, 89);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(320, 92);
            btnHoaDon.TabIndex = 58;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_649;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(2, 3);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(320, 91);
            btnKhoGiay.TabIndex = 57;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(1095, 101);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 31);
            textBox1.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(499, 9);
            label2.Name = "label2";
            label2.Size = new Size(645, 89);
            label2.TabIndex = 66;
            label2.Text = "Lịch Sử Bán Hàng";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1080, 228);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(202, 31);
            txtTongTien.TabIndex = 79;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(1080, 161);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.ReadOnly = true;
            txtMaKhach.Size = new Size(199, 31);
            txtMaKhach.TabIndex = 78;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(534, 285);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(357, 31);
            txtMaNhanVien.TabIndex = 77;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(534, 228);
            txtThang.Name = "txtThang";
            txtThang.ReadOnly = true;
            txtThang.Size = new Size(357, 31);
            txtThang.TabIndex = 75;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(534, 164);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.ReadOnly = true;
            txtMaHDBan.Size = new Size(357, 31);
            txtMaHDBan.TabIndex = 74;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(367, 333);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.RowTemplate.Height = 33;
            dgvHoaDon.Size = new Size(912, 314);
            dgvHoaDon.TabIndex = 73;
            dgvHoaDon.Click += dgvHoaDon_Click;
            dgvHoaDon.DoubleClick += dgvHoaDon_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(907, 231);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 71;
            label7.Text = "Tổng tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(904, 164);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 70;
            label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(374, 285);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 69;
            label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(374, 228);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 68;
            label4.Text = "Ngày Bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(374, 172);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 67;
            label3.Text = "Mã hóa đơn";
            // 
            // FormLichSuBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1325, 701);
            Controls.Add(txtTongTien);
            Controls.Add(txtMaKhach);
            Controls.Add(txtMaNhanVien);
            Controls.Add(txtThang);
            Controls.Add(txtMaHDBan);
            Controls.Add(dgvHoaDon);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormLichSuBanHang";
            Text = "FormLichSuBanHang";
            Load += FormLichSuBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSKH;
        private Button btnHoaDon;
        private Button btnKhoGiay;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtMaKhach;
        private TextBox txtMaNhanVien;
        private TextBox txtThang;
        private TextBox txtMaHDBan;
        private DataGridView dgvHoaDon;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}