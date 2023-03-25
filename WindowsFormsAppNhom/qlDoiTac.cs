﻿using System;
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

            sql = "insert into doiTac values (@maDT, @tenDT, @maHH, @tensp)";
            if (tbmadt.Text.Length == 0 || tbmasp.Text.Length == 0 || tbtendt.Text.Length == 0 || tbtensp.Text.Length == 0)
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu");
            else
            {
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maDT", tbmadt.Text);
                cmd.Parameters.AddWithValue("@tenDT", tbtendt.Text);
                cmd.Parameters.AddWithValue("@maHH", tbmasp.Text);
                cmd.Parameters.AddWithValue("@tensp", tbtensp.Text);
                cmd.ExecuteNonQuery();
                dt.Rows.Clear();
                da.Fill(dt);
                MessageBox.Show("Them thanh cong doi tac !","Thong bao");
            }


        }
        int ddc;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            ddc = e.RowIndex;
            tbmadt.Text = Convert.ToString(row.Cells["Mã đối tác "].Value);
            tbtendt.Text = Convert.ToString(row.Cells["Tên đối tác "].Value);
            tbmasp.Text = Convert.ToString(row.Cells["Mã hàng hóa  "].Value);
            tbtensp.Text = Convert.ToString(row.Cells["Tên hàng hóa "].Value);
        }

        private void btXoa_Click(object sender, EventArgs e) {
            string a = dt.Rows[ddc][0].ToString();
        
            string xoa = "delete from doiTac where maDT = '" + a + "'";
            cmd = new SqlCommand(xoa, connection);
            cmd.ExecuteNonQuery();
            
            dt.Rows.Clear();
            da.Fill(dt);
            MessageBox.Show("Xoa thanh cong doi tac!","Thong bao");




        }
        private void btSua_Click(object sender, EventArgs e)
        {
            sql = "update doiTac set maDT=@maDT, tenDT=@tenDT, maHH=@maHH,tensp=@tensp where maDT=@maDT";

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
   
 

