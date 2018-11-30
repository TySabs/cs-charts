namespace UnchartedApp
{
    partial class PyramidChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
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
            this.MainPanel.Location = new System.Drawing.Point(454, 33);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1514, 1336);
            this.MainPanel.TabIndex = 0;
            // 
            // MainChart
            // 
            chartArea4.Name = "MainArea";
            this.MainChart.ChartAreas.Add(chartArea4);
            legend4.Name = "MainLegend";
            legend4.Title = "Databases";
            this.MainChart.Legends.Add(legend4);
            this.MainChart.Location = new System.Drawing.Point(91, 160);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(1326, 910);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainLabel.Location = new System.Drawing.Point(362, 36);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(822, 82);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Most Popular Databases";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(86, 1094);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(1133, 29);
            this.SourceLabel.TabIndex = 3;
            this.SourceLabel.Text = "Source: StackOverflow Developer Survey 2018 -- All Respondents, 66,264 responses;" +
    " select all that apply";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.Location = new System.Drawing.Point(539, 1164);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(400, 125);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PyramidChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2401, 1381);
            this.Controls.Add(this.MainPanel);
            this.Name = "PyramidChart";
            this.Text = "PyramidChart";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Button BackButton;
    }
}