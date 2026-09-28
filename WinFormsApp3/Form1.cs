using System.Globalization;

namespace WinFormsApp3
{
    public partial class FromNhapDiem : Form
    {
        public FromNhapDiem()
        {
            InitializeComponent();
        }

        private void FromNhapDiem_Load(object sender, EventArgs e)
        {

        }
        private void DangKyEnterChuyenField()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += TextBox_KeyPress;
                }
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true);
                }
            }
        }
        private void txtDiem_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal toan;
            decimal van;
            decimal anh;

            errorProvider1.Clear();

            bool hopLe = true;

            if (!decimal.TryParse(
                txtToan.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out toan) || toan < 0 || toan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(
                txtVan.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out van) || van < 0 || van > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(
                txtAnh.Text,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out anh) || anh < 0 || anh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string dong =
                txtMaHS.Text + " | " +
                txtHoTen.Text + " | " +
                "T:" + toan.ToString("0.0", CultureInfo.InvariantCulture) + " " +
                "V:" + van.ToString("0.0", CultureInfo.InvariantCulture) + " " +
                "A:" + anh.ToString("0.0", CultureInfo.InvariantCulture);

            listBox1.Items.Add(dong);

            XoaTrang();

            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtMaHS.Focus();
        }
        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();
        }
    }
}
