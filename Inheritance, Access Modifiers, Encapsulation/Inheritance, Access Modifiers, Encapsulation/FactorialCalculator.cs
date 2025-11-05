using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_Modifiers__Encapsulation
{
    // Faktorial hesablayan sinif
    public class FactorialCalculator
    {
        // Public method: müsbət tam ədəd (n >= 0) qəbul edir və BigInteger qaytarır
        public BigInteger Calculate(int n)
        {
            if (n < 0)
                throw new ArgumentException("Eded menfidir. Faktorial ancaq 0 ve ya musbet eded ucun hesablanir.", nameof(n));

            BigInteger result = BigInteger.One;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}