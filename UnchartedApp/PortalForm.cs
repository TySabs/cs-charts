using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnchartedApp
{
    public partial class PortalForm : Form
    {
        public PortalForm()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnyChart_FormClosed(object sender, EventArgs e)
        {
            Show();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            BarChart selectedChart = new BarChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }

        private void PieButton_Click(object sender, EventArgs e)
        {
            PieChart selectedChart = new PieChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }

        private void PyramidButton_Click(object sender, EventArgs e)
        {
            PyramidChart selectedChart = new PyramidChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }

        private void DoughnutButton_Click(object sender, EventArgs e)
        {
            DoughnutChart selectedChart = new DoughnutChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyChart_FormClosed);

            Hide();
            selectedChart.Show();
        }
    }
}
