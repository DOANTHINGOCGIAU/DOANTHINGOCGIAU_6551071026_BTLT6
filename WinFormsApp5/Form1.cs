namespace WinFormsApp5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
            cboPhim.Items.Add("Mai");
            cboPhim.Items.Add("Lật Mặt 7");
            cboPhim.Items.Add("Doraemon");
            cboPhim.Items.Add("Avengers");

            cboSuatChieu.Items.Add("09:00");
            cboSuatChieu.Items.Add("13:00");
            cboSuatChieu.Items.Add("16:00");
            cboSuatChieu.Items.Add("19:00");
            cboSuatChieu.Items.Add("21:00");
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {

        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void btnDatVe_Click_1(object sender, EventArgs e)
        {

            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cboSuatChieu.Focus();
                return;
            }

            if (txtGheDaChon.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n" +
                "Tên khách: " + txtTenKhach.Text + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Suất chiếu: " + cboSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
        }
    }
}
