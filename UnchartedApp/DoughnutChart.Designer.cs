namespace UnchartedApp
{
    partial class DoughnutChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.WantedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DreadedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LovedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WantedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DreadedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LovedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.Controls.Add(this.SourceLabel);
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Controls.Add(this.WantedChart);
            this.MainPanel.Controls.Add(this.DreadedChart);
            this.MainPanel.Controls.Add(this.LovedChart);
            this.MainPanel.Location = new System.Drawing.Point(114, 61);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(2523, 1237);
            this.MainPanel.TabIndex = 0;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(25, 967);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(1425, 29);
            this.SourceLabel.TabIndex = 5;
            this.SourceLabel.Text = "Source: StackOverflow Developer Survey 2018 -- Percentage of developers who expre" +
    "ssed the following emotions about a language";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.Location = new System.Drawing.Point(1066, 1070);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(400, 125);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainLabel.Location = new System.Drawing.Point(599, 52);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1343, 82);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Most Loved, Dreaded, Wanted Languges";
            // 
            // WantedChart
            // 
            chartArea1.Name = "WantedArea";
            this.WantedChart.ChartAreas.Add(chartArea1);
            legend1.Name = "WantedLegend";
            legend1.Title = "Most Wanted";
            this.WantedChart.Legends.Add(legend1);
            this.WantedChart.Location = new System.Drawing.Point(1696, 175);
            this.WantedChart.Name = "WantedChart";
            this.WantedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.WantedChart.Size = new System.Drawing.Size(804, 776);
            this.WantedChart.TabIndex = 2;
            this.WantedChart.Text = "chart2";
            // 
            // DreadedChart
            // 
            chartArea2.Name = "DreadedArea";
            this.DreadedChart.ChartAreas.Add(chartArea2);
            legend2.Name = "DreadedLegend";
            legend2.Title = "Most Dreaded";
            this.DreadedChart.Legends.Add(legend2);
            this.DreadedChart.Location = new System.Drawing.Point(867, 175);
            this.DreadedChart.Name = "DreadedChart";
            this.DreadedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.DreadedChart.Size = new System.Drawing.Size(804, 776);
            this.DreadedChart.TabIndex = 1;
            this.DreadedChart.Text = "chart1";
            // 
            // LovedChart
            // 
            chartArea3.Name = "LovedArea";
            this.LovedChart.ChartAreas.Add(chartArea3);
            legend3.Name = "LovedLegend";
            legend3.Title = "Most Loved";
            this.LovedChart.Legends.Add(legend3);
            this.LovedChart.Location = new System.Drawing.Point(30, 175);
            this.LovedChart.Name = "LovedChart";
            this.LovedChart.Size = new System.Drawing.Size(804, 776);
            this.LovedChart.TabIndex = 0;
            this.LovedChart.Text = "chart1";
            // 
            // DoughnutChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2744, 1325);
            this.Controls.Add(this.MainPanel);
            this.Name = "DoughnutChart";
            this.Text = "Doughnut Chart";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WantedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DreadedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LovedChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart LovedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WantedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DreadedChart;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SourceLabel;
    }
}