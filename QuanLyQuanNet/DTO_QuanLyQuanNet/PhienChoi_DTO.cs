using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class PhienChoi_DTO
    {
        public string MaPhien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaMay { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }
        public double TongSoGio { get; set; }
        public decimal TongTien { get; set; }
        public decimal SoTienConLai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MaTrangThai { get; set; }  // mới thêm
    }
}
