using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class compare
    {

        public static float Largest(float Num1, float Num2, float Num3)
        {

            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 ||
                Num1.CompareTo(Num2) >= 0 && Num1.CompareTo(Num3) > 0 ||
                Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) >= 0)
            {
                return Num1;
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 ||
                Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 ||
                Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 ||
                Num3.CompareTo(Num1) >= 0 && Num3.CompareTo(Num2) > 0 ||
                Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) >= 0)
            {
                return Num3;
            }
            return Num3;
        }
    }

}


