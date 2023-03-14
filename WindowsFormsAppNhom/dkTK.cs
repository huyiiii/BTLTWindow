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
            if (cbDKHienMK.Checked)
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
            if (txtDKHo.Text == "")
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
            }
            else if (txtDKMK.Text == "")
            {
                txtDKMK.Focus();
            }
            else if (txtDKXN.Text == "")
            {
                txtDKXN.Focus();
            }
            else
            {
                try
                {
                    int sdt = int.Parse(txtDKSDT.Text);
                    if (txtDKMK.Text == txtDKXN.Text)
                    {
                        if (sdt.ToString().Length > 11 || sdt.ToString().Length < 10)
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
                        DialogResult result = MessageBox.Show(
                            "Bạn có muốn đăng ký tài khoản không.",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                        if (result == DialogResult.Yes)
                        {
                            //cập nhật csdl
                            //đóng form
                            //mở lại form trước đó
                        }
                        else
                        {
                            //đóng form
                            this.Close();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(
                            "Mật khẩu không khớp.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        txtDKMK.Text = "";
                        txtDKXN.Text = "";
                        txtDKMK.Focus();
                    }

                }
                catch
                {
                    DialogResult result1 = MessageBox.Show(
                        "Số điện thoại không hợp lệ.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    if (result1 == DialogResult.OK)
                    {
                        txtDKSDT.Text = "";
                        txtDKSDT.Focus();
                    }
                    if (txtDKMK.Text != txtDKXN.Text)
                    {
                        DialogResult result = MessageBox.Show(
                            "Mật khẩu không khớp.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        if (result == DialogResult.OK)
                        {
                            txtDKMK.Text = "";
                            txtDKXN.Text = "";
                            txtDKMK.Focus();
                        }

                    }
                }
            }
        }
    }
}
