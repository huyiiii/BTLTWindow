using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    public partial class qlHDon : Form
    {
     
        string connectionString = "Data Source=ADMIN\\QUOCHUY;Initial Catalog=quanlybandtdd; Integrated Security=True";
        SqlConnection connection = null;
        DataTable dttb = new DataTable();
        public qlHDon()
        {
            InitializeComponent();
        }

        private void qlHDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string qerry = "select mahh as 'Mã Hàng',tensp as 'Tên sản phẩm' ,soDienThoai as 'Số điện thoại',tenKH as 'Tên Khách hàng',giaban as 'Giá sản phẩm',diachi as 'Địa chỉ',ngaymua as 'Ngày bán' from hoadon";
            //SqlCommand cmd = new SqlCommand(qerry, connection);
            SqlDataAdapter dtp = new SqlDataAdapter(qerry,connection);           
            dtp.Fill(dttb);
            DtgvDSHD.DataSource = dttb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
