using System.Collections.Generic;
using DTO_QuanLyQuanNet;
using DAL_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class MayTinh_BUS
    {
        public static List<MayTinh_DTO> LayDanhSach()
        {
            return MayTinh_DAL.LayDanhSach();
        }
        public static MayTinh_DTO LayMayTheoMa(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma))
                return null;
            return MayTinh_DAL.LayMayTheoMa(ma);
        }

        public static bool Them(MayTinh_DTO mt)
        {
            if (string.IsNullOrWhiteSpace(mt.MaMay) || string.IsNullOrWhiteSpace(mt.TenMay))
                return false;

            return MayTinh_DAL.ThemMay(mt);
        }

        public static bool Sua(MayTinh_DTO mt)
        {
            if (string.IsNullOrWhiteSpace(mt.MaMay))
                return false;

            return MayTinh_DAL.SuaMay(mt);
        }

        public static bool Xoa(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma))
                return false;

            return MayTinh_DAL.XoaMay(ma);
        }
        public static bool CapNhatTrangThaiMay(string maMay, string maTrangThai)
        {
            if (string.IsNullOrWhiteSpace(maMay) || string.IsNullOrWhiteSpace(maTrangThai))
                return false;
            return MayTinh_DAL.CapNhatTrangThaiMay(maMay, maTrangThai);
        }
    }
}
