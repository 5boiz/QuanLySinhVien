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
        public BindingSource SearchUser(LoaiNguoiDung loaiNguoiDung, string query)
        {
            
            List<User> users = new List<User>();
            Static.mock.Data.users.Values.ToList().ForEach(u => {
                if (u.LoaiNguoiDung == loaiNguoiDung)
                {
                    if (u.HoTen.Contains(query) || GetClassByID(u.Lop).TenLop.Contains(query) || u.DiaChi.Contains(query) || u.GioiTinh.Contains(query) )
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
                }
            });

            if (loaiNguoiDung == LoaiNguoiDung.SinhVien)
            {
                bindingSourceStudent.DataSource = users;
                return bindingSourceStudent;
            }
            else
            {
                bindingSourceTeacher.DataSource = users;
                return bindingSourceTeacher;
            }

            
        }
    }
}
