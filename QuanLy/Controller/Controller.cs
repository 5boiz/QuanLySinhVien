using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    enum LoginState
    {
        None,
        Logged
    }
    partial class Controller
    {
        public User user;
        public BindingSource bindingSourceStudent = new BindingSource();
        public BindingSource bindingSourceTeacher = new BindingSource();
        public BindingSource bindingSourceClass = new BindingSource();

        public Controller()
        {
            bindingSourceStudent.DataSource = GetAllStudent();
            bindingSourceTeacher.DataSource = GetAllTeacher();
            bindingSourceClass.DataSource = GetAllClass();
        }
    }
}
