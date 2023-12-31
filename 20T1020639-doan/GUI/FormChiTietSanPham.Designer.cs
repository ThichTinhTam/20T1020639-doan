namespace _20T1020639_doan.GUI
{
    partial class FormChiTietSanPham
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            txtmagiay = new TextBox();
            txttengiay = new TextBox();
            txtmaloai = new TextBox();
            txtdongia = new TextBox();
            txtghichu = new TextBox();
            label7 = new Label();
            Ảnh = new Label();
            txtAnh = new TextBox();
            picAnh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(81, 146);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "Mã giày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(80, 210);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 1;
            label2.Text = "Tên giày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(80, 274);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 2;
            label3.Text = "Mã loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(601, 148);
            label5.Name = "label5";
            label5.Size = new Size(100, 29);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(605, 210);
            label6.Name = "label6";
            label6.Size = new Size(96, 29);
            label6.TabIndex = 6;
            label6.Text = "Ghi chú";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.logout_66_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(45, 519);
            button1.Name = "button1";
            button1.Size = new Size(167, 34);
            button1.TabIndex = 7;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtmagiay
            // 
            txtmagiay.Location = new Point(211, 146);
            txtmagiay.Name = "txtmagiay";
            txtmagiay.Size = new Size(211, 31);
            txtmagiay.TabIndex = 8;
            // 
            // txttengiay
            // 
            txttengiay.Location = new Point(211, 210);
            txttengiay.Name = "txttengiay";
            txttengiay.Size = new Size(211, 31);
            txttengiay.TabIndex = 9;
            // 
            // txtmaloai
            // 
            txtmaloai.Location = new Point(211, 268);
            txtmaloai.Name = "txtmaloai";
            txtmaloai.Size = new Size(211, 31);
            txtmaloai.TabIndex = 10;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(755, 144);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(255, 31);
            txtdongia.TabIndex = 12;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(755, 208);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(255, 31);
            txtghichu.TabIndex = 13;
            txtghichu.TextChanged += txtghichu_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(268, 44);
            label7.Name = "label7";
            label7.Size = new Size(610, 68);
            label7.TabIndex = 14;
            label7.Text = "Thông tin sản phẩm";
            label7.Click += label7_Click;
            // 
            // Ảnh
            // 
            Ảnh.AutoSize = true;
            Ảnh.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Ảnh.ForeColor = SystemColors.ActiveCaption;
            Ảnh.Location = new Point(605, 268);
            Ảnh.Name = "Ảnh";
            Ảnh.Size = new Size(56, 29);
            Ảnh.TabIndex = 15;
            Ảnh.Text = "Ảnh";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(755, 268);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(255, 31);
            txtAnh.TabIndex = 16;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(621, 322);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(346, 275);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 41;
            picAnh.TabStop = false;
            // 
            // FormChiTietSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1022, 623);
            Controls.Add(picAnh);
            Controls.Add(txtAnh);
            Controls.Add(Ảnh);
            Controls.Add(label7);
            Controls.Add(txtghichu);
            Controls.Add(txtdongia);
            Controls.Add(txtmaloai);
            Controls.Add(txttengiay);
            Controls.Add(txtmagiay);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChiTietSanPham";
            Text = "FormChiTietSanPham";
            Load += FormChiTietSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox txtmagiay;
        private TextBox txttengiay;
        private TextBox txtmaloai;
        private TextBox txtdongia;
        private TextBox txtghichu;
        private Label label7;
        private Label Ảnh;
        private TextBox txtAnh;
        private PictureBox picAnh;
    }
}