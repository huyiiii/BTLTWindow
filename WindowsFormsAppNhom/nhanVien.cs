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
        private void nhanVien_Load(object sender, EventArgs e)
        {
            Form childForm = new banSp();
            ShowChildForm(childForm, tpNhanVienBSP);
            Form childForm1 = new qlHDon();
            ShowChildForm(childForm1, tpNhanVienQLHD);
            Form childForm2 = new qlSP();
            ShowChildForm(childForm2, tpNhanVienQLSP);
        }
    }
}
