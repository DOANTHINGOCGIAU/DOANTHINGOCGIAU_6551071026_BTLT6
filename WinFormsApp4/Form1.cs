namespace WinFormsApp4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;
        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" ||
                txtSDT.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = txtTen.Text + " - " + txtSDT.Text;

            if (_indexDangSua == -1)
            {
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _indexDangSua = -1;
            }

            txtTen.Clear();
            txtSDT.Clear();
            lstLienHe.ClearSelected();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();
            string ten = lienHe.Split('-')[0].Trim();

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtTen.Clear();
                txtSDT.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            string[] thongTin = lienHe.Split('-');

            txtTen.Text = thongTin[0].Trim();
            txtSDT.Text = thongTin[1].Trim();

            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTen.Text.Trim() != "" ||
                txtSDT.Text.Trim() != "")
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (ketQua == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (ketQua == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            }
    }
}
