namespace WindowsFormsAppNhom
{
    partial class qlHDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgvDSHD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDSHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 148);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xem chi tiết ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hoá đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgvDSHD
            // 
            this.DtgvDSHD.AllowUserToDeleteRows = false;
            this.DtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDSHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgvDSHD.Location = new System.Drawing.Point(0, 150);
            this.DtgvDSHD.Name = "DtgvDSHD";
            this.DtgvDSHD.ReadOnly = true;
            this.DtgvDSHD.Size = new System.Drawing.Size(800, 300);
            this.DtgvDSHD.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(199, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 150);
            this.panel2.TabIndex = 1;
            // 
            // qlHDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgvDSHD);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "qlHDon";
            this.Text = "qlHDon";
            this.Load += new System.EventHandler(this.qlHDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDSHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgvDSHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}