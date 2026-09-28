namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool KiemTraHopLe()
        {
            bool hopLe = true;

            errorProvider1.Clear();

            if (txtHoTen.Text.Trim() == "")
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có ít nhất 3 ký tự!");
                hopLe = false;
            }

            if (txtSDT.Text.Length != 10 || txtSDT.Text[0] != '0')
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!");
                hopLe = false;
            }
            else
            {
                for (int i = 0; i < txtSDT.Text.Length; i++)
                {
                    if (txtSDT.Text[i] < '0' || txtSDT.Text[i] > '9')
                    {
                        errorProvider1.SetError(txtSDT, "Số điện thoại chỉ được chứa chữ số!");
                        hopLe = false;
                        break;
                    }
                }
            }

            int viTriA = txtEmail.Text.IndexOf("@");

            if (viTriA == -1 || txtEmail.Text.IndexOf(".", viTriA) == -1)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng!");
                hopLe = false;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có ít nhất 6 ký tự!");
                hopLe = false;
            }

            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                hopLe = false;
            }

            return hopLe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            Close();
        }
    }
}
