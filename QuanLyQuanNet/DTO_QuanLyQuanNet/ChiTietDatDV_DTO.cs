using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class ChiTietDatDV_DTO
    {
            public string MaChiTiet { get; set; }
            public string MaPhien { get; set; }
            public string MaDichVu { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLuong * DonGia;
    }
}
