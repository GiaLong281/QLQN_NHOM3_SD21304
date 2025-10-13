using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace BLL_QuanLyQuanNet
{
    public class DichVu_BUS
    {
        private DichVu_DAL dal = new DichVu_DAL();

        // Lấy danh sách dịch vụ
        public List<DichVu_DTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Add(DichVu_DTO dv)
        {
            //thêm mới dịch vụ
            if (string.IsNullOrWhiteSpace(dv.MaDV) || string.IsNullOrWhiteSpace(dv.TenDV) || dv.DonGia <= 0)
                return false;
            if (dv.NgayTao == default(DateTime))
                dv.NgayTao = DateTime.Now; // Gán ngày tạo nếu không được cung cấp
            return dal.Add(dv);
        }

        public bool Update(DichVu_DTO dv)
        {
            //sửa đổi thông tin dịch vụ
            if (string.IsNullOrWhiteSpace(dv.MaDV) || string.IsNullOrWhiteSpace(dv.TenDV) || dv.DonGia <= 0)
                return false;
            if (dv.NgayTao == default(DateTime))
                dv.NgayTao = DateTime.Now; // Gán ngày tạo nếu không được cung cấp
            return dal.Update(dv);
        }

        public bool Delete(string maDichVu)
        {
            //xóa dịch vụ
            if (string.IsNullOrWhiteSpace(maDichVu))
                return false;
            return dal.Delete(maDichVu);
        }

        // Tìm kiếm theo mã dịch vụ
        public List<DichVu_DTO> Search(string keyword)
        {
            return dal.Search(keyword);
        }

        public string GetNextMaDichVu()
        {
            return dal.GetNextMaDichVu();
        }
    }
}
