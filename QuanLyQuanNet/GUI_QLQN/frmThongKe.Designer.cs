using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLQN
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.chartNhanVien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTiLeMay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeMay)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chartNhanVien
            // 
            this.chartNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartNhanVien.BorderlineColor = System.Drawing.Color.Gray;
            this.chartNhanVien.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.Name = "ChartArea1";
            this.chartNhanVien.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNhanVien.Legends.Add(legend1);
            this.chartNhanVien.Location = new System.Drawing.Point(621, 412);
            this.chartNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartNhanVien.Name = "chartNhanVien";
            series1.BorderColor = System.Drawing.Color.DarkGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VALY{N0} VNĐ";
            series1.LabelForeColor = System.Drawing.Color.DarkSlateGray;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNhanVien.Series.Add(series1);
            this.chartNhanVien.Size = new System.Drawing.Size(927, 474);
            this.chartNhanVien.TabIndex = 18;
            this.chartNhanVien.Text = "chart2";
            title1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            title1.Name = "Title1";
            title1.Text = "Doanh thu nhân viên";
            this.chartNhanVien.Titles.Add(title1);
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.DarkSlateBlue;
            chartArea2.AxisY.LabelStyle.Format = "N0";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.DarkSlateBlue;
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 71);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.DarkGreen;
            series2.LabelFormat = "N0";
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Orange;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.ToolTip = "#VALX: #VALY VND";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(1548, 340);
            this.chartDoanhThu.TabIndex = 14;
            this.chartDoanhThu.Text = "chart1";
            // 
            // chartTiLeMay
            // 
            this.chartTiLeMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartTiLeMay.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.chartTiLeMay.Legends.Add(legend2);
            this.chartTiLeMay.Location = new System.Drawing.Point(0, 412);
            this.chartTiLeMay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartTiLeMay.Name = "chartTiLeMay";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTiLeMay.Series.Add(series3);
            this.chartTiLeMay.Size = new System.Drawing.Size(615, 474);
            this.chartTiLeMay.TabIndex = 16;
            this.chartTiLeMay.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(651, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(197, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ ngày:";
            // 
            // dtpTo
            // 
            this.dtpTo.BorderThickness = 2;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(782, 17);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(288, 35);
            this.dtpTo.TabIndex = 11;
            this.dtpTo.Value = new System.DateTime(2025, 7, 22, 12, 41, 2, 684);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderThickness = 2;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(311, 17);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(288, 35);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.Value = new System.DateTime(2025, 7, 22, 12, 41, 2, 684);
            // 
            // btnXem
            // 
            this.btnXem.Animated = true;
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BorderRadius = 10;
            this.btnXem.BorderThickness = 2;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(1155, 14);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(166, 46);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseTransparentBackground = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 64);
            this.panel1.TabIndex = 19;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1548, 885);
            this.Controls.Add(this.chartTiLeMay);
            this.Controls.Add(this.chartNhanVien);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Chart chartTiLeMay;
        private Chart chartNhanVien;
        private System.Windows.Forms.Panel panel1;
    }
}