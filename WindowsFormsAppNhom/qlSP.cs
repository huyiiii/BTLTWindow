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
    public partial class qlSP : Form
    {
<<<<<<< HEAD
        string chuoiketnoi = "Data Source=ADMIN\\QUOCHUY;"
        + "Initial Catalog=quanlybandtdd; "
        + "Integrated Security=True";
=======
<<<<<<< HEAD
        string chuoiketnoi = "DESKTOP-D1DV4KN\\SQLEXPRESS;"
            + "Initial Catalog=quanlybandtdd; "
            +"Integrated Security=True";
=======
        string chuoiketnoi = "Data Source=DESKTOP-RKR0FIM\\SQLEXPRESS;"
        + "Initial Catalog=quanlybandtdd; "
        + "Integrated Security=True";
>>>>>>> 905b519f4b10d07e589aea0f52c0d5cf3d80c91e
>>>>>>> 20c528b7a2c348f824517555b3cf0165ee746e80
        SqlConnection conn = null;

        public qlSP()
        {
            InitializeComponent();
        }
        public void load_form(string sql)
        {
            SqlDataAdapter daSP = new SqlDataAdapter(sql, conn);
            DataTable dtSP = new DataTable();
            daSP.Fill(dtSP);
            dgvSP.DataSource = dtSP;
        }

        private void qlSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "SELECT * FROM hangHoa";
            load_form(sql);
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtMaHH.Text == "" || txtMaDT.Text == "" || txtTenSP.Text == "" || 
            txtSoLuong.Text == "" || txtGiaBan.Text == "" || txtLinkImg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                txtMaHH.Focus();
                return;
            }

            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string maHH = txtMaHH.Text;
            string maDT = txtMaDT.Text;
            string tenSP = txtTenSP.Text;
            string soLuong = txtSoLuong.Text;
            string giaBan = txtGiaBan.Text;
            string linkImg = txtLinkImg.Text;

            string sql_add = "INSERT INTO hangHoa (maHH,maDT,tenSP,soLuong,giaBan,linkImg) " +
                "VALUES (@maHH,@maDT,@tenSP,@soLuong,@giaBan,@linkImg)";

            SqlCommand cmd = new SqlCommand(sql_add, conn);
            cmd.Parameters.AddWithValue("@maHH", maHH);
            cmd.Parameters.AddWithValue("@maDT", maDT);
            cmd.Parameters.AddWithValue("@tenSP", tenSP);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.Parameters.AddWithValue("@giaBan", giaBan);
            cmd.Parameters.AddWithValue("@linkImg", linkImg);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
            conn.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string maHH = txtMaHH.Text;
            string maDT = txtMaDT.Text;
            string tenSP = txtTenSP.Text;
            string soLuong = txtSoLuong.Text;
            string giaBan = txtGiaBan.Text;
            string linkImg = txtLinkImg.Text;

            string sql_update = "UPDATE SanPham SET maDT = @maDT, tenSP = @tenSP, tenSP = @tenSP" +
                ", soLuong = @soLuong, giaBan = @giaBan,linkImg = @linkImg WHERE maHH = @maHH";

            SqlCommand cmd = new SqlCommand(sql_update, conn);
            cmd.Parameters.AddWithValue("@maHH", maHH);
            cmd.Parameters.AddWithValue("@maDT", maDT);
            cmd.Parameters.AddWithValue("@tenSP", tenSP);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.Parameters.AddWithValue("@giaBan", giaBan);
            cmd.Parameters.AddWithValue("@linkImg", linkImg);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công!");         
            }
            else
            {
                MessageBox.Show("Sửa thông tin sản phẩm thất bại!");
            }
            conn.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string maHH = txtMaHH.Text;

            string sql_delete = "DELETE hangHoa WHERE maHH=@maHH";

            SqlCommand cmd = new SqlCommand(sql_delete, conn);
            cmd.Parameters.AddWithValue("@maHH", maHH);
 
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại!");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string TK = txtTK.Text;
            string sql = "SELECT * FROM hangHoa WHERE maHH LIKE '%" + TK + "%' OR maDT LIKE '%" + TK + "%' OR tenSP LIKE '%" 
                + TK + "%' OR soLuong LIKE '%" + TK + "%' OR giaBan LIKE '%"+ TK +"%' OR linkImg LIKE '%" + TK + "%';";
            load_form(sql);
            conn.Close();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSP.Enabled = true;
            int i = dgvSP.CurrentRow.Index;

            txtMaHH.Text = dgvSP.Rows[i].Cells[0].Value.ToString();
            txtMaDT.Text = dgvSP.Rows[i].Cells[1].Value.ToString();
            txtTenSP.Text = dgvSP.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSP.Rows[i].Cells[3].Value.ToString();
            txtGiaBan.Text = dgvSP.Rows[i].Cells[4].Value.ToString();
            txtLinkImg.Text = dgvSP.Rows[i].Cells[5].Value.ToString();
        }
    }
}
