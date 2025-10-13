using System.Collections.Generic;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class LoaiTrangThai_BUS
    {
        public static List<LoaiTrangThai_DTO> LayTatCa()
        {
            return LoaiTrangThai_DAL.LayTatCa();
        }

        public static bool Them(LoaiTrangThai_DTO ltt)
        {
            if (string.IsNullOrWhiteSpace(ltt.MaTrangThai) || string.IsNullOrWhiteSpace(ltt.TenTrangThai))
                return false;

            return LoaiTrangThai_DAL.Them(ltt);
        }

        public static bool Sua(LoaiTrangThai_DTO ltt)
        {
            return LoaiTrangThai_DAL.Sua(ltt);
        }

        public static bool Xoa(string ma)
        {
            return LoaiTrangThai_DAL.Xoa(ma);
        }
    }
}
