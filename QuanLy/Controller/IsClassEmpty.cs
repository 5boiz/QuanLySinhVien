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
        public bool IsClassEmpty(string ID)
        {
            
            return Static.mock.Data.users.Values.ToList().Find(c => c.Lop == ID) == null;
        }
    }
}
