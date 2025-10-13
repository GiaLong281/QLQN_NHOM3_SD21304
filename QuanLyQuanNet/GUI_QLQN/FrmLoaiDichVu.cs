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
    public partial class FrmLoaiDichVu : Form
    {
        private LoaiDichVu_BUS bus = new LoaiDichVu_BUS();
        public FrmLoaiDichVu()
        {
            InitializeComponent();
        }
        private void FrmLoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadComboBoxTrangThai();
            LoadLoaiDichVu();
        }
        private void LoadComboBoxTrangThai()
        {
            var trangThaiList = new List<LoaiTrangThai_DTO>
    {
        new LoaiTrangThai_DTO("TT01", "Hoạt động"),
        new LoaiTrangThai_DTO("TT02", "Ngừng hoạt động")
    };

            cboTrangThai.DataSource = trangThaiList;
            cboTrangThai.DisplayMember = "TenTrangThai";  // Cái user nhìn thấy
            cboTrangThai.ValueMember = "MaTrangThai";     // Cái thực tế sẽ lưu
        }

        private void SetGridHeader()
{
    if (dgvLoaiDichVu.Columns["MaLoaiDichVu"] != null)
        dgvLoaiDichVu.Columns["MaLoaiDichVu"].HeaderText = "Mã Loại DV";
    if (dgvLoaiDichVu.Columns["TenLoaiDichVu"] != null)
        dgvLoaiDichVu.Columns["TenLoaiDichVu"].HeaderText = "Tên Loại DV";
    if (dgvLoaiDichVu.Columns["TenTrangThai"] != null)
        dgvLoaiDichVu.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
    if (dgvLoaiDichVu.Columns["NgayTao"] != null)
    {
        dgvLoaiDichVu.Columns["NgayTao"].HeaderText = "Ngày Tạo";
        dgvLoaiDichVu.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
    }
    if (dgvLoaiDichVu.Columns["MaTrangThai"] != null)
        dgvLoaiDichVu.Columns["MaTrangThai"].Visible = false;
}

        private void LoadLoaiDichVu()
        {
            var danhSach = bus.GetAll();
            var trangThaiDict = new Dictionary<string, string>
    {
        { "TT01", "Hoạt động" },
        { "TT02", "Ngừng hoạt động" }
    };

            var dataHienThi = danhSach
                .Where(d => d.MaTrangThai == "TT01") // chỉ lấy loại đang hoạt động
                .Select(d => new
                {
                    d.MaLoaiDichVu,
                    d.TenLoaiDichVu,
                    MaTrangThai = d.MaTrangThai,
                    TenTrangThai = trangThaiDict.ContainsKey(d.MaTrangThai) ? trangThaiDict[d.MaTrangThai] : "Không rõ",
                    d.NgayTao
                }).ToList();

            dgvLoaiDichVu.DataSource = dataHienThi;
            SetGridHeader();
        }

        private bool ValidateInput()
{
    if (string.IsNullOrWhiteSpace(txtTLDV.Text))
    {
        MessageBox.Show("Tên loại dịch vụ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtTLDV.Focus();
        return false;
    }
    // Không cho phép ký tự đặc biệt trong tên loại dịch vụ
    if (System.Text.RegularExpressions.Regex.IsMatch(txtTLDV.Text, @"[^a-zA-Z0-9\sÀ-ỹ]"))
    {
        MessageBox.Show("Tên loại dịch vụ không được chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtTLDV.Focus();
        return false;
    }
    if (cboTrangThai.SelectedIndex < 0)
    {
        MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cboTrangThai.Focus();
        return false;
    }
    return true;
}

private string GenerateMaLoaiDichVu()
{
    var danhSach = bus.GetAll();
    if (danhSach.Count == 0) return "LDV001";
    int max = 0;
    foreach (var ldv in danhSach)
    {
        if (ldv.MaLoaiDichVu.StartsWith("LDV") && int.TryParse(ldv.MaLoaiDichVu.Substring(3), out int so))
            if (so > max) max = so;
    }
    return "LDV" + (max + 1).ToString("D2");
}

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var loaiDV = new DTO_QuanLyQuanNet.LoaiDichVu_DTO
            {
                MaLoaiDichVu = txtMLDV.Text.Trim(),
                TenLoaiDichVu = txtTLDV.Text.Trim(),
                MaTrangThai = cboTrangThai.SelectedValue.ToString(),
                NgayTao = dtpNgayTao.Value
            };
            if (bus.Add(loaiDV))
            {
                MessageBox.Show("Thêm loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiDichVu();
                LamMoi();
            }
            else
            {
                MessageBox.Show("Thêm loại dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (dgvLoaiDichVu.SelectedRows.Count > 0)
            {
                var loaiDV = new DTO_QuanLyQuanNet.LoaiDichVu_DTO
                {
                    MaLoaiDichVu = txtMLDV.Text.Trim(),
                    TenLoaiDichVu = txtTLDV.Text.Trim(),
                    MaTrangThai = cboTrangThai.SelectedValue.ToString(),
                    NgayTao = dtpNgayTao.Value
                };
                if (bus.Update(loaiDV))
                {
                    MessageBox.Show("Cập nhật loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiDichVu();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xoá loại dịch vụ
            if (dgvLoaiDichVu.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLoaiDichVu.SelectedRows[0];
                string maLoaiDV = selectedRow.Cells["MaLoaiDichVu"].Value.ToString();
                if (bus.Delete(maLoaiDV))
                {
                    MessageBox.Show("Xoá loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiDichVu();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Xoá loại dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        private void LamMoi()
        {
            txtMLDV.Text = GenerateMaLoaiDichVu();
            txtTLDV.Clear();
            txtTKMT.Clear();
            cboTrangThai.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            dgvLoaiDichVu.ClearSelection();

            // Enable lại các trường bị disable khi chọn dòng
            txtMLDV.Enabled = false; // Luôn không cho nhập tay
            dtpNgayTao.Enabled = true;
            txtTLDV.Enabled = true;
            cboTrangThai.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTKMT.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadLoaiDichVu();
                return;
            }
            var results = bus.Search(keyword);
            if (results.Count > 0)
            {
                var trangThaiDict = new Dictionary<string, string>
                {
                    { "TT01", "Hoạt động" },
                    { "TT02", "Ngừng hoạt động" }
                };
                var dataHienThi = results.Select(d => new
                {
                    d.MaLoaiDichVu,
                    d.TenLoaiDichVu,
                    MaTrangThai = d.MaTrangThai,
                    TenTrangThai = trangThaiDict.ContainsKey(d.MaTrangThai) ? trangThaiDict[d.MaTrangThai] : "Không rõ",
                    d.NgayTao
                }).ToList();
                dgvLoaiDichVu.DataSource = dataHienThi;
                SetGridHeader();
            }
            else
            {
                MessageBox.Show("Không tìm thấy loại dịch vụ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiDichVu();
            }
        }

        private void dgvLoaiDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLoaiDichVu.Rows[e.RowIndex];
                HienThiThongTin(row);

                // Disable các trường không được sửa
                txtMLDV.Enabled = false;
                dtpNgayTao.Enabled = false;
            }
        }
        private void HienThiThongTin(DataGridViewRow row)
        {
            txtMLDV.Text = row.Cells["MaLoaiDichVu"].Value.ToString();
            txtTLDV.Text = row.Cells["TenLoaiDichVu"].Value.ToString();
            string maTrangThai = row.Cells["MaTrangThai"].Value.ToString();
            cboTrangThai.SelectedValue = maTrangThai;
            dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
        }

    }
}
