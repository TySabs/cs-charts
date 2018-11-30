using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 6         Fall 2018   *
 *                                                          *
 *  Programmers: Tyler Saballus                             *
 *                                                          *
 *  Date Due:   Nov-29                                      *
 *                                                          *
 *  Purpose:    This is a Charting app that displays        *
 *               various different types of developer data. *
 ***********************************************************/

namespace UnchartedApp
{
    public partial class PyramidChart : Form
    {
        // Chart constructor
        public PyramidChart()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
            CenterToScreen();
            InitDataPoints();
        }

        /*******************************************************
        * InitDataPoints method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Initializes Data points for this char
        ******************************************************/
        private void InitDataPoints()
        {
            Series newSeries = new Series();

            newSeries.ChartArea = "MainArea";
            newSeries.ChartType = SeriesChartType.Pyramid;
            newSeries.IsValueShownAsLabel = true;
            newSeries.Name = "Popularity";

            string dataSrc = "../../Properties/Resources/popular-databases.txt";

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

            MainChart.Series.Add(newSeries);
        } // end InitDataPoints method


        /*******************************************************
        * BackButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Closes the chart on button click
        ******************************************************/
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    } // end PyramidChart class
} // end UnchartedApp namespace
