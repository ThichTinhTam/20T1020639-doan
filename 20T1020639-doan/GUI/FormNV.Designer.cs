namespace _20T1020639_doan.GUI
{
    partial class FormNV
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
            btnDSKH = new Button();
            btnHoaDon = new Button();
            btnKhoGiay = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_647;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(1, 431);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(320, 84);
            btnTrangChu.TabIndex = 52;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(51, 532);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 51;
            label1.Text = "Viết Shoe";
            label1.Click += label1_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_648;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(1, 610);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(320, 85);
            btnDangXuat.TabIndex = 50;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = Color.LightCoral;
            btnDSKH.Image = Properties.Resources.user_149_648;
            btnDSKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSKH.Location = new Point(1, 175);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(320, 84);
            btnDSKH.TabIndex = 49;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCoral;
            btnHoaDon.Image = Properties.Resources.bill_5_643;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(1, 84);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(320, 92);
            btnHoaDon.TabIndex = 48;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_649;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(1, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(320, 91);
            btnKhoGiay.TabIndex = 47;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dia_chi_ban_giay_second_hand_duoc_ua_chuong_nhat_tai_thanh_pho_ho_chi_minh_683090;
            pictureBox1.Location = new Point(327, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 697);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.information_19_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 256);
            button1.Name = "button1";
            button1.Size = new Size(320, 96);
            button1.TabIndex = 54;
            button1.Text = "Thông Tin Cá Nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(914, 28);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 31);
            textBox1.TabIndex = 55;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Image = Properties.Resources.history_15_48;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1, 349);
            button2.Name = "button2";
            button2.Size = new Size(320, 85);
            button2.TabIndex = 56;
            button2.Text = "Lịch Sử Bán Hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1158, 696);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormNV";
            Text = "Bán giày";
            Load += FormNV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSKH;
        private Button btnHoaDon;
        private Button btnKhoGiay;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}