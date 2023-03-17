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
        private void khachHang_Load(object sender, EventArgs e)
        {
            Form childForm = new xemSP();
            ShowChildForm(childForm, tpKhachHangXemSP);
            Form childForm1 = new qlTKCaNhan();
            ShowChildForm(childForm1, tpKhachHangTKCN);
            Form childForm2 = new muaSanPham();
            ShowChildForm(childForm2, tpKhachHangMSP);
        }
    }
}
