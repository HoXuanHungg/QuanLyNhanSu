using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class Formluachon : Form
    {
        public Formluachon()
        {
            InitializeComponent();
        }
//button hiện bảng nhân viên:
        private void button1nhanvien_Click(object sender, EventArgs e)
        {               
            Form2QuanLyNhanVien f = new Form2QuanLyNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
//button hiện bảng khách hàng:
        private void button2khachhang_Click(object sender, EventArgs e)
        {
            Form2QuanLyKhachHang f = new Form2QuanLyKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
//button thoát:
        private void button1thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//button hiện bảng đăng kí:
        private void button1dangky_Click(object sender, EventArgs e)
        {
            Form2DangKy f = new Form2DangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}
