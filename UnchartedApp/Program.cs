using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnchartedApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PortalForm());
        }

        public static Size InitFrameSize()
        {
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.75);
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            return new Size(w, h);
        }
    }
}
