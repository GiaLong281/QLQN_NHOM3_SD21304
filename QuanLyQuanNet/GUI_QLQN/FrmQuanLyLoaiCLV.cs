using BLL_QuanlyQuanNet;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLQN
{
    public partial class FrmQuanLyLoaiCLV : Form
    {
        private LoaiCLV_BUS loaiCLV_BLL = new LoaiCLV_BUS();

        public FrmQuanLyLoaiCLV()
        {
            InitializeComponent();
        }

        private void FrmQuanLyLoaiCLV_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiCLV();
            LoadTrangThai();
        }

        private void LoadDanhSachLoaiCLV()
        {
            try
            {
                var dsView = loaiCLV_BLL.LayDanhSach(); // Lấy danh sách loại ca làm việc có TenTrangThai

                dgvLCLV.DataSource = null;
                dgvLCLV.DataSource = dsView;

                dgvLCLV.Columns["MaLoai"].HeaderText = "Mã Loại";
                dgvLCLV.Columns["TenLoai"].HeaderText = "Tên Loại";
                dgvLCLV.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
                dgvLCLV.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
                dgvLCLV.Columns["LuongTheoGio"].HeaderText = "Lương Theo Giờ";

                dgvLCLV.Columns["MaTrangThai"].Visible = false;
                dgvLCLV.Columns["TenTrangThai"].HeaderText = "Trạng Thái";

                dgvLCLV.ClearSelection();

                // Font rõ hơn
                dgvLCLV.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvLCLV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTrangThai()
        {
            cboMTT.DataSource = LoaiTrangThai_BUS.LayTatCa();
            cboMTT.DisplayMember = "TenTrangThai";
            cboMTT.ValueMember = "MaTrangThai";
            cboMTT.SelectedIndex = -1;
        }

        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtML.Text) ||
                string.IsNullOrWhiteSpace(txtTL.Text) ||
                string.IsNullOrWhiteSpace(txtLTG.Text) ||
                cboMTT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtLTG.Text.Trim(), out _))
            {
                MessageBox.Show("Lương theo giờ phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;
            try
            {
                LoaiCLV_DTO loai = new LoaiCLV_DTO
                {
                    MaLoai = txtML.Text.Trim(),
                    TenLoai = txtTL.Text.Trim(),
                    LuongTheoGio = (float)decimal.Parse(txtLTG.Text.Trim()),
                    MaTrangThai = cboMTT.SelectedValue.ToString(),
                    GioBatDau = dtpGBD.Value.TimeOfDay,
                    GioKetThuc = dtpGKT.Value.TimeOfDay
                };

                if (loaiCLV_BLL.ThemLoaiCLV(loai))
                {
                    MessageBox.Show("✔️ Thêm thành công!");
                    LoadDanhSachLoaiCLV();
                    ResetForm();
                }
                else MessageBox.Show("❌ Thêm thất bại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;
            try
            {
                if (string.IsNullOrWhiteSpace(txtML.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại ca làm việc cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoaiCLV_DTO loaiCLV = new LoaiCLV_DTO
                {
                    MaLoai = txtML.Text.Trim(),
                    TenLoai = txtTL.Text.Trim(),
                    GioBatDau = dtpGBD.Value.TimeOfDay,
                    GioKetThuc = dtpGKT.Value.TimeOfDay,
                    LuongTheoGio = (float)decimal.Parse(txtLTG.Text.Trim()),
                    MaTrangThai = cboMTT.SelectedValue.ToString(),
                };

                if (loaiCLV_BLL.SuaLoaiCLV(loaiCLV))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLoaiCLV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtML.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại ca làm việc cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại ca làm việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (loaiCLV_BLL.XoaLoaiCLV(txtML.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachLoaiCLV();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTKML.Text.Trim();
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    LoadDanhSachLoaiCLV(); // Hiển thị lại toàn bộ nếu ô tìm kiếm trống
                }
                else
                {
                    dgvLCLV.DataSource = loaiCLV_BLL.TimKiemLoaiCLV(tuKhoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDanhSachLoaiCLV();
        }

        private void ResetForm()
        {
            txtML.Text = "";
            txtTL.Text = "";
            txtLTG.Text = "";
            cboMTT.SelectedIndex = -1;
            dtpGBD.Value = DateTime.Now;
            dtpGKT.Value = DateTime.Now;
            txtML.Enabled = true;
        }

        private void dgvLCLV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvLCLV.Rows[e.RowIndex];

                    txtML.Text = row.Cells["MaLoai"].Value?.ToString();
                    txtTL.Text = row.Cells["TenLoai"].Value?.ToString();

                    // TimeSpan -> DateTime.Today + TimeOfDay
                    if (row.Cells["GioBatDau"].Value is TimeSpan gioBatDau)
                        dtpGBD.Value = DateTime.Today.Add(gioBatDau);

                    if (row.Cells["GioKetThuc"].Value is TimeSpan gioKetThuc)
                        dtpGKT.Value = DateTime.Today.Add(gioKetThuc);

                    txtLTG.Text = row.Cells["LuongTheoGio"].Value?.ToString();

                    // Gán trạng thái từ MaTrangThai
                    if (row.Cells["MaTrangThai"].Value != null)
                        cboMTT.SelectedValue = row.Cells["MaTrangThai"].Value.ToString();

                    txtML.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
