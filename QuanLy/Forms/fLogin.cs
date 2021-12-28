
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
      

       
        private void fLogin_Load(object sender, EventArgs e)
        {
          
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            this.Hide();
            fMain fquanlysinhvien = new fMain();
            fquanlysinhvien.ShowDialog();
            this.Close();
            //if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            //{
            //    if (!string.IsNullOrEmpty(txtMatKhau.Text))
            //    {

            //        if (Kiemtradangnhap(txtTaiKhoan.Text, txtMatKhau.Text))
            //        {

            //            this.Hide();
            //            fMain fquanlysinhvien = new fMain();
            //            fquanlysinhvien.ShowDialog();
            //            this.Close();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu", "Thông báo");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nhập mật khẩu", "Thông báo");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Nhập tên đăng nhập", "Thông báo");
            //}
        }

        private bool Kiemtradangnhap(string tenDangNhap, string matKhau)
        {
            
            return false;
        }

        private void chbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        
    }
}
