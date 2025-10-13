using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class ThanhToan_DTO
    {
        public string MaThanhToan { get; set; }
        public string MaKhachHang { get; set; }
        public string MaTaiKhoan { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; }

        public ThanhToan_DTO() { }

        public ThanhToan_DTO(string maTT, string maKH, string maTK, DateTime tgTT, decimal tongTien, DateTime ngayTao)
        {
            MaThanhToan = maTT;
            MaKhachHang = maKH;
            MaTaiKhoan = maTK;
            ThoiGianThanhToan = tgTT;
            TongTien = tongTien;
            NgayTao = ngayTao;
        }
    }
}
