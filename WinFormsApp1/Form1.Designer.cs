namespace WinFormsApp1
{
    partial class Form1
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
            lblDangKy = new Label();
            lblNhapThongTin = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMK = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDangKy.Location = new Point(12, 9);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(279, 35);
            lblDangKy.TabIndex = 0;
            lblDangKy.Text = "Đăng ký tài khoản mới";
            // 
            // lblNhapThongTin
            // 
            lblNhapThongTin.AutoSize = true;
            lblNhapThongTin.Location = new Point(12, 55);
            lblNhapThongTin.Name = "lblNhapThongTin";
            lblNhapThongTin.Size = new Size(214, 20);
            lblNhapThongTin.TabIndex = 1;
            lblNhapThongTin.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(121, 98);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(80, 143);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(121, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(121, 235);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Location = new Point(57, 282);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(134, 20);
            lblXacNhanMK.TabIndex = 6;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DodgerBlue;
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(217, 338);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(138, 36);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnHuy.Location = new Point(361, 338);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 36);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(197, 98);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(389, 27);
            txtHoTen.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(197, 140);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(389, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(197, 235);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(389, 27);
            txtMatKhau.TabIndex = 12;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(197, 279);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(389, 27);
            txtXacNhanMK.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(lblXacNhanMK);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(lblNhapThongTin);
            Controls.Add(lblDangKy);
            Name = "Form1";
            Text = "Đăng ký tài khoản";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangKy;
        private Label lblNhapThongTin;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblMatKhau;
        private Label lblXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private ErrorProvider errorProvider1;
    }
}
