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
        string chuoiketnoi = "DESKTOP-D1DV4KN\\SQLEXPRESS;"
            + "Initial Catalog=quanlybandtdd; "
            +"Integrated Security=True";
        SqlConnection conn = null;
        public qlSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void qlSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string sql = "SELECT * FROM hangHoa";
            SqlDataAdapter daSP = new SqlDataAdapter(sql,conn);
            DataTable dtSP = new DataTable();
            daSP.Fill(dtSP);
            dgvSP.DataSource = dtSP;
        }
    }
}
