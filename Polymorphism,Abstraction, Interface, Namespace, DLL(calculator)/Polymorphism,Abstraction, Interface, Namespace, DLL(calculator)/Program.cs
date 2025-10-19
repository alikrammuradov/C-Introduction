namespace Polymorphism_Abstraction__Interface__Namespace__DLL_calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulyator");

            Console.Write("Birinci ededi daxil et: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emeliyyatı daxil et (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("İkinci ededi daxil et: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            ICalculation calc = new Calculation();  // interface-dən obyekt
            double result = calc.Calculate(num1, num2, op);

            if (!double.IsNaN(result))
                Console.WriteLine($"Netice: {num1} {op} {num2} = {result}");
        }
    }

}
