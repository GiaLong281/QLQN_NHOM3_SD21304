using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO_QuanLyQuanNet;
using BLL_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class FrmQuanLyHTTT : Form
    {
        public FrmQuanLyHTTT()
        {
            InitializeComponent();
        }

        private void QuanLyHTTT_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            dgvHTTT.AutoGenerateColumns = true;
            dgvHTTT.DataSource = HinhThucThanhToan_BUS.LayTatCa();

            dgvHTTT.Columns["MaHinhThuc"].HeaderText = "Mã Hình Thức";
            dgvHTTT.Columns["TenHinhThuc"].HeaderText = "Tên Hình Thức";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var hinhThuc = new HinhThucThanhToan_DTO(
                txtMHT.Text.Trim(),
                txtTHT.Text.Trim()
            );

            if (HinhThucThanhToan_BUS.Them(hinhThuc, out string loi))
            {
                MessageBox.Show("✔️ Thêm thành công!");
                LoadDuLieu();
                LamMoi();
            }
            else
                MessageBox.Show(loi ?? "❌ Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var hinhThuc = new HinhThucThanhToan_DTO(
                txtMHT.Text.Trim(),
                txtTHT.Text.Trim()
            );

            if (HinhThucThanhToan_BUS.Sua(hinhThuc, out string loi))
            {
                MessageBox.Show("✔️ Sửa thành công!");
                LoadDuLieu();
                LamMoi();
            }
            else
                MessageBox.Show(loi ?? "❌ Sửa thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHT = txtMHT.Text.Trim();

            if (MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (HinhThucThanhToan_BUS.Xoa(maHT, out string loi))
                {
                    MessageBox.Show("🗑️ Xoá thành công!");
                    LoadDuLieu();
                    LamMoi();
                }
                else
                    MessageBox.Show(loi ?? "❌ Xoá thất bại!");
            }
        }

        private void LamMoi()
        {
            txtMHT.Text = "";
            txtTHT.Text = "";
            txtTKMT.Text = "";
            txtMHT.Enabled = true;
            txtMHT.Text = LayMaHTTTAutoIncrement();
        }

        private void dgvHTTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHTTT.Rows[e.RowIndex];
                txtMHT.Text = row.Cells["MaHinhThuc"].Value.ToString();
                txtTHT.Text = row.Cells["TenHinhThuc"].Value.ToString();
                txtMHT.Enabled = false;
            }


        }

        private void txtTKMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKMT.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDuLieu(); // Hiển thị toàn bộ nếu không nhập gì
            }
            else
            {
                var ketQua = HinhThucThanhToan_BUS.LayTatCa()
                                .FindAll(ht => ht.MaHinhThuc.Contains(tuKhoa)
                                            || ht.TenHinhThuc.Contains(tuKhoa));
                dgvHTTT.DataSource = ketQua;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDuLieu();
        }
        private string LayMaHTTTAutoIncrement()
        {
            var ds = HinhThucThanhToan_BUS.LayTatCa();
            int max = 0;
            foreach (var ht in ds)
            {
                // Assuming MaHinhThuc is in the format "HT001", "HT002", etc.
                if (ht.MaHinhThuc.Length > 2 && int.TryParse(ht.MaHinhThuc.Substring(2), out int num))
                {
                    if (num > max) max = num;
                }
            }
            return $"HT{(max + 1).ToString("D2")}";
        }
    }
}
