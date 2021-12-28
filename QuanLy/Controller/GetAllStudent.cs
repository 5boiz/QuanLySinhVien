﻿using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   
    partial class Controller
    {
        public List<User> GetAllStudent()
        {
            List<User> users = new List<User>();
            Static.mock.Data.users.Values.ToList().ForEach(u => {
                if (u.LoaiNguoiDung == LoaiNguoiDung.SinhVien)
                {
                    users.Add(u);
                }
            });

            return users;
        }
    }
}