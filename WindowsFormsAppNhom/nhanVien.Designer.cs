namespace WindowsFormsAppNhom
{
    partial class nhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhanVienBSP = new System.Windows.Forms.TabPage();
            this.tpNhanVienQLHD = new System.Windows.Forms.TabPage();
            this.tpNhanVienQLSP = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhanVienBSP);
            this.tabControl1.Controls.Add(this.tpNhanVienQLHD);
            this.tabControl1.Controls.Add(this.tpNhanVienQLSP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNhanVienBSP
            // 
            this.tpNhanVienBSP.Location = new System.Drawing.Point(4, 25);
            this.tpNhanVienBSP.Name = "tpNhanVienBSP";
            this.tpNhanVienBSP.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVienBSP.Size = new System.Drawing.Size(792, 421);
            this.tpNhanVienBSP.TabIndex = 0;
            this.tpNhanVienBSP.Text = "Bán sản phẩm";
            this.tpNhanVienBSP.UseVisualStyleBackColor = true;
            // 
            // tpNhanVienQLHD
            // 
            this.tpNhanVienQLHD.Location = new System.Drawing.Point(4, 25);
            this.tpNhanVienQLHD.Name = "tpNhanVienQLHD";
            this.tpNhanVienQLHD.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVienQLHD.Size = new System.Drawing.Size(792, 421);
            this.tpNhanVienQLHD.TabIndex = 1;
            this.tpNhanVienQLHD.Text = "Quản lý hóa đơn";
            this.tpNhanVienQLHD.UseVisualStyleBackColor = true;
            // 
            // tpNhanVienQLSP
            // 
            this.tpNhanVienQLSP.Location = new System.Drawing.Point(4, 25);
            this.tpNhanVienQLSP.Name = "tpNhanVienQLSP";
            this.tpNhanVienQLSP.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanVienQLSP.Size = new System.Drawing.Size(792, 421);
            this.tpNhanVienQLSP.TabIndex = 2;
            this.tpNhanVienQLSP.Text = "Quản lý sản phẩm";
            this.tpNhanVienQLSP.UseVisualStyleBackColor = true;
            // 
            // nhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "nhanVien";
            this.Text = "nhanVien";
            this.Load += new System.EventHandler(this.nhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhanVienBSP;
        private System.Windows.Forms.TabPage tpNhanVienQLHD;
        private System.Windows.Forms.TabPage tpNhanVienQLSP;
    }
}