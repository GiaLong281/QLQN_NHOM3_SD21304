using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QuanLyQuanNet
{
    public class CaLamViec_BUS
    {
        private static CaLamViec_DAL dal = new CaLamViec_DAL();
        private static LoaiCLV_DAL loaiDal = new LoaiCLV_DAL();

        public static List<CaLamViecViewModel> LayDanhSachChiTiet()
        {
            var danhSachGoc = dal.LayDanhSach();
            var danhSachLoaiCa = loaiDal.LayDanhSachLoaiCLV();

            var kq = from ca in danhSachGoc
                     join loai in danhSachLoaiCa on ca.MaLoaiCa equals loai.MaLoai
                     select new CaLamViecViewModel
                     {
                         MaCa = ca.MaCa,
                         MaNhan = ca.MaNhanVien,
                         MaLoaiCa = ca.MaLoaiCa,
                         TenLoaiCa = loai.TenLoai,
                         NgayLam = ca.NgayLam,
                         NgayTao = ca.NgayTao,
                         GhiChu = ca.GhiChu
                     };

            return kq.ToList();
        }

        public class CaLamViecViewModel
        {
            public string MaCa { get; set; }
            public string MaNhan { get; set; }
            public string MaLoaiCa { get; set; }
            public string TenLoaiCa { get; set; }
            public DateTime NgayLam { get; set; }
            public DateTime NgayTao { get; set; }
            public string GhiChu { get; set; }
        }

        public  bool Them(CaLamViec_DTO clv) => dal.Them(clv);
        public  bool Sua(CaLamViec_DTO clv) => dal.Sua(clv);
        public  bool Xoa(string maCa) => dal.Xoa(maCa);
        public  List<CaLamViec_DTO> TimKiem(string keyword) => dal.TimKiem(keyword);
        public  List<string> LayMaNhanVien() => dal.LayDanhSachMaNhanVien();
        public List<LoaiCLV_DTO> LayLoaiCa() => loaiDal.LayDanhSachLoaiCLV();
    }
}
