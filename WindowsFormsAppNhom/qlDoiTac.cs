using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace WindowsFormsAppNhom
{
    public partial class qlDoiTac : Form
    {
        public qlDoiTac()
        {
            InitializeComponent();
        }
        string connectionString = "DESKTOP-D1DV4KN\\SQLEXPRESS;" + "Initial Catalog = quanlybandtdd;" + "Integrated Security = True";
        SqlConnection connection = null;

        //Khởi tạo các đối tượng SqlConnection,SqlDataAdapter,DataTable;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;
        SqlDataReader dr;
        private void qlDoiTac_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            sql = "select maDT as 'Mã đối tác', tenDT as 'Tên đối tác', maHH as 'Mã hàng hóa', tensp as 'Tên hàng hóa' from doiTac";
            da = new SqlDataAdapter(sql, connection);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

        }





        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (tbmadt.Text.Length == 0 || tbmasp.Text.Length == 0 || tbtendt.Text.Length == 0 || tbtensp.Text.Length == 0)
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu");
            else
            {
                sql = "insert into doiTac values (" + tbmadt.Text + "," + tbmasp.Text + ", '" + tbtendt.Text + "' , '" + tbtensp.Text + "' ," + "' '" + ");";
                cmd = new SqlCommand(sql, connection);
                Console.WriteLine(sql);
                cmd.ExecuteNonQuery();
                dt.Rows.Clear();
                string query = "select maDT as 'Mã đối tác', tenDT as 'Tên đối tác', maHH as 'Mã hàng hóa', tensp as 'Tên hàng hóa' from doiTac";
                da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
<<<<<<< HEAD
                dgv.DataSource = dt;
=======
                MessageBox.Show("Them thanh cong doi tac !","Thong bao");
>>>>>>> 20c528b7a2c348f824517555b3cf0165ee746e80
            }


        }
        int ddc;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            ddc = e.RowIndex;
            tbmadt.Text = dgv.Rows[ddc].Cells[0].Value.ToString();
            tbtendt.Text = dgv.Rows[ddc].Cells[1].Value.ToString();
            tbmasp.Text = dgv.Rows[ddc].Cells[2].Value.ToString();
            tbtensp.Text = dgv.Rows[ddc].Cells[3].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e) {
            
            string a = dt.Rows[ddc][2].ToString();
            
            string xoa = "delete from doiTac where maHH = '" + a + "'";
            cmd = new SqlCommand(xoa, connection);
            cmd.ExecuteNonQuery();
            
            dt.Rows.Clear();
            da.Fill(dt);
            MessageBox.Show("Xoa thanh cong doi tac!","Thong bao");




        }
        private void btSua_Click(object sender, EventArgs e)
        {
            sql = "update doiTac set maDT=@maDT, tenDT=@tenDT, maHH=@maHH,tensp=@tensp where maHH=@maHH";

            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@maDT", tbmadt.Text);
            cmd.Parameters.AddWithValue("@tenDT", tbtendt.Text);
            cmd.Parameters.AddWithValue("@maHH", tbmasp.Text);
            cmd.Parameters.AddWithValue("@tensp", tbtensp.Text);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            da.Fill(dt);
            dgv.DataSource = dt;
            MessageBox.Show("Sửa thành công đối tác !","Thong bao");
        }

       
    }
}
   
 

