using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class   DancerStudio
    {

        Dancer[] dancerArr;
      
        public Dancer[] DancerArr
        {
            get
            {
                if (dancerArr.Length == 0)
                    throw new Exception("There are no dancers");
                return dancerArr;
            }
            set {; }
        }

        static int position;
        public DancerStudio(int size)
        {

            dancerArr = new Dancer[size];
        }


        public override bool Equals(object dn)
        {
            if (dancerArr.Length != 0)
            {
                for (int i = 0; i < position; i++)
                {
                    int hashcode1 = dancerArr[i].GetHashCode();
                    int hashcode2 = dn.GetHashCode();
                    if (hashcode1 == hashcode2)
                        return true;
                }
                return false;
            }
            return false;

        }

        public void intUpdate(int x)
        {
            position = x;
        }

    }
}