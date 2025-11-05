namespace Inheritance__Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new FactorialCalculator();

            Console.Write("Müsbət tam ədəd daxil edin: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Düzgün ədəd daxil edilmədi.");
                return;
            }

            try
            {
                BigInteger fact = calculator.Calculate(n);
                Console.WriteLine($"{n}! = {fact}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Xəta: " + ex.Message);
            }
        }
    }
}