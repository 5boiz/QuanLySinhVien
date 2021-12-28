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
        public void UpdateUser(User user)
        {
            Static.mock.Data.users[user.ID] = user;
            
            Static.mock.XuatData();
            Resetbinding();
        }
    }
}
