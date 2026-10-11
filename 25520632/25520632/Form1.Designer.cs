namespace _25520632
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnEye = new Button();
            btnForgot = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 70);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 144);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(252, 141);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nhập tài khoản";
            txtUser.Size = new Size(346, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(252, 214);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Nhập mật khẩu";
            txtPass.Size = new Size(346, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 217);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(373, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnEye
            // 
            btnEye.Location = new Point(604, 214);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(32, 27);
            btnEye.TabIndex = 6;
            btnEye.Text = "👁";
            btnEye.UseVisualStyleBackColor = true;
            btnEye.Click += btnEye_Click;
            // 
            // btnForgot
            // 
            btnForgot.Location = new Point(356, 276);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(124, 26);
            btnForgot.TabIndex = 7;
            btnForgot.Text = "Quên mật khẩu";
            btnForgot.UseVisualStyleBackColor = true;
            btnForgot.Click += btnForgot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForgot);
            Controls.Add(btnEye);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label3;
        private Button btnLogin;
        private Button btnEye;
        private Button btnForgot;
    }
}
