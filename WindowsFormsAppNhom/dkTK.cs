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
    public partial class dkTK : Form
    {
        public dkTK()
        {
            InitializeComponent();
        }

        private void dkTK_Load(object sender, EventArgs e)
        {

        }

        private void cbDKHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDKHienMK.Checked)
            {
                txtDKMK.PasswordChar = '\0';
                txtDKXN.PasswordChar = '\0';
            }
            else
            {
                txtDKMK.PasswordChar = '*';
                txtDKXN.PasswordChar = '*';
            }
        }

        private void bntDKDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap dangNhap = new dangNhap();
            dangNhap.ShowDialog(this);
            this.Close();
        }

        private void bntDKDK_Click(object sender, EventArgs e)
        {
            if(txtDKHo.Text == "")
            {
                txtDKHo.Focus();
            }
            else if (txtDKTen.Text == "")
            {
               txtDKTen.Focus();
            }
            else if (txtDKSDT.Text == "")
            {
                txtDKSDT.Focus();   
            }else if (txtDKMK.Text == "")
            {
                txtDKMK.Focus();
            }else if(txtDKXN.Text == "")
            {
                txtDKXN.Focus();
            }
            else
            {
                try
                {
                    int sdt = int.Parse(txtDKSDT.Text);
                    if(sdt.ToString().Length > 11|| sdt.ToString().Length < 10)
                    {
                        txtDKSDT.Text = "";
                        txtDKMK.Focus();
                    }
                    if (txtDKMK.Text != txtDKXN.Text)
                    {
                        txtDKXN.Text = "";
                        txtDKMK.Text = "";
                        txtDKMK.Focus();
                    }
                }catch {
                    txtDKSDT.Text = "";
                    txtDKSDT.Focus();
                    if (txtDKMK.Text != txtDKXN.Text)
                    {
                        txtDKXN.Text = "";
                        txtDKMK.Text = "";
                    }
                }
            }
        }
    }
}
