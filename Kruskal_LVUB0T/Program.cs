using System;
using System.Windows.Forms;

namespace Kruskal_LVUB0T
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
            Application.Run(new Kruskal_form());
        }
    }
}
