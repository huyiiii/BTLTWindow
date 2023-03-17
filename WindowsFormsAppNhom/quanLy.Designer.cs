namespace WindowsFormsAppNhom
{
    partial class quanLy
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
            this.tcQuanLy = new System.Windows.Forms.TabControl();
            this.tpQuanLyNV = new System.Windows.Forms.TabPage();
            this.tpQuanLyDT = new System.Windows.Forms.TabPage();
            this.tpQuanLyDoiTac = new System.Windows.Forms.TabPage();
            this.tcQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Controls.Add(this.tpQuanLyNV);
            this.tcQuanLy.Controls.Add(this.tpQuanLyDT);
            this.tcQuanLy.Controls.Add(this.tpQuanLyDoiTac);
            this.tcQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(800, 450);
            this.tcQuanLy.TabIndex = 0;
            // 
            // tpQuanLyNV
            // 
            this.tpQuanLyNV.Location = new System.Drawing.Point(4, 25);
            this.tpQuanLyNV.Name = "tpQuanLyNV";
            this.tpQuanLyNV.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyNV.Size = new System.Drawing.Size(792, 421);
            this.tpQuanLyNV.TabIndex = 0;
            this.tpQuanLyNV.Text = "Quản lý nhân viên";
            this.tpQuanLyNV.UseVisualStyleBackColor = true;
            this.tpQuanLyNV.Click += new System.EventHandler(this.tpQuanLyNV_Click);
            // 
            // tpQuanLyDT
            // 
            this.tpQuanLyDT.Location = new System.Drawing.Point(4, 25);
            this.tpQuanLyDT.Name = "tpQuanLyDT";
            this.tpQuanLyDT.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyDT.Size = new System.Drawing.Size(792, 421);
            this.tpQuanLyDT.TabIndex = 1;
            this.tpQuanLyDT.Text = "Quản lý doanh thu";
            this.tpQuanLyDT.UseVisualStyleBackColor = true;
            this.tpQuanLyDT.Click += new System.EventHandler(this.tpQuanLyDT_Click);
            // 
            // tpQuanLyDoiTac
            // 
            this.tpQuanLyDoiTac.Location = new System.Drawing.Point(4, 25);
            this.tpQuanLyDoiTac.Name = "tpQuanLyDoiTac";
            this.tpQuanLyDoiTac.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyDoiTac.Size = new System.Drawing.Size(792, 421);
            this.tpQuanLyDoiTac.TabIndex = 2;
            this.tpQuanLyDoiTac.Text = "Quản lý đối tác";
            this.tpQuanLyDoiTac.UseVisualStyleBackColor = true;
            this.tpQuanLyDoiTac.Click += new System.EventHandler(this.tpQuanLyDoiTac_Click);
            // 
            // quanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcQuanLy);
            this.Name = "quanLy";
            this.Text = "quanLy";
            this.tcQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLy;
        private System.Windows.Forms.TabPage tpQuanLyNV;
        private System.Windows.Forms.TabPage tpQuanLyDT;
        private System.Windows.Forms.TabPage tpQuanLyDoiTac;
    }
}