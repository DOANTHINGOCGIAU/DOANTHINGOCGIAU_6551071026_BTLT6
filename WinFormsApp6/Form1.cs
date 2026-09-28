namespace WinFormsApp6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            CapNhatSoGhiChu();
        }
        private void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text =
                "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }
        private void mởGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGhiChu form = new FormGhiChu();

            form.MdiParent = this;

            form.FormClosed += FormGhiChu_FormClosed;

            form.Show();

            CapNhatSoGhiChu();
        }
        private void FormGhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoGhiChu();
        }

        private void sắpXếpCửaSổToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpTầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
