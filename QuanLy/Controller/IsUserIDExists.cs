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
        public bool IsUserIDExists(string ID)
        {
            return Static.mock.Data.users.Values.ToList().Find(u => u.ID == ID) != null;
        }
    }
}
