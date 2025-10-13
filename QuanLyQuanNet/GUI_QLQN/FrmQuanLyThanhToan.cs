using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyQuanNet;
using BUS_QuanLyQuanNet;
using BLL_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class FrmQuanLyThanhToan : Form
    {
        private readonly ThanhToan_BUS bll = new ThanhToan_BUS();

        public FrmQuanLyThanhToan()
        {
            InitializeComponent();
        }

        private void FrmQuanLyThanhToan_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các phiên chưa thanh toán (giả sử có hàm lấy đúng nghiệp vụ)
            var dsPhien = LayDanhSachPhienChuaThanhToan();
            LoadLichSuThanhToan();

            //chỉnh sửa lại kích cỡ size chữ header của dgv = 8
            dgvChiTietPhien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            //đổi tựa tên header của dgv


            cboMaPhien.DataSource = dsPhien;
            cboMaPhien.DisplayMember = "MaPhien";
            cboMaPhien.ValueMember = "MaPhien";
            cboMaPhien.SelectedIndex = -1;

            LamMoi();
        }



        private void LoadLichSuThanhToan()
        {
            var dsLichSu = ThanhToan_BUS.LayLichSuThanhToan()
                .AsEnumerable()
                .Where(row => row.Field<string>("TenTrangThai") == "Hoạt động")
                .OrderBy(row => row.Field<string>("MaPhien"))
                .CopyToDataTable();

            dgvChiTietPhien.DataSource = dsLichSu;

            // Đổi tên header cho tất cả các cột từ view SQL
            dgvChiTietPhien.Columns["MaPhien"].HeaderText = "Mã Phiên";
            dgvChiTietPhien.Columns["MaKhachHang"].HeaderText = "Mã KH";
            dgvChiTietPhien.Columns["TenKhachHang"].HeaderText = "Tên KH";
            dgvChiTietPhien.Columns["MaLoaiKhachHang"].HeaderText = "Mã Loại KH";
            dgvChiTietPhien.Columns["LoaiKhach"].HeaderText = "Loại Khách";
            dgvChiTietPhien.Columns["MaMay"].HeaderText = "Mã Máy";
            dgvChiTietPhien.Columns["ThoiGianBatDau"].HeaderText = "Bắt Đầu";
            dgvChiTietPhien.Columns["ThoiGianKetThuc"].HeaderText = "Kết Thúc";
            dgvChiTietPhien.Columns["TongSoGio"].HeaderText = "Số Giờ";
            dgvChiTietPhien.Columns["TongTien"].HeaderText = "Tiền Chơi";
            dgvChiTietPhien.Columns["TongTienDichVu"].HeaderText = "Tiền DV";
            dgvChiTietPhien.Columns["KhuyenMai"].HeaderText = "Khuyến Mãi";
            dgvChiTietPhien.Columns["SoTienConLai"].HeaderText = "Số dư";
            dgvChiTietPhien.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvChiTietPhien.Columns["MaTrangThai"].HeaderText = "Mã Trạng Thái";
            dgvChiTietPhien.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
            dgvChiTietPhien.Columns["DaThanhToan"].HeaderText = "Đã Thanh Toán";
        }

        private List<PhienChoi_DTO> LayDanhSachPhienChuaThanhToan()
        {
            // Giả sử có thuộc tính DaThanhToan hoặc MaTrangThai != 'TT02'
            // Nếu không, bạn cần sửa lại cho đúng nghiệp vụ lấy phiên chưa thanh toán
            var allPhien = BLL_QuanLyQuanNet.PhienChoi_BLL.LayTatCaPhien();
            return allPhien.Where(p => p.ThoiGianKetThuc != null && (p.MaTrangThai == null || p.MaTrangThai != "TT02")).ToList();
        }

        private void cboMaPhien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhien = cboMaPhien.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maPhien))
            {
                LamMoi();
                return;
            }

            // Lấy thông tin phiên chơi
            var phien = BLL_QuanLyQuanNet.PhienChoi_BLL.LayTatCaPhien().FirstOrDefault(p => p.MaPhien == maPhien);
            if (phien == null)
            {
                LamMoi();
                return;
            }

            txtMaKH.Text = phien.MaKhachHang ?? "";

            // Lấy thông tin khách hàng từ bảng KhachHang
            var kh = new BLL_QuanLyQuanNet.KhachHang_BUS().LayTheoMa(phien.MaKhachHang);
            txtLoaiKH.Text = kh?.MaLoaiKhachHang ?? "";
            txtSoTienConLai.Text = kh != null ? kh.SoDuTaiKhoan.ToString("N0") : "";

            // Xóa các textbox chi tiết
            txtGioChoi.Clear();
            txtTienChoi.Clear();
            txtTienDV.Clear();
            txtKhuyenMai.Clear();
            txtTT.Clear();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Chỉ hiển thị số tiền cần thanh toán, KHÔNG trừ vào tài khoản hoặc cập nhật dữ liệu
            string maPhien = cboMaPhien.SelectedValue?.ToString();
            decimal donGia = PhienChoi_BLL.LayDonGia();
            bool laKhachCoTaiKhoan = !string.IsNullOrEmpty(txtMaKH.Text);

            if (string.IsNullOrEmpty(maPhien))
            {
                MessageBox.Show("Vui lòng chọn phiên cần tính tiền!");
                return;
            }

            if (laKhachCoTaiKhoan)
            {
                var result = bll.ThanhToanCoKhuyenMai(maPhien, donGia);
                if (result.Success)
                {
                    txtGioChoi.Text = result.SoGio.ToString("0.##");
                    txtTienChoi.Text = result.TienGio.ToString("N0");
                    txtTienDV.Text = result.TienDV.ToString("N0");
                    txtKhuyenMai.Text = result.GiamGia.ToString("N0");
                    txtTT.Text = result.TongPhaiTra.ToString("N0");
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var result = bll.TinhTienXuatHoaDon(maPhien, donGia);
                if (result.Success)
                {
                    txtGioChoi.Text = result.SoGio.ToString("0.##");
                    txtTienChoi.Text = result.TienGio.ToString("N0");
                    txtTienDV.Text = result.TienDV.ToString("N0");
                    txtKhuyenMai.Text = "0"; // Khách vãng lai không có khuyến mãi
                    txtTT.Text = result.TongCanThu.ToString("N0");
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXNTT_Click(object sender, EventArgs e)
        {
            string maPhien = cboMaPhien.SelectedValue?.ToString();
            decimal donGia = PhienChoi_BLL.LayDonGia();
            bool laKhachCoTaiKhoan = !string.IsNullOrEmpty(txtMaKH.Text);

            if (string.IsNullOrEmpty(maPhien))
            {
                MessageBox.Show("Vui lòng chọn phiên cần thanh toán!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn thanh toán phiên này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (laKhachCoTaiKhoan)
            {
                // Lấy số dư thực tế từ DB
                decimal soDuKhachHang = KhachHang_BUS.LaySoDuKhachHang(txtMaKH.Text.Trim());

                // Tính tổng phải trả trước khi trừ tiền
                var result = bll.ThanhToanCoKhuyenMai(maPhien, donGia);

                if (result.Success)
                {
                    if (soDuKhachHang < result.TongPhaiTra)
                    {
                        MessageBox.Show($"Tài khoản không đủ để thanh toán. Cần ít nhất {result.TongPhaiTra:N0} VND.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tiếp tục xử lý thanh toán...
                    MessageBox.Show(
                        $"Thanh toán thành công!\n" +
                        $"Số giờ chơi: {result.SoGio}\n" +
                        $"Tiền giờ: {result.TienGio:N0}\n" +
                        $"Tiền dịch vụ: {result.TienDV:N0}\n" +
                        $"Giảm giá: {result.GiamGia:N0}\n" +
                        $"Tổng phải trả: {result.TongPhaiTra:N0}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    FrmQuanLyThanhToan_Load(null, null);
                    LoadLichSuThanhToan();
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Khách vãng lai
                var result = bll.TinhTienXuatHoaDon(maPhien, donGia);
                if (result.Success)
                {
                    MessageBox.Show(
                        $"Tính tiền thành công!\n" +
                        $"Số giờ chơi: {result.SoGio}\n" +
                        $"Tiền giờ: {result.TienGio:N0}\n" +
                        $"Tiền dịch vụ: {result.TienDV:N0}\n" +
                        $"Giảm giá: {result.GiamGia:N0}\n" +
                        $"Tổng cần thu: {result.TongCanThu:N0}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    FrmQuanLyThanhToan_Load(null, null);
                    LoadLichSuThanhToan();
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            FrmQuanLyThanhToan_Load(null, null);
        }

        private void LamMoi()
        {
            cboMaPhien.SelectedIndex = -1;
            txtMaKH.Clear();
            txtLoaiKH.Clear();
            txtSoTienConLai.Clear();
            txtGioChoi.Clear();
            txtTienChoi.Clear();
            txtTienDV.Clear();
            txtKhuyenMai.Clear();
            txtTT.Clear();
        }

        private void dgvChiTietPhien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
