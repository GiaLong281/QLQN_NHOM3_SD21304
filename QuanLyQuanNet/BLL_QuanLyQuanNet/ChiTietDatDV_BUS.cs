using System;
using DTO_QuanLyQuanNet;
using DAL_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class ChiTietDatDV_BUS
    {
        public static bool ThemChiTietDatDV(ChiTietDatDV_DTO dto)
        {
            return ChiTietDatDV_DAL.ThemChiTietDatDV(dto);
        }
    }
}
