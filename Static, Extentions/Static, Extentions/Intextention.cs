using System;

namespace MyExtensions
{
    public static class IntExtensions
    {
        public static double Power(this int number, int exponent)
        {
            if (exponent == 0)
                return 1;

            double result = 1;
            double baseValue = number;
            int absExponent = Math.Abs(exponent);

            for (int i = 0; i < absExponent; i++)
            {
                result *= baseValue;
            }

            if (exponent < 0)
            {
                if (number == 0)
                    throw new DivideByZeroException("0 mənfi qüvvətə qaldırıla bilməz.");
                result = 1 / result;
            }

            return result;
        }
    }
}
