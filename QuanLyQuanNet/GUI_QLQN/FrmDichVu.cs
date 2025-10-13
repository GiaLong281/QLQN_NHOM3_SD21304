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
using BLL_QuanLyQuanNet;
using System.IO;

namespace GUI_QLQN
{
    public partial class FrmDichVu : Form
    {
        private List<LoaiDichVu_DTO> dsLoaiDV;
        private byte[] selectedImageBytes;

        private DichVu_BUS bus = new DichVu_BUS();
        private List<string> hiddenMaDV = new List<string>();

        public FrmDichVu()
        {
            InitializeComponent();

            dsLoaiDV = new LoaiDichVu_BUS().GetAll(); // Cần BUS của LoaiDichVu

            cboMaLoaiDichVu.DataSource = dsLoaiDV;
            cboMaLoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cboMaLoaiDichVu.ValueMember = "MaLoaiDichVu";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDichVu.Text))
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
                txtMaDichVu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
            {
                MessageBox.Show("Tên dịch vụ không được để trống!");
                txtTenDichVu.Focus();
                return false;
            }
            if (cboMaLoaiDichVu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ!");
                cboMaLoaiDichVu.Focus();
                return false;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số lớn hơn 0!");
                txtDonGia.Focus();
                return false;
            }
            return true;
        }
        private void LoadDichVu()
        {
            var dsDV = bus.GetAll();
            var data = dsDV
                .Where(dv => dv.MaTrangThai == "TT01") // Chỉ lấy dịch vụ đang hoạt động
                .Select(dv => new
                {
                    dv.MaDV,
                    dv.TenDV,
                    TenLoaiDichVu = dsLoaiDV.FirstOrDefault(ldv => ldv.MaLoaiDichVu == dv.MaLoaiDV)?.TenLoaiDichVu ?? "Không rõ",
                    dv.DonGia,
                    dv.NgayTao,
                    dv.AnhSP
                }).ToList();

            dgvQuanLyDichVu.DataSource = data;

            dgvQuanLyDichVu.Columns["MaDV"].HeaderText = "Mã Dịch Vụ";
            dgvQuanLyDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
            dgvQuanLyDichVu.Columns["TenLoaiDichVu"].HeaderText = "Loại Dịch Vụ";
            dgvQuanLyDichVu.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvQuanLyDichVu.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvQuanLyDichVu.Columns["AnhSP"].Visible = false;
            dgvQuanLyDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvQuanLyDichVu.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            DichVu_DTO dv = new DichVu_DTO
            {
                MaDV = txtMaDichVu.Text.Trim(),
                TenDV = txtTenDichVu.Text.Trim(),
                MaLoaiDV = cboMaLoaiDichVu.SelectedValue.ToString(),
                DonGia = decimal.Parse(txtDonGia.Text),
                NgayTao = dtpNgayTao.Value,
                AnhSP = selectedImageBytes,
                MaTrangThai = "TT01" // Mặc định đang hoạt động
            };

            if (bus.Add(dv))
            {
                MessageBox.Show("Thêm thành công!");
                LamMoi();
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        private void LamMoi()
        {
            txtMaDichVu.Text = bus.GetNextMaDichVu(); // Tự động sinh mã mới
            txtTenDichVu.Clear();
            cboMaLoaiDichVu.SelectedIndex = -1;
            txtDonGia.Clear();
            dtpNgayTao.Value = DateTime.Now;
            txtTKMT.Clear();

            // Enable lại các trường bị disable khi chọn dòng
            txtMaDichVu.Enabled = false; // Luôn không cho nhập tay
            dtpNgayTao.Enabled = true;
            txtTenDichVu.Enabled = true;
            cboMaLoaiDichVu.Enabled = true;
            txtDonGia.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            //tạo code sửa cho tôi
            if (dgvQuanLyDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DichVu_DTO dv = new DichVu_DTO
            {
                MaDV = txtMaDichVu.Text.Trim(),
                TenDV = txtTenDichVu.Text.Trim(),
                MaLoaiDV = cboMaLoaiDichVu.SelectedValue.ToString(),
                DonGia = decimal.Parse(txtDonGia.Text),
                NgayTao = dtpNgayTao.Value,
                AnhSP = selectedImageBytes
            };

            if (bus.Update(dv))
            {
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Cập nhật dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần ẩn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDichVu = dgvQuanLyDichVu.SelectedRows[0].Cells["MaDV"].Value.ToString();
            var result = MessageBox.Show("Bạn có muốn tạm dừng dịch vụ này không? (Dịch vụ sẽ không bị xóa khỏi hệ thống)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (bus.Delete(maDichVu))
                {
                    MessageBox.Show("Đã tạm dừng dịch vụ!");
                    LoadDichVu();
                }
                else
                {
                    MessageBox.Show("Không thể tạm dừng dịch vụ!");
                }
            }
        }

        private void FrmDichVu_Load_1(object sender, EventArgs e)
        {
            LoadComboBoxLoaiDichVu();
            LoadDichVu();
        }
        private void LoadComboBoxLoaiDichVu()
        {
            LoaiDichVu_BUS loaiDVBus = new LoaiDichVu_BUS();
            cboMaLoaiDichVu.DataSource = loaiDVBus.GetAll();
            cboMaLoaiDichVu.DisplayMember = "TenLoaiDichVu";     // 👈 Hiển thị tên cho dễ nhìn
            cboMaLoaiDichVu.ValueMember = "MaLoaiDichVu";        // 👈 Dùng mã khi thêm dịch vụ
            cboMaLoaiDichVu.SelectedIndex = -1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            //cho tôi code tìm kiếm
            string keyword = txtTKMT.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<DichVu_DTO> results = bus.Search(keyword);
            if (results.Count > 0)
            {
                dgvQuanLyDichVu.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDichVu(); // Hiển thị lại danh sách đầy đủ nếu không tìm thấ
            }
        }

        private void dgvQuanLyDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = dgvQuanLyDichVu.Rows[e.RowIndex];
                txtMaDichVu.Text = row.Cells["MaDV"].Value.ToString();
                txtTenDichVu.Text = row.Cells["TenDV"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();

                string tenLoai = row.Cells["TenLoaiDichVu"].Value.ToString();
                var loai = dsLoaiDV.FirstOrDefault(x => x.TenLoaiDichVu == tenLoai);
                if (loai != null)
                    cboMaLoaiDichVu.SelectedValue = loai.MaLoaiDichVu;

                dtpNgayTao.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
                if (row.Cells["AnhSP"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["AnhSP"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbAnhSP.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbAnhSP.Image = null;
                }

                // Disable các trường không được sửa
                txtMaDichVu.Enabled = false;
                dtpNgayTao.Enabled = false;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbAnhSP.Image = Image.FromFile(ofd.FileName);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbAnhSP.Image.Save(ms, pbAnhSP.Image.RawFormat);
                        selectedImageBytes = ms.ToArray();
                    }
                }
            }
        }
    }
}

