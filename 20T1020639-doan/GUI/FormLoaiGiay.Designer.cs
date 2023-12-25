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
            dgvLoai = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnBoqua = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoai).BeginInit();
            SuspendLayout();
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = SystemColors.ActiveCaption;
            btnLoaiGiay.Location = new Point(12, 111);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(283, 89);
            btnLoaiGiay.TabIndex = 17;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(12, 408);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 89);
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
            btnDangXuat.Location = new Point(12, 580);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 89);
            btnDangXuat.TabIndex = 14;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_2;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(12, 309);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(283, 89);
            btnDSNV.TabIndex = 13;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(12, 210);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 89);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(12, 12);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 89);
            btnKhoGiay.TabIndex = 11;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // txtMaloai
            // 
            txtMaloai.Location = new Point(602, 107);
            txtMaloai.Name = "txtMaloai";
            txtMaloai.Size = new Size(265, 31);
            txtMaloai.TabIndex = 0;
            // 
            // txtTenloai
            // 
            txtTenloai.Location = new Point(602, 165);
            txtTenloai.Name = "txtTenloai";
            txtTenloai.Size = new Size(265, 31);
            txtTenloai.TabIndex = 1;
            // 
            // dgvLoai
            // 
            dgvLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoai.Location = new Point(339, 229);
            dgvLoai.Name = "dgvLoai";
            dgvLoai.RowHeadersWidth = 62;
            dgvLoai.RowTemplate.Height = 33;
            dgvLoai.Size = new Size(752, 341);
            dgvLoai.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ActiveCaption;
            btnThem.Location = new Point(360, 610);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ActiveCaption;
            btnSua.Location = new Point(510, 610);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ActiveCaption;
            btnXoa.Location = new Point(656, 610);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ActiveCaption;
            btnLuu.Location = new Point(805, 610);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnBoqua.ForeColor = SystemColors.ActiveCaption;
            btnBoqua.Location = new Point(949, 610);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(112, 34);
            btnBoqua.TabIndex = 6;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(483, 107);
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
            label3.Location = new Point(483, 168);
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
            label4.Location = new Point(531, 12);
            label4.Name = "label4";
            label4.Size = new Size(427, 60);
            label4.TabIndex = 28;
            label4.Text = "Danh mục loại giày";
            // 
            // FormLoaiGiay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 672);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBoqua);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvLoai);
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
            Text = "FormLoaiGiay";
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
        private DataGridView dgvLoai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoqua;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}