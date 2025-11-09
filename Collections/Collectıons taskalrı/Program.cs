using System.Collections;

namespace Collectıons_taskalrı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region List
            //List<int> nums = new();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            // for (int i = 0; i < nums.Count; i++)
            //{                
            //    Console.WriteLine(nums[i]); 
            //}
            // List <string> names = new();
            //names.Add("Lala");
            //names.Add("Gulare");
            //names.Add("Ninya");

            //foreach (var item in names)
            //{
            //    Console.WriteLine("Name: {0} ", item);
            //}
            //List<Person> people = new();

            //Person person1 = new Person();
            //person1.Id = 1;
            //person1.Name = "Lala";
            //person1.Surname = "Aliyeva";
            //person1.Email = "lala@gmail.com";

            //Person person2 = new()
            //{
            //    Id = 2,
            //    Name = "Gulare",
            //    Surname = "Abasova",
            //    Email = "gulere@gmail.com"
            //};
            //Console.WriteLine(person2.Id);

            //people.Add(new Person { Id = 1, Name = "Lala", Surname = "Aliyeva", Email = "lalaaliyev23@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Gulare", Surname = "Abasova", Email = "gularabasova43@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Ninya", Surname = "Huseynli", Email = "ninyahuseynli53@gmail.com" });


            //foreach (var item in people)
            //{
            //    Console.WriteLine("Id: {0}, Name: {1}, Surname: {2}, Email: {3}", item.Id, item.Name, item.Surname, item.Email);
            //}


            // GetAllPersons(people);

            //Person person = GetPersonByName(people, "Gulare");
            // Console.WriteLine(person.Name);
            #endregion


            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Lala");
            //hashtable.Add(2, "Gulare");
            //hashtable.Add(3, "Ninya");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"Key :{item.Key} , Value :{item.Value}");
            //}

            //SortedList sortedList = new ();

            //sortedList.Add("Superadmin", "Lala");
            //sortedList.Add("Admin", "Gulare");
            //sortedList.Add("Member", "Ninya");
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine($"Key :{item.Key} , Value :{item.Value}");
            //}


            //SortedList<int, string> sortedList = new();
            //sortedList.Add(1, "Ninya");
            //sortedList.Add(2, "Gulare");
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine($"Key :{item.Key} , Value :{item.Value}");
            //}

            //HashSet<string> hashSet = new ();
            //hashSet.Add("Gulare");
            //hashSet.Add("Gulare");
            //hashSet.Add("Ninya");
            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item.Length);
            //}
        }

        #region List
        //public static void GetAllPersons(List<Person> students)
        //{
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine("Id: {0}, Name: {1}, Surname: {2}, Email: {3}", item.Id, item.Name, item.Surname, item.Email);
        //    }
        //}


        //public static  Person GetPersonByName(List<Person> teachers, string name)
        //{
        //    Person person = teachers.Find(m => m.Name == name);

        //    return person;
        //}
        #endregion
    }
}

