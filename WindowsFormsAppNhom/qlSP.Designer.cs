//namespace sanpham
//{
//    partial class Form1
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
//            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
//            this.label5 = new System.Windows.Forms.Label();
//            this.textBox4 = new System.Windows.Forms.TextBox();
//            this.btTk = new System.Windows.Forms.Button();
//            this.btThem = new System.Windows.Forms.Button();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.textBox3 = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.textBox2 = new System.Windows.Forms.TextBox();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.btSua = new System.Windows.Forms.Button();
//            this.btXoa = new System.Windows.Forms.Button();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.ma_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.dac_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
//            this.splitContainer1.Panel1.SuspendLayout();
//            this.splitContainer1.Panel2.SuspendLayout();
//            this.splitContainer1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // splitContainer1
//            // 
//            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
//            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
//            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.splitContainer1.Name = "splitContainer1";
//            // 
//            // splitContainer1.Panel1
//            // 
//            this.splitContainer1.Panel1.Controls.Add(this.label5);
//            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
//            this.splitContainer1.Panel1.Controls.Add(this.btTk);
//            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
//            // 
//            // splitContainer1.Panel2
//            // 
//            this.splitContainer1.Panel2.Controls.Add(this.btThem);
//            this.splitContainer1.Panel2.Controls.Add(this.label3);
//            this.splitContainer1.Panel2.Controls.Add(this.label2);
//            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
//            this.splitContainer1.Panel2.Controls.Add(this.label1);
//            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
//            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
//            this.splitContainer1.Panel2.Controls.Add(this.btSua);
//            this.splitContainer1.Panel2.Controls.Add(this.btXoa);
//            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
//            this.splitContainer1.Size = new System.Drawing.Size(1097, 297);
//            this.splitContainer1.SplitterDistance = 363;
//            this.splitContainer1.SplitterWidth = 5;
//            this.splitContainer1.TabIndex = 0;
//            // 
//            // label5
//            // 
//            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.label5.AutoSize = true;
//            this.label5.Location = new System.Drawing.Point(16, 66);
//            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(144, 16);
//            this.label5.TabIndex = 3;
//            this.label5.Text = "Nhập thông tin tìm kiếm";
//            // 
//            // textBox4
//            // 
//            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.textBox4.Location = new System.Drawing.Point(15, 94);
//            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.textBox4.Name = "textBox4";
//            this.textBox4.Size = new System.Drawing.Size(316, 22);
//            this.textBox4.TabIndex = 2;
//            // 
//            // btTk
//            // 
//            this.btTk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.btTk.Location = new System.Drawing.Point(227, 123);
//            this.btTk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.btTk.Name = "btTk";
//            this.btTk.Size = new System.Drawing.Size(106, 36);
//            this.btTk.TabIndex = 1;
//            this.btTk.Text = "Tìm kiếm";
//            this.btTk.UseVisualStyleBackColor = true;
//            // 
//            // btThem
//            // 
//            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.btThem.Location = new System.Drawing.Point(576, 74);
//            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.btThem.Name = "btThem";
//            this.btThem.Size = new System.Drawing.Size(136, 36);
//            this.btThem.TabIndex = 15;
//            this.btThem.Text = "Thêm";
//            this.btThem.UseVisualStyleBackColor = true;
//            // 
//            // label3
//            // 
//            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(4, 185);
//            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(64, 16);
//            this.label3.TabIndex = 10;
//            this.label3.Text = "Đặc điểm";
//            // 
//            // label2
//            // 
//            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(7, 133);
//            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(59, 16);
//            this.label2.TabIndex = 8;
//            this.label2.Text = "Mã hàng";
//            // 
//            // textBox3
//            // 
//            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.textBox3.Location = new System.Drawing.Point(111, 181);
//            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.textBox3.Name = "textBox3";
//            this.textBox3.Size = new System.Drawing.Size(456, 22);
//            this.textBox3.TabIndex = 14;
//            // 
//            // label1
//            // 
//            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(8, 78);
//            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(93, 16);
//            this.label1.TabIndex = 6;
//            this.label1.Text = "Tên sản phẩm";
//            // 
//            // textBox2
//            // 
//            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.textBox2.Location = new System.Drawing.Point(111, 129);
//            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.textBox2.Name = "textBox2";
//            this.textBox2.Size = new System.Drawing.Size(456, 22);
//            this.textBox2.TabIndex = 13;
//            // 
//            // textBox1
//            // 
//            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.textBox1.Location = new System.Drawing.Point(109, 74);
//            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(459, 22);
//            this.textBox1.TabIndex = 12;
//            // 
//            // btSua
//            // 
//            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.btSua.Location = new System.Drawing.Point(577, 123);
//            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.btSua.Name = "btSua";
//            this.btSua.Size = new System.Drawing.Size(136, 36);
//            this.btSua.TabIndex = 11;
//            this.btSua.Text = "Sửa";
//            this.btSua.UseVisualStyleBackColor = true;
//            // 
//            // btXoa
//            // 
//            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
//            this.btXoa.Location = new System.Drawing.Point(576, 175);
//            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.btXoa.Name = "btXoa";
//            this.btXoa.Size = new System.Drawing.Size(136, 34);
//            this.btXoa.TabIndex = 9;
//            this.btXoa.Text = "Xóa";
//            this.btXoa.UseVisualStyleBackColor = true;
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.ma_hang,
//            this.ten_san_pham,
//            this.dac_diem});
//            this.dataGridView1.Location = new System.Drawing.Point(3, 298);
//            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersWidth = 51;
//            this.dataGridView1.Size = new System.Drawing.Size(1091, 310);
//            this.dataGridView1.TabIndex = 1;
//            // 
//            // ma_hang
//            // 
//            this.ma_hang.HeaderText = "Mã hàng";
//            this.ma_hang.MinimumWidth = 6;
//            this.ma_hang.Name = "ma_hang";
//            // 
//            // ten_san_pham
//            // 
//            this.ten_san_pham.HeaderText = "Tên sản phẩm";
//            this.ten_san_pham.MinimumWidth = 6;
//            this.ten_san_pham.Name = "ten_san_pham";
//            // 
//            // dac_diem
//            // 
//            this.dac_diem.HeaderText = "Đặc điểm";
//            this.dac_diem.MinimumWidth = 6;
//            this.dac_diem.Name = "dac_diem";
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1097, 609);
//            this.Controls.Add(this.splitContainer1);
//            this.Controls.Add(this.dataGridView1);
//            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.Name = "Form1";
//            this.Text = "Quản lý sản phẩm";
//            this.splitContainer1.Panel1.ResumeLayout(false);
//            this.splitContainer1.Panel1.PerformLayout();
//            this.splitContainer1.Panel2.ResumeLayout(false);
//            this.splitContainer1.Panel2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
//            this.splitContainer1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.SplitContainer splitContainer1;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.TextBox textBox4;
//        private System.Windows.Forms.Button btTk;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox textBox3;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox textBox2;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.Button btSua;
//        private System.Windows.Forms.Button btXoa;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Button btThem;
//        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hang;
//        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dac_diem;
//    }
//}

