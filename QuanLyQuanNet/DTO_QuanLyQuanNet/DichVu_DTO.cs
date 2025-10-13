using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class DichVu_DTO
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string MaLoaiDV { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgayTao { get; set; }
        public byte[] AnhSP { get; set; }
        public string MaTrangThai { get; set; }
    }
}
