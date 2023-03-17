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
    public partial class quanLy : Form
    {
        public quanLy()
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

        private void tpQuanLyNV_Click(object sender, EventArgs e)
        {
            Form childForm = new qlNV();
            ShowChildForm(childForm, tpQuanLyNV); 

        }

        private void tpQuanLyDT_Click(object sender, EventArgs e)
        {
            Form childForm = new qlDT();
            ShowChildForm(childForm, tpQuanLyDT);
        }

        private void tpQuanLyDoiTac_Click(object sender, EventArgs e)
        {
            Form childForm = new qlDoiTac();
            ShowChildForm(childForm, tpQuanLyDoiTac);
        }
    }
}
