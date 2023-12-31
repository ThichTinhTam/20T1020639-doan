namespace _20T1020639_doan.GUI
{
    partial class FormHienThiHoaDon
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
            txtTongtien = new TextBox();
            label19 = new Label();
            lblBangchu = new Label();
            dtpngayban = new DateTimePicker();
            mskDienThoai = new MaskedTextBox();
            dgvHoadon = new DataGridView();
            txtDiachi = new TextBox();
            txttenKhachhang = new TextBox();
            txttennhanvien = new TextBox();
            txtmahoadon = new TextBox();
            label2 = new Label();
            label17 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            cboMaKhachHang = new ComboBox();
            cboMaNhanVien = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoadon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTongtien
            // 
            txtTongtien.Location = new Point(787, 348);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.ReadOnly = true;
            txtTongtien.Size = new Size(223, 31);
            txtTongtien.TabIndex = 80;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ActiveCaption;
            label19.Location = new Point(669, 351);
            label19.Name = "label19";
            label19.Size = new Size(87, 25);
            label19.TabIndex = 79;
            label19.Text = "Tổng tiền";
            // 
            // lblBangchu
            // 
            lblBangchu.AutoSize = true;
            lblBangchu.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBangchu.ForeColor = SystemColors.ActiveCaption;
            lblBangchu.Location = new Point(45, 368);
            lblBangchu.Name = "lblBangchu";
            lblBangchu.Size = new Size(92, 24);
            lblBangchu.TabIndex = 78;
            lblBangchu.Text = "Bằng chữ";
            // 
            // dtpngayban
            // 
            dtpngayban.Format = DateTimePickerFormat.Short;
            dtpngayban.Location = new Point(173, 65);
            dtpngayban.Name = "dtpngayban";
            dtpngayban.Size = new Size(300, 31);
            dtpngayban.TabIndex = 15;
            // 
            // mskDienThoai
            // 
            mskDienThoai.Location = new Point(786, 157);
            mskDienThoai.Mask = "(098) 000-0000";
            mskDienThoai.Name = "mskDienThoai";
            mskDienThoai.ReadOnly = true;
            mskDienThoai.Size = new Size(253, 31);
            mskDienThoai.TabIndex = 14;
            // 
            // dgvHoadon
            // 
            dgvHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoadon.Location = new Point(6, 43);
            dgvHoadon.Name = "dgvHoadon";
            dgvHoadon.RowHeadersWidth = 62;
            dgvHoadon.RowTemplate.Height = 33;
            dgvHoadon.Size = new Size(1066, 265);
            dgvHoadon.TabIndex = 70;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(786, 113);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.ReadOnly = true;
            txtDiachi.Size = new Size(253, 31);
            txtDiachi.TabIndex = 13;
            // 
            // txttenKhachhang
            // 
            txttenKhachhang.Location = new Point(786, 65);
            txttenKhachhang.Name = "txttenKhachhang";
            txttenKhachhang.ReadOnly = true;
            txttenKhachhang.Size = new Size(253, 31);
            txttenKhachhang.TabIndex = 12;
            // 
            // txttennhanvien
            // 
            txttennhanvien.Location = new Point(173, 150);
            txttennhanvien.Name = "txttennhanvien";
            txttennhanvien.ReadOnly = true;
            txttennhanvien.Size = new Size(300, 31);
            txttennhanvien.TabIndex = 11;
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(173, 27);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.ReadOnly = true;
            txtmahoadon.Size = new Size(300, 31);
            txtmahoadon.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(411, 0);
            label2.Name = "label2";
            label2.Size = new Size(402, 50);
            label2.TabIndex = 78;
            label2.Text = "Thông tin hóa đơn";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.IndianRed;
            label17.Location = new Point(45, 332);
            label17.Name = "label17";
            label17.Size = new Size(230, 25);
            label17.TabIndex = 71;
            label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(38, 111);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongtien);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(lblBangchu);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dgvHoadon);
            groupBox2.Location = new Point(15, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1088, 403);
            groupBox2.TabIndex = 77;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaKhachHang);
            groupBox1.Controls.Add(dtpngayban);
            groupBox1.Controls.Add(mskDienThoai);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txttenKhachhang);
            groupBox1.Controls.Add(txttennhanvien);
            groupBox1.Controls.Add(txtmahoadon);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 196);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKhachHang
            // 
            cboMaKhachHang.FormattingEnabled = true;
            cboMaKhachHang.Location = new Point(786, 25);
            cboMaKhachHang.Name = "cboMaKhachHang";
            cboMaKhachHang.Size = new Size(253, 33);
            cboMaKhachHang.TabIndex = 16;
            cboMaKhachHang.TextChanged += cboMaKhachHang_TextChanged_1;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(173, 111);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(300, 33);
            cboMaNhanVien.TabIndex = 8;
            cboMaNhanVien.TextChanged += cboMaNhanVien_TextChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(634, 154);
            label10.Name = "label10";
            label10.Size = new Size(93, 25);
            label10.TabIndex = 7;
            label10.Text = "Điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(633, 111);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 6;
            label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(633, 65);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 5;
            label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(634, 27);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 4;
            label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(38, 154);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 3;
            label6.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(38, 65);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Ngày bán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(38, 27);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(56, 669);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(112, 34);
            btnQuayLai.TabIndex = 79;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormHienThiHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1114, 714);
            Controls.Add(btnQuayLai);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHienThiHoaDon";
            Text = "FormHienThiHoaDon";
            Load += FormHienThiHoaDon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvHoadon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTongtien;
        private Label label19;
        private Label lblBangchu;
        private DateTimePicker dtpngayban;
        private MaskedTextBox mskDienThoai;
        private DataGridView dgvHoadon;
        private TextBox txtDiachi;
        private TextBox txttenKhachhang;
        private TextBox txttennhanvien;
        public TextBox txtmahoadon;
        private Label label2;
        private Label label17;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cboMaNhanVien;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btnQuayLai;
        private ComboBox cboMaKhachHang;
    }
}