using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class CaLamViec_DTO
    {
        public string MaCa { get; set; }
        public string MaNhanVien { get; set; }
        public string MaLoaiCa { get; set; }
        public DateTime NgayLam { get; set; }
        public DateTime NgayTao { get; set; }
        public string GhiChu { get; set; }
    }
}
