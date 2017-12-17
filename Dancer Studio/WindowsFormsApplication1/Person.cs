using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person
    {
       protected string name;
       protected  int id;
       protected BirthData bd;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return GetHashCode(); }

            
        }
        public BirthData Bd
        {

            get { return bd; }
            
        }

        public Person(string name,int id,BirthData bd)
        {
            Name = name;
            if (id < 0)
                throw new Exception("Invalid ID Number, please enter a positive 9-digit integer number");
            
             
            this.id = id;
            this.bd = bd;
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}