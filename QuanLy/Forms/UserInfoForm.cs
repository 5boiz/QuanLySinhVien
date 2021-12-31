
using QuanLy.Models;
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
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();


            
        }
        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            User user = Static.controller.GetUserByID(Static.controller.user.ID);
            txtID.Text = user.ID;
            txtFullName.Text = user.HoTen;
            txtAddress.Text = user.DiaChi;
            cbClass.Text = Static.controller.GetClassByID(user.Lop).TenLop;
            cbGender.Text = user.GioiTinh;
            txtUserName.Text = user.TenTaiKhoan;
            txtPassWord.Text = user.MatKhau;
            cbType.Text = user.LoaiNguoiDung.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
