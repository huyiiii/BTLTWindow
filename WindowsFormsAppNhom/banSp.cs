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
    public partial class banSp : Form
    {
<<<<<<< HEAD
        string chuoiketnoi = "Data Source=ADMIN\\QUOCHUY;"
=======
        string chuoiketnoi = "Data Source=DESKTOP-RKR0FIM\\SQLEXPRESS;"
>>>>>>> 20c528b7a2c348f824517555b3cf0165ee746e80
        + "Initial Catalog=quanlybandtdd; "
        + "Integrated Security=True";
        SqlConnection conn = null;

        public banSp()
        {
            InitializeComponent();
        }

        private void banSp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "SELECT * FROM hoaDon";
            SqlDataAdapter daDH = new SqlDataAdapter(sql, conn);
            DataTable dtDH = new DataTable();
            daDH.Fill(dtDH);
            dgvDH.DataSource = dtDH;
            conn.Close();
        }

        private void dgvDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btReload_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "SELECT * FROM hoaDon";
            SqlDataAdapter daDH = new SqlDataAdapter(sql, conn);
            DataTable dtDH = new DataTable();
            daDH.Fill(dtDH);
            dgvDH.DataSource = dtDH;
            conn.Close();
        }

        private void btHuy1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            int i = dgvDH.CurrentRow.Index;
            string maHH = dgvDH.Rows[i].Cells[0].Value.ToString();

            string sql = "DELETE hoaDon WHERE maHH=@maHH";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@maHH", maHH);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Hủy đơn hàng thành công!");
            }
            else
            {
                MessageBox.Show("Hủy đơn hàng thất bại!");
            }
            conn.Close();
        }
    }
}
