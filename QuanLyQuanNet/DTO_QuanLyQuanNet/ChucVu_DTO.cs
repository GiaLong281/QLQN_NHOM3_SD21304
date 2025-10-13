using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class ChucVu_DTO
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MaTrangThai { get; set; }

        public ChucVu_DTO() { } // thêm constructor mặc định

        public ChucVu_DTO(string ma, string ten, string trangThai)
        {
            MaChucVu = ma;
            TenChucVu = ten;
            MaTrangThai = trangThai;
        }
    }
    public class ChucVuViewModel
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
    }
}
