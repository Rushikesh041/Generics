using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxMethod<L> where L : IComparable
    {
        public L[] value;
        public MaxMethod(L[] value)
        {
            this.value = value;
        }
        public L[] Sort(L[] values)
        {
            Array.Sort(values);
            return values;
        }
        public L Largest(params L[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public L Maxmethod()
        {
            var Max = Largest(this.value);
            return Max;
        }
        public void PrintMaxValue()
        {
            var Max = Largest(this.value);
            Console.WriteLine("Largest Value is : " + Max);
        }
    }
}
