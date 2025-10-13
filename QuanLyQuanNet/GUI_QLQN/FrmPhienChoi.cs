using BLL_QuanLyQuanNet;
using DTO_QuanLyQuanNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI_QLQN
{
    public partial class FrmPhienChoi : Form
    {
        public FrmPhienChoi()
        {
            InitializeComponent();
            cboSoCot.Items.Clear();
            for (int i = 1; i <= 8; i++)
                cboSoCot.Items.Add(i.ToString());

            cboSoCot.SelectedIndex = 2; // Mặc định 3 cột
            LoadPanelMay(3);
        }

        PhienChoi_BLL bll = new PhienChoi_BLL();

        private void FrmPhienChoi_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxMaMay();
            timer1.Interval = 1000; // 1 giây
            dgvPhienChoi.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvPhienChoi.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
        }

        private bool CheckFormValid()
        {
            if (cboMKH.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                cboMKH.Focus();
                return false;
            }
            if (cboMM.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn máy!");
                cboMM.Focus();
                return false;
            }
            if (!decimal.TryParse(txtSTCL.Text, out decimal stcl) || stcl <= 0)
            {
                MessageBox.Show("Số tiền còn lại phải là số dương!");
                txtSTCL.Focus();
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            List<PhienChoi_DTO> danhSachPhien = PhienChoi_BLL.LayTatCaPhien();
            dgvPhienChoi.DataSource = danhSachPhien;

            bool hasUnfinishedSession = danhSachPhien.Any(p => p.ThoiGianKetThuc == null);
            if (hasUnfinishedSession)
                timer1.Start();
            else
                timer1.Stop();

            DatLaiHeaderTiengViet();
        }

        private void LoadComboBoxMaMay()
        {
            string connStr = "Data Source=DESKTOP-O7TJDCH\\SQLEXPRESS;Initial Catalog=PRO231_QuanLyQuanNet1903;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT MaMay FROM MayTinh";
                    SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, conn));
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboMM.DataSource = dt;
                    cboMM.DisplayMember = "MaMay";
                    cboMM.ValueMember = "MaMay";
                    cboMM.SelectedIndex = -1;
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT MaKhachHang FROM KhachHang";
                    SqlDataAdapter da = new SqlDataAdapter(new SqlCommand(query, conn));
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboMKH.DataSource = dt;
                    cboMKH.DisplayMember = "MaKhachHang";
                    cboMKH.ValueMember = "MaKhachHang";
                    cboMKH.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu máy/khách: " + ex.Message);
            }
        }

        private void LoadPanelMay(int soCot)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = soCot;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            var dsMay = MayTinh_BUS.LayDanhSach()
                .Where(mt => mt.MaTrangThai != "TT02") // Ẩn máy tạm dừng
                .ToList();

            int col = 0, row = 0;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < soCot; i++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / soCot));

            foreach (var may in dsMay)
            {
                if (col == soCot)
                {
                    col = 0;
                    row++;
                    tableLayoutPanel1.RowCount = row + 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
                var uc = new ucTinhTrangMay();
                uc.MaMay = may.MaMay;
                uc.SetTenMay(may.TenMay);
                uc.CapNhatTrangThai(may.MaTrangThai);
                uc.Size = new Size(280, 100); // Giảm chiều cao row

                uc.MaySelected += (s, maMay) =>
                {
                    cboMM.SelectedValue = maMay;
                };

                tableLayoutPanel1.Controls.Add(uc, col, row);
                col++;
            }
        }

        private void DatLaiHeaderTiengViet()
        {
            dgvPhienChoi.Columns["MaPhien"].HeaderText = "Mã Phiên";
            dgvPhienChoi.Columns["MaKhachHang"].HeaderText = "Mã KH";
            dgvPhienChoi.Columns["MaMay"].HeaderText = "Mã Máy";
            dgvPhienChoi.Columns["ThoiGianBatDau"].HeaderText = "Bắt Đầu";
            dgvPhienChoi.Columns["ThoiGianKetThuc"].HeaderText = "Kết Thúc";
            dgvPhienChoi.Columns["TongSoGio"].HeaderText = "Số Giờ";
            dgvPhienChoi.Columns["TongTien"].HeaderText = "Tiền Chơi";
            dgvPhienChoi.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            dgvPhienChoi.Columns["SoTienConLai"].HeaderText = "Số dư";
            dgvPhienChoi.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dgvPhienChoi.Columns["MaTrangThai"].Visible = false;

            dgvPhienChoi.Columns["ThoiGianBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvPhienChoi.Columns["ThoiGianKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvPhienChoi.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private PhienChoi_DTO GetFormData(bool isAdd = true)
        {
            string maPhien = txtMP.Text.Trim();
            string maMay = cboMM.SelectedValue?.ToString();
            string maKhach = cboMKH.SelectedValue?.ToString();
            DateTime thoiGianBatDau = dtpTGBD.Value;
            DateTime? thoiGianKetThuc = isAdd ? (DateTime?)null : dtpTGKT.Value;

            decimal soTienConLai = 0;
            decimal.TryParse(txtSTCL.Text, out soTienConLai); // txtNapTien là textbox nhập tiền nạp

            if (string.IsNullOrWhiteSpace(maPhien) || string.IsNullOrWhiteSpace(maMay))
                return null;

            return new PhienChoi_DTO
            {
                MaPhien = maPhien,
                MaMay = maMay,
                MaKhachHang = maKhach,
                ThoiGianBatDau = thoiGianBatDau,
                ThoiGianKetThuc = thoiGianKetThuc,
                TongTien = 0,
                SoTienConLai = soTienConLai,
                NgayTao = dtpNT.Value,
                MaTrangThai = "TT01"
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckFormValid()) return;

            string maKhachHang = cboMKH.SelectedValue?.ToString();
            decimal soDuKhachHang = KhachHang_BUS.LaySoDuKhachHang(maKhachHang);
            txtSTCL.Text = soDuKhachHang.ToString("N0");

            var pc = GetFormData(true);
            if (pc != null && bll.ThemPhien(pc))
            {
                // Cập nhật trạng thái máy sang "Đang hoạt động" (TT01)
                MayTinh_BUS.CapNhatTrangThaiMay(pc.MaMay, "TT01");

                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var pc = GetFormData(false);
            if (pc != null && bll.CapNhatPhien(pc))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMP.Text) && bll.XoaPhien(txtMP.Text))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa phiên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa phiên thất bại hoặc đã bị xóa trước đó!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiên cần xóa!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            txtMP.Text = bll.TaoMaPhienMoi();
            cboMKH.SelectedIndex = -1;
            cboMM.SelectedIndex = -1;

            dtpTGBD.Value = now;
            dtpTGKT.Value = now;

            txtTSG.Text = "00:00:00";
            txtTT.Clear();
            txtSTCL.Clear();
            dtpNT.Value = now;
            cboMKH.Focus();
            btnThem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMay = txtTKLM.Text.Trim();
            dgvPhienChoi.DataSource = bll.TimKiemPhien(maMay);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal donGia = PhienChoi_BLL.LayDonGia();

            foreach (DataGridViewRow row in dgvPhienChoi.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime batDau = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);
                object ketThucObj = row.Cells["ThoiGianKetThuc"].Value;
                DateTime ketThuc = (ketThucObj == null || Convert.IsDBNull(ketThucObj))
                    ? DateTime.Now
                    : Convert.ToDateTime(ketThucObj);

                TimeSpan duration = ketThuc - batDau;
                double soGio = duration.TotalHours;
                decimal tongTien = Math.Round((decimal)soGio * donGia, 0);

                // Chỉ gán số vào cell, không format
                row.Cells["TongSoGio"].Value = soGio;
                row.Cells["TongTien"].Value = tongTien;

                // Nếu là phiên đang chọn thì cập nhật txtTSG và txtTT
                if (row.Cells["MaPhien"].Value?.ToString() == txtMP.Text)
                {
                    txtTSG.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)duration.TotalHours, duration.Minutes, duration.Seconds);
                    txtTT.Text = tongTien.ToString("N0");
                }
            }
        }

        private void dgvPhienChoi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhienChoi.Columns[e.ColumnIndex].Name == "TongSoGio" && e.Value != null)
            {
                double soGio = Convert.ToDouble(e.Value);
                TimeSpan ts = TimeSpan.FromHours(soGio);
                e.Value = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
                e.FormattingApplied = true;
            }
        }

        private void dgvPhienChoi_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0 && !dgvPhienChoi.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgvPhienChoi.Rows[e.RowIndex];

                txtMP.Text = row.Cells["MaPhien"].Value?.ToString();
                cboMKH.SelectedValue = row.Cells["MaKhachHang"].Value?.ToString();
                cboMM.SelectedValue = row.Cells["MaMay"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["ThoiGianBatDau"].Value?.ToString(), out DateTime tgbd))
                    dtpTGBD.Value = tgbd;

                var ketThucVal = row.Cells["ThoiGianKetThuc"].Value;
                DateTime? tgkt = null;
                if (ketThucVal != null && !Convert.IsDBNull(ketThucVal))
                    tgkt = Convert.ToDateTime(ketThucVal);

                if (tgkt == null || tgkt < dtpTGKT.MinDate)
                    dtpTGKT.Value = DateTime.Now;
                else
                    dtpTGKT.Value = tgkt.Value;

                if (row.Cells["ThoiGianBatDau"].Value != null)
                {
                    DateTime batDau = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);
                    DateTime ketThuc;
                    var ketThucVal2 = row.Cells["ThoiGianKetThuc"].Value;
                    if (ketThucVal2 != null && !Convert.IsDBNull(ketThucVal2))
                        ketThuc = Convert.ToDateTime(ketThucVal2);
                    else
                        ketThuc = DateTime.Now;

                    TimeSpan duration = ketThuc - batDau;
                    txtTSG.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)duration.TotalHours, duration.Minutes, duration.Seconds);
                }
                else
                {
                    txtTSG.Text = "00:00:00";
                }
                txtTT.Text = row.Cells["TongTien"].Value?.ToString();
                txtSTCL.Text = row.Cells["SoTienConLai"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out DateTime ngayTao))
                    dtpNT.Value = ngayTao;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMP.Text))
            {
                MessageBox.Show("Vui lòng chọn phiên cần kết thúc!");
                return;
            }

            string maPhien = txtMP.Text.Trim();
            DateTime thoiGianBatDau = dtpTGBD.Value;
            DateTime thoiGianKetThuc = DateTime.Now;
            decimal donGia = PhienChoi_BLL.LayDonGia();
            double tongSoGio = Math.Round((thoiGianKetThuc - thoiGianBatDau).TotalHours, 2);
            decimal tongTien = Math.Round((decimal)tongSoGio * donGia, 0);

            string maKhachHang = cboMKH.SelectedValue?.ToString();
            decimal soDuKhachHang = KhachHang_BUS.LaySoDuKhachHang(maKhachHang);

            decimal soDuMoi = soDuKhachHang - tongTien;
            KhachHang_BUS.CapNhatSoDuKhachHang(maKhachHang, soDuMoi);

            decimal soTienConLai = soDuMoi;
            bool result = PhienChoi_BLL.CapNhatKetThucPhien(maPhien, thoiGianKetThuc, tongSoGio, tongTien, soTienConLai);

            if (result)
            {
                // Cập nhật trạng thái máy về "Sẵn sàng" (TT03)
                var maMay = cboMM.SelectedValue?.ToString();
                MayTinh_BUS.CapNhatTrangThaiMay(maMay, "TT03");

                MessageBox.Show("Kết thúc phiên thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Kết thúc phiên thất bại!");
            }
        }

        private void cboMM_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboSoCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soCot = int.Parse(cboSoCot.SelectedItem.ToString());
            LoadPanelMay(soCot);
        }
    }
}