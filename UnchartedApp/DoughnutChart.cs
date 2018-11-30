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
    public partial class DoughnutChart : Form
    {
        // Chart constructor
        public DoughnutChart()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
            CenterToScreen();
            InitSeries();
        }

        /*******************************************************
        * InitSeries method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Initializes Three Series for our doughnut chart
        ******************************************************/
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

        /*******************************************************
        * InitDataPoints method
        *
        * Arguments: (2):
        *   1. source - the path to the data file
        *   2. name - the name of the new series
        *
        * Return Type: void
        * Use Case: Initializes Data points for this char
        ******************************************************/
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
                } // end while loop
            } // end using

            return newSeries;
        }  // end InitDataPoints method


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
    } // end DoughnutChart class
} // end UnchartedApp namespace
