using DevComponents.DotNetBar;
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
    public partial class MainForm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public System.Windows.Forms.TabControl tab;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            tabControl.SelectedIndex = 2;

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0,1);
            tabControl.SizeMode = TabSizeMode.Fixed;

            tab = tabControl;

            ClassTab classTab = new ClassTab(this);
            tabPageClass.Controls.Add(classTab);


            StudentTab studentTab = new StudentTab(this);
            tabPageStudent.Controls.Add(studentTab);

            TeacherTab teacherTab = new TeacherTab(this);
            tabPageTeacher.Controls.Add(teacherTab);


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginState state = Static.controller.Logout();
            if (state == LoginState.None)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm();
            userInfoForm.ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;

        }
    }
}
