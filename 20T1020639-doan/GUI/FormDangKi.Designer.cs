namespace _20T1020639_doan.GUI
{
    partial class FormDangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKi));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkAdmin = new CheckBox();
            txtID = new TextBox();
            txtMK = new TextBox();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSalmon;
            button1.Location = new Point(376, 347);
            button1.Name = "button1";
            button1.Size = new Size(207, 57);
            button1.TabIndex = 0;
            button1.Text = "Đăng kí";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("Showcard Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.LightSalmon;
            button2.Location = new Point(671, 551);
            button2.Name = "button2";
            button2.Size = new Size(196, 50);
            button2.TabIndex = 1;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Showcard Gothic", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(437, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 65);
            label1.TabIndex = 2;
            label1.Text = "Đăng kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Stout", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(261, 137);
            label2.Name = "label2";
            label2.Size = new Size(216, 27);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Stout", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(261, 219);
            label3.Name = "label3";
            label3.Size = new Size(208, 27);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(559, 276);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(88, 29);
            chkAdmin.TabIndex = 5;
            chkAdmin.Text = "admin";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(528, 133);
            txtID.Name = "txtID";
            txtID.Size = new Size(258, 31);
            txtID.TabIndex = 6;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(528, 215);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(258, 31);
            txtMK.TabIndex = 7;
            txtMK.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Image = Properties.Resources.logout_66_321;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(650, 348);
            button3.Name = "button3";
            button3.Size = new Size(206, 56);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(200, 551);
            label4.Name = "label4";
            label4.Size = new Size(447, 50);
            label4.TabIndex = 10;
            label4.Text = "Bạn đã có tài khoản?";
            // 
            // FormDangKi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1137, 650);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(txtMK);
            Controls.Add(txtID);
            Controls.Add(chkAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormDangKi";
            Text = "FormDangKi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkAdmin;
        private TextBox txtID;
        private TextBox txtMK;
        private Button button3;
        private Label label4;
    }
}