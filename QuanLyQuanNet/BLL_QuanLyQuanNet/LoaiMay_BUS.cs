using System.Collections.Generic;
using DTO_QuanLyQuanNet;
using DAL_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class LoaiMay_BUS
    {
        public static List<LoaiMay_DTO> LayDanhSach()
        {
            return LoaiMay_DAL.LayDanhSach();
        }

        public static bool Them(LoaiMay_DTO loai)
        {
            if (string.IsNullOrWhiteSpace(loai.MaLoaiMay) || string.IsNullOrWhiteSpace(loai.TenLoaiMay))
                return false;

            return LoaiMay_DAL.ThemLoaiMay(loai);
        }

        public static bool Sua(LoaiMay_DTO loai)
        {
            if (string.IsNullOrWhiteSpace(loai.MaLoaiMay))
                return false;

            return LoaiMay_DAL.SuaLoaiMay(loai);
        }

        public static bool Xoa(string maLoai)
        {
            if (string.IsNullOrWhiteSpace(maLoai))
                return false;

            return LoaiMay_DAL.XoaLoaiMay(maLoai);
        }
    }
}
