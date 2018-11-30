using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UnchartedApp
{
    public partial class DoughnutChart : Form
    {
        public DoughnutChart()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
            CenterToScreen();
            InitSeries();
        }

        private void InitSeries()
        {
            Series newSeries1, newSeries2, newSeries3;
            newSeries1 = InitDataPoints("../../Properties/Resources/languages-loved.txt", "Loved");
            newSeries2 = InitDataPoints("../../Properties/Resources/languages-dreaded.txt", "Dreaded");
            newSeries3 = InitDataPoints("../../Properties/Resources/languages-wanted.txt", "Wanted");

            LovedChart.Series.Add(newSeries1);
            DreadedChart.Series.Add(newSeries2);
            WantedChart.Series.Add(newSeries3);
        }

        private Series InitDataPoints(string source, string name)
        {
            Series newSeries = new Series();

            newSeries.ChartArea = name + "Area";
            newSeries.ChartType = SeriesChartType.Doughnut;
            newSeries.Legend = name + "Legend";
            newSeries.IsValueShownAsLabel = true;
            newSeries.Name = name;

            string dataSrc = source;

            using (StreamReader inFile = new StreamReader(dataSrc))
            {
                string buffer;
                while ((buffer = inFile.ReadLine()) != null)
                {
                    string[] splitLine = buffer.Split('*');

                    double newValue = Double.Parse(splitLine[0]);

                    DataPoint newPoint = new DataPoint();
                    newPoint.SetValueY(newValue);
                    newPoint.AxisLabel = splitLine[1];

                    newPoint.LabelFormat = "#.#\'%\'";

                    newSeries.Points.Add(newPoint);
                }
            }

            return newSeries;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
