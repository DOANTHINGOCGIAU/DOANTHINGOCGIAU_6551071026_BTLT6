using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }
        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            lstGhe.MultiColumn = true;
            lstGhe.ColumnWidth = 45;

            lstGhe.Items.Add("A1");
            lstGhe.Items.Add("B1");
            lstGhe.Items.Add("C1");

            lstGhe.Items.Add("A2");
            lstGhe.Items.Add("B2");
            lstGhe.Items.Add("C2");

            lstGhe.Items.Add("A3");
            lstGhe.Items.Add("B3");
            lstGhe.Items.Add("C3");

            lstGhe.Items.Add("A4");
            lstGhe.Items.Add("B4");
            lstGhe.Items.Add("C4");

            lstGhe.Items.Add("A5");
            lstGhe.Items.Add("B5");
            lstGhe.Items.Add("C5");

            if (gheHienTai != "")
            {
                int viTri = lstGhe.Items.IndexOf(gheHienTai);

                if (viTri != -1)
                {
                    lstGhe.SelectedIndex = viTri;
                }
            }
        }

        private void FormChonGhe_Load(object sender, EventArgs e)
        {

        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedIndex != -1)
            {
                lblGheDaChon.Text =
                    "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn:";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
    }
