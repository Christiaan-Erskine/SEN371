using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            //Application.Run(new Form1());
            
            Application.Run(new PresentationLayer.Technician());


            Application.Run(new PresentationLayer.CallCenterManager());

            //Application.Run(new PresentationLayer.CallCenterEmployee());
            //Application.Run(new PresentationLayer.Search());
            //Application.Run(new PresentationLayer.ClientDataManager());

        }
    }
}