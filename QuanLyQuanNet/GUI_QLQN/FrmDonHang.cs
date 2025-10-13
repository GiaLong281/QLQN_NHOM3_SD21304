using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO_QuanLyQuanNet;
using BLL_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class FrmDonHang : Form
    {
        private List<DonDatHang_DTO> danhSachGoc;

        public FrmDonHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            danhSachGoc = DonDatHang_BUS.LayTatCa();

            var data = danhSachGoc.Select(d => new DonHangViewModel
            {
                MaDonDatHang = d.MaDonDatHang,
                MaKhachHang = d.MaKhachHang,
                Gio = d.ThoiGianDat.ToString("HH:mm:ss"),
                Ngay = d.NgayTao.ToString("dd/MM/yyyy"),
                TongTien = d.TongTien
            }).ToList();

            dgvQLDH.DataSource = data;
            DatTenCotTiengViet();
            dgvQLDH.ClearSelection();
        }

        private void DatTenCotTiengViet()
        {
            dgvQLDH.Columns["MaDonDatHang"].HeaderText = "Mã Đơn";
            dgvQLDH.Columns["MaKhachHang"].HeaderText = "Mã Khách";
            dgvQLDH.Columns["Gio"].HeaderText = "Giờ";
            dgvQLDH.Columns["Ngay"].HeaderText = "Ngày";
            dgvQLDH.Columns["TongTien"].HeaderText = "Tổng Tiền";

            dgvQLDH.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                return;
            }

            var ketQua = danhSachGoc
                .Where(d => d.MaDonDatHang.ToLower().Contains(keyword))
                .Select(d => new DonHangViewModel
                {
                    MaDonDatHang = d.MaDonDatHang,
                    MaKhachHang = d.MaKhachHang,
                    Gio = d.ThoiGianDat.ToString("HH:mm:ss"),
                    Ngay = d.NgayTao.ToString("dd/MM/yyyy"),
                    TongTien = d.TongTien
                }).ToList();

            dgvQLDH.DataSource = ketQua;
            dgvQLDH.ClearSelection();

            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy đơn hàng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvQLDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvQLDH.Rows[e.RowIndex].DataBoundItem as DonHangViewModel;
                if (row != null)
                {
                    txtMaDH.Text = row.MaDonDatHang;
                    txtMaKH.Text = row.MaKhachHang;
                    dtpThoiGianDat.Text = row.Gio;
                    dtpNgayDatHang.Text = row.Ngay;
                    txtTongTien.Text = row.TongTien.ToString("N0");
                }
            }
        }

        public class DonHangViewModel
        {
            public string MaDonDatHang { get; set; }
            public string MaKhachHang { get; set; }
            public string Gio { get; set; }
            public string Ngay { get; set; }
            public decimal TongTien { get; set; }
        }
    }
}
