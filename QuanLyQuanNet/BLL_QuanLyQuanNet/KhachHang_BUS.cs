using System.Collections.Generic;
using BLL_QuanLyQuanNet;
using System.Linq;
using System;


namespace BLL_QuanLyQuanNet
{
    public class KhachHang_BUS
    {
        KhachHang_DAL dal = new KhachHang_DAL();

        public List<KhachHang_DTO> GetAllKhachHang() => dal.GetAll();

        public List<KhachHangViewModel> GetAllView()
        {
            var dsKH = dal.GetAll();
            var dsLoai = LoaiKhachHang_BUS.LayTatCa();
            var dsTrangThai = LoaiTrangThai_BUS.LayTatCa();

            var kq = from kh in dsKH
                     join loai in dsLoai on kh.MaLoaiKhachHang equals loai.MaLoaiKhachHang
                     join tt in dsTrangThai on kh.MaTrangThai equals tt.MaTrangThai
                     select new KhachHangViewModel
                     {
                         MaKhachHang = kh.MaKhachHang,
                         TenDangNhap = kh.TenDangNhap,
                         MatKhau = kh.MatKhau,
                         HoTen = kh.HoTen,
                         SoDienThoai = kh.SoDienThoai,
                         Email = kh.Email,
                         CCCD = kh.CCCD,
                         NgayTao = kh.NgayTao ?? DateTime.Now,
                         MaLoaiKhachHang = kh.MaLoaiKhachHang,
                         TenLoaiKhachHang = loai.TenLoai,
                         MaTrangThai = kh.MaTrangThai,
                         TenTrangThai = tt.TenTrangThai,
                         SoDuTaiKhoan = kh.SoDuTaiKhoan
                     };

            return kq.ToList();
        }

        //laytheoma
        public KhachHang_DTO LayTheoMa(string maKH)
        {
            return dal.LayTheoMa(maKH);
        }

        public static decimal LaySoDuKhachHang(string maKhachHang)
        {
            return KhachHang_DAL.LaySoDuKhachHang(maKhachHang);
        }

        public static void CapNhatSoDuKhachHang(string maKhachHang, decimal soDuMoi)
        {
            KhachHang_DAL.CapNhatSoDuKhachHang(maKhachHang, soDuMoi);
        }

        public void AddKhachHang(KhachHang_DTO kh) => dal.Insert(kh);

        public void UpdateKhachHang(KhachHang_DTO kh) => dal.Update(kh);

        public void DeleteKhachHang(string maKH) => dal.Delete(maKH);
    }
}