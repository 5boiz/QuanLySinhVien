
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

namespace QuanLy.UC_control
{
    public partial class CreateClassForm : Form
    {
        public CreateClassForm()
        {
            InitializeComponent();

            txtID.Text = (Static.controller.GetLastClassID() + 1).ToString();
            txtID.Enabled = false;
            cbTeacher.DataSource = Static.controller.GetAllTeacher();
            cbTeacher.DisplayMember = "HoTen";
            cbTeacher.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Class classs = new Class();
            classs.ID = txtID.Text;
            classs.TenLop = txtClassName.Text;
            classs.Khoa = txtFaculty.Text;
            classs.GiaoVien = ((User)cbTeacher.SelectedItem).ID;
            classs.NamHoc = txtYear.Text;


            if (string.IsNullOrEmpty(classs.TenLop) || string.IsNullOrEmpty(classs.Khoa) || string.IsNullOrEmpty(classs.GiaoVien) || string.IsNullOrEmpty(classs.NamHoc))
            {
                MessageBox.Show("Thông tin không được để trống");
                return;
            }
            if (Static.controller.IsClassNameExists(classs.TenLop))
            {
                MessageBox.Show("Tên lớp đã được sử dụng");
                return;
            }

            Static.controller.AddClass(classs);
            MessageBox.Show("Tạo thành công");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
