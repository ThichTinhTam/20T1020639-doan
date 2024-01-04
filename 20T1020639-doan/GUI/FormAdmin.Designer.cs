namespace _20T1020639_doan.GUI
{
    partial class FormAdmin
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
            btnKhoGiay = new Button();
            btnThongKe = new Button();
            btnDSNV = new Button();
            btnDangXuat = new Button();
            label1 = new Label();
            btnTrangChu = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLoaiGiay = new Button();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_643;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(1, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(321, 79);
            btnKhoGiay.TabIndex = 0;
            btnKhoGiay.Text = "Quản Lý Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.LightCoral;
            btnThongKe.Image = Properties.Resources.statistical_chart_7_642;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(-2, 158);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(324, 88);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = Color.LightCoral;
            btnDSNV.Image = Properties.Resources.user_149_642;
            btnDSNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSNV.Location = new Point(-2, 329);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(324, 91);
            btnDSNV.TabIndex = 2;
            btnDSNV.Text = "Quản Lý Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_642;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(1, 674);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(321, 94);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 596);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 7;
            label1.Text = "Viết Shoe";
            label1.Click += label1_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_641;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(1, 500);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(321, 90);
            btnTrangChu.TabIndex = 9;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightYellow;
            label2.Font = new Font("Felix Titling", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(635, 720);
            label2.Name = "label2";
            label2.Size = new Size(570, 38);
            label2.TabIndex = 8;
            label2.Text = "Nâng niu bàn chân người Việt";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kinh_doanh_giay_dep_thoi_trang;
            pictureBox1.Location = new Point(322, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(883, 760);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = Color.LightCoral;
            btnLoaiGiay.Image = Properties.Resources.canvas_shoe_25_642;
            btnLoaiGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiGiay.Location = new Point(-2, 77);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(324, 84);
            btnLoaiGiay.TabIndex = 10;
            btnLoaiGiay.Text = "Quản Lý Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.bill_5_641;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, 245);
            button1.Name = "button1";
            button1.Size = new Size(324, 86);
            button1.TabIndex = 11;
            button1.Text = "Quản Lý Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Image = Properties.Resources.icon_permission_management_48;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1, 416);
            button2.Name = "button2";
            button2.Size = new Size(321, 87);
            button2.TabIndex = 21;
            button2.Text = "Quản Lý Chức Vụ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(338, 24);
            label3.Name = "label3";
            label3.Size = new Size(220, 63);
            label3.TabIndex = 22;
            label3.Text = "Viết Shoe";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1207, 763);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLoaiGiay);
            Controls.Add(btnTrangChu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKhoGiay;
        private Button btnThongKe;
        private Button btnDSNV;
        private Button btnDangXuat;
        private Label label1;
        private Button btnTrangChu;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnLoaiGiay;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}