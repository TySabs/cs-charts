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
    public partial class PyramidChart : Form
    {
        public PyramidChart()
        {
            InitializeComponent();
            Size = Program.InitFrameSize();
            CenterToScreen();
        }
    }
}
