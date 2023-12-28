namespace _20T1020639_doan.GUI
{
    partial class FormThongKe
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
            btnDSNV = new Button();
            btnThongKe = new Button();
            btnKhoGiay = new Button();
            button1 = new Button();
            label2 = new Label();
            dgvThongke = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongke).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(-1, 483);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 81);
            btnTrangChu.TabIndex = 21;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(22, 567);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 20;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(-1, 633);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 96);
            btnDangXuat.TabIndex = 19;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(-1, 393);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(283, 90);
            btnDSNV.TabIndex = 18;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            btnDSNV.Click += btnDSNV_Click_1;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(-1, 192);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 99);
            btnThongKe.TabIndex = 17;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click_1;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(-1, 5);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 90);
            btnKhoGiay.TabIndex = 16;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(306, 633);
            button1.Name = "button1";
            button1.Size = new Size(266, 38);
            button1.TabIndex = 22;
            button1.Text = "Thống kê trong ngày";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(518, 9);
            label2.Name = "label2";
            label2.Size = new Size(458, 89);
            label2.TabIndex = 23;
            label2.Text = "Doanh Thu";
            // 
            // dgvThongke
            // 
            dgvThongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongke.Location = new Point(306, 135);
            dgvThongke.Name = "dgvThongke";
            dgvThongke.RowHeadersWidth = 62;
            dgvThongke.RowTemplate.Height = 33;
            dgvThongke.Size = new Size(884, 407);
            dgvThongke.TabIndex = 24;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(608, 633);
            button2.Name = "button2";
            button2.Size = new Size(266, 38);
            button2.TabIndex = 25;
            button2.Text = "Thống kê trong tháng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(880, 633);
            button3.Name = "button3";
            button3.Size = new Size(310, 38);
            button3.TabIndex = 26;
            button3.Text = "Thống kê trong năm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(608, 677);
            button4.Name = "button4";
            button4.Size = new Size(266, 38);
            button4.TabIndex = 27;
            button4.Text = "Thống kê trong tháng trước";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaption;
            button5.Location = new Point(880, 677);
            button5.Name = "button5";
            button5.Size = new Size(310, 38);
            button5.TabIndex = 28;
            button5.Text = "Thống kê trong năm trước";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaption;
            button6.Location = new Point(306, 677);
            button6.Name = "button6";
            button6.Size = new Size(296, 38);
            button6.TabIndex = 29;
            button6.Text = "Thống kê trong ngày hôm qua";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(-1, 93);
            button7.Name = "button7";
            button7.Size = new Size(283, 97);
            button7.TabIndex = 30;
            button7.Text = "Loại Giày";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Location = new Point(-1, 287);
            button8.Name = "button8";
            button8.Size = new Size(283, 107);
            button8.TabIndex = 31;
            button8.Text = "Danh Sách Hóa Đơn";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 727);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvThongke);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrangChu;
        private Label label1;
        private Button btnDangXuat;
        private Button btnDSNV;
        private Button btnThongKe;
        private Button btnKhoGiay;
        private Button button1;
        private Label label2;
        private DataGridView dgvThongke;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}