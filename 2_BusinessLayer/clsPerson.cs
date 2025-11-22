using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using _3_DataAccessLayer;

namespace _2_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string Seondname { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + Seondname + " " + ThirdName + " " + LastName;
            }
        }
        public string NationalNo { get; set; }
        public DateTime BirthDate { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }


        public clsPerson()
        {
            PersonID = 0;
            FirstName = string.Empty;
            Seondname = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            NationalNo = string.Empty;
            BirthDate = DateTime.Now;
            Gendor = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = 0;
            ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }

        public clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.Seondname = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.BirthDate = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.Seondname, this.ThirdName,
                this.LastName, this.NationalNo, this.BirthDate, this.Gendor,
                 this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

            return this.PersonID > 0;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.Seondname, this.ThirdName,
                this.LastName, this.NationalNo, this.BirthDate, this.Gendor,
                 this.Address, this.Phone, this.Email,  
                this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool found = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref NationalNo, ref DateOfBirth, ref Gendor,
                 ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);
            if (found)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;
            short Gendor = 0;

            bool found = clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gendor,
                 ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);

            if(found)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())//if added successfully is not -1
                    {
                        Mode = enMode.Update;//change mode to update
                        return true;
                    }
                    else
                        return false;//can't add
                case enMode.Update:
                    return _UpdatePerson();//if updated successfully return true else false
            }
            return false;
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPersonData.IsPersonExist(ID);
        }

        public static bool isPerosonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

    }
}
