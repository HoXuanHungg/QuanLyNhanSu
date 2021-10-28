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
    public partial class Form1dangnhap : Form
    {
        public Form1dangnhap()
        {
            InitializeComponent();
        }
//KẾT NỐI SQL.
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SG2VP7H\SQLEXPRESS;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True");
//BUTTON THOÁT.
        private void button2thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//CHÚ THÍCH THÊM KHI THOÁT.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
//BUTTON ĐĂNG NHẬP.
        private void button1dangnhap_Click(object sender, EventArgs e)
        {
            string TK = textBox1tendangnhap.Text;  //gán biến vs dạng string
            string mk = textBox2matkhau.Text;  //gán          
            conn.Open();//MỞ KẾT NỐI.
            SqlCommand cmd = new SqlCommand("select*from DANGNHAP where TAIKHOAN='" + TK + "' and MATKHAU ='" + mk + "'", conn);//truy van sql
            SqlDataReader hxh1 = cmd.ExecuteReader();//ĐỌC DỮ LIỆU.
            if (hxh1.Read() == true)//neu dung thi chạy
            {
                Formluachon f = new Formluachon();
                this.Hide();//ĐÓNG FORM NHƯNG VẪN CÒN.
                f.ShowDialog();
                this.Show();// ĐÓNG HẲN FORM.
            }
            else
                MessageBox.Show("Mật khẩu hoặc tài khoản của bạn không chính xác");// hien thất bại nếu nhập sai mạt khẩu
            conn.Close();//ĐÓNG KẾT NỐI.   
        }
    }
}