using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXP_Project19_DVLD.Send_data_back_to_form_using_delegate
{
    public partial class DelegateFrm1 : Form
    {
        public DelegateFrm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelegateFrm2 frm = new DelegateFrm2();
            frm.DataBack += frm_databack;
            frm.ShowDialog();
        }

        private void frm_databack(object sender,string text)
        {
            textBox1.Text = text;
        }
    }
}
