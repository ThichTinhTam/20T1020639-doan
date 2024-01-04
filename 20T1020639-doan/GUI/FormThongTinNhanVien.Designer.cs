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
            button1.Text = "Thông Tin Nhân Viên";
            button1.UseVisualStyleBackColor = false;
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
            // 
            // FormThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 684);
            Controls.Add(button1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormThongTinNhanVien";
            Text = "FormThongTinNhanVien";
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
    }
}