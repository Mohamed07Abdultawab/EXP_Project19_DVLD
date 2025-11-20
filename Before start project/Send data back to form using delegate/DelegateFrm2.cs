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
    public partial class DelegateFrm2 : Form
    {
        public delegate void SendDataBack(object sender, string text);
        public event SendDataBack DataBack;

        public DelegateFrm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this,textBox1.Text);

            this.Close();
        }
    }
}
