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
    public partial class khachHang : Form
    {
        public khachHang()
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
        private void tpKhachHangXemSP_Click(object sender, EventArgs e)
        {
            Form childForm = new xemSP();
            ShowChildForm(childForm, tpKhachHangXemSP);
        }

        private void tpKhachHangTKCN_Click(object sender, EventArgs e)
        {
            Form childForm = new qlTKCaNhan();
            ShowChildForm(childForm, tpKhachHangTKCN);
        }

        private void tpKhachHangMSP_Click(object sender, EventArgs e)
        {
            Form childForm = new muaSanPham();
            ShowChildForm(childForm, tpKhachHangMSP);
        }
    }
}
