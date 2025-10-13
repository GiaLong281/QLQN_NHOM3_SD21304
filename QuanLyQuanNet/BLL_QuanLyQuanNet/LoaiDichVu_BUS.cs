using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;


namespace BLL_QuanLyQuanNet
{
    public class LoaiDichVu_BUS
    {
        private LoaiDichVu_DAL dal = new LoaiDichVu_DAL();
        // Lấy danh sách loại dịch vụ
        public List<LoaiDichVu_DTO> GetAll()
        {
            return dal.GetAll();
        }
        // Thêm loại dịch vụ
        public bool Add(LoaiDichVu_DTO loaiDV)
        {
            if (string.IsNullOrWhiteSpace(loaiDV.MaLoaiDichVu) || string.IsNullOrWhiteSpace(loaiDV.TenLoaiDichVu))
            {
                return false; // Dữ liệu không hợp lệ
            }
            return dal.Add(loaiDV);
        }
        // Cập nhật loại dịch vụ
        public bool Update(LoaiDichVu_DTO loaiDV)
        {
            if (string.IsNullOrWhiteSpace(loaiDV.MaLoaiDichVu))
                return false;
            return dal.Update(loaiDV);
        }
        // Xoá loại dịch vụ
        public bool Delete(string maLoaiDichVu)
        {
            if (string.IsNullOrWhiteSpace(maLoaiDichVu))
                return false;
            return dal.Delete(maLoaiDichVu);
        }
        // Tìm kiếm theo mã loại dịch vụ
        public List<LoaiDichVu_DTO> Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}
