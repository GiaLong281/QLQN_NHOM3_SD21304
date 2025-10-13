using BLL_QuanlyQuanNet;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLQN
{
    public partial class FrmQuanLyCLV : Form
    {
        private CaLamViec_BUS bus = new CaLamViec_BUS();

        public FrmQuanLyCLV()
        {
            InitializeComponent();
        }
        private void FrmQuanLyCLV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            var data = CaLamViec_BUS.LayDanhSachChiTiet();  // Lấy danh sách đã có TenLoaiCa
            dgvQCLV.DataSource = data;

            // ✅ Đổi tên cột sang tiếng Việt
            dgvQCLV.Columns["MaCa"].HeaderText = "Mã Ca";
            dgvQCLV.Columns["MaNhan"].HeaderText = "Mã Nhân Viên";
            dgvQCLV.Columns["MaLoaiCa"].Visible = false; // Ẩn mã nếu muốn
            dgvQCLV.Columns["TenLoaiCa"].HeaderText = "Ca";
            dgvQCLV.Columns["NgayLam"].HeaderText = "Ngày Làm";
            dgvQCLV.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvQCLV.Columns["GhiChu"].HeaderText = "Ghi Chú";

            // Tùy chỉnh thêm
            dgvQCLV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQCLV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvQCLV.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        // Load ComboBox
            private void LoadComboBox()
        {
            var danhSachLoaiCa = bus.LayLoaiCa(); // List<LoaiCLV_DTO>

            cboMLC.DataSource = danhSachLoaiCa;
            cboMLC.DisplayMember = "TenLoai";   // Hiển thị tên ca sáng/chiều
            cboMLC.ValueMember = "MaLoai";      // Dùng để lưu mã loại thật khi CRUD

            // Load mã nhân viên
            var dsMaNV = bus.LayMaNhanVien();  // List<string>
            cboMNV.DataSource = dsMaNV;
        }



        private void ClearForm()
        {
            txtMC.Clear();
            txtGhiChu.Clear();
            txtTKMC.Clear();
            dtpNgayLam.Value = DateTime.Now;
            cboMNV.SelectedIndex = 0;
            cboMLC.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var clv = new CaLamViec_DTO
            {
                MaCa = txtMC.Text.Trim(),
                MaNhanVien = cboMNV.SelectedValue.ToString(),  // ✅ Lấy đúng mã
                MaLoaiCa = cboMLC.SelectedValue.ToString(),    // ✅ Lấy đúng mã loại
                NgayLam = dtpNgayLam.Value,
                NgayTao = dtpNgayTao.Value,
                GhiChu = txtGhiChu.Text.Trim()
            };

            if (bus.Them(clv))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra Mã Ca, Mã NV, Mã Loại Ca.");
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            var clv = new CaLamViec_DTO
            {
                MaCa = txtMC.Text.Trim(),
                MaNhanVien = cboMNV.SelectedValue.ToString(),   // ✅ dùng SelectedValue
                MaLoaiCa = cboMLC.SelectedValue.ToString(),     // ✅ dùng SelectedValue
                NgayLam = dtpNgayLam.Value,
                NgayTao = dtpNgayTao.Value,
                GhiChu = txtGhiChu.Text.Trim()
            };

            if (bus.Sua(clv))
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCa = txtMC.Text.Trim();

            if (string.IsNullOrEmpty(maCa))
            {
                MessageBox.Show("Vui lòng nhập Mã Ca cần xóa.");
                return;
            }

            if (bus.Xoa(maCa))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTKMC.Text.Trim();
            dgvQCLV.DataSource = bus.TimKiem(keyword);
        }



        private void dgvQCLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQCLV.Rows[e.RowIndex];
                txtMC.Text = row.Cells["MaCa"].Value.ToString();
                cboMNV.Text = row.Cells["MaNhan"].Value.ToString();
                cboMLC.SelectedValue = row.Cells["MaLoaiCa"].Value.ToString(); // giữ logic CRUD
                dtpNgayLam.Value = Convert.ToDateTime(row.Cells["NgayLam"].Value);
                dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void cboMLC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
