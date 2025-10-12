using System;

namespace TasksProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==============================
            // 1) Verilmiş n ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
            // ==============================

            Console.WriteLine("1) Verilmiş n ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın:");
            Console.Write("n ədədini daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 7 == 0)
                Console.WriteLine($"{n} həm 3-ə, həm də 7-ə bölünür.");
            else if (n % 3 == 0)
                Console.WriteLine($"{n} yalnız 3-ə bölünür.");
            else if (n % 7 == 0)
                Console.WriteLine($"{n} yalnız 7-ə bölünür.");
            else
                Console.WriteLine($"{n} nə 3-ə, nə də 7-ə bölünür.");

            Console.WriteLine("\n---------------------------------\n");


            // ==============================
            // 2) n və m ədədləri verilir. Əgər hər ikisi cütdürsə, n və m ədədlərinin cəmini hesablayın.
            // ==============================

            Console.WriteLine("2) n və m ədədləri verilir. Hər ikisi cütdürsə cəmini tapın:");
            Console.Write("n ədədini daxil edin: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("m ədədini daxil edin: ");
            int m2 = int.Parse(Console.ReadLine());

            if (n2 % 2 == 0 && m2 % 2 == 0)
            {
                int cem = n2 + m2;
                Console.WriteLine($"Hər iki ədəd cütdür. Cəmi = {cem}");
            }
            else
            {
                Console.WriteLine("Ən azı biri tək ədəddir, cəm hesablanmadı.");
            }

            Console.WriteLine("\n---------------------------------\n");


            // ==============================
            // 3) Verilmiş n və m (n < m) ədədləri arasındakı tək ədədlərin cəmini tapın.
            // ==============================

            Console.WriteLine("3) Verilmiş n və m (n < m) ədədləri arasındakı tək ədədlərin cəmini tapın:");
            Console.Write("n ədədini daxil edin: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("m ədədini daxil edin: ");
            int m3 = int.Parse(Console.ReadLine());

            int tekCem = 0;

            for (int i = n3; i <= m3; i++)
            {
                if (i % 2 != 0)
                    tekCem += i;
            }

            Console.WriteLine($"{n3} ilə {m3} arasındakı tək ədədlərin cəmi: {tekCem}");

            Console.WriteLine("\n---------------------------------\n");


            // ==============================
            // 4) Verilmiş array-in içindəki tək ədədlərin cəmini tapın.
            // ==============================

            Console.WriteLine("4) Verilmiş arrayin içindəki tək ədədlərin cəmini tapın:");

            int[] arr = { 5, 8, 11, 14, 17, 20 };
            int tekSum = 0;

            foreach (int num in arr)
            {
                if (num % 2 != 0)
                    tekSum += num;
            }

            Console.WriteLine("Array: {5, 8, 11, 14, 17, 20}");
            Console.WriteLine($"Tək ədədlərin cəmi: {tekSum}");

            Console.WriteLine("\n---------------------------------\n");


            // ==============================
            // 5) Verilmiş arrayin içindəki cüt ədədlərin sayını tapın.
            // ==============================

            Console.WriteLine("5) Verilmiş arrayin içindəki cüt ədədlərin sayını tapın:");

            int[] arr2 = { 3, 6, 9, 12, 15, 18 };
            int cutSay = 0;

            foreach (int num in arr2)
            {
                if (num % 2 == 0)
                    cutSay++;
            }

            Console.WriteLine("Array: {3, 6, 9, 12, 15, 18}");
            Console.WriteLine($"Cüt ədədlərin sayı: {cutSay}");

            Console.WriteLine("\nBütün tapşırıqlar yerinə yetirildi ✅");
        }
    }
}