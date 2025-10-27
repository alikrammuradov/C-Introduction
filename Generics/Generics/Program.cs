namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region implicit , explicit
            // Manat manat = new(1);

            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Generic 
            //StringList stringList = new();
            //stringList.Add("Alex");
            //stringList.Add("Muradov");
            //stringList.GetAll();
            //IntList intList = new();
            //intList.Add(5);
            //intList.Add(10);
            //intList.GetAll();

            //BookList bookList = new();
            //Book book1 = new() 
            //{ 
            //    Id=1,
            //    Name = "1984", 
            //    Author = " George Orwell"
            //};
            //Book book2 = new()
            //{
            //    Id=2,
            //    Name = "To Kill a Mockingbird",
            //    Author = "Harper Lee"
            //};
            //Book book3 = new()
            //{
            //    Id = 3,
            //    Name = "The Great Gatsby",
            //    Author = "F. Scott Fitzgerald"
            //};
            //Book book4 = new()
            //{
            //    Id=4,
            //    Name = "Pride and Prejudice",
            //    Author = "Jane Austen"
            //};

            //BookList bookList1 = new();

            //bookList.Add(book1);
            //bookList.Add(book2);
            //bookList.Add(book3);
            //bookList.Add(book4);

            //bookList.GetAll();

            //Book findItem =bookList.GetById(2);

            //Console.WriteLine(findItem.Name);
            //DataList <string> stringList = new ();
            //stringList.Add("Hello");
            //stringList.Add("World");
            //stringList.GetAll();

            //DataList<int> intList = new();
            //intList.Add(10);
            //intList.Add(20);
            // intList.GetAll();

            //DataList<Book> bookList = new();
            //bookList.Add(new Book { Id = 1, Name = "1984", Author = "George Orwell" });
            //bookList.Add(new Book { Id = 2, Name = "To Kill a Mockingbird", Author = "Harper Lee" });
            //bookList.GetAll();
            #endregion
            Employee employee = new(5);
            Student student = new(20);
            if (employee > student)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
        #region Generic
        public class DataList<T> where T : BookList
        {
            private T[] datas;
            public DataList()
            {
                datas = [];
            }
            public void Add(T item)
            {
                Array.Resize(ref datas, datas.Length + 1);
                datas[datas.Length - 1] = item;
            }
            public void GetAll()
            {
                foreach (var item in datas)
                {
                    if (item is Book book)
                    {
                        Console.WriteLine(book.Name + book.Author);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        #region implicit , explicit
        //public class Dollar
        //{
        //    public double Usd { get; set; }

        //    public Dollar(double usd)
        //    {
        //        Usd = usd;
        //    }
        //}

        //public class Manat
        //{
        //    public double Azn { get; set; }
        //    public Manat(double azn)
        //    {
        //        Azn = azn;
        //    }
        //    public static explicit operator Dollar(Manat manat)
        //    {
        //        return new Dollar(manat.Azn * 1.7);
        //    }
        //}
        #endregion

        public class StringList

        {
            private string[] arr;
            public StringList()
            {
                arr = new string[0];
            }
            public void Add(string item)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = item;
            }
            public void GetAll()
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public class IntList
        {
            private int[] arr;
            public IntList()
            {
                arr = new int[0];


            }
            public void Add(int item)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = item;
            }
            public void GetAll()
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
    public class Book : BookList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }


    }
    public class BookList
    {
        private Book[] arr;
        public BookList()
        {
            arr = [];
        }
        public void Add(Book item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name + item.Author);
            }
        }
        public Book GetById(int id)
        {
            foreach (var item in arr)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
    #endregion
    public class Employee
    {
        public int Count { get; set; }

        public Employee(int count)
        {
            Count = count;
        }

        public static bool operator >(Employee emp, Student stu)
        {
            return emp.Count > stu.Count;
        }
        public static bool operator <(Employee emp, Student stu)
        {
            return emp.Count < stu.Count;
        }
    }
    public class Student
    {
        public int Count { get; set; }
        public Student(int count)
        {
            Count = count;
        }
    }
}