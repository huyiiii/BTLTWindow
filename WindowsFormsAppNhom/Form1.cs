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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            banSp banSp = new banSp();
            banSp.ShowDialog(this);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap dangNhap = new dangNhap();
            dangNhap.ShowDialog(this);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dkTK dkTK = new dkTK();
            dkTK.ShowDialog(this);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            muaSanPham muaSanPham = new muaSanPham();
            muaSanPham.ShowDialog(this);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlDoiTac qlDoiTac = new qlDoiTac();
            qlDoiTac.ShowDialog(this);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlDT qlDT = new qlDT();
            qlDT.ShowDialog(this);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlHDon qlHDon = new qlHDon();
            qlHDon.ShowDialog(this);
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlNV qlNV = new qlNV();
            qlNV.ShowDialog(this);
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlSP qlSP = new qlSP();
            qlSP.ShowDialog(this);
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            qlTKCaNhan qlTKCaNhan = new qlTKCaNhan();
            qlTKCaNhan.ShowDialog(this);
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            xemSP xemSP = new xemSP();
            xemSP.ShowDialog(this);
            this.Close();
        }
    }
}
