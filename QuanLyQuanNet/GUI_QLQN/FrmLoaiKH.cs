using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL_QuanLyQuanNet;
using BUS_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class FrmLoaiKH : Form
    {
        public FrmLoaiKH()
        {
            InitializeComponent();
        }

        private void FrmLoaiKH_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadTrangThai();
        }

        private void LoadDuLieu()
        {
            var dsView = LoaiKhachHang_BUS.GetAllView()
                .Where(x => x.MaTrangThai != "TT02") // Ẩn bản ghi đã xóa mềm
                .ToList();
            dgvLoaiKH.DataSource = null;
            dgvLoaiKH.DataSource = dsView;

            dgvLoaiKH.Columns["MaLoaiKhachHang"].HeaderText = "Mã Loại";
            dgvLoaiKH.Columns["TenLoaiKhachHang"].HeaderText = "Tên Loại KH";
            dgvLoaiKH.Columns["MaTrangThai"].Visible = false;
            dgvLoaiKH.Columns["TenTrangThai"].HeaderText = "Trạng Thái";

            dgvLoaiKH.ClearSelection();
        }

        private void LoadTrangThai()
        {
            cboMKH.DataSource = LoaiTrangThai_BUS.LayTatCa();
            cboMKH.DisplayMember = "TenTrangThai";
            cboMKH.ValueMember = "MaTrangThai";
            cboMKH.SelectedIndex = -1;
        }

        private void LamMoi()
        {
            txtMLKH.Text = LoaiKhachHang_BUS.SinhMaLoaiKhachHang(); // Gán mã tự động
            txtTLKH.Clear();
            cboMKH.SelectedIndex = -1;
            txtMLKH.Enabled = false; // Không cho sửa mã
            dgvLoaiKH.ClearSelection();
        }

        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtMLKH.Text))
            {
                MessageBox.Show("⚠️ Mã loại khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMLKH.Focus();
                return false;
            }
            if (txtMLKH.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("⚠️ Mã loại khách hàng chỉ được nhập chữ và số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMLKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTLKH.Text))
            {
                MessageBox.Show("⚠️ Tên loại khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTLKH.Focus();
                return false;
            }
            if (cboMKH.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Vui lòng chọn trạng thái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMKH.Focus();
                return false;
            }
            // Kiểm tra trùng mã khi thêm mới
            if (txtMLKH.Enabled)
            {
                var ds = LoaiKhachHang_BUS.GetAllView();
                if (ds.Any(x => x.MaLoaiKhachHang == txtMLKH.Text.Trim()))
                {
                    MessageBox.Show("⚠️ Mã loại khách hàng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMLKH.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLKH.Text))
            {
                MessageBox.Show("⚠️ Tên loại khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTLKH.Focus();
                return;
            }
            if (cboMKH.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Vui lòng chọn trạng thái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMKH.Focus();
                return;
            }

            var loai = new LoaiKhachHang_DTO(
                txtMLKH.Text.Trim(),
                txtTLKH.Text.Trim(),
                cboMKH.SelectedValue?.ToString()
            );

            if (LoaiKhachHang_BUS.Them(loai, out string loi))
            {
                MessageBox.Show("✔️ Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
                LamMoi();
            }
            else
            {
                MessageBox.Show(loi ?? "❌ Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            var loai = new LoaiKhachHang_DTO(
                txtMLKH.Text.Trim(),
                txtTLKH.Text.Trim(),
                cboMKH.SelectedValue?.ToString()
            );

            if (LoaiKhachHang_BUS.Sua(loai, out string loi))
            {
                MessageBox.Show("✅ Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
                LamMoi();
            }
            else
            {
                MessageBox.Show(loi ?? "❌ Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMLKH.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("⚠️ Vui lòng chọn loại khách hàng cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xoá (ẩn) loại khách hàng này? Dữ liệu sẽ không bị mất.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Soft delete: cập nhật trạng thái về "TT02" (Đã xóa)
                var loai = new LoaiKhachHang_DTO(ma, txtTLKH.Text.Trim(), "TT02");
                if (LoaiKhachHang_BUS.Sua(loai, out string loi))
                {
                    MessageBox.Show("🗑️ Đã ẩn loại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show(loi ?? "❌ Ẩn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKMT.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDuLieu();
                return;
            }

            var ketQua = LoaiKhachHang_BUS.TimKiem(tuKhoa);
            dgvLoaiKH.DataSource = null;
            dgvLoaiKH.DataSource = ketQua;
            dgvLoaiKH.ClearSelection();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy loại khách hàng nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoaiKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLoaiKH.Rows[e.RowIndex].DataBoundItem is LoaiKhachHangViewModel item)
            {
                txtMLKH.Text = item.MaLoaiKhachHang;
                txtTLKH.Text = item.TenLoaiKhachHang;
                cboMKH.SelectedValue = item.MaTrangThai;
                txtMLKH.Enabled = false;
            }
        }

        // Các sự kiện này nếu không dùng có thể xoá đi hoặc để nguyên
        private void txtMLKH_TextChanged(object sender, EventArgs e) { }
        private void txtTLKH_TextChanged(object sender, EventArgs e) { }
        private void cboMKH_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtTKMT_TextChanged(object sender, EventArgs e) { }

    }
}
