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
        public List<User> GetAllTeacher()
        {
            List<User> users = new List<User>();
            Static.mock.Data.users.Values.ToList().ForEach(u => {
                if (u.LoaiNguoiDung == LoaiNguoiDung.GiaoVien)
                {
                    User user = new User();
                    user.ID = u.ID;
                    user.HoTen = u.HoTen;
                    user.GioiTinh = u.GioiTinh;
                    user.TenTaiKhoan = u.TenTaiKhoan;
                    user.MatKhau = u.MatKhau;
                    user.LoaiNguoiDung = u.LoaiNguoiDung;
                    user.DiaChi = u.DiaChi;
                    user.Lop = GetClassByID(u.Lop).TenLop;

                    users.Add(user);
                }
            });

            return users;
        }
    }
}
