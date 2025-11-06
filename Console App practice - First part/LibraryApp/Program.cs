using Domain.Models;
using Service;
using Service.Services;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecet Option");
           Helper.WriteConsole(ConsoleColor.Cyan,"Library: 1-Create, 2-Update,3-Get, 4-GetAll, 5- Delete");
  LibraryService libraryService = new LibraryService();
           while(true)
            {
            Input: string input = Console.ReadLine();
                int number;

                bool isConvert=int.TryParse(input, out number);
                if (isConvert)
                {
                  
                  switch (number)
                    {
                        case 1:
                            Console.WriteLine ("Name:");
                                string name = Console.ReadLine();

                            Console.WriteLine("Seat count") ;
                            int seatCount=Convert.ToInt32(Console.ReadLine());

                            Library library = new()
                            {
                                Name = name,
                                SeatCount = seatCount
                            };
                            var newLibrary =libraryService.Create(library);
                            Helper.WriteConsole(ConsoleColor.Green,$" iD:{newLibrary.Id},Name:{newLibrary.Name},SeatCount:{newLibrary.SeatCount} ,Date:{newLibrary.CreatedDate}");
                            break;
                        case 2:
                            Console.WriteLine ("Update");
                            break;
                        case 3:
                            Console.WriteLine ("Get");
                            break;
                        case 4:
                            Console.WriteLine ("GetAll");
                            break;
                        case 5:
                            Console.WriteLine ("Delete");
                            break;
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select option is not correct");
                            break;
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Input type is not correct");
                    goto Input;
                }
                }
            }
        }
}
