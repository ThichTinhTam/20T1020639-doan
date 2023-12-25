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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            btnKhoGiay = new Button();
            btnThongKe = new Button();
            btnDSNV = new Button();
            btnDangXuat = new Button();
            label1 = new Label();
            btnTrangChu = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLoaiGiay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(2, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 89);
            btnKhoGiay.TabIndex = 0;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(2, 192);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 89);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(2, 287);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(283, 89);
            btnDSNV.TabIndex = 2;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(2, 566);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 89);
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
            label1.Location = new Point(26, 488);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 7;
            label1.Text = "Viết Shoe";
            label1.Click += label1_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(2, 382);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 89);
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
            label2.Location = new Point(444, 610);
            label2.Name = "label2";
            label2.Size = new Size(570, 38);
            label2.TabIndex = 8;
            label2.Text = "Nâng niu bàn chân người Việt";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 657);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnLoaiGiay
            // 
            btnLoaiGiay.BackColor = SystemColors.ActiveCaption;
            btnLoaiGiay.Location = new Point(2, 93);
            btnLoaiGiay.Name = "btnLoaiGiay";
            btnLoaiGiay.Size = new Size(283, 89);
            btnLoaiGiay.TabIndex = 10;
            btnLoaiGiay.Text = "Loại Giày";
            btnLoaiGiay.UseVisualStyleBackColor = false;
            btnLoaiGiay.Click += btnLoaiGiay_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 657);
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
    }
}