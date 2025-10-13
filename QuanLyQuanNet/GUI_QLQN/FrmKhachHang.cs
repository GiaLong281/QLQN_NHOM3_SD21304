using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace QuanLyQuanNet.GUI
{
    public partial class FrmKhachHang : Form
    {
        private readonly KhachHang_BUS bus = new KhachHang_BUS();

        public FrmKhachHang()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
        }

        private void LoadData()
        {
            var ds = bus.GetAllView(); // từ BUS
            dgvKhachHang.DataSource = ds;
            SetGridHeader();
        }

        private void SetGridHeader()
        {
            if (dgvKhachHang.Columns["MaKhachHang"] != null)
                dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã KH";
            if (dgvKhachHang.Columns["TenDangNhap"] != null)
                dgvKhachHang.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            if (dgvKhachHang.Columns["MatKhau"] != null)
                dgvKhachHang.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            if (dgvKhachHang.Columns["HoTen"] != null)
                dgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dgvKhachHang.Columns["SoDienThoai"] != null)
                dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            if (dgvKhachHang.Columns["Email"] != null)
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
            if (dgvKhachHang.Columns["CCCD"] != null)
                dgvKhachHang.Columns["CCCD"].HeaderText = "CCCD";
            if (dgvKhachHang.Columns["NgayTao"] != null)
                dgvKhachHang.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            if (dgvKhachHang.Columns["TenLoaiKhachHang"] != null)
                dgvKhachHang.Columns["TenLoaiKhachHang"].HeaderText = "Loại KH";
            if (dgvKhachHang.Columns["TenTrangThai"] != null)
                dgvKhachHang.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
            if (dgvKhachHang.Columns["SoDuTaiKhoan"] != null)
                dgvKhachHang.Columns["SoDuTaiKhoan"].HeaderText = "Số Dư";

            // Ẩn mã nếu cần
            if (dgvKhachHang.Columns["MaTrangThai"] != null)
                dgvKhachHang.Columns["MaTrangThai"].Visible = false;
            if (dgvKhachHang.Columns["MaLoaiKhachHang"] != null)
                dgvKhachHang.Columns["MaLoaiKhachHang"].Visible = false;
        }

        private void LoadComboBox()
        {
            cboTrangThai.DataSource = LoaiTrangThai_BUS.LayTatCa();
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "MaTrangThai";
            cboTrangThai.SelectedIndex = -1;

            cboLoaiKH.DataSource = LoaiKhachHang_BUS.LayTatCa();
            cboLoaiKH.DisplayMember = "TenLoai";
            cboLoaiKH.ValueMember = "MaLoaiKhachHang";

            cboLoaiKH.SelectedIndex = -1;
        }

        private string GenerateMaKhachHang()
        {
            var danhSachKH = bus.GetAllKhachHang();
            if (danhSachKH.Count == 0) return "KH001";

            int max = 0;
            foreach (var kh in danhSachKH)
            {
                if (kh.MaKhachHang.StartsWith("KH") && int.TryParse(kh.MaKhachHang.Substring(2), out int so))
                    if (so > max) max = so;
            }
            return "KH" + (max + 1).ToString("D3");
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenDN.Text) ||
                string.IsNullOrWhiteSpace(txtMK.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                var emailRegex = new Regex("^[\\w.-]+@[\\w.-]+\\.[a-zA-Z]{2,}$");
                if (!emailRegex.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng.");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                var sdtRegex = new Regex(@"^0[0-9]{9,10}$");
                if (!sdtRegex.IsMatch(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng 0 và có 10-11 chữ số.");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtCCCD.Text) && txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải đúng 12 chữ số.");
                return false;
            }

            if (cboTrangThai.SelectedIndex == -1 || cboLoaiKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Trạng Thái và Loại Khách Hàng.");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var kh = new KhachHang_DTO
            {
                MaKhachHang = txtMaKH.Text.Trim(), // Sử dụng mã trên form để tránh trùng lặp khi làm mới
                TenDangNhap = txtTenDN.Text.Trim(),
                MatKhau = txtMK.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                CCCD = txtCCCD.Text.Trim(),
                NgayTao = DateTime.TryParse(txtNgayTao.Text, out DateTime nt) ? nt : DateTime.Now,
                MaTrangThai = cboTrangThai.SelectedValue?.ToString(),
                MaLoaiKhachHang = cboLoaiKH.SelectedValue?.ToString(),
                SoDuTaiKhoan = decimal.TryParse(txtSoDu.Text.Replace("đ", "").Replace(",", "").Trim(), out decimal sodu) ? sodu : 0
            };

            bus.AddKhachHang(kh);
            LoadData();
            ClearForm();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (dgvKhachHang.CurrentRow?.DataBoundItem is KhachHangViewModel khView)
            {
                decimal soDuMoi = khView.SoDuTaiKhoan;
                // Cho phép nhập số dư mới từ textbox
                decimal.TryParse(txtSoDu.Text.Replace("đ", "").Replace(",", "").Trim(), out soDuMoi);

                var kh = new KhachHang_DTO
                {
                    MaKhachHang = khView.MaKhachHang,
                    TenDangNhap = txtTenDN.Text.Trim(),
                    MatKhau = txtMK.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    CCCD = txtCCCD.Text.Trim(),
                    NgayTao = khView.NgayTao,
                    MaTrangThai = cboTrangThai.SelectedValue?.ToString(),
                    MaLoaiKhachHang = cboLoaiKH.SelectedValue?.ToString(),
                    SoDuTaiKhoan = soDuMoi // cập nhật số dư mới
                };

                bus.UpdateKhachHang(kh);
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow?.DataBoundItem is KhachHangViewModel khView)
            {
                if (MessageBox.Show("Xác nhận xoá?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bus.DeleteKhachHang(khView.MaKhachHang);
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Đã xoá!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
            dgvKhachHang.ClearSelection();
        }

        private void ClearForm()
        {
            txtMaKH.Text = GenerateMaKhachHang();
            txtTenDN.Clear();
            txtMK.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtCCCD.Clear();
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSoDu.Text = "0 đ";

            cboTrangThai.SelectedIndex = -1;
            cboLoaiKH.SelectedIndex = -1;

            txtMaKH.Enabled = true;
            txtNgayTao.Enabled = true;
            txtSoDu.Enabled = true;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKhachHang"].Value?.ToString();
                txtTenDN.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtMK.Text = row.Cells["MatKhau"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtNgayTao.Text = row.Cells["NgayTao"].Value is DateTime dt ? dt.ToString("dd/MM/yyyy") : "";
                txtSoDu.Text = row.Cells["SoDuTaiKhoan"].Value is decimal soDu ? soDu.ToString("N0") : "0";

                cboTrangThai.Text = row.Cells["TenTrangThai"].Value?.ToString();
                cboLoaiKH.Text = row.Cells["TenLoaiKhachHang"].Value?.ToString();

                txtMaKH.Enabled = false;
                txtNgayTao.Enabled = false;
            }
        }

        // Sửa lại nút tìm kiếm:
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var danhSach = bus.GetAllView();
            var ketQua = danhSach.FindAll(kh =>
                (kh.TenDangNhap != null && kh.TenDangNhap.ToLower().Contains(keyword)) ||
                (kh.HoTen != null && kh.HoTen.ToLower().Contains(keyword)) ||
                (kh.SoDienThoai != null && kh.SoDienThoai.ToLower().Contains(keyword)) ||
                (kh.Email != null && kh.Email.ToLower().Contains(keyword)) ||
                (kh.CCCD != null && kh.CCCD.ToLower().Contains(keyword)) ||
                (kh.TenLoaiKhachHang != null && kh.TenLoaiKhachHang.ToLower().Contains(keyword)) ||
                (kh.TenTrangThai != null && kh.TenTrangThai.ToLower().Contains(keyword))
            );
            dgvKhachHang.DataSource = ketQua;
            SetGridHeader();
        }

    }
}