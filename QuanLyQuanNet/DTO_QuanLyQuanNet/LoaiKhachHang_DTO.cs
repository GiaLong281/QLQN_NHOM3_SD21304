using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class LoaiKhachHang_DTO
    {
        public string MaLoaiKhachHang { get; set; }
        public string TenLoai { get; set; }
        public string MaTrangThai { get; set; }

        public LoaiKhachHang_DTO(string ma, string ten, string mtt)
        {
            MaLoaiKhachHang = ma;
            TenLoai = ten;
            MaTrangThai = mtt;
        }
    }
    public class LoaiKhachHangViewModel
    {
        public string MaLoaiKhachHang { get; set; }
        public string TenLoaiKhachHang { get; set; }
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
    }
}
