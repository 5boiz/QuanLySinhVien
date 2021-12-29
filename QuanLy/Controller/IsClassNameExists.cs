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
        public bool IsClassNameExists(string ClassName)
        {
            return Static.mock.Data.classes.Values.ToList().Find(c => c.TenLop == ClassName) != null;
        }
    }
}
