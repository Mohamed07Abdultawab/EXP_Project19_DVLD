using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXP_Project19_DVLD.Before_start_project._3Simple_event_with_parametar
{
    public partial class EventFrm1 : Form
    {
        public EventFrm1()
        {
            InitializeComponent();
        }

        private void ctlCalculator1_OnCalculationComplete(int obj)
        {
            MessageBox.Show(Text = "Calculation complete! Result: " + obj.ToString());
        }
    }
}
