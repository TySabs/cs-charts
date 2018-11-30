using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UnchartedApp
{
    public partial class PieChart : Form
    {
        public PieChart()
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
            newSeries.ChartType = SeriesChartType.Pie;
            newSeries.IsValueShownAsLabel = true;
            newSeries.Name = "Popularity";

            string dataSrc = "../../Properties/Resources/popular-frameworks.txt";

            using (StreamReader inFile = new StreamReader(dataSrc))
            {
                string buffer;
                while ((buffer = inFile.ReadLine()) != null)
                {
                    string[] splitLine = buffer.Split('#');

                    double newValue = Double.Parse(splitLine[0]);

                    DataPoint newPoint = new DataPoint();
                    newPoint.SetValueY(newValue);
                    newPoint.AxisLabel = splitLine[1];

                    newPoint.LabelFormat = "#.0\'%\'";

                    newSeries.Points.Add(newPoint);
                }
            }

            chart1.Series.Add(newSeries);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
