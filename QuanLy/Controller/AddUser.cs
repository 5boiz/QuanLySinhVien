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
        public void AddUser(User user)
        {
            Static.mock.Data.users.Add(user.ID, user);
            Static.mock.Data.LID += 1;
            Static.mock.XuatData();
            Resetbinding();
        }
    }
}
