using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace UnchartedApp
{
    public partial class BarChart : Form
    {
        public BarChart()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
            CenterToScreen();
            InitDataPoints();
        }

        private void InitDataPoints()
        {
            Series newSeries = new Series();

            newSeries.ChartArea = "MainArea";
            newSeries.ChartType = SeriesChartType.Bar;
            newSeries.IsValueShownAsLabel = true;
            newSeries.Legend = "Legend1";
            newSeries.Name = "Popularity";

            string dataSrc = "../../Properties/Resources/popular-languages.txt";

            using (StreamReader inFile = new StreamReader(dataSrc))
            {
                string buffer;
                while ((buffer = inFile.ReadLine()) != null)
                {
                    string[] splitLine = buffer.Split(' ');

                    double newValue = Double.Parse(splitLine[0]);

                    DataPoint newPoint = new DataPoint();
                    newPoint.SetValueY(newValue);
                    newPoint.AxisLabel = splitLine[1];

                    newPoint.CustomProperties = "DrawingStyle=Emboss";
                    newPoint.LabelFormat = "#.0\'%\'";

                    newSeries.Points.Add(newPoint);
                }
            }

            MainChart.Series.Add(newSeries);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
