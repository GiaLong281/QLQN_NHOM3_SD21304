using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class LoaiCLV_DTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public float LuongTheoGio { get; set; }
        public string MaTrangThai { get; set; }  // BẮT BUỘC PHẢI CÓ
    }

    public class LoaiCaLamViecViewModel
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public decimal LuongTheoGio { get; set; }

        public string MaTrangThai { get; set; }  // ẩn đi
        public string TenTrangThai { get; set; } // dùng để hiển thị
    }
}
