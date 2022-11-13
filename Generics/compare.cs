using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class Compare<L> where L : IComparable
    {
        public L val1, val2, val3, val4;
        public Compare(L val1, L val2, L val3, L val4)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
            this.val4 = val4;

        }
        public static L Largest<L>(L val1, L val2, L val3, L val4) where L : IComparable
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 && val1.CompareTo(val4) > 0 ||
                val1.CompareTo(val2) >= 0 && val1.CompareTo(val3) > 0 && val1.CompareTo(val4) > 0 ||
                val1.CompareTo(val2) > 0 && val1.CompareTo(val3) >= 0 && val1.CompareTo(val4) > 0 ||
                val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 && val1.CompareTo(val4) >= 0)
            {
                return val1;
            }
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 && val2.CompareTo(val4) > 0 ||
                val2.CompareTo(val1) >= 0 && val2.CompareTo(val3) > 0 && val2.CompareTo(val4) > 0 ||
                val2.CompareTo(val1) > 0 && val2.CompareTo(val3) >= 0 && val2.CompareTo(val4) > 0 ||
                val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 && val2.CompareTo(val4) >= 0)
            {
                return val2;
            }
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0 && val3.CompareTo(val4) > 0 ||
                val3.CompareTo(val1) >= 0 && val3.CompareTo(val2) > 0 && val3.CompareTo(val4) > 0 ||
                val3.CompareTo(val1) > 0 && val3.CompareTo(val2) >= 0 && val3.CompareTo(val4) > 0 ||
                val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0 && val3.CompareTo(val4) >= 0)
            {
                return val3;
            }
            if (val4.CompareTo(val1) > 0 && val4.CompareTo(val2) > 0 && val4.CompareTo(val3) > 0 ||
                val4.CompareTo(val1) >= 0 && val4.CompareTo(val2) > 0 && val4.CompareTo(val3) > 0 ||
                val4.CompareTo(val1) > 0 && val4.CompareTo(val2) >= 0 && val4.CompareTo(val3) > 0 ||
                val4.CompareTo(val1) > 0 && val4.CompareTo(val2) > 0 && val4.CompareTo(val3) >= 0)
            {
                return val4;
            }
            return default;
        }
        public L MaxMethod()
        {
            L Max = Compare<L>.Largest(this.val1, this.val2, this.val3, this.val4);
            return Max;
        }

    }
}


