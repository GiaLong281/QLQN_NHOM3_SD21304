using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace GUI_QLQN
{
    public partial class ucDichVu : UserControl
    {

        public string MaDichVu { get; set; }

        public string TenDichVu
        {
            get => lblTenDichVu.Text;
            set => lblTenDichVu.Text = value;
        }

        private decimal donGia;
        public decimal DonGia
        {
            get => donGia;
            set
            {
                donGia = value;
                lblDonGia.Text = $"Giá: {donGia:N0} VNĐ";
            }
        }

        public int SoLuong
        {
            get => int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0;
            set => txtSoLuong.Text = value.ToString();
        }

        public decimal ThanhTien => DonGia * SoLuong;

        // Sự kiện gửi ra ngoài khi số lượng thay đổi
        public event EventHandler SoLuongThayDoi;

        public ucDichVu()
        {
            InitializeComponent();
            pbAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
            SoLuong = 0;
        }

        public byte[] AnhDichVuBytes
        {
            set
            {
                if (value != null && value.Length > 0)
                {
                    using (var ms = new MemoryStream(value))
                    {
                        pbAnhSP.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbAnhSP.Image = null;
                }
            }
        }

        public byte[] GetAnhDichVuFromDatabase(string maDichVu)
        {
            byte[] imageBytes = null;
            string connectionString = @"Data Source=DESKTOP-O7TJDCH\SQLEXPRESS;Initial Catalog=PRO231_QuanLyQuanNet1903;Integrated Security=True;TrustServerCertificate=True";
        string query = "SELECT AnhSP FROM DichVu WHERE MaDichVu = @MaDichVu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    imageBytes = (byte[])result;
                }
            }
            return imageBytes;
        }

        private void BtnTang_Click(object sender, EventArgs e)
        {
            SoLuong += 1;
            SoLuongThayDoi?.Invoke(this, EventArgs.Empty);
        }

        private void BtnGiam_Click(object sender, EventArgs e)
        {
            if (SoLuong > 1)
            {
                SoLuong -= 1;
            }
            else
            {
                SoLuong = 0;
            }
            SoLuongThayDoi?.Invoke(this, EventArgs.Empty);
        }

        private void ucDichVu_Load(object sender, EventArgs e)
        {
            lblTenDichVu.Left = (paneluc.Width - lblTenDichVu.Width) / 2;

            lblDonGia.Left = (paneluc.Width - lblDonGia.Width) / 2;

            if (!string.IsNullOrEmpty(MaDichVu))
            {
                var imageBytes = GetAnhDichVuFromDatabase(MaDichVu);
                AnhDichVuBytes = imageBytes;
            }
        }
        public void ResetSoLuong()
        {
            this.SoLuong = 0;
        }

    }
}
