using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;


namespace GUI_QLQN
{
    public partial class FrmChiTietDatDV : Form
    {
        private BindingList<ChiTietDatDV_DTO> dsChiTietTam = new BindingList<ChiTietDatDV_DTO>();
        // Sử dụng BLL để lấy dữ liệu dịch vụ
        private DichVu_BUS bus = new DichVu_BUS();
        private List<ucDichVu> danhSachDichVu = new List<ucDichVu>();
        public FrmChiTietDatDV()
        {
            InitializeComponent();
            LoadDanhSachDichVu();
            LoadComboBoxes();
        }

        private void LoadDanhSachDichVu()
        {
            // Giả sử bạn có danh sách dịch vụ từ cơ sở dữ liệu hoặc hardcode
            var danhSachDV = bus.GetAll();

            foreach (var item in danhSachDV)
            {
                var uc = new ucDichVu
                {
                    MaDichVu = item.MaDV,
                    TenDichVu = item.TenDV,
                    DonGia = item.DonGia
                };

                uc.SoLuongThayDoi += Uc_SoLuongThayDoi;

                danhSachDichVu.Add(uc);
                flpDichVu.Controls.Add(uc);
            }
        }

        private void LoadComboBoxes()
        {
            var dsPhien = PhienChoi_BLL.LayTatCaPhien();
            cboMaPhien.DataSource = dsPhien;
            cboMaPhien.DisplayMember = "MaPhien";
            cboMaPhien.ValueMember = "MaPhien";
            // Load mã máy
            var mayList = MayTinh_BUS.LayDanhSach();
            cboMaMay.DataSource = mayList;
            cboMaMay.DisplayMember = "TenMay";
            cboMaMay.ValueMember = "MaMay";
        }

        private void CapNhatDataGridView()
        {
            dsChiTietTam.Clear();
            string maPhien = cboMaPhien.SelectedValue?.ToString() ?? "";
            foreach (var uc in danhSachDichVu)
            {
                if (uc.SoLuong > 0)
                {
                    dsChiTietTam.Add(new ChiTietDatDV_DTO
                    {
                        MaChiTiet = $"CTDV{(dsChiTietTam.Count + 1):D3}",
                        MaPhien = maPhien,
                        MaDichVu = uc.MaDichVu,
                        SoLuong = uc.SoLuong,
                        DonGia = uc.DonGia
                    });
                }
            }
            dgvdadat.DataSource = null;
            dgvdadat.DataSource = dsChiTietTam;
        }

        private void Uc_SoLuongThayDoi(object sender, EventArgs e)
        {
            decimal tongTien = danhSachDichVu.Sum(dv => dv.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
            CapNhatDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dsChiTietTam.Count == 0)
            {
                MessageBox.Show("Chưa có dịch vụ nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = true;

            foreach (var item in dsChiTietTam)
            {
                if (!ChiTietDatDV_BUS.ThemChiTietDatDV(item))
                {
                    success = false;
                    break;
                }
            }

            if (success)
            {
                MessageBox.Show("Thêm chi tiết đặt dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsChiTietTam.Clear();
                dgvdadat.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";

                // Reset số lượng trong các ucDichVu về 0
                foreach (var uc in danhSachDichVu)
                {
                    uc.ResetSoLuong();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn hủy toàn bộ dịch vụ đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                dsChiTietTam.Clear();
                dgvdadat.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";

                foreach (var uc in danhSachDichVu)
                {
                    uc.ResetSoLuong(); // reset về 0
                }
            }
        }
    }
}
