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
using EXP_Project19_DVLD.Properties;

namespace EXP_Project19_DVLD.People
{
    public partial class frmAddUpdatePersone : Form
    {

        public delegate void SendDataBack(object sender, int PersonID);
        public event SendDataBack DataBack;

        public enum enMode { AddNew,Update};
        public enum enGendor { Male,Female};

        private enMode _Mode;


        clsPerson _Person = new clsPerson();
        private int _PersonID;

        public frmAddUpdatePersone()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePersone(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void ResetDefualtValues()
        {

            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked)
            {
                pbProfile.Image = Resources.Male_512;
            }
            else
            {
                pbProfile.Image = Resources.
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID= " + _PersonID , "Person Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblTitle.Text = "Update Person";
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            dtDateOfBirth.Value = _Person.BirthDate;
            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            txtAddress.Text = _Person.Address;
            if(!string.IsNullOrEmpty(_Person.ImagePath))
                pbProfile.ImageLocation = _Person.ImagePath;

            llRemoveImage.Visible = (_Person.ImagePath != "");//show it if there is an image
        }

        private void frmAddUpdatePersone_Load(object sender, EventArgs e)
        {


            if(_Mode == enMode.Update)
                _LoadData();
        }
    }
}
