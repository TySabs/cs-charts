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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.SourceLabel);
            this.MainPanel.Controls.Add(this.MainLabel);
            this.MainPanel.Controls.Add(this.MainChart);
            this.MainPanel.Location = new System.Drawing.Point(392, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1961, 1341);
            this.MainPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.Location = new System.Drawing.Point(800, 1195);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(400, 125);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(333, 1096);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(1133, 29);
            this.SourceLabel.TabIndex = 6;
            this.SourceLabel.Text = "Source: StackOverflow Developer Survey 2018 -- All Respondents, 78,334 responses;" +
    " select all that apply";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainLabel.Location = new System.Drawing.Point(324, 10);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1286, 82);
            this.MainLabel.TabIndex = 5;
            this.MainLabel.Text = "Most Popular Programming Languages";
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
            this.MainChart.Location = new System.Drawing.Point(338, 141);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.MainChart.Size = new System.Drawing.Size(1298, 930);
            this.MainChart.TabIndex = 4;
            this.MainChart.Text = "Programming Languages";
            // 
            // BarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2691, 1385);
            this.Controls.Add(this.MainPanel);
            this.Name = "BarChart";
            this.Text = "BarChart";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}