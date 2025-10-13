namespace DTO_QuanLyQuanNet
{
    public class LoaiTrangThai_DTO
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }

        public LoaiTrangThai_DTO(string ma, string ten, string mota = "")
        {
            MaTrangThai = ma;
            TenTrangThai = ten;
            MoTa = mota;
        }
    }
}
