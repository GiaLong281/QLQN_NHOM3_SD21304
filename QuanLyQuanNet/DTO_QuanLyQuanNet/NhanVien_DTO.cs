
using System;

public class NhanVien_DTO
{
    public string MaNhanVien { get; set; }
    public string HoTen { get; set; }
    public string Email { get; set; }
    public string MatKhau { get; set; }
    public string MaChucVu { get; set; }
    public string MaTrangThai { get; set; }
    public DateTime NgayTao { get; set; }
}
public class NhanVienViewModel
{
    public string MaNhanVien { get; set; }
    public string HoTen { get; set; }
    public string Email { get; set; }
    public string MatKhau { get; set; }

    public string MaChucVu { get; set; }
    public string TenChucVu { get; set; }

    public string MaTrangThai { get; set; }
    public string TenTrangThai { get; set; }

    public DateTime NgayTao { get; set; }
}
