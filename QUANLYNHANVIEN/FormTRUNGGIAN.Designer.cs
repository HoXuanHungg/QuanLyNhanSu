namespace QUANLYNHANSU
{
    partial class Formluachon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1nhanvien = new System.Windows.Forms.Button();
            this.button2khachhang = new System.Windows.Forms.Button();
            this.button1thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1dangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1nhanvien
            // 
            this.button1nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1nhanvien.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1nhanvien.Location = new System.Drawing.Point(46, 96);
            this.button1nhanvien.Name = "button1nhanvien";
            this.button1nhanvien.Size = new System.Drawing.Size(152, 36);
            this.button1nhanvien.TabIndex = 0;
            this.button1nhanvien.Text = "Nhân Viên";
            this.button1nhanvien.UseVisualStyleBackColor = false;
            this.button1nhanvien.Click += new System.EventHandler(this.button1nhanvien_Click);
            // 
            // button2khachhang
            // 
            this.button2khachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2khachhang.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2khachhang.Location = new System.Drawing.Point(258, 96);
            this.button2khachhang.Name = "button2khachhang";
            this.button2khachhang.Size = new System.Drawing.Size(152, 36);
            this.button2khachhang.TabIndex = 1;
            this.button2khachhang.Text = "Khách Hàng";
            this.button2khachhang.UseVisualStyleBackColor = false;
            this.button2khachhang.Click += new System.EventHandler(this.button2khachhang_Click);
            // 
            // button1thoat
            // 
            this.button1thoat.BackColor = System.Drawing.Color.Red;
            this.button1thoat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1thoat.Location = new System.Drawing.Point(258, 204);
            this.button1thoat.Name = "button1thoat";
            this.button1thoat.Size = new System.Drawing.Size(152, 38);
            this.button1thoat.TabIndex = 2;
            this.button1thoat.Text = "Thoát";
            this.button1thoat.UseVisualStyleBackColor = false;
            this.button1thoat.Click += new System.EventHandler(this.button1thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bạn muốn chọn :";
            // 
            // button1dangky
            // 
            this.button1dangky.BackColor = System.Drawing.Color.Red;
            this.button1dangky.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1dangky.Location = new System.Drawing.Point(46, 204);
            this.button1dangky.Name = "button1dangky";
            this.button1dangky.Size = new System.Drawing.Size(152, 38);
            this.button1dangky.TabIndex = 4;
            this.button1dangky.Text = "Đăng kí";
            this.button1dangky.UseVisualStyleBackColor = false;
            this.button1dangky.Click += new System.EventHandler(this.button1dangky_Click);
            // 
            // Formluachon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(444, 303);
            this.Controls.Add(this.button1dangky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1thoat);
            this.Controls.Add(this.button2khachhang);
            this.Controls.Add(this.button1nhanvien);
            this.Name = "Formluachon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1nhanvien;
        private System.Windows.Forms.Button button2khachhang;
        private System.Windows.Forms.Button button1thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1dangky;

    }
}