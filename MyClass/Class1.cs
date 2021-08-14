using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Class1
    {
        public static double GetSqrt(double value)
        {
            return Math.Sqrt(value);
        }

        public string SayHello(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Parameter name cannot be");

            }
            return "Hello" + name;
        }

    }
}
