using System.Collections.Generic;
using DAL_QuanLyQuanNet;
using System.Linq;

public class NhanVien_BUS
{
    public List<NhanVien_DTO> GetAll() => NhanVien_DAL.GetAll();

    public List<NhanVienViewModel> GetAllView()
    {
        var dsNV = NhanVien_DAL.GetAll();
        var dsChucVu = ChucVu_DAL.LayTatCa();
        var dsTrangThai = LoaiTrangThai_DAL.LayTatCa();

        var kq = from nv in dsNV
                 join cv in dsChucVu on nv.MaChucVu equals cv.MaChucVu
                 join tt in dsTrangThai on nv.MaTrangThai equals tt.MaTrangThai
                 select new NhanVienViewModel
                 {
                     MaNhanVien = nv.MaNhanVien,
                     HoTen = nv.HoTen,
                     Email = nv.Email,
                     MatKhau = nv.MatKhau,
                     MaChucVu = nv.MaChucVu,
                     TenChucVu = cv.TenChucVu,
                     MaTrangThai = nv.MaTrangThai,
                     TenTrangThai = tt.TenTrangThai,
                     NgayTao = nv.NgayTao
                 };

        return kq.ToList();
    }

    public void Add(NhanVien_DTO nv) => NhanVien_DAL.Add(nv);
    public void Update(NhanVien_DTO nv) => NhanVien_DAL.Update(nv);
    public void Delete(string maNV) => NhanVien_DAL.Delete(maNV);

    public static NhanVien_DTO DangNhap(string maNV, string matKhau)
    {
        return NhanVien_DAL.KiemTraDangNhap(maNV, matKhau);
    }
    public static bool KiemTraMatKhau(string maNV, string matKhauCu)
    {
        return NhanVien_DAL.KiemTraMatKhau(maNV, matKhauCu);
    }
    public static bool DoiMatKhau(string maNV, string matKhauMoi)
    {
        return NhanVien_DAL.DoiMatKhau(maNV, matKhauMoi);
    }
    public static NhanVien_DTO LayTheoMa(string maNV)
    {
        var list = NhanVien_DAL.GetAll();
        return list.FirstOrDefault(nv => nv.MaNhanVien == maNV);
    }
}
