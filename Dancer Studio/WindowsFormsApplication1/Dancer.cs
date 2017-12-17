using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   
    class Dancer:Person
    {
        static string strid;

        string danceType;
        int performanceNum;
        BirthData bdMom;
        public string DanceType
        {
            get { return danceType; }
            set {danceType=value; }
        }

        public int PerformanceNum
        {
            get { return performanceNum; }
            set
            {
                if (value <= 0)
                    throw new Exception("Number of performances is too small.\r\nPlease enter a valid Number");
                performanceNum=value;
            }
            
        }
        public BirthData BdMom { get { return bdMom; } }

        public Dancer(string danceType, int performanceNum, BirthData bdMom,string name,int id,BirthData bd):base(name,id,bd)
        { 
            DanceType = danceType;
            PerformanceNum=performanceNum;
            this.bdMom = bdMom;

        }
      
        public  string DancerDetails()
        {
            return ToString();
           
        }
        public override string ToString()
        {

            if (id.ToString().Length < 9)
            {
                int count = 9 - id.ToString().Length;
                for (int i = 0; i < count; i++)
                {
                    strid += "0";
                }
            }
           
                string str =
                "Dancer's Name: " + Name +
                "\r\nDancer's ID: " + strid + id + bd.bdata() +
                 "\r\nDancer's dancer type: " + danceType +
                 "\r\nDancer's number of perfomances: " + PerformanceNum +
                  "\r\nDancer's mother's information: " + BdMom.bdata() + "\r\n";

            strid = "";
            return str;
        }
        
    }
}
