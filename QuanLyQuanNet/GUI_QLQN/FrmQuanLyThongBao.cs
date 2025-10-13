using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class FrmQuanLyThongBao : Form
    {
        private ThongBao_BLL bll = new ThongBao_BLL();
        private static readonly string connectionString = @"Data Source=DESKTOP-O7TJDCH\SQLEXPRESS;Initial Catalog=PRO231_QuanLyQuanNet1903;Integrated Security=True;TrustServerCertificate=True";

        public FrmQuanLyThongBao()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxes();
        }

        private void LoadData()
        {
            dgvThongBao.DataSource = bll.LayDanhSach(txtSearch.Text);
            if (dgvThongBao.Columns.Count > 0)
            {
                dgvThongBao.Columns["MaThongBao"].HeaderText = "Mã Thông Báo";
                dgvThongBao.Columns["MaPhien"].HeaderText = "Mã Phiên";
                dgvThongBao.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dgvThongBao.Columns["ThoiGianThongBao"].HeaderText = "Thời Gian";
                dgvThongBao.Columns["TrangThaiDoc"].HeaderText = "Trạng Thái Đọc";
                dgvThongBao.Columns["NoiDung"].HeaderText = "Nội Dung";
            }
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter daPhien = new SqlDataAdapter("SELECT MaPhien FROM PhienSuDung", conn);
                DataTable dtPhien = new DataTable();
                daPhien.Fill(dtPhien);
                cboPhien.DataSource = dtPhien;
                cboPhien.DisplayMember = "MaPhien";
                cboPhien.ValueMember = "MaPhien";

                SqlDataAdapter daNhanVien = new SqlDataAdapter("SELECT MaNhanVien, HoTen FROM NhanVien", conn);
                DataTable dtNV = new DataTable();
                daNhanVien.Fill(dtNV);
                cboNhanVien.DataSource = dtNV;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNhanVien";

                cboTrangThaiDoc.Items.Clear();
                cboTrangThaiDoc.Items.Add("Đã đọc");
                cboTrangThaiDoc.Items.Add("Chưa đọc");
            }
        }

        private ThongBao_DTO GetThongBaoFromForm()
        {
            return new ThongBao_DTO
            {
                MaThongBao = txtMaThongBao.Text,
                MaPhien = cboPhien.SelectedValue?.ToString(),
                MaNhanVien = cboNhanVien.SelectedValue?.ToString(),
                ThoiGianThongBao = dtpThoiGianThongBao.Value,
                TrangThaiDoc = cboTrangThaiDoc.Text == "Đã đọc",
                NoiDung = txtNoiDung.Text
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tb = GetThongBaoFromForm();
            if (bll.ThemMoi(tb))
            {
                MessageBox.Show("Thêm thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Mã thông báo đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tb = GetThongBaoFromForm();
            if (bll.CapNhat(tb))
            {
                MessageBox.Show("Sửa thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvThongBao.CurrentRow.Cells["MaThongBao"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông báo này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bll.Xoa(id))
                {
                    MessageBox.Show("Xóa thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvThongBao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow != null)
            {
                txtMaThongBao.Text = dgvThongBao.CurrentRow.Cells["MaThongBao"].Value.ToString();
                cboPhien.SelectedValue = dgvThongBao.CurrentRow.Cells["MaPhien"].Value.ToString();
                cboNhanVien.SelectedValue = dgvThongBao.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                dtpThoiGianThongBao.Value = Convert.ToDateTime(dgvThongBao.CurrentRow.Cells["ThoiGianThongBao"].Value);
                cboTrangThaiDoc.Text = Convert.ToBoolean(dgvThongBao.CurrentRow.Cells["TrangThaiDoc"].Value) ? "Đã đọc" : "Chưa đọc";
                txtNoiDung.Text = dgvThongBao.CurrentRow.Cells["NoiDung"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
            MessageBox.Show("Dữ liệu đã được làm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetForm()
        {
            txtMaThongBao.Clear();
            cboPhien.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            cboTrangThaiDoc.SelectedIndex = -1;
            txtNoiDung.Clear();
            dtpThoiGianThongBao.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
