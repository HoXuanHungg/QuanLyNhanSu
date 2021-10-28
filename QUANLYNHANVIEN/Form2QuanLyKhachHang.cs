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
    public partial class Form2QuanLyKhachHang : Form
    {
        public Form2QuanLyKhachHang()
        {
            InitializeComponent();
        }
// KẾT NỐI VỚI SQL:
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SG2VP7H\SQLEXPRESS;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True");

//HIỂN THỊ DATAGRIDVIEW:
        private void hienthi()
        {
            con.Open();//mở kết nối
            string sql = "select * from KHACHHANG";  // lay het du lieu trong bang nhan vien
            SqlCommand cmd = new SqlCommand(sql, con); //bat dau truy van
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter hxh1 = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataTable dtt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            hxh1.Fill(dtt); // đổ dữ liệu vào kho
            con.Close(); // đóng kết nối
            dataGridView1khachhang.DataSource = dtt; //đổ dữ liệu vào datagridvie
        }
         private void Form2QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            hienthi();
        }

//HIỂN THỊ NHANH
        private void dataGridView1khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= dataGridView1khachhang.CurrentRow.Index;          
            textBox1makhachhang.Text = dataGridView1khachhang.Rows[i].Cells[0].Value.ToString();
            textBox2tenkhachhang.Text = dataGridView1khachhang.Rows[i].Cells[1].Value.ToString();
            textBox3diachi.Text = dataGridView1khachhang.Rows[i].Cells[2].Value.ToString();
            textBox4cmnd.Text = dataGridView1khachhang.Rows[i].Cells[3].Value.ToString();
            textBox5sdt.Text = dataGridView1khachhang.Rows[i].Cells[4].Value.ToString();
        }

//BUTTON THÊM:
        private void button1them_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@CMND,@SDT)", con);//dòng đỏ là dòng truy vấn sql,conn de ket noi sql
            cmd.Parameters.AddWithValue("@MAKH", textBox1makhachhang.Text);
            cmd.Parameters.AddWithValue("@TENKH", textBox2tenkhachhang.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox3diachi.Text);
            cmd.Parameters.AddWithValue("@CMND", textBox4cmnd.Text);
            cmd.Parameters.AddWithValue("@SDT", textBox5sdt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            hienthi();
            MessageBox.Show("Thành công");
        }             
//BUTTON XÓA:
        private void button2xoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "delete KHACHHANG where MAKH='" + textBox1makhachhang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            hienthi();
            MessageBox.Show("Thành công");
        }
//BUTTON SỬA:
        private void button3sua_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update KHACHHANG set TENKH=N'" + textBox2tenkhachhang.Text + "',DIACHI=N'" + textBox3diachi.Text + "',CMND ='" + textBox4cmnd.Text + "',SDT='" + textBox5sdt.Text + "' where MAKH='" + textBox1makhachhang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            hienthi();
            MessageBox.Show("Thành công");
        }
//BUTTON THOÁT:
        private void button4thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//BUTTON TÌM KIẾM:
        private void button5timkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select *from KHACHHANG where MAKH=@MAKH";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MAKH", textBox6timkiem.Text);
            cmd.Parameters.AddWithValue("@TENKH", textBox2tenkhachhang.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox3diachi.Text);
            cmd.Parameters.AddWithValue("@CMND", textBox4cmnd.Text);
            cmd.Parameters.AddWithValue("@SDT", textBox5sdt.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter hxh1 = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataTable dtt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            hxh1.Fill(dtt); // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1khachhang.DataSource = dtt;
        }

        private void textBox3diachi_TextChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
