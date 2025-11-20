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
    public partial class Form2 : Form
    {
        private int _PersoneID;
        public Form2(int personid)
        {
            InitializeComponent();
            _PersoneID = personid;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = _PersoneID.ToString();
        }
    }
}
