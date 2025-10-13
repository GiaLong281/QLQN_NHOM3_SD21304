using System;
using System.Collections.Generic;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public static class HinhThucThanhToan_BUS
    {
        public static List<HinhThucThanhToan_DTO> LayTatCa()
        {
            return HinhThucThanhToan_DAL.LayTatCa();
        }

        public static bool Them(HinhThucThanhToan_DTO hinhThuc, out string loi)
        {
            try
            {
                loi = null;
                return HinhThucThanhToan_DAL.Them(hinhThuc);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi thêm: " + ex.Message;
                return false;
            }
        }

        public static bool Sua(HinhThucThanhToan_DTO hinhThuc, out string loi)
        {
            try
            {
                loi = null;
                return HinhThucThanhToan_DAL.Sua(hinhThuc);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi sửa: " + ex.Message;
                return false;
            }
        }

        public static bool Xoa(string maHinhThuc, out string loi)
        {
            try
            {
                loi = null;
                return HinhThucThanhToan_DAL.Xoa(maHinhThuc);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi xoá: " + ex.Message;
                return false;
            }
        }

        public static HinhThucThanhToan_DTO TimTheoMa(string maHT)
        {
            return LayTatCa().Find(ht => ht.MaHinhThuc == maHT);
        }
    }

}
