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
    public partial class qlTKCaNhan : Form
    {
        public qlTKCaNhan()
        {
            InitializeComponent();
        }
        private void cbTKHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTKHienMK.Checked)
            {
                txtTKMKcu.PasswordChar = '\0';
                txtTKMKmoi.PasswordChar = '\0';
                txtTKMKxn.PasswordChar = '\0';
            }
            else
            {
                txtTKMKcu.PasswordChar = '*';
                txtTKMKmoi.PasswordChar = '*';
                txtTKMKxn.PasswordChar = '*';
            }
        }

        private void bntTKXN_Click(object sender, EventArgs e)
        {
            if (txtTKHo.Text == "")
            {
                txtTKHo.Focus();
            }
            if (txtTKTen.Text == "")
            {
                txtTKTen.Focus();
            }
            if (txtTKTen.Text != "" && txtTKHo.Text != "")
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thay đổi thông tin không",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    //cập nhật csdl
                    this.Close();
                }
                else
                {
                    //hiện thị lại thông tin khi chưa sửa
                }
            }
        }

        private void bntTkxacNhan_Click(object sender, EventArgs e)
        {
            //so sánh với csdl
            if (txtTKMKcu.Text != "a"|| txtTKMKcu.Text=="")
            {
                txtTKMKcu.Text = "";
                txtTKMKcu.Focus();
                if(txtTKMKcu.Text != "a")
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn nhập sai mật khẩu!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
            }
            if (txtTKMKmoi.Text == "")
            {
                txtTKMKmoi.Focus();
            }
            if (txtTKMKxn.Text == "")
            {
                txtTKMKxn.Focus();
            }
            if(txtTKMKxn.Text != txtTKMKmoi.Text)
            {
                txtTKMKxn.Text="";
                txtTKMKmoi.Text = "";
                txtTKMKmoi.Focus();
            }
            if (txtTKMKmoi.Text != "" && txtTKMKxn.Text != "" && txtTKMKcu.Text == "mật khẩu cũ")
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn đổi mật khẩu",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    //cập nhật csdl
                    this.Close();
                    //mở form trước đó
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblTTCNHoTen.Text=txtTKHo.Text + txtTKTen.Text;
        }

        private void lblTKMKCu_Click(object sender, EventArgs e)
        {

        }
    }
}
