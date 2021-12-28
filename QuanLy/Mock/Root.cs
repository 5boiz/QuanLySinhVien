using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    public class Root
    {
        public Dictionary<string, User> users { get; set; }

        public Dictionary<string, Class> classes { get; set; }

        public int LID { get; set; }
    }
}
