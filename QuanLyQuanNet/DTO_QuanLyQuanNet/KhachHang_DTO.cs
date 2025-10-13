
using System;

public class KhachHang_DTO
{
    public string MaKhachHang { get; set; }
    public string TenDangNhap { get; set; }
    public string MatKhau { get; set; }
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string CCCD { get; set; }
    public DateTime? NgayTao { get; set; }
    public string MaTrangThai { get; set; }
    public string MaLoaiKhachHang { get; set; }
    public decimal SoDuTaiKhoan { get; set; }
}

public class KhachHangViewModel
{
    public string MaKhachHang { get; set; }
    public string TenDangNhap { get; set; }
    public string MatKhau { get; set; }
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string CCCD { get; set; }
    public DateTime NgayTao { get; set; }
    public string MaTrangThai { get; set; }
    public string TenTrangThai { get; set; }
    public string MaLoaiKhachHang { get; set; }
    public string TenLoaiKhachHang { get; set; }
    public decimal SoDuTaiKhoan { get; set; }
}