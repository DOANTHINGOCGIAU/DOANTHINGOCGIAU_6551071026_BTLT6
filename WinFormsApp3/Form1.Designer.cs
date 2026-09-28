namespace WinFormsApp3
{
    partial class FromNhapDiem
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
            components = new System.ComponentModel.Container();
            lblMaHS = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            txtToan = new TextBox();
            lblToan = new Label();
            txtVan = new TextBox();
            lblVan = new Label();
            txtAnh = new TextBox();
            lblAnh = new Label();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            listBox1 = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(12, 9);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(53, 20);
            lblMaHS.TabIndex = 0;
            lblMaHS.Text = "Mã HS";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(12, 32);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(80, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(189, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(80, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(190, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // txtToan
            // 
            txtToan.Location = new Point(377, 32);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(80, 27);
            txtToan.TabIndex = 2;
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Location = new Point(378, 9);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(81, 20);
            lblToan.TabIndex = 4;
            lblToan.Text = "Điểm Toán";
            // 
            // txtVan
            // 
            txtVan.Location = new Point(549, 32);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(80, 27);
            txtVan.TabIndex = 3;
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Location = new Point(550, 9);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(73, 20);
            lblVan.TabIndex = 8;
            lblVan.Text = "Điểm Văn";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(698, 32);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(80, 27);
            txtAnh.TabIndex = 4;
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(699, 9);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(75, 20);
            lblAnh.TabIndex = 6;
            lblAnh.Text = "Điểm Anh";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.Location = new Point(12, 84);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ActiveBorder;
            btnXoaTrang.Location = new Point(132, 84);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(123, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 304);
            listBox1.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FromNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtVan);
            Controls.Add(lblVan);
            Controls.Add(txtAnh);
            Controls.Add(lblAnh);
            Controls.Add(txtToan);
            Controls.Add(lblToan);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(lblMaHS);
            Name = "FromNhapDiem";
            Text = "Nhập điểm học sinh";
            Load += FromNhapDiem_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private TextBox txtToan;
        private Label lblToan;
        private TextBox txtVan;
        private Label lblVan;
        private TextBox txtAnh;
        private Label lblAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox listBox1;
        private ErrorProvider errorProvider1;
    }
}
