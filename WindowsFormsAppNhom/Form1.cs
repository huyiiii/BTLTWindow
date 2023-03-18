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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            khachHang khachHang = new khachHang();
            khachHang.ShowDialog();
            this.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    nhanVien banSp = new nhanVien();
        //    banSp.ShowDialog(this);
        //    this.Close();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    khachHang dangNhap = new khachHang();
        //    dangNhap.ShowDialog(this);
        //    this.Close();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    qlDoiTac qlDoiTac = new qlDoiTac();
        //    qlDoiTac.ShowDialog(this);
        //    this.Close();
        //}



        //private void button12_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    quanLy xemSP = new quanLy();
        //    xemSP.ShowDialog(this);
        //    this.Close();
        //}
    }
}
