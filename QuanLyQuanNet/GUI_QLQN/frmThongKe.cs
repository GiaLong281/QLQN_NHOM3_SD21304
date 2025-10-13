using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL_QuanLyQuanNet;

namespace GUI_QLQN
{
    public partial class frmThongKe : Form
    {
        private readonly ThongKe_BLL thongKeBLL = new ThongKe_BLL();
        public frmThongKe()
        {
            InitializeComponent();

            // Set default date range: from Jan 1st of current year to today
            dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTo.Value = DateTime.Now.Date;

            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            VeBieuDo(thongKeBLL.LayDoanhThuTheoNgay(from, to));
            VeBieuDoTiLeChonMay(thongKeBLL.LayTiLeChonMay(from, to));
            VeBieuDoDoanhThuNhanVien(thongKeBLL.LayDoanhThuNhanVien(from, to));
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            VeBieuDo(thongKeBLL.LayDoanhThuTheoNgay(from, to));
            VeBieuDoTiLeChonMay(thongKeBLL.LayTiLeChonMay(from, to));
            VeBieuDoDoanhThuNhanVien(thongKeBLL.LayDoanhThuNhanVien(from, to));
        }
        private void VeBieuDo(DataTable dt)
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Legends.Clear();

            ChartArea chartArea = new ChartArea("DoanhThuArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisY.Title = "Tổng tiền (VNĐ)";
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartDoanhThu.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.OrangeRed,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.DarkGreen,
                LabelFormat = "N0"
            };

            foreach (DataRow row in dt.Rows)
            {
                string ngay = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM");
                decimal tong = Convert.ToDecimal(row["TongTien"]);
                series.Points.AddXY(ngay, tong);
            }

            chartDoanhThu.Series.Add(series);
            chartDoanhThu.Titles.Add(new Title("Biểu đồ Doanh Thu",
                Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.DarkSlateBlue));
        }
        private void VeBieuDoTiLeChonMay(DataTable dt)
        {
            chartTiLeMay.Series.Clear();
            chartTiLeMay.ChartAreas.Clear();
            chartTiLeMay.Titles.Clear();
            chartTiLeMay.Legends.Clear();

            ChartArea chartArea = new ChartArea("PieArea");
            chartTiLeMay.ChartAreas.Add(chartArea);

            Legend legend = new Legend("Legend1")
            {
                Docking = Docking.Right,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            chartTiLeMay.Legends.Add(legend);

            chartTiLeMay.Palette = ChartColorPalette.BrightPastel;

            Series series = new Series("Tỉ lệ máy")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P1}",
                LegendText = "#VALX"
            };

            foreach (DataRow row in dt.Rows)
            {
                string tenMay = row["TenMay"].ToString();
                int soLuot = Convert.ToInt32(row["SoLuotSuDung"]);
                series.Points.AddXY(tenMay, soLuot);
            }

            chartTiLeMay.Series.Add(series);
            chartTiLeMay.Titles.Add(new Title("Tỉ lệ chọn máy",
                Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.DarkSlateBlue));
        }
        private void VeBieuDoDoanhThuNhanVien(DataTable dt)
        {
            chartNhanVien.Series.Clear();
            chartNhanVien.ChartAreas.Clear();
            chartNhanVien.Titles.Clear();
            chartNhanVien.Legends.Clear();

            ChartArea chartArea = new ChartArea("NhanVienArea");
            chartArea.AxisX.Title = "Nhân viên";
            chartArea.AxisX.LabelStyle.Angle = -20;
            chartArea.AxisY.Title = "Tổng doanh thu (VNĐ)";
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartNhanVien.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh thu nhân viên")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Black,
                Label = "#VALY{N0} VNĐ"
            };

            Color[] colors = { Color.MediumSeaGreen, Color.SteelBlue, Color.OrangeRed, Color.DarkGoldenrod, Color.Purple };

            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                string hoTen = row["HoTen"].ToString();
                decimal tong = Convert.ToDecimal(row["TongTien"]);
                int pointIndex = series.Points.AddXY(hoTen, tong);
                series.Points[pointIndex].Color = colors[index % colors.Length];
                index++;
            }

            chartNhanVien.Series.Add(series);
            chartNhanVien.Titles.Add(new Title("Doanh thu của từng nhân viên",
                Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.DarkSlateBlue));
        }

    }
}
