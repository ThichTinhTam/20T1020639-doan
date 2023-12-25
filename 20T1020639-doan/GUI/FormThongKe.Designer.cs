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
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(12, 338);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 89);
            btnTrangChu.TabIndex = 21;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Blackadder ITC", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(36, 449);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 20;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(12, 541);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 89);
            btnDangXuat.TabIndex = 19;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // btnDSNV
            // 
            btnDSNV.BackColor = SystemColors.ActiveCaption;
            btnDSNV.Location = new Point(12, 232);
            btnDSNV.Name = "btnDSNV";
            btnDSNV.Size = new Size(283, 89);
            btnDSNV.TabIndex = 18;
            btnDSNV.Text = "Danh Sách Nhân Viên";
            btnDSNV.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.ActiveCaption;
            btnThongKe.Location = new Point(12, 121);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(283, 89);
            btnThongKe.TabIndex = 17;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(12, 9);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 89);
            btnKhoGiay.TabIndex = 16;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 637);
            Controls.Add(btnTrangChu);
            Controls.Add(label1);
            Controls.Add(btnDangXuat);
            Controls.Add(btnDSNV);
            Controls.Add(btnThongKe);
            Controls.Add(btnKhoGiay);
            Name = "FormThongKe";
            Text = "FormThongKe";
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
    }
}