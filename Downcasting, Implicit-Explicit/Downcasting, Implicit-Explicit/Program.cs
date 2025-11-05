namespace Downcasting__Implicit_Explicit
{
    class Program
    {
        static void Main()
        {
            Celsius c = new Celsius(25);  // 25°C
            Kelvin k = c;  // avtomatik çevrilir (implicit)

            Console.WriteLine($"{c.Degree}°C = {k.Degree}K");
        }
    }
}
