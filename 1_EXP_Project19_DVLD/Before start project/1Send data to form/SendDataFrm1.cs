using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXP_Project19_DVLD
{
    public partial class SendDataFrm1 : Form
    {
        public SendDataFrm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personid = -1;
            if(int.TryParse(textBox1.Text,out personid))
            {
                Form frm = new SendDataFrm2(personid);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Person ID");
                label1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
