namespace Polymorphism_Abstraction__Interface__Namespace__DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new();
            //dog.Sound();
            //dog.Eat();

            //Bird bird = new();
            //bird.Sound();
            //bird.Eat();

            //Test test = new();
            //test.name = "Test Animal";

            Account account = new Account();

            account.Register("Alex", "alex", "1235678");

            account.Login("alex", "1235678"); 

            //if(result)
            //{
            //    Console.WriteLine("Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}
        }
    }
}
