using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace QuanLyQuanNet.GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private readonly NhanVien_BUS bus = new NhanVien_BUS();

        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
            ClearForm();
        }



        private void LoadData()
        {
            var dsView = bus.GetAllView();
            dgvNhanVien.DataSource = dsView;

            // Set header
            dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["Email"].HeaderText = "Email";
            dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvNhanVien.Columns["TenChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
            dgvNhanVien.Columns["NgayTao"].HeaderText = "Ngày Tạo";

            dgvNhanVien.Columns["MaChucVu"].Visible = false;
            dgvNhanVien.Columns["MaTrangThai"].Visible = false;
        }

        private void LoadComboBox()
        {
            cboChucVu.DataSource = ChucVu_BUS.LayTatCa();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
            cboChucVu.SelectedIndex = -1;

            cboTrangThai.DataSource = LoaiTrangThai_BUS.LayTatCa();
            cboTrangThai.DisplayMember = "TenTrangThai";
            cboTrangThai.ValueMember = "MaTrangThai";
            cboTrangThai.SelectedIndex = -1;
        }

        private string GenerateMaNV()
        {
            var ds = bus.GetAll();
            int max = 0;
            foreach (var nv in ds)
            {
                if (nv.MaNhanVien.StartsWith("NV") && int.TryParse(nv.MaNhanVien.Substring(2), out int so))
                    if (so > max) max = so;
            }
            return "NV" + (max + 1).ToString("D3");
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                txtMK.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!regex.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng.");
                    txtEmail.Focus();
                    return false;
                }
            }

            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.");
                cboChucVu.Focus();
                return false;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.");
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var nv = new NhanVien_DTO
            {
                MaNhanVien = GenerateMaNV(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MatKhau = txtMK.Text.Trim(),
                MaChucVu = cboChucVu.SelectedValue.ToString(),
                MaTrangThai = cboTrangThai.SelectedValue.ToString(),
                NgayTao = DateTime.Now
            };

            bus.Add(nv);
            LoadData();
            ClearForm();
            MessageBox.Show("Thêm nhân viên thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var nv = new NhanVien_DTO
            {
                MaNhanVien = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                MatKhau = txtMK.Text,
                MaChucVu = cboChucVu.SelectedValue.ToString(),
                MaTrangThai = cboTrangThai.SelectedValue.ToString(),
                NgayTao = DateTime.ParseExact(txtNgayTao.Text, "dd/MM/yyyy", null)
            };

            bus.Update(nv);
            LoadData();
            ClearForm();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow?.DataBoundItem is NhanVienViewModel nv)
            {
                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên: {nv.HoTen}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bus.Delete(nv.MaNhanVien); // Gọi theo MaNhanVien
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
            dgvNhanVien.ClearSelection();
        }

        private void ClearForm()
        {
            txtMaNV.Text = GenerateMaNV();
            txtHoTen.Clear();
            txtMK.Clear();
            txtEmail.Clear();
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            txtMaNV.Enabled = true;
            txtNgayTao.Enabled = true;
            txtSearch.Clear();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.Rows[e.RowIndex].DataBoundItem is NhanVienViewModel nv)
            {
                txtMaNV.Text = nv.MaNhanVien;
                txtHoTen.Text = nv.HoTen;
                txtEmail.Text = nv.Email;
                txtMK.Text = nv.MatKhau;
                cboChucVu.Text = nv.TenChucVu;
                cboTrangThai.Text = nv.TenTrangThai;
                txtNgayTao.Text = nv.NgayTao.ToString("dd/MM/yyyy");

                txtMaNV.Enabled = false;
                txtNgayTao.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var ketQua = bus.GetAll().FindAll(nv =>
                (!string.IsNullOrEmpty(nv.HoTen) && nv.HoTen.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.Email) && nv.Email.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.MaNhanVien) && nv.MaNhanVien.ToLower().Contains(keyword))
            );

            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = ketQua;
            dgvNhanVien.ClearSelection();

            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy nhân viên phù hợp.");
        }
    }
}