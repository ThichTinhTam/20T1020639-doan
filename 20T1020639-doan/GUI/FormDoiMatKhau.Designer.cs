namespace _20T1020639_doan.GUI
{
    partial class FormDoiMatKhau
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btndoimatkhau = new Button();
            txtPass = new TextBox();
            txtenterpassword = new TextBox();
            txtID = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(146, 21);
            label1.Name = "label1";
            label1.Size = new Size(271, 44);
            label1.TabIndex = 0;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(30, 80);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(30, 138);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(30, 198);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Password new";
            // 
            // btndoimatkhau
            // 
            btndoimatkhau.BackColor = Color.BlanchedAlmond;
            btndoimatkhau.ForeColor = SystemColors.ActiveCaptionText;
            btndoimatkhau.Image = Properties.Resources.Button_Refresh_icon;
            btndoimatkhau.ImageAlign = ContentAlignment.MiddleLeft;
            btndoimatkhau.Location = new Point(303, 255);
            btndoimatkhau.Margin = new Padding(3, 2, 3, 2);
            btndoimatkhau.Name = "btndoimatkhau";
            btndoimatkhau.Size = new Size(194, 42);
            btndoimatkhau.TabIndex = 5;
            btndoimatkhau.Text = "&Đổi mật khẩu";
            btndoimatkhau.UseVisualStyleBackColor = false;
            btndoimatkhau.Click += btndoimatkhau_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(264, 133);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(251, 34);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // txtenterpassword
            // 
            txtenterpassword.Location = new Point(264, 192);
            txtenterpassword.Margin = new Padding(3, 2, 3, 2);
            txtenterpassword.Name = "txtenterpassword";
            txtenterpassword.Size = new Size(251, 34);
            txtenterpassword.TabIndex = 7;
            txtenterpassword.UseSystemPasswordChar = true;
            txtenterpassword.KeyPress += txtenterpassword_KeyPress;
            // 
            // txtID
            // 
            txtID.Location = new Point(264, 80);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(251, 34);
            txtID.TabIndex = 8;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.logout_66_321;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(50, 255);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 42);
            button1.TabIndex = 9;
            button1.Text = "&Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(585, 324);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(txtenterpassword);
            Controls.Add(txtPass);
            Controls.Add(btndoimatkhau);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMatKhau";
            Text = "FormDoiMatKhau";
            Load += FormDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btndoimatkhau;
        private TextBox txtPass;
        private TextBox txtenterpassword;
        private TextBox txtID;
        private Button button1;
    }
}