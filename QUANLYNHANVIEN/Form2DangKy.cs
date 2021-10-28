using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QUANLYNHANSU
{
    public partial class Form2DangKy : Form
    {
        public Form2DangKy()
        {
            InitializeComponent();
        }
      SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-SG2VP7H\SQLEXPRESS;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True");
//button thoát:
        private void button2thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//button đăng kí tài khoản mới:
        private void button1dangky_Click(object sender, EventArgs e)
        {
            conn.Open();
            Form1dangnhap hxh = new Form1dangnhap();
            hxh.Close();
            this.Hide();
//so sánh mật khẩu mới vs nhau.
            if (textBox2matkhau.Text == textBox3nhaplaimatkhau.Text)
                 {            
                    SqlCommand cmd = new SqlCommand("INSERT INTO DANGNHAP values  (@TAIKHOAN ,@MATKHAU)", conn);
                    cmd.Parameters.AddWithValue("@TAIKHOAN", textBox1tendangky.Text);
                    cmd.Parameters.AddWithValue("@MATKHAU", textBox2matkhau.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công");
                    conn.Close();              
                  }

            else{
                MessageBox.Show("Mật khẩu nhập lại không trùng.");
                }
        }
    }
}
