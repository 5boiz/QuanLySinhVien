using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.Models
{
    public enum LoaiNguoiDung
    {
        SinhVien,
        GiaoVien
    }
    public class User
    {
        public string ID { get; set; }
        public string HoTen { get; set; }  
        public string GioiTinh { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public LoaiNguoiDung LoaiNguoiDung { get; set; }


    }
}
