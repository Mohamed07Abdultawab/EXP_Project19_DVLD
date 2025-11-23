using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountry = clsCountry.GetAllCountries();
            foreach(DataRow row in dtCountry.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
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
                pbProfile.Image = Resources.Female_512;
            }
            llRemoveImage.Visible = (pbProfile.ImageLocation != "");//show it if there is an image

            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtDateOfBirth.Value = dtDateOfBirth.MaxDate;

            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

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
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbProfile.ImageLocation == null)
                pbProfile.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbProfile.ImageLocation == null)
                pbProfile.Image = Resources.Female_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required.");
            }
            else
                errorProvider1.SetError(textBox, "");
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required.");
                return;
            }
            errorProvider1.SetError(txtNationalNo, "");

            //make sure national no is unique
            if(txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPerosonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This National No is already exist.");
            }
            else
                errorProvider1.SetError(txtNationalNo, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                    errorProvider1.SetError(txtEmail, "");
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "Invalid Email Address.");
                }
            }
            errorProvider1.SetError(txtEmail, "");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over thr red icon(s) to see error","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //handlePersonImage

            //clsCountry country = clsCountry.Find(cbCountry.Text);
            //int NationalityCountryID = country.CountryID;
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.Seondname = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.BirthDate = dtDateOfBirth.Value;

            if (rbMale.Checked)
            {
                _Person.Gendor = (short)enGendor.Male;
            }
            else
                _Person.Gendor = (short)enGendor.Female;

            _Person.NationalityCountryID = NationalityCountryID;

            if (pbProfile.ImageLocation != null)
                _Person.ImagePath = pbProfile.ImageLocation;
            else
                _Person.ImagePath = "";

            if(_Person.Save())
            {
                //after click save botton weill show up the personID
                lblPersonID.Text = _Person.PersonID.ToString();

                //changing mode to update
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);


                //trigger the even to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error, Data is not saved successfully.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Load(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
            }
        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProfile.ImageLocation = null;

            if (rbMale.Checked)
                pbProfile.Image = Resources.Male_512;
            else
                pbProfile.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }


        //handlePersonImage in next time
        private bool _HandlePersonImage()
        {
            return true;
        }
    }
}
