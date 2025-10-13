using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLyQuanNet;
using DAL_QuanLyQuanNet;
using System.Data;

namespace BLL_QuanLyQuanNet
{
    public class ThongBao_BLL
    {
        private ThongBao_DAL dal = new ThongBao_DAL();

        public DataTable LayDanhSach(string keyword = "") => dal.LayDanhSach(keyword);
        public bool ThemMoi(ThongBao_DTO tb) => !dal.KiemTraTonTai(tb.MaThongBao) && dal.Them(tb);
        public bool CapNhat(ThongBao_DTO tb) => dal.CapNhat(tb);
        public bool Xoa(string maTB) => dal.Xoa(maTB);
        public bool KiemTraTonTai(string maTB) => dal.KiemTraTonTai(maTB);
    }
}
