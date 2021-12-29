
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
    public partial class EditClassForm : Form
    {
        Class classs;
        public EditClassForm(Class value)
        {
            InitializeComponent();

            classs = value;
            txtID.Text = classs.ID;
            txtClassName.Text = classs.TenLop;
            txtFaculty.Text = classs.Khoa;
            cbTeacher.DataSource = Static.controller.GetAllTeacher();
            cbTeacher.DisplayMember = "HoTen";
            cbTeacher.SelectedItem = Static.controller.GetUserByName(value.GiaoVien);
            txtYear.Text = classs.NamHoc;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            classs.ID = txtID.Text;
            classs.TenLop = txtClassName.Text;
            classs.Khoa = txtFaculty.Text;
            classs.GiaoVien = ((User)cbTeacher.SelectedItem).HoTen;
            classs.NamHoc = txtYear.Text;


            if (string.IsNullOrEmpty(classs.TenLop) || string.IsNullOrEmpty(classs.Khoa) || string.IsNullOrEmpty(classs.GiaoVien) || string.IsNullOrEmpty(classs.NamHoc))
            {
                MessageBox.Show("Thông tin không được để trống");
                return;
            }

            Static.controller.UpdateClass(classs);
            MessageBox.Show("Cập nhập thành công");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
