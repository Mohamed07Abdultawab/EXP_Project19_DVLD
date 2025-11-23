using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _3_DataAccessLayer;

namespace _2_BusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
        }

        public clsCountry(int id, string name)
        {
            this.CountryID = id;
            this.CountryName = name;
        }

        public static clsCountry Find(int ID)
        {
            string countryName = string.Empty;
            if (clsCountryData.GetCountryInfoByID(ID, ref countryName))
                return new clsCountry(ID, countryName);
            else 
                return null;
        }

        public static clsCountry Find(string countryName)
        {
            int ID  = -1;
            if (clsCountryData.GetCountryInfoByName(countryName, ref ID))
                return new clsCountry(ID, countryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
