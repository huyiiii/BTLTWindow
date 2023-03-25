namespace WindowsFormsAppNhom
{
    partial class banSp
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
            this.btHuy = new System.Windows.Forms.Button();
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.ma_don_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thong_tin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_don_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btHuy.Location = new System.Drawing.Point(308, 23);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(133, 39);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy đơn";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy1_Click);
            // 
            // dgvDH
            // 
            this.dgvDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_don_hang,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.thong_tin,
            this.ten_don_hang});
            this.dgvDH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDH.Location = new System.Drawing.Point(0, 91);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.Size = new System.Drawing.Size(800, 359);
            this.dgvDH.TabIndex = 3;
            this.dgvDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDH_CellClick);
            // 
            // ma_don_hang
            // 
            this.ma_don_hang.DataPropertyName = "maHH";
            this.ma_don_hang.HeaderText = "Mã hàng hóa";
            this.ma_don_hang.Name = "ma_don_hang";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maDT";
            this.Column1.HeaderText = "Mã đối tác";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soDienThoai";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenKH";
            this.Column4.HeaderText = "Tên khách hàng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "giaBan";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            // 
            // thong_tin
            // 
            this.thong_tin.DataPropertyName = "diaChi";
            this.thong_tin.HeaderText = "Địa chỉ";
            this.thong_tin.Name = "thong_tin";
            // 
            // ten_don_hang
            // 
            this.ten_don_hang.DataPropertyName = "ngayMua";
            this.ten_don_hang.HeaderText = "Ngày mua";
            this.ten_don_hang.Name = "ten_don_hang";
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(21, 12);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(60, 38);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "Làm mới";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // banSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.dgvDH);
            this.Name = "banSp";
            this.Text = "banSp";
            this.Load += new System.EventHandler(this.banSp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_don_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn thong_tin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_don_hang;
        private System.Windows.Forms.Button btReload;
    }
}