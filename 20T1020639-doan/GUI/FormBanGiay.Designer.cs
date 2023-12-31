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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGiay).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ActiveCaption;
            btnTrangChu.Location = new Point(9, 351);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(283, 109);
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
            label1.Location = new Point(39, 482);
            label1.Name = "label1";
            label1.Size = new Size(220, 63);
            label1.TabIndex = 58;
            label1.Text = "Viết Shoe";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(12, 575);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(283, 113);
            btnDangXuat.TabIndex = 57;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDSKH
            // 
            btnDSKH.BackColor = SystemColors.ActiveCaption;
            btnDSKH.Location = new Point(12, 243);
            btnDSKH.Name = "btnDSKH";
            btnDSKH.Size = new Size(283, 102);
            btnDSKH.TabIndex = 56;
            btnDSKH.Text = "Danh Sách Khách Hàng";
            btnDSKH.UseVisualStyleBackColor = false;
            btnDSKH.Click += btnDSKH_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = SystemColors.ActiveCaption;
            btnHoaDon.Location = new Point(12, 129);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(283, 108);
            btnHoaDon.TabIndex = 55;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnKhoGiay
            // 
            btnKhoGiay.BackColor = SystemColors.ActiveCaption;
            btnKhoGiay.Location = new Point(9, 8);
            btnKhoGiay.Name = "btnKhoGiay";
            btnKhoGiay.Size = new Size(283, 115);
            btnKhoGiay.TabIndex = 54;
            btnKhoGiay.Text = "Kho Giày";
            btnKhoGiay.UseVisualStyleBackColor = false;
            btnKhoGiay.Click += btnKhoGiay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(499, 8);
            label2.Name = "label2";
            label2.Size = new Size(441, 98);
            label2.TabIndex = 60;
            label2.Text = "Viết Shoe";
            // 
            // dgvGiay
            // 
            dgvGiay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiay.Location = new Point(301, 109);
            dgvGiay.Name = "dgvGiay";
            dgvGiay.RowHeadersWidth = 62;
            dgvGiay.RowTemplate.Height = 33;
            dgvGiay.Size = new Size(856, 507);
            dgvGiay.TabIndex = 61;
            dgvGiay.CellDoubleClick += dgvGiay_CellDoubleClick;
            dgvGiay.DoubleClick += dgvGiay_DoubleClick;
            dgvGiay.MouseDoubleClick += dgvGiay_MouseDoubleClick;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 20F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(842, 622);
            button1.Name = "button1";
            button1.Size = new Size(306, 66);
            button1.TabIndex = 62;
            button1.Text = "Mua hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBanGiay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1160, 700);
            Controls.Add(button1);
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
        private Button button1;
    }
}