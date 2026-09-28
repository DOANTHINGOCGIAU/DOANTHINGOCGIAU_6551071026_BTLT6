namespace WinFormsApp2
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            txtNgayNhan = new TextBox();
            lblNgayNhan = new Label();
            txtNgayTra = new TextBox();
            lblNgayTra = new Label();
            txtSoNguoiLon = new TextBox();
            lblSoNguoiLon = new Label();
            txtSoTreEm = new TextBox();
            lblSoTreEm = new Label();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(121, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(121, 32);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(445, 27);
            txtHoTen.TabIndex = 1;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += txtHoTen_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(121, 92);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(445, 27);
            txtCCCD.TabIndex = 3;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += txtCCCD_Validated;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(121, 69);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(68, 20);
            lblCCCD.TabIndex = 2;
            lblCCCD.Text = "Số CCCD";
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(121, 152);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(445, 27);
            txtNgayNhan.TabIndex = 5;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += txtNgayNhan_Validated;
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(121, 129);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(117, 20);
            lblNgayNhan.TabIndex = 4;
            lblNgayNhan.Text = "Ngày đặt phòng";
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(121, 216);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(445, 27);
            txtNgayTra.TabIndex = 7;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += txtNgayTra_Validated;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(121, 193);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(113, 20);
            lblNgayTra.TabIndex = 6;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(121, 273);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(445, 27);
            txtSoNguoiLon.TabIndex = 9;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += txtSoNguoiLon_Validated;
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(121, 250);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(94, 20);
            lblSoNguoiLon.TabIndex = 8;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(121, 332);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(445, 27);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += txtSoTreEm_Validated;
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(121, 309);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(73, 20);
            lblSoTreEm.TabIndex = 10;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.Highlight;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(121, 387);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(445, 29);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
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
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(lblNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Đặt phòng khách sạn";
            FormClosing += Form1_FormClosing_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private Label lblCCCD;
        private TextBox txtNgayNhan;
        private Label lblNgayNhan;
        private TextBox txtNgayTra;
        private Label lblNgayTra;
        private TextBox txtSoNguoiLon;
        private Label lblSoNguoiLon;
        private TextBox txtSoTreEm;
        private Label lblSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
