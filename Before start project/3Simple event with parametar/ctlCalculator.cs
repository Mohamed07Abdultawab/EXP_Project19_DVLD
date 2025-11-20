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
    public partial class ctlCalculator : UserControl
    {
        // Removed duplicate declaration of the event
        public event Action<int> OnCalculationComplete;

        protected virtual void RaiseCalculationComplete(int PersonID) // Renamed method to avoid conflict
        {
            Action<int> handler = OnCalculationComplete;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public ctlCalculator()
        {
            InitializeComponent();
        }

        private void ctlCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int TheResult = (Convert.ToInt32(txtNumber1.Text) + Convert.ToInt32(txtNumber2.Text));
            result.Text = TheResult.ToString();

            if (OnCalculationComplete != null)
            {
                RaiseCalculationComplete(TheResult);
            }
        }
    }
}
