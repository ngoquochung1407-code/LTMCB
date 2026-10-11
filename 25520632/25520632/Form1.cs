namespace _25520632
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar =
               !txtPass.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form2 f = new Form2();
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DeepSkyBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DodgerBlue;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tài khoản demo:\n\nUsername: admin\nPassword: 123",
                "Quên mật khẩu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
