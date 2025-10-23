using Upcasting_Params_Enum_Struct_Nullable.Models;

namespace Upcasting_Params_Enum_Struct_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //    int input=Convert.ToInt32(Console.ReadLine());  

            //    switch (input)
            //        {
            //        case (int)Roles.Member:
            //            Console.WriteLine("Member");
            //            break;
            //            case(int) Roles.Admin:
            //                Console.WriteLine("Admin");
            //            break;
            //            case (int)Roles.SuperAdmin:
            //                Console.WriteLine("SuperAdmin");
            //            break;

            //        default:
            //            Console.WriteLine("Unknown role");
            //            break;
            //    }
            //}
            #endregion
            #region Enum
            //enum Roles
            //{
            //    Member = 1,
            //    Admin ,
            //    SuperAdmin

            #endregion


            #region Params

            //int[] arrays = { 1, 2, 3, 4, 5 };

            //GetNumber( "SALAM ", 2, 3, 4);
            #endregion

            #region Nullable 
            //int ? a = 100;
            //int b = a == null ? 50 : 10;
            //int c = a ?? 50;

            //Console.WriteLine(c);

            //a=1;
            //console.WriteLine(a++);

            //Test test = new();
            //console.WriteLine(test.Age);
            #endregion
            #region Struct
            //Test test = new();
            //Console.WriteLine(test.Id);
            #endregion

            // byte a = 5;
            // int b = a;
            Eagle eagle1 = new Eagle();
            Animal eagle2 = eagle1;
            eagle2.Eat();

        }


        #region Params
        //static void GetNumber( string word ,params int[] numbers)
        //{
        //    foreach (var item in numbers )
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Nullable
        //public class Test()
        //{
        //    public int? Age { get; set; }
        #endregion


        #region Struct
        //struct Test : ITest
        //{
        //    public int Id { get; set; }

        //    Test(string name)
        //    {
        //        Id = 50;
        //    }
        //}
        //class Test2
        //{

        //}
        //interface ITest
        //{

        //}
        #endregion


        //    Console.Write("1-7 arası bir rəqəm daxil et: ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    switch (num)
        //    {
        //        case (int)WeekDays.Monday:
        //            Console.WriteLine("Monday");
        //            break;
        //        case (int)WeekDays.Tuesday:
        //            Console.WriteLine("Tuesday");
        //            break;
        //        case (int)WeekDays.Wednesday:
        //            Console.WriteLine("Wednesday");
        //            break;
        //        case (int)WeekDays.Thursday:
        //            Console.WriteLine("Thursday");
        //            break;
        //        case (int)WeekDays.Friday:
        //            Console.WriteLine("Friday");
        //            break;
        //        case (int)WeekDays.Saturday:
        //            Console.WriteLine("Saturday");
        //            break;
        //        case (int)WeekDays.Sunday:
        //            Console.WriteLine("Sunday");
        //            break;
        //        default:
        //            Console.WriteLine("Yanlış dəyər daxil etmisən.");
        //            break;
        //    }
        //}
        //enum WeekDays
        //{
        //    Monday = 1,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}

        //Console.Write("Rəngi daxil et (Red, Yellow, Green): ");
        //string input = Console.ReadLine();

        //if (Enum.TryParse(input, true, out TrafficLight light))
        //{
        //    switch (light)
        //    {
        //        case TrafficLight.Red:
        //            Console.WriteLine("stop");
        //            break;

        //        case TrafficLight.Yellow:
        //            Console.WriteLine("wait");
        //            break;

        //        case TrafficLight.Green:
        //            Console.WriteLine("go");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Belə rəng yoxdur.");
        //}
    }
    //enum TrafficLight
    //{
    //    Red,
    //    Yellow,
    //    Green
    //}

}
