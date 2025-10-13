using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class ThongBao_DTO
    {
        public string MaThongBao { get; set; }
        public string MaPhien { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime ThoiGianThongBao { get; set; }
        public bool TrangThaiDoc { get; set; }
        public string NoiDung { get; set; }
    }
}
