using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DTO_QuanLyQuanNet
{
    public class HinhThucThanhToan_DTO
    {
        public string MaHinhThuc { get; set; }
        public string TenHinhThuc { get; set; }

        public HinhThucThanhToan_DTO() { }

        public HinhThucThanhToan_DTO(string maHT, string tenHT)
        {
            MaHinhThuc = maHT;
            TenHinhThuc = tenHT;
        }
    }
}

