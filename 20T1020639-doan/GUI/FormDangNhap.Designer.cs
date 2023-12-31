namespace _20T1020639_doan
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            btnDn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDn
            // 
            btnDn.BackColor = SystemColors.ControlDark;
            btnDn.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDn.Location = new Point(331, 469);
            btnDn.Name = "btnDn";
            btnDn.Size = new Size(206, 46);
            btnDn.TabIndex = 0;
            btnDn.Text = "Đăng Nhập";
            btnDn.UseVisualStyleBackColor = false;
            btnDn.Click += btnDn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1165, 767);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(331, 84);
            label1.Name = "label1";
            label1.Size = new Size(443, 89);
            label1.TabIndex = 2;
            label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(293, 221);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(293, 335);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.ControlDark;
            txtUser.Location = new Point(483, 221);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(306, 31);
            txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ControlDark;
            txtPass.Location = new Point(483, 338);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(306, 31);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Image = Properties.Resources.logout_66_321;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(583, 469);
            button2.Name = "button2";
            button2.Size = new Size(206, 46);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(249, 681);
            label4.Name = "label4";
            label4.Size = new Size(255, 26);
            label4.TabIndex = 9;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(596, 678);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 761);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDn);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button2;
        private Label label4;
        private Button button1;
    }
}