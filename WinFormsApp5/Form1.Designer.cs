namespace WinFormsApp5
{
    partial class FormBanVe
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
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            lblSuatChieu = new Label();
            txtGheDaChon = new TextBox();
            lblGheChon = new Label();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(12, 9);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(77, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(12, 41);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(236, 27);
            txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(12, 80);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(45, 20);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(12, 103);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(236, 28);
            cboPhim.TabIndex = 3;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(12, 170);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(236, 28);
            cboSuatChieu.TabIndex = 5;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(12, 147);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(80, 20);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(12, 240);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(236, 27);
            txtGheDaChon.TabIndex = 7;
            // 
            // lblGheChon
            // 
            lblGheChon.AutoSize = true;
            lblGheChon.Location = new Point(12, 217);
            lblGheChon.Name = "lblGheChon";
            lblGheChon.Size = new Size(95, 20);
            lblGheChon.TabIndex = 6;
            lblGheChon.Text = "Ghế đã chọn:";
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(137, 332);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(94, 29);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(260, 332);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click_1;
            btnDatVe.MouseCaptureChanged += btnDatVe_MouseCaptureChanged;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(377, 332);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(lblGheChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(lblPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblTenKhach);
            Name = "FormBanVe";
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private Label lblSuatChieu;
        private TextBox txtGheDaChon;
        private Label lblGheChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
