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
    public partial class Form2QuanLyNhanVien : Form
    {
        public Form2QuanLyNhanVien()
        {
            InitializeComponent();
        }
//KẾT NỐI VỚI SQL:
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SG2VP7H\SQLEXPRESS;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True");

// HIỂN THỊ DATAGRIDVIEW:
            private void hienthi()
            {
                conn.Open();              
                string sql = "select * from NHANVIEN";  // lay het du lieu trong bang nhan vien
                SqlCommand cmd = new SqlCommand(sql, conn); //bat dau truy van
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter hxh1 = new SqlDataAdapter(cmd); //chuyen du lieu ve
                DataTable dtt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                hxh1.Fill(dtt); // đổ dữ liệu vào kho
                conn.Close();  // đóng kết nối
                dataGridView1hienthidanhsach.DataSource = dtt; //đổ dữ liệu vào datagridview
            }
            private void Form2QuanLyNhanVien_Load(object sender, EventArgs e)
            {
                hienthi();
            }

// TIM KIEM NHANH:
            private void dataGridView1hienthidanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                int i = dataGridView1hienthidanhsach.CurrentRow.Index;              
                textBox1manhanvien.Text = dataGridView1hienthidanhsach.Rows[i].Cells[0].Value.ToString();
                textBox2tennhanvien.Text = dataGridView1hienthidanhsach.Rows[i].Cells[1].Value.ToString();
                textBox3diachi.Text = dataGridView1hienthidanhsach.Rows[i].Cells[2].Value.ToString();
                dateTimePicker1ngaysinh.Text = dataGridView1hienthidanhsach.Rows[i].Cells[3].Value.ToString();
                comboBox1chucvu.Text = dataGridView1hienthidanhsach.Rows[i].Cells[4].Value.ToString();
            }

// BUTTON THÊM:
        private void button1them_Click(object sender, EventArgs e)
        { 
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into NHANVIEN values(@MANV,@TENNV,@DIACHI,@NGAYSINH,@CHUCVU)", conn);//dòng đỏ là dòng truy vấn sql,conn de ket noi sql
            cmd.Parameters.AddWithValue("@MANV",textBox1manhanvien.Text);
            cmd.Parameters.AddWithValue("@TENNV", textBox2tennhanvien.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox3diachi.Text);         
            DateTime ngaySinh1 = Convert.ToDateTime(dateTimePicker1ngaysinh.Text);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinh1);
            //cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = dateTimePicker1ngaysinh.Value.Date;
            //cmd.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1ngaysinh.Text);
            cmd.Parameters.AddWithValue("@CHUCVU",comboBox1chucvu.Text);
            cmd.ExecuteNonQuery(); 
            conn.Close();
            hienthi();
            MessageBox.Show("Thành công");         
        }    
          
// BUTTON XÓA:
        private void button2xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "delete NHANVIEN where MANV='" + textBox1manhanvien.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            hienthi();
            MessageBox.Show("Thành công");
        }

// BUTTON SUA:
        private void button3sua_Click(object sender, EventArgs e)
        {
            conn.Open();
          //format ngay sang sql
            DateTime ngaySinh1 = Convert.ToDateTime(dateTimePicker1ngaysinh.Text);
            string formatForMySql = ngaySinh1.ToString("yyyy-MM-dd");
            string sql = "update NHANVIEN set TENNV=N'" + textBox2tennhanvien.Text + "',DIACHI=N'" + textBox3diachi.Text +"',NGAYSINH='" +formatForMySql +"',CHUCVU =N'"+ comboBox1chucvu.Text+"' where MANV='"+ textBox1manhanvien.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            hienthi();
            MessageBox.Show("Thành công");
        }
//BUTTON THOÁT:
        private void button5thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//BUTTON TÌM KIẾM:
        private void button1timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select *from NHANVIEN where MANV=@MANV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANV", textBox1timkiem.Text);
            cmd.Parameters.AddWithValue("@TENNV", textBox2tennhanvien.Text);
            cmd.Parameters.AddWithValue("@DIACHI", textBox3diachi.Text);
            DateTime ngaySinh1 = Convert.ToDateTime(dateTimePicker1ngaysinh.Text);
            cmd.Parameters.AddWithValue("@CHUCVU", comboBox1chucvu.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter hxh1 = new SqlDataAdapter(cmd); //chuyen du lieu ve
            DataTable dtt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            hxh1.Fill(dtt); // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dataGridView1hienthidanhsach.DataSource = dtt;
            
        }
    }
}
