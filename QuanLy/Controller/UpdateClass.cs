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
        public void UpdateClass(Class classs)
        {
            Static.mock.Data.classes[classs.ID] = classs;
            
            Static.mock.XuatData();
            Resetbinding();
        }
    }
}
