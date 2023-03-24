//namespace WindowsFormsAppNhom
//{
//    partial class dangNhap
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // dangNhap
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Name = "dangNhap";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "dangNhap";
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}
namespace WindowsFormsAppNhom
{
    partial class dangNhap
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
            this.lblDKLTK = new System.Windows.Forms.Label();
            this.lblDNTDN = new System.Windows.Forms.Label();
            this.lblDNMK = new System.Windows.Forms.Label();
            this.cbDNLTK = new System.Windows.Forms.ComboBox();
            this.txtDNTenDN = new System.Windows.Forms.TextBox();
            this.txtDNMK = new System.Windows.Forms.TextBox();
            this.btnDNMK = new System.Windows.Forms.Button();
            this.btDNThoat = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDKLTK
            // 
            this.lblDKLTK.AutoSize = true;
            this.lblDKLTK.Location = new System.Drawing.Point(21, 36);
            this.lblDKLTK.Name = "lblDKLTK";
            this.lblDKLTK.Size = new System.Drawing.Size(93, 16);
            this.lblDKLTK.TabIndex = 0;
            this.lblDKLTK.Text = "Loại tài khoản ";
            // 
            // lblDNTDN
            // 
            this.lblDNTDN.AutoSize = true;
            this.lblDNTDN.Location = new System.Drawing.Point(21, 80);
            this.lblDNTDN.Name = "lblDNTDN";
            this.lblDNTDN.Size = new System.Drawing.Size(98, 16);
            this.lblDNTDN.TabIndex = 1;
            this.lblDNTDN.Text = "Tên đăng nhập";
            // 
            // lblDNMK
            // 
            this.lblDNMK.AutoSize = true;
            this.lblDNMK.Location = new System.Drawing.Point(21, 124);
            this.lblDNMK.Name = "lblDNMK";
            this.lblDNMK.Size = new System.Drawing.Size(64, 16);
            this.lblDNMK.TabIndex = 2;
            this.lblDNMK.Text = "Mật khẩu ";
            // 
            // cbDNLTK
            // 
            this.cbDNLTK.FormattingEnabled = true;
            this.cbDNLTK.Items.AddRange(new object[] {
            "QuanLy",
            "NhanVien",
            "KhachHang"});
            this.cbDNLTK.Location = new System.Drawing.Point(134, 33);
            this.cbDNLTK.Name = "cbDNLTK";
            this.cbDNLTK.Size = new System.Drawing.Size(289, 24);
            this.cbDNLTK.TabIndex = 3;
            // 
            // txtDNTenDN
            // 
            this.txtDNTenDN.Location = new System.Drawing.Point(134, 74);
            this.txtDNTenDN.Name = "txtDNTenDN";
            this.txtDNTenDN.Size = new System.Drawing.Size(289, 22);
            this.txtDNTenDN.TabIndex = 4;
            // 
            // txtDNMK
            // 
            this.txtDNMK.Location = new System.Drawing.Point(134, 118);
            this.txtDNMK.Name = "txtDNMK";
            this.txtDNMK.PasswordChar = '*';
            this.txtDNMK.Size = new System.Drawing.Size(289, 22);
            this.txtDNMK.TabIndex = 5;
            // 
            // btnDNMK
            // 
            this.btnDNMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDNMK.Location = new System.Drawing.Point(67, 192);
            this.btnDNMK.Name = "btnDNMK";
            this.btnDNMK.Size = new System.Drawing.Size(96, 47);
            this.btnDNMK.TabIndex = 6;
            this.btnDNMK.Text = "Đăng nhập";
            this.btnDNMK.UseVisualStyleBackColor = false;
            this.btnDNMK.Click += new System.EventHandler(this.btnDNMK_Click);
            // 
            // btDNThoat
            // 
            this.btDNThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDNThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDNThoat.Location = new System.Drawing.Point(303, 192);
            this.btDNThoat.Name = "btDNThoat";
            this.btDNThoat.Size = new System.Drawing.Size(106, 47);
            this.btDNThoat.TabIndex = 7;
            this.btDNThoat.Text = "Thoát ";
            this.btDNThoat.UseVisualStyleBackColor = false;
            this.btDNThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(134, 157);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(133, 20);
            this.cbHienMK.TabIndex = 10;
            this.cbHienMK.Text = "Hiển thị mật khẩu ";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.ChkShow_CheckedChanged);
            // 
            // dangNhap
            // 
            this.AcceptButton = this.btnDNMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btDNThoat;
            this.ClientSize = new System.Drawing.Size(483, 264);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btDNThoat);
            this.Controls.Add(this.btnDNMK);
            this.Controls.Add(this.txtDNMK);
            this.Controls.Add(this.txtDNTenDN);
            this.Controls.Add(this.cbDNLTK);
            this.Controls.Add(this.lblDNMK);
            this.Controls.Add(this.lblDNTDN);
            this.Controls.Add(this.lblDKLTK);
            this.Name = "dangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDKLTK;
        private System.Windows.Forms.Label lblDNTDN;
        private System.Windows.Forms.Label lblDNMK;
        private System.Windows.Forms.ComboBox cbDNLTK;
        private System.Windows.Forms.TextBox txtDNTenDN;
        private System.Windows.Forms.TextBox txtDNMK;
        private System.Windows.Forms.Button btnDNMK;
        private System.Windows.Forms.Button btDNThoat;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}