using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction__Interface__Namespace__DLL_calculator_
{
    class Calculation : ICalculation
    {
        public double Calculate(double num1, double num2, char operation)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Sıfıra bölme xetası!");
                        return double.NaN;
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun olmayan hesablama !");
                    return double.NaN;
            }

            return result;
        }
    }
}
