using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BirthData
    {
        int year;
        string hospitalName;
        string country;
        
        public int Year
        {
            get
            {
                return year;
            }
        }
    
    
        public string HospitalName
        {
            get
            {
                return hospitalName;
            }
            set
            {
                hospitalName = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public BirthData(int year, string hospitalName, string country)
        {
            if (year < 1900 || year > 2100)
                throw new Exception("Invalid year, please  enter numbers between 1900 and 2100");
            this.year = year;
            HospitalName = hospitalName;
            Country = country;
        }
       
        public string bdata()
        {
            return ToString();
        }
        public override string ToString()
        {
            string str = "\r\nBirth year: " + Year +
                    "\r\nBirth hospital: " + HospitalName +
                    "\r\nBirth country: " + Country;
            return str;
        }
    }


}

