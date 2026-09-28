namespace WinFormsApp6
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            txtTieuDe = new TextBox();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblMucDoUuTien = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(12, 30);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(61, 20);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Tiêu đề:";
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(94, 27);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(555, 27);
            txtTieuDe.TabIndex = 1;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(12, 63);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(74, 20);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(12, 86);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(637, 183);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblMucDoUuTien
            // 
            lblMucDoUuTien.AutoSize = true;
            lblMucDoUuTien.Location = new Point(12, 272);
            lblMucDoUuTien.Name = "lblMucDoUuTien";
            lblMucDoUuTien.Size = new Size(59, 20);
            lblMucDoUuTien.TabIndex = 4;
            lblMucDoUuTien.Text = "Priority:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Location = new Point(12, 295);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(255, 28);
            cboMucDoUuTien.TabIndex = 5;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.BackColor = SystemColors.ActiveBorder;
            btnLuuGhiChu.Location = new Point(474, 294);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 6;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = false;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeForm);
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            FormClosed += FormGhiChu_FormClosed;
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private TextBox txtTieuDe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private Label lblMucDoUuTien;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}