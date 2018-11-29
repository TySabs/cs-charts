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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Languages";
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 90D;
            chartArea3.AxisY.Title = "Popularity Percentage";
            chartArea3.Name = "MainArea";
            this.MainChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.MainChart.Legends.Add(legend3);
            this.MainChart.Location = new System.Drawing.Point(708, 156);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(1298, 930);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "Programming Languages";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainLabel.Location = new System.Drawing.Point(694, 25);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1286, 82);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Most Popular Programming Languages";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(703, 1111);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(716, 29);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Source: StackOverflow Developer Survey 2018 -- All Respondents";
            // 
            // BarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2661, 1220);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.MainChart);
            this.Name = "BarChart";
            this.Text = "BarChart";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label SourceLabel;
    }
}