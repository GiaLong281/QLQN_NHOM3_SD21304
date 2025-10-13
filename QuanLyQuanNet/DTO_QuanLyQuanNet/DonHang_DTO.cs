using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class DonDatHang_DTO
    {
        public string MaDonDatHang { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
