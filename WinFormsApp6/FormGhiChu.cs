using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class FormGhiChu : Form
    {
        public FormGhiChu()
        {
            InitializeComponent();

            this.KeyPreview = true;

            cboMucDoUuTien.Items.Add("Thấp");
            cboMucDoUuTien.Items.Add("Trung bình");
            cboMucDoUuTien.Items.Add("Cao");

            cboMucDoUuTien.SelectedIndex = 0;
        }

        private void FormGhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (txtNoiDung.Modified)
                {
                    DialogResult kq = MessageBox.Show(
                        "Nội dung đã thay đổi. Bạn có muốn đóng ghi chú không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (kq == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.TextLength >= 500 &&
                txtNoiDung.SelectionLength == 0 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            if (txtTieuDe.Text.Trim() == "")
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống!");

                txtTieuDe.BackColor = Color.MistyRose;

                return;
            }

            if (txtTieuDe.Text.Trim().Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề tối đa 50 ký tự!");

                txtTieuDe.BackColor = Color.MistyRose;

                return;
            }

            errorProvider1.SetError(txtTieuDe, "");
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text;

            txtNoiDung.Modified = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
