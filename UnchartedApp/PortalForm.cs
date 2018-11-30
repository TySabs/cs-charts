using System;
using System.Windows.Forms;

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
    public partial class PortalForm : Form
    {
        // Portal constructor
        public PortalForm()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
        }

        /*******************************************************
        * ExitButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Closes the main form on button click
        ******************************************************/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*******************************************************
        * AnyChart_FormClosed method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Closes the main form on button click
        ******************************************************/
        private void AnyChart_FormClosed(object sender, EventArgs e)
        {
            Show();
        }


        /*******************************************************
        * BarButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Opens up the Bar Chart
        ******************************************************/
        private void BarButton_Click(object sender, EventArgs e)
        {
            BarChart selectedChart = new BarChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }

        /*******************************************************
        * PieButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Opens up the Pie Chart
        ******************************************************/
        private void PieButton_Click(object sender, EventArgs e)
        {
            PieChart selectedChart = new PieChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }

        /*******************************************************
        * PyramidButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Opens up the Pyramid Chart
        ******************************************************/
        private void PyramidButton_Click(object sender, EventArgs e)
        {
            PyramidChart selectedChart = new PyramidChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }


        /*******************************************************
        * DoughnutButton_Click method
        *
        * Arguments: (0):
        *
        * Return Type: void
        * Use Case: Opens up the Doughnut Chart
        ******************************************************/
        private void DoughnutButton_Click(object sender, EventArgs e)
        {
            DoughnutChart selectedChart = new DoughnutChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }
    } // end PortalForm class
} // end UnchartedApp namespace
