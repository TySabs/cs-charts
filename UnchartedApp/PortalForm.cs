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
            InitFrameSize();
        }

        private void InitFrameSize()
        {
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.75);
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            Size = new Size(w, h);
        }

        private void AnyForm_FormClosed(object sender, EventArgs e)
        {
            Show();
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            BarChart selectedChart = new BarChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyForm_FormClosed);
            selectedChart.Show();
            Hide();
        }

        private void PieButton_Click(object sender, EventArgs e)
        {
            PieChart selectedChart = new PieChart();
            selectedChart.FormClosed += new FormClosedEventHandler(AnyForm_FormClosed);
            selectedChart.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
