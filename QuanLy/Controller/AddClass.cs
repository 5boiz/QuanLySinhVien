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
        public void AddClass(Class classs)
        {
            Static.mock.Data.classes.Add(classs.ID, classs);
            Static.mock.Data.LCID += 1;
            Static.mock.XuatData();
            Resetbinding();
        }
    }
}
