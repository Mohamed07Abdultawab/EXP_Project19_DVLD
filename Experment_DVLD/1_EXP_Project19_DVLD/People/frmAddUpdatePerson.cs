using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BusinessLayer;

namespace EXP_Project19_DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        clsPerson _Person = new clsPerson();
        int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }

        clsPerson.enMode Mode = clsPerson.enMode.AddNew;


        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _Person = clsPerson.Find(PersonID);

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.Seondname;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtDateOfBirth.Value = _Person.BirthDate;
            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            rtxtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
