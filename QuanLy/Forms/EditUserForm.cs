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
    public partial class EditUserForm : Form
    {
        User user;
        public EditUserForm(User value)
        {
            InitializeComponent();

            cbType.DataSource = Enum.GetValues(typeof(LoaiNguoiDung));

            user = value;
            txtID.Text = user.ID;
            txtFullName.Text = user.HoTen;
            cbGender.SelectedItem = user.GioiTinh;
            txtAddress.Text = user.DiaChi;
            cbClass.DataSource = Static.controller.GetAllClass();
            cbClass.DisplayMember = "TenLop";
            cbClass.ValueMember = "ID";
            cbClass.SelectedValue = user.Lop;
            txtUserName.Text = user.TenTaiKhoan;
            txtPassWord.Text = user.MatKhau;
            cbType.SelectedItem = user.LoaiNguoiDung;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            user.ID = txtID.Text;
            user.HoTen = txtFullName.Text;
            user.GioiTinh = cbGender.SelectedItem.ToString();
            user.Lop = cbClass.SelectedValue.ToString();
            user.TenTaiKhoan = txtUserName.Text;
            user.MatKhau = txtPassWord.Text;
            user.DiaChi = txtAddress.Text;
            user.LoaiNguoiDung = (LoaiNguoiDung)cbType.SelectedItem;

            

            if (string.IsNullOrEmpty(user.HoTen) || string.IsNullOrEmpty(user.GioiTinh) || string.IsNullOrEmpty(user.Lop) || string.IsNullOrEmpty(user.DiaChi) || string.IsNullOrEmpty(user.TenTaiKhoan) || string.IsNullOrEmpty(user.MatKhau))
            {
                MessageBox.Show("Thông tin không được để trống");
                return;
            }
            //if (Static.controller.IsUserNameExists(user.TenTaiKhoan))
            //{
            //    MessageBox.Show("Tên tài khoản đã được sử dụng");
            //    return;
            //}

            Static.controller.UpdateUser(user);
            MessageBox.Show("Cập nhập thành công");
            
        }
    }
}
