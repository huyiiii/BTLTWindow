using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    public partial class nhanVien : Form
    {
        public nhanVien()
        {
            InitializeComponent();
        }
        private void ShowChildForm(Form childForm, Control parentControl)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentControl.Controls.Add(childForm);
            parentControl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void tpNhanVienBSP_Click(object sender, EventArgs e)
        {
            Form childForm = new banSp();
            ShowChildForm(childForm, tpNhanVienBSP);
        }

        private void tpNhanVienQLHD_Click(object sender, EventArgs e)
        {
            Form childForm = new qlHDon();
            ShowChildForm(childForm, tpNhanVienQLHD);
        }

        private void tpNhanVienQLSP_Click(object sender, EventArgs e)
        {
            Form childForm = new qlSP();
            ShowChildForm(childForm, tpNhanVienQLSP);
        }
    }
}
