using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class LoaiKhachHang_BUS
    {
        public static List<LoaiKhachHang_DTO> LayTatCa()
        {
            return LoaiKhachHang_DAL.GetAll();
        }

        public static List<LoaiKhachHangViewModel> GetAllView()
        {
            var dsLoai = LoaiKhachHang_DAL.GetAll();
            var dsTrangThai = LoaiTrangThai_BUS.LayTatCa();

            var result = from loai in dsLoai
                         join tt in dsTrangThai on loai.MaTrangThai equals tt.MaTrangThai
                         select new LoaiKhachHangViewModel
                         {
                             MaLoaiKhachHang = loai.MaLoaiKhachHang,
                             TenLoaiKhachHang = loai.TenLoai,
                             MaTrangThai = loai.MaTrangThai,
                             TenTrangThai = tt.TenTrangThai
                         };

            return result.ToList();
        }
        public static bool Them(LoaiKhachHang_DTO loai, out string loi)
        {
            try
            {
                loi = null;
                return LoaiKhachHang_DAL.Them(loai);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi thêm: " + ex.Message;
                return false;
            }
        }

        public static bool Sua(LoaiKhachHang_DTO loai, out string loi)
        {
            try
            {
                loi = null;
                return LoaiKhachHang_DAL.Sua(loai);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi sửa: " + ex.Message;
                return false;
            }
        }

        public static bool Xoa(string ma, out string loi)
        {
            try
            {
                loi = null;
                return LoaiKhachHang_DAL.Xoa(ma);
            }
            catch (Exception ex)
            {
                loi = "❌ Lỗi khi xoá: " + ex.Message;
                return false;
            }
        }
        public static List<LoaiKhachHang_DTO> TimKiem(string tuKhoa)
        {
            return LoaiKhachHang_DAL.TimKiem(tuKhoa);
        }
        public static string SinhMaLoaiKhachHang()
        {
            var ds = GetAllView();
            if (ds == null || ds.Count == 0)
                return "LKH01";
            var max = ds
                .Select(x => x.MaLoaiKhachHang)
                .Where(m => m.StartsWith("LKH"))
                .Select(m => int.TryParse(m.Substring(3), out int n) ? n : 0)
                .DefaultIfEmpty(0)
                .Max();
            return $"LKH{(max + 1):D2}";
        }
    }
}
