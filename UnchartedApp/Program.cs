using System;
using System.Drawing;
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

        /*******************************************************
        * InitFrameSize method
        *
        * Arguments: (0):
        *
        * Return Type: Size - new size of the window
        * Use Case: Calculates the form size based on client's window size
        ******************************************************/
        public static Size InitFrameSize()
        {
            int h = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.75);
            int w = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.65);
            return new Size(w, h);
        }
    } // end Program class
} // end UnchartedApp namespace
