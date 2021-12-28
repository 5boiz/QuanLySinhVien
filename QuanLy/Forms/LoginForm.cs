
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
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            LoginState state = Static.controller.Login(txtTaiKhoan.Text, txtMatKhau.Text);
            if (state == LoginState.Logged)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
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
