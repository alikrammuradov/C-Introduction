using System;
using MyExtensions; // Extension methodu işlətmək üçün namespace əlavə olunur

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ededi daxil et: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Qüvveti daxil et: ");
            int power = int.Parse(Console.ReadLine());

            double result = number.Power(power);
            Console.WriteLine($"{number}^{power} = {result}");
        }
    }
}
