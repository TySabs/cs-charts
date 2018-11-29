namespace UnchartedApp
{
    partial class BarChart
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5.8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 6.1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 6.7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7.1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7.4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8.1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10.1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 17.4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 23D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25.4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30.7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34.4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38.8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 39.8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 45.3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 57D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 65.1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 68.5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 69.8D);
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Languages";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 90D;
            chartArea1.AxisY.Title = "Popularity Percentage";
            chartArea1.Name = "MainArea";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(418, 85);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Popularity";
            dataPoint1.AxisLabel = "MatLab";
            dataPoint1.CustomProperties = "DrawingStyle=Emboss";
            dataPoint1.LabelFormat = "#.0\'%\'";
            dataPoint2.AxisLabel = "R";
            dataPoint2.CustomProperties = "DrawingStyle=Emboss";
            dataPoint2.LabelFormat = "#.0\'%\'";
            dataPoint3.AxisLabel = "VB.NET";
            dataPoint3.CustomProperties = "DrawingStyle=Emboss";
            dataPoint3.LabelFormat = "#.0\'%\'";
            dataPoint4.AxisLabel = "Objective-C";
            dataPoint4.CustomProperties = "DrawingStyle=Emboss";
            dataPoint4.LabelFormat = "#.0\'%\'";
            dataPoint5.AxisLabel = "Go";
            dataPoint5.CustomProperties = "DrawingStyle=Emboss";
            dataPoint5.LabelFormat = "#.0\'%\'";
            dataPoint6.AxisLabel = "Assembly";
            dataPoint6.CustomProperties = "DrawingStyle=Emboss";
            dataPoint6.LabelFormat = "#.0\'%\'";
            dataPoint7.AxisLabel = "Swift";
            dataPoint7.CustomProperties = "DrawingStyle=Emboss";
            dataPoint7.LabelFormat = "#.0\'%\'";
            dataPoint8.AxisLabel = "Ruby";
            dataPoint8.CustomProperties = "DrawingStyle=Emboss";
            dataPoint8.LabelFormat = "#.0\'%\'";
            dataPoint9.AxisLabel = "TypeScript";
            dataPoint9.CustomProperties = "DrawingStyle=Emboss";
            dataPoint9.LabelFormat = "#.0\'%\'";
            dataPoint10.AxisLabel = "C";
            dataPoint10.CustomProperties = "DrawingStyle=Emboss";
            dataPoint10.LabelFormat = "#.0\'%\'";
            dataPoint11.AxisLabel = "C++";
            dataPoint11.CustomProperties = "DrawingStyle=Emboss";
            dataPoint11.LabelFormat = "#.0\'%\'";
            dataPoint12.AxisLabel = "PHP";
            dataPoint12.CustomProperties = "DrawingStyle=Emboss";
            dataPoint12.LabelFormat = "#.0\'%\'";
            dataPoint13.AxisLabel = "C#";
            dataPoint13.CustomProperties = "DrawingStyle=Emboss";
            dataPoint13.LabelFormat = "#.0\'%\'";
            dataPoint14.AxisLabel = "Python";
            dataPoint14.CustomProperties = "DrawingStyle=Emboss";
            dataPoint14.LabelFormat = "#.0\'%\'";
            dataPoint15.AxisLabel = "Bash/Shell";
            dataPoint15.CustomProperties = "DrawingStyle=Emboss";
            dataPoint15.LabelFormat = "#.0\'%\'";
            dataPoint16.AxisLabel = "Java";
            dataPoint16.CustomProperties = "DrawingStyle=Emboss";
            dataPoint16.LabelFormat = "#.0\'%\'";
            dataPoint17.AxisLabel = "SQL";
            dataPoint17.CustomProperties = "DrawingStyle=Emboss";
            dataPoint17.LabelFormat = "#.0\'%\'";
            dataPoint18.AxisLabel = "CSS";
            dataPoint18.CustomProperties = "DrawingStyle=Emboss";
            dataPoint18.LabelFormat = "#.0\'%\'";
            dataPoint19.AxisLabel = "HTML";
            dataPoint19.CustomProperties = "DrawingStyle=Emboss";
            dataPoint19.LabelFormat = "#.0\'%\'";
            dataPoint20.AxisLabel = "JavaScript";
            dataPoint20.CustomProperties = "DrawingStyle=Emboss";
            dataPoint20.LabelFormat = "#.0\'%\'";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            series1.Points.Add(dataPoint15);
            series1.Points.Add(dataPoint16);
            series1.Points.Add(dataPoint17);
            series1.Points.Add(dataPoint18);
            series1.Points.Add(dataPoint19);
            series1.Points.Add(dataPoint20);
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(1298, 930);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "Programming Languages";
            // 
            // BarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2127, 1080);
            this.Controls.Add(this.MainChart);
            this.Name = "BarChart";
            this.Text = "BarChart";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}