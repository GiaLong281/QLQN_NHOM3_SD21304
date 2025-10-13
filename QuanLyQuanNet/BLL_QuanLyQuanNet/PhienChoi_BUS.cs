using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;

namespace BLL_QuanLyQuanNet
{
    public class PhienChoi_BLL
    {
        private readonly PhienChoi_DAL dal = new PhienChoi_DAL();

        // Lấy danh sách tất cả các phiên chơi
        public static List<PhienChoi_DTO> LayTatCaPhien()
        {
            return PhienChoi_DAL.GetAll();
        }

        // Thêm phiên chơi mới
        public bool ThemPhien(PhienChoi_DTO pc)
        {
            return PhienChoi_DAL.ThemPhienChoi(pc);
        }

        // Cập nhật phiên chơi
        public bool CapNhatPhien(PhienChoi_DTO pc)
        {
            return PhienChoi_DAL.CapNhatPhienChoi(pc);
        }

        // Xóa mềm phiên chơi (đổi trạng thái)
        public bool XoaPhien(string maPhien)
        {
            return PhienChoi_DAL.XoaPhienChoi_Mem(maPhien);
        }

        // Tìm kiếm phiên chơi theo mã máy, mã khách, mã phiên...
        public List<PhienChoi_DTO> TimKiemPhien(string tuKhoa)
        {
            return PhienChoi_DAL.TimKiemPhien(tuKhoa);
        }

        // Lấy chi tiết một phiên chơi theo mã
        public PhienChoi_DTO LayPhienTheoMa(string maPhien)
        {
            return PhienChoi_DAL.LayPhienChoiTheoMa(maPhien);
        }

        // Gọi stored procedure để tính tiền phiên chơi
        public static decimal TinhTienPhien(string maPhien)
        {
            return PhienChoi_DAL.TinhTienPhien(maPhien);
        }

        public static decimal LayDonGia()
        {
            return PhienChoi_DAL.LayDonGiaHienTai();
        }

        // Cập nhật kết thúc phiên chơi và tính tiền
        public static bool CapNhatKetThucPhien(string maPhien, DateTime tgKetThuc, double tongGio, decimal tongTien, decimal tienConLai)
        {
            return PhienChoi_DAL.CapNhatKetThucPhien(maPhien, tgKetThuc, tongGio, tongTien, tienConLai);
        }
        public string TaoMaPhienMoi()
        {
            return PhienChoi_DAL.GenerateMaPhienMoi();
        }
    }
}