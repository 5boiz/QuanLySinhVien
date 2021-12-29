using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   
    partial class Controller
    {
        public List<Class> GetAllClass()
        {
            List<Class> classes = new List<Class>();

            Static.mock.Data.classes.Values.ToList().ForEach(c => classes.Add(c));

            return classes;
        }
    }
}
