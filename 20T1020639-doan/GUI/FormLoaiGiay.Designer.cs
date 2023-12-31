namespace _20T1020639_doan.GUI
{
    partial class FormLoaiGiay
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
            btnLoaiGiay = new Button();
            btnTrangChu = new Button();
            label1 = new Label();
            btnDangXuat = new Button();
            btnDSNV = new Button();
            btnThongKe = new Button();
            btnKhoGiay = new Button();
            txtMaloai = new TextBox();
            txtTenloai = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnBoqua = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvLoai = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoai).BeginInit();
            SuspendLayout();
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = SystemColors.ActiveCaption;
            btnLoaiGiay.Image = Properties.Resources.canvas_shoe_25_644;
            btnLoaiGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiGiay.Location = new Point(-7, 83);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(309, 87);
            btnLoaiGiay.TabIndex = 17;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Image = Properties.Resources.home_184_646;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(-7, 426);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(309, 78);
            btnTrangChu.TabIndex = 16;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(36, 507);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 15;
            label1.Text = "Viết Shoe";
            label1.Click += label1_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_647;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-7, 580);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(309, 89);
            btnDangXuat.TabIndex = 14;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_2;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Image = Properties.Resources.user_149_647;
            btnDSNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSNV.Location = new Point(-7, 343);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(309, 87);
            btnDSNV.TabIndex = 13;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Image = Properties.Resources.statistical_chart_7_644;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(-7, 169);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(309, 89);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_648;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(-7, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(309, 89);
            btnKhoGiay.TabIndex = 11;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // txtMaloai
            // 
            txtMaloai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaloai.Location = new Point(591, 98);
            txtMaloai.Name = "txtMaloai";
            txtMaloai.Size = new Size(265, 31);
            txtMaloai.TabIndex = 0;
            // 
            // txtTenloai
            // 
            txtTenloai.Location = new Point(591, 166);
            txtTenloai.Name = "txtTenloai";
            txtTenloai.Size = new Size(265, 31);
            txtTenloai.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaption;
            btnThem.Image = Properties.Resources.Button_Add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(314, 604);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 47);
            btnThem.TabIndex = 2;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ActiveCaption;
            btnSua.Image = Properties.Resources.fix_1_32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(468, 604);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 47);
            btnSua.TabIndex = 3;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaption;
            btnXoa.Image = Properties.Resources.Button_Close;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(612, 604);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 47);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaption;
            btnLuu.Image = Properties.Resources.save_32_32;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(765, 604);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(128, 50);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoqua
            // 
            btnBoqua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnBoqua.ForeColor = SystemColors.ActiveCaption;
            btnBoqua.Image = Properties.Resources.Button_Next_icon;
            btnBoqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoqua.Location = new Point(913, 604);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(160, 50);
            btnBoqua.TabIndex = 6;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            btnBoqua.Click += btnBoqua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(494, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 26;
            label2.Text = "Mã loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(494, 172);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 27;
            label3.Text = "Tên loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(537, 8);
            label4.Name = "label4";
            label4.Size = new Size(427, 60);
            label4.TabIndex = 28;
            label4.Text = "Danh mục loại giày";
            // 
            // dgvLoai
            // 
            dgvLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoai.Location = new Point(320, 219);
            dgvLoai.Name = "dgvLoai";
            dgvLoai.RowHeadersWidth = 62;
            dgvLoai.RowTemplate.Height = 33;
            dgvLoai.Size = new Size(732, 359);
            dgvLoai.TabIndex = 20;
            dgvLoai.Click += dgvLoai_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Image = Properties.Resources.bill_5_641;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-7, 258);
            button1.Name = "button1";
            button1.Size = new Size(309, 90);
            button1.TabIndex = 29;
            button1.Text = "Danh Sách Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormLoaiGiay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1085, 672);
            Controls.Add(button1);
            Controls.Add(dgvLoai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenloai);
            Controls.Add(txtMaloai);
            Controls.Add(btnLoaiGiay);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormLoaiGiay";
            Text = "Quản lý Loại";
            Load += FormLoaiGiay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoaiGiay;
        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSNV;
        private Button btnThongKe;
        private Button btnKhoGiay;
        private TextBox txtMaloai;
        private TextBox txtTenloai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoqua;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvLoai;
        private Button button1;
    }
}