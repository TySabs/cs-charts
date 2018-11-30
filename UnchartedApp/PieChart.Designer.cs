namespace UnchartedApp
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BackButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.SourceLabel);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(293, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 1327);
            this.panel1.TabIndex = 0;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainLabel.Location = new System.Drawing.Point(12, 26);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1546, 82);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Most Popular Frameworks, Libraries, and Tools";
            // 
            // chart1
            // 
            chartArea10.AxisY.Title = "Popularity";
            chartArea10.Name = "MainArea";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "MainLegend";
            legend10.Title = "Framework";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(44, 141);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1551, 949);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.Location = new System.Drawing.Point(603, 1175);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(400, 125);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(39, 1102);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(1151, 29);
            this.SourceLabel.TabIndex = 5;
            this.SourceLabel.Text = "Source: StackOverflow Developer Survey 2018 -- All Respondents, 51,620 responses;" +
    " Select All That Apply";
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2273, 1372);
            this.Controls.Add(this.panel1);
            this.Name = "PieChart";
            this.Text = "PieChart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label SourceLabel;
    }
}