namespace WindowsFormsAppNhom
{
    partial class muaSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(muaSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMspAnh = new System.Windows.Forms.PictureBox();
            this.lblMSPTen = new System.Windows.Forms.Label();
            this.blbMSPGia = new System.Windows.Forms.Label();
            this.bntMSPMua = new System.Windows.Forms.Button();
            this.txtMSPViTri = new System.Windows.Forms.TextBox();
            this.lblMSPVanChuyen = new System.Windows.Forms.Label();
            this.lblMSPDaBan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMspAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pbMspAnh);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 288);
            this.panel1.TabIndex = 0;
            // 
            // pbMspAnh
            // 
            this.pbMspAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMspAnh.Image = ((System.Drawing.Image)(resources.GetObject("pbMspAnh.Image")));
            this.pbMspAnh.Location = new System.Drawing.Point(0, 0);
            this.pbMspAnh.Name = "pbMspAnh";
            this.pbMspAnh.Size = new System.Drawing.Size(267, 288);
            this.pbMspAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMspAnh.TabIndex = 7;
            this.pbMspAnh.TabStop = false;
            this.pbMspAnh.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMSPTen
            // 
            this.lblMSPTen.AutoSize = true;
            this.lblMSPTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSPTen.Location = new System.Drawing.Point(394, 43);
            this.lblMSPTen.Name = "lblMSPTen";
            this.lblMSPTen.Size = new System.Drawing.Size(250, 29);
            this.lblMSPTen.TabIndex = 1;
            this.lblMSPTen.Text = "Giá để treo tai nghe ";
            // 
            // blbMSPGia
            // 
            this.blbMSPGia.AutoSize = true;
            this.blbMSPGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbMSPGia.Location = new System.Drawing.Point(395, 160);
            this.blbMSPGia.Name = "blbMSPGia";
            this.blbMSPGia.Size = new System.Drawing.Size(198, 20);
            this.blbMSPGia.TabIndex = 2;
            this.blbMSPGia.Text = "Giá sản phẩm: 40.000vnd";
            // 
            // bntMSPMua
            // 
            this.bntMSPMua.Location = new System.Drawing.Point(504, 288);
            this.bntMSPMua.Name = "bntMSPMua";
            this.bntMSPMua.Size = new System.Drawing.Size(140, 43);
            this.bntMSPMua.TabIndex = 3;
            this.bntMSPMua.Text = "Mua sản phẩm";
            this.bntMSPMua.UseVisualStyleBackColor = true;
            // 
            // txtMSPViTri
            // 
            this.txtMSPViTri.Location = new System.Drawing.Point(511, 220);
            this.txtMSPViTri.Name = "txtMSPViTri";
            this.txtMSPViTri.Size = new System.Drawing.Size(100, 22);
            this.txtMSPViTri.TabIndex = 5;
            // 
            // lblMSPVanChuyen
            // 
            this.lblMSPVanChuyen.AutoSize = true;
            this.lblMSPVanChuyen.Location = new System.Drawing.Point(396, 226);
            this.lblMSPVanChuyen.Name = "lblMSPVanChuyen";
            this.lblMSPVanChuyen.Size = new System.Drawing.Size(103, 16);
            this.lblMSPVanChuyen.TabIndex = 6;
            this.lblMSPVanChuyen.Text = "Vận chuyển đến";
            // 
            // lblMSPDaBan
            // 
            this.lblMSPDaBan.AutoSize = true;
            this.lblMSPDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSPDaBan.Location = new System.Drawing.Point(399, 101);
            this.lblMSPDaBan.Name = "lblMSPDaBan";
            this.lblMSPDaBan.Size = new System.Drawing.Size(89, 20);
            this.lblMSPDaBan.TabIndex = 7;
            this.lblMSPDaBan.Text = "Đã bán: 1k";
            // 
            // muaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 377);
            this.Controls.Add(this.lblMSPDaBan);
            this.Controls.Add(this.lblMSPVanChuyen);
            this.Controls.Add(this.txtMSPViTri);
            this.Controls.Add(this.bntMSPMua);
            this.Controls.Add(this.blbMSPGia);
            this.Controls.Add(this.lblMSPTen);
            this.Controls.Add(this.panel1);
            this.Name = "muaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua sản phẩm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMspAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMSPTen;
        private System.Windows.Forms.Label blbMSPGia;
        private System.Windows.Forms.Button bntMSPMua;
        private System.Windows.Forms.TextBox txtMSPViTri;
        private System.Windows.Forms.Label lblMSPVanChuyen;
        private System.Windows.Forms.PictureBox pbMspAnh;
        private System.Windows.Forms.Label lblMSPDaBan;
    }
}