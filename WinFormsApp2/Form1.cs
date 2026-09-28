using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing_1;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.BackColor = Color.Honeydew;
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "CCCD phải có 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
                return;
            }

            for (int i = 0; i < txtCCCD.Text.Length; i++)
            {
                if (txtCCCD.Text[i] < '0' || txtCCCD.Text[i] > '9')
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtCCCD, "CCCD chỉ được chứa chữ số!");
                    txtCCCD.BackColor = Color.MistyRose;
                    return;
                }
            }

            errorProvider1.SetError(txtCCCD, "");
            txtCCCD.BackColor = Color.Honeydew;
        }

        private void txtCCCD_Validated(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Honeydew;
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày phải có dạng dd/MM/yyyy!");
                txtNgayNhan.BackColor = Color.MistyRose;
                return;
            }

            if (ngayNhan < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phòng phải từ hôm nay trở đi!");
                txtNgayNhan.BackColor = Color.MistyRose;
                return;
            }

            errorProvider1.SetError(txtNgayNhan, "");
            txtNgayNhan.BackColor = Color.Honeydew;
        }

        private void txtNgayNhan_Validated(object sender, EventArgs e)
        {
            txtNgayNhan.BackColor = Color.Honeydew;
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            if (!DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày phải có dạng dd/MM/yyyy!");
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Hãy nhập ngày nhận phòng đúng trước!");
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            if (ngayTra <= ngayNhan)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải sau ngày nhận!");
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            errorProvider1.SetError(txtNgayTra, "");
            txtNgayTra.BackColor = Color.Honeydew;
        }

        private void txtNgayTra_Validated(object sender, EventArgs e)
        {
            txtNgayTra.BackColor = Color.Honeydew;
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon) ||
                soNguoiLon < 1 ||
                soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validated(object sender, EventArgs e)
        {
            txtSoNguoiLon.BackColor = Color.Honeydew;
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text, out soTreEm) ||
                soTreEm < 0 ||
                soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validated(object sender, EventArgs e)
        {
            txtSoTreEm.BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan;
            DateTime ngayTra;
            int soNguoiLon;
            int soTreEm;

            DateTime.TryParseExact(
                txtNgayNhan.Text,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan);

            DateTime.TryParseExact(
                txtNgayTra.Text,
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayTra);

            int.TryParse(txtSoNguoiLon.Text, out soNguoiLon);
            int.TryParse(txtSoTreEm.Text, out soTreEm);

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n" +
                "Họ tên: " + txtHoTen.Text + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + soNguoiLon + "\n" +
                "Số trẻ em: " + soTreEm,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}