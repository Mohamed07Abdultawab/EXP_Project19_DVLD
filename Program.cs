using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXP_Project19_DVLD.Before_start_project._3Simple_event_with_parametar;
using EXP_Project19_DVLD.Send_data_back_to_form_using_delegate;

namespace EXP_Project19_DVLD
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
            Application.Run(new EventFrm1());
        }
    }
}
