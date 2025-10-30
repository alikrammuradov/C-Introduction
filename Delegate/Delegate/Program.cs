namespace Delegate
{

    delegate bool FilterDelegate(string s);

    internal class Program
    {
        #region
        //    static void Main(string[] args)
        //    {

        //        List<string> names = new List<string> { "Gülarə", "Akşin", "Əlikram" };
        //        StringFilter filter = new StringFilter(names);

        //        FilterDelegate longName = n => n.Length > 5;

        //        List<string> filtered = filter.Filter(longName);

        //        Console.WriteLine("Adı 5 hərfdən uzun olanlar:");
        //        foreach (var name in filtered)
        //            Console.WriteLine(name); // Nəticə: Gülarə, Əlikram
        //    }
        //}
        //class StringFilter
        //{
        //    private List<string> items;

        //    public StringFilter(List<string> items)
        //    {
        //        this.items = items;
        //    }

        //    public List<string> Filter(FilterDelegate filter)
        //    {
        //        List<string> result = new List<string>();
        //        foreach (var item in items)
        //        {
        //            if (filter(item))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //        return result;
        //    }
        //}
        #endregion

        //public delegate bool CheckNums(int num);

        public delegate void Changestring(string str);
        static void Main(string[] args)
        {
            #region stack, queue, dictionary
            //Stack<int> stack = new ();
            //stack.Push(5);
            //stack.Push(25);
            //stack.Push(10);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item );
            //}

            //Queue<int> queue = new();
            //queue.Enqueue(3);
            //queue.Enqueue(44);
            //queue.Enqueue(11);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);

            //}

            //Dictionary<string, string> dictionary = new();

            //dictionary.Add("Address", "Baki");
            //dictionary.Add("Tel", "30");
            //dictionary.Add("Email", "test@gmail.com");

            //Console.WriteLine(dictionary["Address"]);
            #endregion

            //int[] nums = { 2,5,9,2,3,6};
            //Console.WriteLine(CheckAAndSumNum(CheckOdd,nums));
            //Console.WriteLine(CheckAAndSumNum(CheckEven, nums));
            //Console.WriteLine(CheckAAndSumNum(CheckGreaterFive,nums));

            //List<int> list = new () { 1, 2, 3, 9,5};
            //var result = list.Find(m => m == 3);

            //Console.WriteLine(result);
            // Test();

            //StringToUpper("hello world");
            // StringToLower("HELLO WORLD");

            //ChangeStr(StrToUpper, "hello ");

            //ChangeStr(StrToLower, "WORLD");

            //Changestring changestring = new(StrToUpper);
            //changestring .Invoke("Gulare");

            Changestring changestring = StrToLower;
            //changestring+= StrToUpper;
            changestring += delegate (string s)
            {
                Console.WriteLine(s.ToLower());
            };
            changestring("Gulare");

        }

        public static void StrToUpper(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        public static void StrToLower(string text)
        {
            Console.WriteLine(text.ToLower());
        }

        public static void ChangeStr(Changestring match, string word)
        {
            match(word);
        }


        //public static void StringToUpper(string text)
        //{
        //    Console.WriteLine(text.ToUpper());
        //}
        //public static void StringToLower(string text)
        //{
        //    Console.WriteLine(text.ToLower());


        //}

        //public static void Test() => Console.WriteLine("Hello APA101");

        //public static bool CheckOdd(int num)
        //{
        //    return num % 2 != 0;
        //}
        //public static bool CheckEven(int num)
        //{
        //    return num % 2 == 0;
        //}

        //public static bool CheckGreaterFive(int num)
        //{
        //    return num  >5;
        //}


        //public static int CheckAAndSumNum(Predicate<int> func , int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

    }
}