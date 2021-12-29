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
        public void DeleteUser(string ID)
        {
            Static.mock.Data.users.Remove(ID);

            Static.mock.XuatData();
            Resetbinding();
        }
    }
}
