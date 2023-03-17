namespace WindowsFormsAppNhom
{
    partial class khachHang
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
            this.tpKhachHangXemSP = new System.Windows.Forms.TabPage();
            this.tpKhachHangTKCN = new System.Windows.Forms.TabPage();
            this.tpKhachHangMSP = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKhachHangXemSP);
            this.tabControl1.Controls.Add(this.tpKhachHangTKCN);
            this.tabControl1.Controls.Add(this.tpKhachHangMSP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpKhachHangXemSP
            // 
            this.tpKhachHangXemSP.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHangXemSP.Name = "tpKhachHangXemSP";
            this.tpKhachHangXemSP.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhachHangXemSP.Size = new System.Drawing.Size(792, 421);
            this.tpKhachHangXemSP.TabIndex = 0;
            this.tpKhachHangXemSP.Text = "Xem sản phẩm";
            this.tpKhachHangXemSP.UseVisualStyleBackColor = true;
            // 
            // tpKhachHangTKCN
            // 
            this.tpKhachHangTKCN.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHangTKCN.Name = "tpKhachHangTKCN";
            this.tpKhachHangTKCN.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhachHangTKCN.Size = new System.Drawing.Size(792, 421);
            this.tpKhachHangTKCN.TabIndex = 1;
            this.tpKhachHangTKCN.Text = "Quản lý tài khoản cá nhân";
            this.tpKhachHangTKCN.UseVisualStyleBackColor = true;
            // 
            // tpKhachHangMSP
            // 
            this.tpKhachHangMSP.Location = new System.Drawing.Point(4, 25);
            this.tpKhachHangMSP.Name = "tpKhachHangMSP";
            this.tpKhachHangMSP.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhachHangMSP.Size = new System.Drawing.Size(792, 421);
            this.tpKhachHangMSP.TabIndex = 2;
            this.tpKhachHangMSP.Text = "Mua sản phẩm";
            this.tpKhachHangMSP.UseVisualStyleBackColor = true;
            // 
            // khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "khachHang";
            this.Text = "khachHang";
            this.Load += new System.EventHandler(this.khachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKhachHangXemSP;
        private System.Windows.Forms.TabPage tpKhachHangTKCN;
        private System.Windows.Forms.TabPage tpKhachHangMSP;
    }
}