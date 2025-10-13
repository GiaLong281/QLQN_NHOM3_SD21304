using System.Collections.Generic;
using DTO_QuanLyQuanNet;
using DAL_QuanLyQuanNet;

public class DonDatHang_BUS
{
    public static List<DonDatHang_DTO> LayTatCa() => DonDatHang_DAL.LayTatCa();
    public static DonDatHang_DTO LayTheoMa(string maDon) => DonDatHang_DAL.LayTheoMa(maDon);
}