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
    public partial class XemCtSP : Form
    {
        public XemCtSP()
        {
            InitializeComponent();
        }

        private void label1tensp_Click(object sender, EventArgs e)
        {

        }

        private void XemCtSP_Load(object sender, EventArgs e)
        {
            string datapicture1 = xemSP.stringlink;
            pictureboxctsp.ImageLocation = datapicture1;
            labeltensp.Text = "Tên sản Phẩm: " + xemSP.stringName;
            lbmasp.Text = "Mã sản phẩm: " + xemSP.stringmasp;
            lbslcon.Text = "Số lượng: " + xemSP.stringslcon;
            lbgiasp.Text = "Giá sản phẩm: " + xemSP.stringGiasp;
        }
    }
}
