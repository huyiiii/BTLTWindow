namespace WindowsFormsAppNhom
{
    partial class dkTK
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
            this.lblDK = new System.Windows.Forms.Label();
            this.lblDKHo = new System.Windows.Forms.Label();
            this.lblDKTen = new System.Windows.Forms.Label();
            this.lblDKSDT = new System.Windows.Forms.Label();
            this.lblDKMK = new System.Windows.Forms.Label();
            this.lblDKXN = new System.Windows.Forms.Label();
            this.cbDKHienMK = new System.Windows.Forms.CheckBox();
            this.bntDKDN = new System.Windows.Forms.Button();
            this.bntDKDK = new System.Windows.Forms.Button();
            this.txtDKHo = new System.Windows.Forms.TextBox();
            this.txtDKTen = new System.Windows.Forms.TextBox();
            this.txtDKSDT = new System.Windows.Forms.TextBox();
            this.txtDKMK = new System.Windows.Forms.TextBox();
            this.txtDKXN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDK
            // 
            this.lblDK.AutoSize = true;
            this.lblDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDK.Location = new System.Drawing.Point(32, 40);
            this.lblDK.Name = "lblDK";
            this.lblDK.Size = new System.Drawing.Size(201, 29);
            this.lblDK.TabIndex = 0;
            this.lblDK.Text = "Đăng ký tài khoản";
            // 
            // lblDKHo
            // 
            this.lblDKHo.AutoSize = true;
            this.lblDKHo.Location = new System.Drawing.Point(37, 112);
            this.lblDKHo.Name = "lblDKHo";
            this.lblDKHo.Size = new System.Drawing.Size(25, 16);
            this.lblDKHo.TabIndex = 1;
            this.lblDKHo.Text = "Họ";
            // 
            // lblDKTen
            // 
            this.lblDKTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDKTen.AutoSize = true;
            this.lblDKTen.Location = new System.Drawing.Point(326, 112);
            this.lblDKTen.Name = "lblDKTen";
            this.lblDKTen.Size = new System.Drawing.Size(31, 16);
            this.lblDKTen.TabIndex = 2;
            this.lblDKTen.Text = "Tên";
            // 
            // lblDKSDT
            // 
            this.lblDKSDT.AutoSize = true;
            this.lblDKSDT.Location = new System.Drawing.Point(37, 180);
            this.lblDKSDT.Name = "lblDKSDT";
            this.lblDKSDT.Size = new System.Drawing.Size(34, 16);
            this.lblDKSDT.TabIndex = 3;
            this.lblDKSDT.Text = "SĐT";
            // 
            // lblDKMK
            // 
            this.lblDKMK.AutoSize = true;
            this.lblDKMK.Location = new System.Drawing.Point(37, 253);
            this.lblDKMK.Name = "lblDKMK";
            this.lblDKMK.Size = new System.Drawing.Size(61, 16);
            this.lblDKMK.TabIndex = 4;
            this.lblDKMK.Text = "Mật khẩu";
            // 
            // lblDKXN
            // 
            this.lblDKXN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDKXN.AutoSize = true;
            this.lblDKXN.Location = new System.Drawing.Point(274, 256);
            this.lblDKXN.Name = "lblDKXN";
            this.lblDKXN.Size = new System.Drawing.Size(83, 16);
            this.lblDKXN.TabIndex = 5;
            this.lblDKXN.Text = "Xác nhận mk";
            // 
            // cbDKHienMK
            // 
            this.cbDKHienMK.AutoSize = true;
            this.cbDKHienMK.Location = new System.Drawing.Point(40, 323);
            this.cbDKHienMK.Name = "cbDKHienMK";
            this.cbDKHienMK.Size = new System.Drawing.Size(114, 20);
            this.cbDKHienMK.TabIndex = 7;
            this.cbDKHienMK.Text = "Hiện mật khẩu";
            this.cbDKHienMK.UseVisualStyleBackColor = true;
            this.cbDKHienMK.CheckedChanged += new System.EventHandler(this.cbDKHienMK_CheckedChanged);
            // 
            // bntDKDN
            // 
            this.bntDKDN.Location = new System.Drawing.Point(37, 384);
            this.bntDKDN.Name = "bntDKDN";
            this.bntDKDN.Size = new System.Drawing.Size(117, 23);
            this.bntDKDN.TabIndex = 8;
            this.bntDKDN.Text = "Đăng nhập";
            this.bntDKDN.UseVisualStyleBackColor = true;
            this.bntDKDN.Click += new System.EventHandler(this.bntDKDN_Click);
            // 
            // bntDKDK
            // 
            this.bntDKDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDKDK.Location = new System.Drawing.Point(496, 384);
            this.bntDKDK.Name = "bntDKDK";
            this.bntDKDK.Size = new System.Drawing.Size(117, 23);
            this.bntDKDK.TabIndex = 9;
            this.bntDKDK.Text = "Đăng ký";
            this.bntDKDK.UseVisualStyleBackColor = true;
            this.bntDKDK.Click += new System.EventHandler(this.bntDKDK_Click);
            // 
            // txtDKHo
            // 
            this.txtDKHo.Location = new System.Drawing.Point(88, 112);
            this.txtDKHo.Name = "txtDKHo";
            this.txtDKHo.Size = new System.Drawing.Size(145, 22);
            this.txtDKHo.TabIndex = 10;
            // 
            // txtDKTen
            // 
            this.txtDKTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDKTen.Location = new System.Drawing.Point(382, 111);
            this.txtDKTen.Name = "txtDKTen";
            this.txtDKTen.Size = new System.Drawing.Size(145, 22);
            this.txtDKTen.TabIndex = 11;
            // 
            // txtDKSDT
            // 
            this.txtDKSDT.Location = new System.Drawing.Point(88, 177);
            this.txtDKSDT.Name = "txtDKSDT";
            this.txtDKSDT.Size = new System.Drawing.Size(145, 22);
            this.txtDKSDT.TabIndex = 12;
            // 
            // txtDKMK
            // 
            this.txtDKMK.Location = new System.Drawing.Point(118, 247);
            this.txtDKMK.Name = "txtDKMK";
            this.txtDKMK.PasswordChar = '*';
            this.txtDKMK.Size = new System.Drawing.Size(115, 22);
            this.txtDKMK.TabIndex = 13;
            // 
            // txtDKXN
            // 
            this.txtDKXN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDKXN.Location = new System.Drawing.Point(382, 250);
            this.txtDKXN.Name = "txtDKXN";
            this.txtDKXN.PasswordChar = '*';
            this.txtDKXN.Size = new System.Drawing.Size(145, 22);
            this.txtDKXN.TabIndex = 14;
            // 
            // dkTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 448);
            this.Controls.Add(this.txtDKXN);
            this.Controls.Add(this.txtDKMK);
            this.Controls.Add(this.txtDKSDT);
            this.Controls.Add(this.txtDKTen);
            this.Controls.Add(this.txtDKHo);
            this.Controls.Add(this.bntDKDK);
            this.Controls.Add(this.bntDKDN);
            this.Controls.Add(this.cbDKHienMK);
            this.Controls.Add(this.lblDKXN);
            this.Controls.Add(this.lblDKMK);
            this.Controls.Add(this.lblDKSDT);
            this.Controls.Add(this.lblDKTen);
            this.Controls.Add(this.lblDKHo);
            this.Controls.Add(this.lblDK);
            this.Name = "dkTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dkTK";
            this.Load += new System.EventHandler(this.dkTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDK;
        private System.Windows.Forms.Label lblDKHo;
        private System.Windows.Forms.Label lblDKTen;
        private System.Windows.Forms.Label lblDKSDT;
        private System.Windows.Forms.Label lblDKMK;
        private System.Windows.Forms.Label lblDKXN;
        private System.Windows.Forms.CheckBox cbDKHienMK;
        private System.Windows.Forms.Button bntDKDN;
        private System.Windows.Forms.Button bntDKDK;
        private System.Windows.Forms.TextBox txtDKHo;
        private System.Windows.Forms.TextBox txtDKTen;
        private System.Windows.Forms.TextBox txtDKSDT;
        private System.Windows.Forms.TextBox txtDKMK;
        private System.Windows.Forms.TextBox txtDKXN;
    }
}