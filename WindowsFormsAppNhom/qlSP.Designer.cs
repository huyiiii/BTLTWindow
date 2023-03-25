namespace WindowsFormsAppNhom
{
    partial class qlSP
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btReload = new System.Windows.Forms.Button();
            this.btTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinkImg = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSP
            // 
            this.dgvSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHH,
            this.maDT,
            this.tenSP,
            this.soLuong,
            this.Column2,
            this.Column3});
            this.dgvSP.Location = new System.Drawing.Point(0, 188);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.Size = new System.Drawing.Size(800, 263);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // maHH
            // 
            this.maHH.DataPropertyName = "maHH";
            this.maHH.HeaderText = "Mã hàng hóa";
            this.maHH.Name = "maHH";
            this.maHH.ReadOnly = true;
            // 
            // maDT
            // 
            this.maDT.DataPropertyName = "maDT";
            this.maDT.HeaderText = "Mã đối tác";
            this.maDT.Name = "maDT";
            this.maDT.ReadOnly = true;
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.Name = "tenSP";
            this.tenSP.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "giaBan";
            this.Column2.HeaderText = "Giá bán";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "linkImg";
            this.Column3.HeaderText = "Link ảnh";
            this.Column3.Name = "Column3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btReload);
            this.splitContainer1.Panel1.Controls.Add(this.btTK);
            this.splitContainer1.Panel1.Controls.Add(this.txtTK);
            this.splitContainer1.Panel1.Controls.Add(this.lbTK);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtLinkImg);
            this.splitContainer1.Panel2.Controls.Add(this.txtGiaBan);
            this.splitContainer1.Panel2.Controls.Add(this.txtSoLuong);
            this.splitContainer1.Panel2.Controls.Add(this.a);
            this.splitContainer1.Panel2.Controls.Add(this.lbMaHang);
            this.splitContainer1.Panel2.Controls.Add(this.lbTenSP);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenSP);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaDT);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaHH);
            this.splitContainer1.Panel2.Controls.Add(this.btXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btSua);
            this.splitContainer1.Panel2.Controls.Add(this.btThem);
            this.splitContainer1.Size = new System.Drawing.Size(796, 191);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(9, 12);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(73, 30);
            this.btReload.TabIndex = 3;
            this.btReload.Text = "Tải lại form";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.qlSP_Load);
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(172, 131);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(75, 23);
            this.btTK.TabIndex = 2;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(12, 105);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(235, 20);
            this.txtTK.TabIndex = 1;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Location = new System.Drawing.Point(11, 78);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(118, 13);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Nhập thông tin tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Link ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng";
            // 
            // txtLinkImg
            // 
            this.txtLinkImg.Location = new System.Drawing.Point(110, 160);
            this.txtLinkImg.Name = "txtLinkImg";
            this.txtLinkImg.Size = new System.Drawing.Size(268, 20);
            this.txtLinkImg.TabIndex = 11;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(110, 128);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(269, 20);
            this.txtGiaBan.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(108, 102);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(269, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(19, 78);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 13);
            this.a.TabIndex = 8;
            this.a.Text = "Tên sản phẩm";
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Location = new System.Drawing.Point(22, 49);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(58, 13);
            this.lbMaHang.TabIndex = 7;
            this.lbMaHang.Text = "Mã đối tác";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(21, 19);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(70, 13);
            this.lbTenSP.TabIndex = 6;
            this.lbTenSP.Text = "Mã hàng hóa";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(108, 74);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(268, 20);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(110, 45);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(269, 20);
            this.txtMaDT.TabIndex = 4;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(109, 16);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(270, 20);
            this.txtMaHH.TabIndex = 3;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(412, 132);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(71, 34);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(412, 79);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(71, 33);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(412, 29);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(71, 36);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.button2_Click);
            // 
            // qlSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dgvSP);
            this.Name = "qlSP";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.qlSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinkImg;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}