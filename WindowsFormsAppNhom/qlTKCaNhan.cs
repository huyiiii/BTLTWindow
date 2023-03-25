using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString = "DESKTOP-D1DV4KN\\SQLEXPRESS; Initial Catalog = quanlybandtdd; Integrated Security=True";
        SqlConnection connection = null;
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
                    string tenDN = dangNhap.TenDN;
                    string loaiTK = dangNhap.LoaiTK;
                    string fullName = txtTKHo.Text +" " + txtTKTen.Text;
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    //cập nhật csdl
                    switch (loaiTK)
                    {
                        case "QuanLy":
                            string mnd = "UPDATE quanLy SET tenQL = '" + fullName + "' WHERE soDienThoai = '" + tenDN + "'; ";
                            SqlCommand sqlCommand = new SqlCommand(mnd, connection);
                            SqlDataReader reader3 = sqlCommand.ExecuteReader();
                            reader3.Close();
                            break;
                        case "NhanVien":
                            string mnd1 = "UPDATE nhanVien SET tenNV = '" + fullName + "' WHERE soDienThoai = '" + tenDN + "'; ";
                            SqlCommand sqlCommand1 = new SqlCommand(mnd1, connection);
                            SqlDataReader reader4 = sqlCommand1.ExecuteReader();
                            reader4.Close();
                            break;
                        case "KhachHang":
                            string mnd2 = "UPDATE khachHang SET tenKH = '" + fullName + "' WHERE soDienThoai = '" + tenDN + "'; ";
                            SqlCommand sqlCommand2 = new SqlCommand(mnd2, connection);
                            SqlDataReader reader5 = sqlCommand2.ExecuteReader();
                            reader5.Close();
                            break;
                    }
                }
                else
                {
                    //hiện thị lại thông tin khi chưa sửa
                }
                lblTTCNHoTen.Text=txtTKHo.Text+" " + txtTKTen.Text;
                lblMKBM.Text= txtTKHo.Text + " " + txtTKTen.Text;
                connection.Close();
            }
        }

        private void bntTkxacNhan_Click(object sender, EventArgs e)
        {
            string hash = dkTK.ComputeMD5Hash(txtTKMKcu.Text);
            string password="";
            //string mnd = "select tenQL from  quanLy where soDienThoai like '" + tenDN + "'";
            //SqlCommand sqlCommand = new SqlCommand(mnd, connection);
            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    lblTTCNHoTen.Text = reader["tenQL"].ToString();
            //}
            string tenDN = dangNhap.TenDN;
            string loaiTK = dangNhap.LoaiTK;
            connection = new SqlConnection(connectionString);
            connection.Open();
            switch (loaiTK)
            {
                case "QuanLy":
                    string mnd = "select matKhau from quanLy where soDienThoai like '" + tenDN+"'";
                    SqlCommand cmd = new SqlCommand(mnd,connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        password = reader["matKhau"].ToString();
                    }
                    reader.Close();
                    break;
                case "NhanVien":
                    string mnd1 = "select matKhau from nhanVien where soDienThoai like '"+tenDN+"'";
                    SqlCommand cmd1 = new SqlCommand(mnd1,connection);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        password = reader1["matKhau"].ToString();
                    }
                    reader1.Close();
                    break;
                case "KhachHang":
                    string nmd2 = "select matKhau from khachHang where soDienThoai like '"+tenDN +"'";
                    SqlCommand cmd2 = new SqlCommand(nmd2,connection);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        password = reader2["matKhau"].ToString();
                    }
                    reader2.Close();    
                    break;
                   
            }
            //so sánh với csdl
            if (password != hash|| txtTKMKcu.Text=="")
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
            if (txtTKMKmoi.Text != "" && txtTKMKxn.Text != "" && password == hash)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn đổi mật khẩu",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    string newPasswork = dkTK.ComputeMD5Hash(txtTKMKmoi.Text);
                    switch (loaiTK)
                    {
                        case "QuanLy":
                            string mnd = "UPDATE quanLy SET matKhau = '"+newPasswork+ "' WHERE soDienThoai = '"+tenDN+"'; ";
                            SqlCommand sqlCommand = new SqlCommand(mnd, connection);
                            SqlDataReader reader3 = sqlCommand.ExecuteReader();
                            reader3.Close();
                            break;
                        case "NhanVien":
                            string mnd1 = "UPDATE nhanVien SET matKhau = '" + newPasswork + "' WHERE soDienThoai = '" + tenDN + "'; ";
                            SqlCommand sqlCommand1 = new SqlCommand(mnd1, connection);
                            SqlDataReader reader4 = sqlCommand1.ExecuteReader();
                            reader4.Close();    
                            break;
                        case "KhachHang":
                            string mnd2 = "UPDATE khachHang SET matKhau = '" + newPasswork + "' WHERE soDienThoai = '" + tenDN + "'; ";
                            SqlCommand sqlCommand2 = new SqlCommand(mnd2, connection);
                            SqlDataReader reader5 = sqlCommand2.ExecuteReader();
                            reader5.Close();
                            break;
                    }
                    DialogResult result1 = MessageBox.Show(
                        "Đổi mật khẩu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }

            }
            txtTKMKcu.Text = "";
            txtTKMKmoi.Text = "";
            txtTKMKxn.Text = "";
            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void lblTKMKCu_Click(object sender, EventArgs e)
        {

        }
        private void qlTKCaNhan_Load(object sender, EventArgs e)
        {
            //lấy tên đăng nhập, loại từ form đăng nhập
            string tenDN = dangNhap.TenDN;
            string loaiTK = dangNhap.LoaiTK;
            //kết nối với sql
            connection = new SqlConnection(connectionString);
            connection.Open();
            //check type account
            lblTTCNHoTen.Text = "";
            Console.WriteLine("loại tài khoản: "+loaiTK);
            Console.WriteLine(tenDN);
            switch (loaiTK)
            {
                case "QuanLy":
                    string mnd = "select tenQL from  quanLy where soDienThoai like '" + tenDN + "'";
                    SqlCommand sqlCommand = new SqlCommand(mnd, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        lblTTCNHoTen.Text = reader["tenQL"].ToString();
                    }
                    reader.Close();
                    break;
                case "NhanVien":
                    string mnd1 = "select tenNV from  nhanVien where soDienThoai like '" + tenDN + "'";
                    SqlCommand sqlCommand1 = new SqlCommand(mnd1, connection);
                    SqlDataReader reader1 = sqlCommand1.ExecuteReader();
                    while (reader1.Read())
                    {
                        lblTTCNHoTen.Text = reader1["tenNV"].ToString();
                    }
                    reader1.Close();
                    break;
                case "KhachHang":
                    string mnd2 = "select tenKH from  khachHang where soDienThoai like '" + tenDN + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(mnd2, connection);
                    SqlDataReader reader2 = sqlCommand2.ExecuteReader();
                    while (reader2.Read())
                    {
                        lblTTCNHoTen.Text = reader2["tenKH"].ToString();
                    }
                    reader2.Close();
                    break;
            }
            Console.WriteLine("ho ten db"+lblTTCNHoTen.Text);
            Console.WriteLine(loaiTK);
            Console.WriteLine(tenDN);
            lblMKBM.Text = lblTTCNHoTen.Text;
            string fullName = lblTTCNHoTen.Text;
            int lastSpaceIndex = fullName.LastIndexOf(" ");
            //txtTKHo.Text = fullName.Substring(0, lastSpaceIndex); // Lấy chuỗi con từ vị trí 0 đến vị trí trước dấu cách cuối cùng
            //txtTKTen.Text = fullName.Substring(lastSpaceIndex + 1); // Lấy chuỗi con từ vị trí sau dấu cách cuối cùng đến hết chuỗi
            connection.Close();
        }
    }
}
