namespace _20T1020639_doan.GUI
{
    partial class FormBanGiay
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
            label2 = new Label();
            dgvGiay = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGiay).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.LightCoral;
            btnTrangChu.Image = Properties.Resources.home_184_642;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(-3, 455);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(311, 102);
            btnTrangChu.TabIndex = 59;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(39, 560);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 58;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Image = Properties.Resources.logout_66_643;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-3, 626);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(311, 79);
            btnDangXuat.TabIndex = 57;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = Color.LightCoral;
            btnDSKH.Image = Properties.Resources.user_149_643;
            btnDSKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDSKH.Location = new Point(-3, 181);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(311, 91);
            btnDSKH.TabIndex = 56;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.LightCoral;
            btnHoaDon.Image = Properties.Resources.bill_5_64;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(-3, 91);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(311, 92);
            btnHoaDon.TabIndex = 55;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = Color.LightCoral;
            btnKhoGiay.Image = Properties.Resources.canvas_shoe_12_644;
            btnKhoGiay.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoGiay.Location = new Point(-3, -2);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(311, 95);
            btnKhoGiay.TabIndex = 54;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(499, 8);
            label2.Name = "label2";
            label2.Size = new Size(441, 98);
            label2.TabIndex = 60;
            label2.Text = "Viết Shoe";
            // 
            // dgvGiay
            // 
            dgvGiay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiay.Location = new Point(314, 109);
            dgvGiay.Name = "dgvGiay";
            dgvGiay.RowHeadersWidth = 62;
            dgvGiay.RowTemplate.Height = 33;
            dgvGiay.Size = new Size(843, 495);
            dgvGiay.TabIndex = 61;
            dgvGiay.CellDoubleClick += dgvGiay_CellDoubleClick;
            dgvGiay.DoubleClick += dgvGiay_DoubleClick;
            dgvGiay.MouseDoubleClick += dgvGiay_MouseDoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Image = Properties.Resources.information_19_48;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 271);
            button2.Name = "button2";
            button2.Size = new Size(311, 105);
            button2.TabIndex = 63;
            button2.Text = "Thông Tin Cá Nhân";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Image = Properties.Resources.history_15_48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 373);
            button1.Name = "button1";
            button1.Size = new Size(311, 85);
            button1.TabIndex = 64;
            button1.Text = "Lịch Sử Bán Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.shopping_cart_full_3_48;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(850, 628);
            button3.Name = "button3";
            button3.Size = new Size(244, 66);
            button3.TabIndex = 65;
            button3.Text = "Mua Hàng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormBanGiay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1160, 706);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dgvGiay);
            Controls.Add(label2);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSKH);
            Controls.Add(btnHoaDon);
            Controls.Add(btnKhoGiay);
            Name = "FormBanGiay";
            Text = "FormBanGiay";
            Load += FormBanGiay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiay).EndInit();
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
        private Label label2;
        private DataGridView dgvGiay;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}