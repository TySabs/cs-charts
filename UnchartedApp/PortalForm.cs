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
            CenterToScreen();
        }

        private void InitFrameSize()
        {
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.65);
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            Size = new Size(w, h);

            BarButton.Left = (this.ClientSize.Width - BarButton.Width) / 2;
            BarButton.Top =(int) ((this.ClientSize.Height - BarButton.Height) * 0.3);

            PieButton.Left = (this.ClientSize.Width - PieButton.Width) / 2;
            PieButton.Top =(int) ((this.ClientSize.Height - PieButton.Height) * 0.5);
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            BarChart selectedChart = new BarChart();
            selectedChart.Show();
            Hide();
        }

        private void PieButton_Click(object sender, EventArgs e)
        {
            PieChart selectedChart = new PieChart();
            selectedChart.Show();
            Hide();
        }
    }
}
