namespace Inheritance__Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main()
        {
            Console.Write("Müsbət ədəd daxil et: ");
            int n = Convert.ToInt32(Console.ReadLine());

            FactorialCalculator calc = new FactorialCalculator();
            long result = calc.Factorial(n);

            Console.WriteLine($"{n}! = {result}");
        }
    }
}