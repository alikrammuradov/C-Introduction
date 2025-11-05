using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downcasting__Implicit_Explicit
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        // Implicit operator: Celsius → Kelvin
        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree + 273);
        }
    }
}
