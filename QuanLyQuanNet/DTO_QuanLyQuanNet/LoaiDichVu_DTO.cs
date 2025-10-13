using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class LoaiDichVu_DTO
    {
        public string MaLoaiDichVu { get; set; }   
        public string TenLoaiDichVu { get; set; }
        public string MaTrangThai { get; set; }
        public DateTime? NgayTao { get; set; }

        public LoaiDichVu_DTO() { }

        public LoaiDichVu_DTO(string maLoaiDV, string tenLoaiDV, string maTrangThai, DateTime ngayTao)
        {
            MaLoaiDichVu = maLoaiDV;
            TenLoaiDichVu = tenLoaiDV;
            MaTrangThai = maTrangThai;
            NgayTao = ngayTao;
        }
    }
}
