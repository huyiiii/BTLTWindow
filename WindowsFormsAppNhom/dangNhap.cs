using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    
    public partial class dangNhap : Form
    {
        //tạo biến để lưu tên đăng nhập và mật khẩu
        public static string TenDN;
        public static string LoaiTK;

        public dangNhap()
        {
            InitializeComponent();
        }
        //tại chuỗi kệt nối với sql server
        string connectionString = "DESKTOP-D1DV4KN\\SQLEXPRESS;Initial Catalog=quanlybandtdd; Integrated Security=True";
        SqlConnection connection = null;

        //băm mật khẩu
        public static string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void dangNhap_Load(object sender, EventArgs e)
        {

        }
        //function dislay password

        private void ChkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtDNMK.PasswordChar = '\0';
            }
            else
            {
                txtDNMK.PasswordChar = '*';
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnDNMK_Click(object sender, EventArgs e)
        {
            if (cbDNLTK.Text == "")
            {
                DialogResult result = MessageBox.Show(
                            "Bạn chưa chọn loại tài khoản.",
                            "Warning",
                            MessageBoxButtons.OK
                            );
                if (result == DialogResult.OK)
                {
                    cbDNLTK.Focus();
                }
            }
            if (txtDNTenDN.Text == "")
            {
                DialogResult result = MessageBox.Show(
                            "Bạn chưa nhập thông tin đăng nhập.",
                            "Warning",
                            MessageBoxButtons.OK
                            );
                if (result == DialogResult.OK)
                {
                    txtDNTenDN.Focus();
                }
            }
            if (txtDNMK.Text == "")
            {
                DialogResult result = MessageBox.Show(
                            "Bạn chưa nhập mật khẩu.",
                            "Warning",
                            MessageBoxButtons.OK
                            );
                if (result == DialogResult.OK)
                {
                    txtDNMK.Focus();
                }
            }
            Console.WriteLine(cbDNLTK.Text);
            if (cbDNLTK.Text != "QuanLy" && cbDNLTK.Text != "NhanVien" && cbDNLTK.Text != "KhachHang")
            {
                DialogResult result = MessageBox.Show(
                            "Chọn loại lại loại tài khoản.",
                            "Warning",
                            MessageBoxButtons.OK
                            );
                if (result == DialogResult.OK)
                {
                    cbDNLTK.Focus();
                }
            }
            else
            {
                string mk = "";
                string loaiTK = cbDNLTK.Text;
                connection = new SqlConnection(connectionString);
                connection.Open();
                string input = txtDNMK.Text;
                string hash = ComputeMD5Hash(input);
                //check mật khẩu của loại tài khoản đã chịn khi đăng nhập để so sánh với mật khầu vừa nhập
                switch (loaiTK)
                {
                    case "QuanLy":
                        string mnd = "select matKhau from quanLy\r\n\twhere soDienThoai like '" + txtDNTenDN.Text + "'";
                        SqlCommand command = new SqlCommand(mnd, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            mk = (string)reader["matKhau"];
                        }
                        reader.Close();
                        break;
                    case "NhanVien":
                        string mnd1 = "select matKhau from nhanVien\r\n\twhere soDienThoai like '" + txtDNTenDN.Text + "'";
                        SqlCommand command1 = new SqlCommand(mnd1, connection);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        while (reader1.Read())
                        {
                            mk = (string)reader1["matKhau"];
                        }
                        reader1.Close();
                        break;
                    case "KhachHang":
                        string mnd2 = "select matKhau from khachHang\r\n\twhere soDienThoai like '" + txtDNTenDN.Text + "'";
                        SqlCommand command2 = new SqlCommand(mnd2, connection);
                        SqlDataReader reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            mk = (string)reader2["matKhau"];
                        }
                        reader2.Close();    
                        break;
                }
                Console.WriteLine(txtDNTenDN.Text);
                Console.WriteLine("Matkhau"+mk);
                if (mk == ""||mk!=hash)
                {
                    DialogResult result = MessageBox.Show(
                    "Tên đăng nhập hoặn mật khẩu sai",
                    "Warning",
                    MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        txtDNMK.Text = "";
                        txtDNTenDN.Text = "";
                        txtDNTenDN.Focus();
                    }
                }
                else
                {
                    switch (loaiTK)
                    {
                        case "QuanLy":
                            this.Hide();
                            quanLy quanLy = new quanLy();
                            quanLy.Show();
                            break;
                        case "NhanVien":
                            this.Hide();
                            nhanVien nhanVien = new nhanVien();
                            nhanVien.Show();
                            break;
                        case "KhachHang":
                            this.Hide();
                            khachHang khachHang = new khachHang();
                            khachHang.Show();
                            break;
                    }
                    //lấy tên đăng nhập để dùng
                    TenDN = txtDNTenDN.Text;
                    LoaiTK = cbDNLTK.Text;
                }
            }

        }
    }
}