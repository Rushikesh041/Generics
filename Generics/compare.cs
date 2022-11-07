using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class compare
    {

        public static string Largest(string String1, string String2, string String3)
        {

            if (String1.CompareTo(String2) > 0 && String1.CompareTo(String3) > 0 ||
                 String1.CompareTo(String2) >= 0 && String1.CompareTo(String3) > 0 ||
                 String1.CompareTo(String2) > 0 && String1.CompareTo(String3) >= 0)
            {
                return String1;
            }
            if (String2.CompareTo(String1) > 0 && String2.CompareTo(String3) > 0 ||
                String2.CompareTo(String1) >= 0 && String2.CompareTo(String3) > 0 ||
                String2.CompareTo(String1) > 0 && String2.CompareTo(String3) >= 0)
            {
                return String2;
            }
            if (String3.CompareTo(String1) > 0 && String3.CompareTo(String2) > 0 ||
                String3.CompareTo(String1) >= 0 && String3.CompareTo(String2) > 0 ||
                String3.CompareTo(String1) > 0 && String3.CompareTo(String2) >= 0)
            {
                return String3;
            }
            return String1;
        }
    }

}


