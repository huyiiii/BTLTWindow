namespace WindowsFormsAppNhom
{
    partial class XemCtSP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureboxctsp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbslcon = new System.Windows.Forms.Label();
            this.lbgiasp = new System.Windows.Forms.Label();
            this.lbmasp = new System.Windows.Forms.Label();
            this.labeltensp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxctsp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.75F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureboxctsp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 444);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mua Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureboxctsp
            // 
            this.pictureboxctsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureboxctsp.Location = new System.Drawing.Point(0, 0);
            this.pictureboxctsp.Name = "pictureboxctsp";
            this.pictureboxctsp.Size = new System.Drawing.Size(324, 301);
            this.pictureboxctsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxctsp.TabIndex = 0;
            this.pictureboxctsp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbslcon);
            this.panel2.Controls.Add(this.lbgiasp);
            this.panel2.Controls.Add(this.lbmasp);
            this.panel2.Controls.Add(this.labeltensp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(333, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 444);
            this.panel2.TabIndex = 1;
            // 
            // lbslcon
            // 
            this.lbslcon.AutoSize = true;
            this.lbslcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbslcon.Location = new System.Drawing.Point(68, 241);
            this.lbslcon.Name = "lbslcon";
            this.lbslcon.Size = new System.Drawing.Size(102, 20);
            this.lbslcon.TabIndex = 3;
            this.lbslcon.Text = "Số lượng còn";
            // 
            // lbgiasp
            // 
            this.lbgiasp.AutoSize = true;
            this.lbgiasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiasp.Location = new System.Drawing.Point(65, 177);
            this.lbgiasp.Name = "lbgiasp";
            this.lbgiasp.Size = new System.Drawing.Size(108, 20);
            this.lbgiasp.TabIndex = 2;
            this.lbgiasp.Text = "Giá sản phẩm";
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasp.Location = new System.Drawing.Point(65, 111);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(105, 20);
            this.lbmasp.TabIndex = 1;
            this.lbmasp.Text = "Mã sản phẩm";
            // 
            // labeltensp
            // 
            this.labeltensp.AutoSize = true;
            this.labeltensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltensp.Location = new System.Drawing.Point(62, 41);
            this.labeltensp.Name = "labeltensp";
            this.labeltensp.Size = new System.Drawing.Size(114, 20);
            this.labeltensp.TabIndex = 0;
            this.labeltensp.Text = "Tên Sản Phẩm";
            this.labeltensp.Click += new System.EventHandler(this.label1tensp_Click);
            // 
            // XemCtSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XemCtSP";
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.XemCtSP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxctsp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureboxctsp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbslcon;
        private System.Windows.Forms.Label lbgiasp;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Label labeltensp;
    }
}