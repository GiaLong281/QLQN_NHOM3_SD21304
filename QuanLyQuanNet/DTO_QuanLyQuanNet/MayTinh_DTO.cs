namespace DTO_QuanLyQuanNet
{
    public class MayTinh_DTO
    {
        public string MaMay { get; set; }
        public string TenMay { get; set; }
        public string MaLoaiMay { get; set; }
        public string MaTrangThai { get; set; }

        public MayTinh_DTO(string maMay, string tenMay, string maLoaiMay, string maTrangThai)
        {
            MaMay = maMay;
            TenMay = tenMay;
            MaLoaiMay = maLoaiMay;
            MaTrangThai = maTrangThai;
        }
    }
}
