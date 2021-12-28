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

namespace QuanLy.Forms
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm(LoaiNguoiDung loaiNguoiDung)
        {
            InitializeComponent();
            cbType.DataSource = Enum.GetValues(typeof(LoaiNguoiDung));
            cbType.SelectedItem = loaiNguoiDung;
            txtID.Text = (Static.controller.GetLastID() + 1).ToString();
            txtID.Enabled = false;
            cbType.Enabled = false;
            cbGender.SelectedIndex = 0;
            cbClass.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = txtID.Text;
            user.HoTen = txtFullName.Text;
            user.GioiTinh = cbGender.SelectedItem.ToString();
            user.Lop = cbClass.SelectedItem.ToString();
            user.TenTaiKhoan = txtUserName.Text;
            user.MatKhau = txtPassWord.Text;
            user.DiaChi = txtAddress.Text;
            user.LoaiNguoiDung = (LoaiNguoiDung)cbType.SelectedItem;


            if (string.IsNullOrEmpty(user.HoTen) || string.IsNullOrEmpty(user.GioiTinh) || string.IsNullOrEmpty(user.Lop) || string.IsNullOrEmpty(user.DiaChi) || string.IsNullOrEmpty(user.TenTaiKhoan) || string.IsNullOrEmpty(user.MatKhau))
            {
                MessageBox.Show("Thông tin không được để trống");
                return;
            }
            if (Static.controller.IsUserNameExists(user.TenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng");
                return;
            }

            Static.controller.AddUser(user);
            MessageBox.Show("Tạo thành công");
            
        }
    }
}
