using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyQuanNet
{
    public class LoaiMay_DTO
    {
        public string MaLoaiMay { get; set; }
        public string TenLoaiMay { get; set; }
        public string MaTrangThai { get; set; }

        public LoaiMay_DTO(string ma, string ten, string trangThai)
        {
            MaLoaiMay = ma;
            TenLoaiMay = ten;
            MaTrangThai = trangThai;
        }
    }
}

