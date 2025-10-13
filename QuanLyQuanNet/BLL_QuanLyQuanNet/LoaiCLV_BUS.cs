using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanlyQuanNet
{
    public class LoaiCLV_BUS
    {
        private LoaiCLV_DAL dal = new LoaiCLV_DAL();

        public List<LoaiCLV_DTO> LayDanhSachLoaiCLV()
        {
            return dal.LayDanhSachLoaiCLV();
        }

        public List<LoaiCaLamViecViewModel> LayDanhSach()
        {
            var ds = dal.LayDanhSachLoaiCLV();
            var dsTrangThai = LoaiTrangThai_DAL.LayTatCa();

            var query = from clv in ds
                        join tt in dsTrangThai on clv.MaTrangThai equals tt.MaTrangThai
                        select new LoaiCaLamViecViewModel
                        {
                            MaLoai = clv.MaLoai,
                            TenLoai = clv.TenLoai,
                            GioBatDau = clv.GioBatDau,
                            GioKetThuc = clv.GioKetThuc,
                            LuongTheoGio = (decimal)clv.LuongTheoGio,
                            MaTrangThai = clv.MaTrangThai,
                            TenTrangThai = tt.TenTrangThai
                        };

            return query.ToList();
        }

        public bool ThemLoaiCLV(LoaiCLV_DTO loaiCLV)
        {
            if (string.IsNullOrEmpty(loaiCLV.MaLoai))
                throw new Exception("Mã loại không được để trống");

            if (string.IsNullOrEmpty(loaiCLV.TenLoai))
                throw new Exception("Tên loại không được để trống");

            if (loaiCLV.GioKetThuc <= loaiCLV.GioBatDau)
                throw new Exception("Giờ kết thúc phải sau giờ bắt đầu");

            if (loaiCLV.LuongTheoGio <= 0)
                throw new Exception("Lương theo giờ phải lớn hơn 0");

            return dal.ThemLoaiCLV(loaiCLV);
        }

        public bool SuaLoaiCLV(LoaiCLV_DTO loaiCLV)
        {
            // Kiểm tra tương tự như ThemLoaiCLV
            if (string.IsNullOrEmpty(loaiCLV.MaLoai))
                throw new Exception("Mã loại không được để trống");

            // ... các kiểm tra khác

            return dal.SuaLoaiCLV(loaiCLV);
        }

        public bool XoaLoaiCLV(string maLoai)
        {
            if (string.IsNullOrEmpty(maLoai))
                throw new Exception("Mã loại không được để trống");

            return dal.XoaLoaiCLV(maLoai);
        }

        public List<LoaiCLV_DTO> TimKiemLoaiCLV(string keyword)
        {
            return dal.TimKiemLoaiCLV(keyword);
        }
    }
}