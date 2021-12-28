using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    partial class Controller
    {
        public LoginState Login(string UserName, string PassWord)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Tên người dùng không được để trống");
                return LoginState.None;
            }
            if (string.IsNullOrEmpty(PassWord))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return LoginState.None;
            }

            User user;

            user = Static.mock.Data.users.Values.ToList().Find(u=> u.TenTaiKhoan == UserName);

            if (user == null)
            {
                MessageBox.Show("Người dùng không tồn tại");
                return LoginState.None;
            }
            if (user.MatKhau != PassWord)
            {
                MessageBox.Show("Mật khẩu không đúng");
                return LoginState.None;
            }

            this.user = user;
            return LoginState.Logged;
        }
    }
}
