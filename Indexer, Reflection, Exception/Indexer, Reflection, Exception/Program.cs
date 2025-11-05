namespace Indexer__Reflection__Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginManager login = new LoginManager();

            try
            {
                Console.Write("İstifadəçi adını daxil edin: ");
                string username = Console.ReadLine();

                Console.Write("Şifrəni daxil edin: ");
                string password = Console.ReadLine();

                login.Login(username, password);
            }
            catch (LoginException ex)
            {
                Console.WriteLine($"Xəta: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gözlənilməyən xəta: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Proqram sonlandı.");
            }

            //    //try
            //    //{
            //    //    int[] nums = new int[10];
            //    //    nums[10] = 100;

            //    //    int a = 5;
            //    //    int b = 0;

            //    //    Console.WriteLine(a / b);
            //    //}
            //    //catch (DivideByZeroException ex)
            //    //{
            //    //     Console.WriteLine(ex.Message);
            //    //}
            //    //catch(IndexOutOfRangeException ex)
            //    //{
            //    //    Console.WriteLine(ex.Message); ;
            //    //}
            //    //finally
            //    //{
            //    //    Console.WriteLine("Duzelis et");
            //    //}

            //    try
            //    {

            //        //int a = 7;
            //        //int c = 0;
            //        //if (c == 0)
            //        //{
            //        //    throw new DividedException("0-a bolunme yoxdur!");
            //        //}
            //        //else 
            //        //{
            //        //    Console.WriteLine(a / c);
            //        //}
            //        List<string> names = new() { "ilkin", "Muhamed", "Aysel" };
            //        var result = FindName(names, "Aysel");

            //        if (result)
            //        {
            //            Console.WriteLine("tapildi");
            //        }
            //        else
            //        {
            //            throw new NotFoundedException("hele de axtarilir");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}
            //public static bool FindName(List<string> names, string searchName)
            //{
            //    if (names.Contains(searchName))
            //    {
            //        return true;
            //    }


            //    return false;

        }
    }
}
