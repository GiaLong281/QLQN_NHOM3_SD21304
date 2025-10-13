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
using GUI_QLQN;
using TheArtOfDevHtmlRenderer.Adapters;

namespace GUI_QLQN
{
    public partial class FrmQuanLyLoaiMay : Form
    {
        public FrmQuanLyLoaiMay()
        {
            InitializeComponent();
        }
        private void FrmQuanLyLoaiMay_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            var ds = LoaiMay_BUS.LayDanhSach();

            var dsView = ds.Select(lm => new
            {
                lm.MaLoaiMay,
                lm.TenLoaiMay,
                TenTrangThai = ChuyenTrangThai(lm.MaTrangThai)
            }).ToList();

            dgvQLLM.DataSource = dsView;
            dgvQLLM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLLM.ReadOnly = true;
            dgvQLLM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvQLLM.Columns["MaLoaiMay"].HeaderText = "Mã Loại Máy";
            dgvQLLM.Columns["TenLoaiMay"].HeaderText = "Tên Loại Máy";
            dgvQLLM.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
        }

        private string ChuyenTrangThai(string maTT)
        {
            switch (maTT)
            {
                case "TT01": return "Đang hoạt động";
                case "TT02": return "Tạm dừng";
                case "TT03": return "Sẵn sàng";
                case "TT04": return "Bảo trì";
                default: return "Không xác định";
            }
        }

        private string LayMaTrangThai()
        {
            if (rdoTrong.Checked) return "TT02";
            if (rdoSD.Checked) return "TT01";

            return null;
        }

        private void dgvQLLM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var loai = new DTO_QuanLyQuanNet.LoaiMay_DTO(
       txtML.Text.Trim(),
       txtTL.Text.Trim(),
       LayMaTrangThai()
   );

            if (BLL_QuanLyQuanNet.LoaiMay_BUS.Them(loai))
            {
                MessageBox.Show("✅ Thêm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("❌ Thêm thất bại. Kiểm tra lại dữ liệu.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var loai = new DTO_QuanLyQuanNet.LoaiMay_DTO(
        txtML.Text.Trim(),
        txtTL.Text.Trim(),
        LayMaTrangThai()
    );

            if (BLL_QuanLyQuanNet.LoaiMay_BUS.Sua(loai))
            {
                MessageBox.Show("✅ Sửa thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("❌ Sửa thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtML.Text.Trim();
            if (BLL_QuanLyQuanNet.LoaiMay_BUS.Xoa(ma))
            {
                MessageBox.Show("🗑️ Xóa thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("❌ Xóa thất bại. Mã có thể đang được dùng.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtML.Text = GenerateNextMaLoaiMay();
            txtTL.Clear();
            txtTKLM.Clear();
            rdoSD.Checked = true;
            txtML.Enabled = false; // Không cho phép sửa mã loại máy
            LoadData();
        }

        private string GenerateNextMaLoaiMay()
        {
            var ds = BLL_QuanLyQuanNet.LoaiMay_BUS.LayDanhSach();
            int max = 0;
            foreach (var lm in ds)
            {
                if (lm.MaLoaiMay.StartsWith("LM"))
                {
                    string numberPart = lm.MaLoaiMay.Substring(2);
                    if (int.TryParse(numberPart, out int num))
                    {
                        if (num > max) max = num;
                    }
                }
            }
            return $"LM{(max + 1).ToString("D2")}";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKLM.Text.Trim();
            var ds = BLL_QuanLyQuanNet.LoaiMay_BUS.LayDanhSach()
    .Where(lm => lm.MaLoaiMay.ToLower().Contains(tuKhoa.ToLower()) ||
                 lm.TenLoaiMay.ToLower().Contains(tuKhoa.ToLower()))
    .ToList();

            dgvQLLM.DataSource = ds;
        }

        private void txtML_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTKLM_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoTrong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoHong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoSD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoBT_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dgvQLLM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo người dùng click vào dòng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLLM.Rows[e.RowIndex];

                txtML.Text = row.Cells["MaLoaiMay"].Value?.ToString();
                txtTL.Text = row.Cells["TenLoaiMay"].Value?.ToString();
                string trangThai = row.Cells["TenTrangThai"].Value?.ToString();

                // Gán radio tương ứng với trạng thái
                switch (trangThai)
                {
                    case "Trống":
                        rdoTrong.Checked = true;
                        break;
                    case "Đang sử dụng":
                        rdoSD.Checked = true;
                        break;
                    default:
                        rdoTrong.Checked = true;
                        break;
                }
                txtML.Enabled = false; // Không cho phép sửa mã loại máy
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
