namespace WinFormsApp6
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mởGhiChúToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpCửaSổToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            xếpTầngToolStripMenuItem = new ToolStripMenuItem();
            xếpNgangToolStripMenuItem = new ToolStripMenuItem();
            xếpDọcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mởGhiChúToolStripMenuItem, sắpXếpCửaSổToolStripMenuItem, thoátToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mởGhiChúToolStripMenuItem
            // 
            mởGhiChúToolStripMenuItem.Name = "mởGhiChúToolStripMenuItem";
            mởGhiChúToolStripMenuItem.Size = new Size(224, 26);
            mởGhiChúToolStripMenuItem.Text = "Mở ghi chú mới";
            mởGhiChúToolStripMenuItem.Click += mởGhiChúToolStripMenuItem_Click;
            // 
            // sắpXếpCửaSổToolStripMenuItem
            // 
            sắpXếpCửaSổToolStripMenuItem.Name = "sắpXếpCửaSổToolStripMenuItem";
            sắpXếpCửaSổToolStripMenuItem.Size = new Size(224, 26);
            sắpXếpCửaSổToolStripMenuItem.Text = "Sắp xếp cửa sổ";
            sắpXếpCửaSổToolStripMenuItem.Click += sắpXếpCửaSổToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xếpTầngToolStripMenuItem, xếpNgangToolStripMenuItem, xếpDọcToolStripMenuItem });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(72, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ ";
            // 
            // xếpTầngToolStripMenuItem
            // 
            xếpTầngToolStripMenuItem.Name = "xếpTầngToolStripMenuItem";
            xếpTầngToolStripMenuItem.Size = new Size(224, 26);
            xếpTầngToolStripMenuItem.Text = "Xếp tầng";
            xếpTầngToolStripMenuItem.Click += xếpTầngToolStripMenuItem_Click;
            // 
            // xếpNgangToolStripMenuItem
            // 
            xếpNgangToolStripMenuItem.Name = "xếpNgangToolStripMenuItem";
            xếpNgangToolStripMenuItem.Size = new Size(224, 26);
            xếpNgangToolStripMenuItem.Text = "Xếp ngang ";
            xếpNgangToolStripMenuItem.Click += xếpNgangToolStripMenuItem_Click;
            // 
            // xếpDọcToolStripMenuItem
            // 
            xếpDọcToolStripMenuItem.Name = "xếpDọcToolStripMenuItem";
            xếpDọcToolStripMenuItem.Size = new Size(224, 26);
            xếpDọcToolStripMenuItem.Text = "Xếp dọc";
            xếpDọcToolStripMenuItem.Click += xếpDọcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoGhiChu });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(145, 20);
            lblSoGhiChu.Text = "Số ghi chú đang mở:";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mởGhiChúToolStripMenuItem;
        private ToolStripMenuItem sắpXếpCửaSổToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem xếpTầngToolStripMenuItem;
        private ToolStripMenuItem xếpNgangToolStripMenuItem;
        private ToolStripMenuItem xếpDọcToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoGhiChu;
    }
}
