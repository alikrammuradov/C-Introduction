using System;

class Program
{
    ////1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.



    //static void Main()
    //{
    //    Console.Write("n ədədini daxil et: ");
    //    int n = Convert.ToInt32(Console.ReadLine());

    //    BolunmeYoxla(n);
    //}

    //static void BolunmeYoxla(int n)
    //{
    //    if (n % 3 == 0 && n % 7 == 0)
    //        Console.WriteLine("n həm 3-ə, həm 7-yə bölünür");
    //    else if (n % 3 == 0)
    //        Console.WriteLine("n yalnız 3-ə bölünür");
    //    else if (n % 7 == 0)
    //        Console.WriteLine("n yalnız 7-yə bölünür");
    //    else
    //        Console.WriteLine("n nə 3-ə, nə də 7-yə bölünmür");
    //}



    ////2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

    //static void Main()
    //{
    //    Console.Write("n ədədini daxil et: ");
    //    int n = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("m ədədini daxil et: ");
    //    int m = Convert.ToInt32(Console.ReadLine());

    //    CutEdedlerinCemi(n, m);
    //}

    //static void CutEdedlərinCemi(int n, int m)
    //{
    //    if (n % 2 == 0 && m % 2 == 0)
    //        Console.WriteLine("n və m ədədlərinin cəmi: " + (n + m));
    //    else
    //        Console.WriteLine("Ədədlər cüt deyil.");
    //}



    ////3) Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapın


    //static void Main()
    //{
    //    Console.Write("ilk olaraq kiçik ədədi daxil edin: ");
    //    int n = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("böyük ədədi daxil edin: ");
    //    int m = Convert.ToInt32(Console.ReadLine());

    //    int sum = TekEdedlerinCemi(n, m);
    //    Console.WriteLine($"{n} və {m} ədədləri arasındakı tək ədədlərin cəmi: " + sum);
    //}

    //static int TekEdedlerinCemi(int n, int m)
    //{
    //    int sum = 0;
    //    for (int i = n + 1; i < m; i++)
    //    {
    //        if (i % 2 != 0)
    //            sum += i;
    //    }
    //    return sum;
    //}



    ////4) Verilmish arrayin icindeki tek ededlerin cemini tapin.

    //static void Main()
    //{
    //    int[] arr = { 7, 11, 27, 31, 62, 69, 72, 90, 7, 13, 21, 45, 67, 88, 99 };

    //    int sum = TekEdedlerinCemi(arr);
    //    Console.WriteLine("Arraydəki tək ədədlərin cəmi: " + sum);
    //}

    //static int TekEdedlerinCemi(int[] array)
    //{
    //    int sum = 0;
    //    foreach (int num in array)
    //    {
    //        if (num % 2 != 0)
    //            sum += num;
    //    }
    //    return sum;
    //}



    ////5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

    //static void Main()
    //{
    //    int[] arr = { 7, 11, 27, 31, 62, 69, 72, 90, 7, 13, 21, 45, 67, 88, 99 };

    //    int count = CutEdedlerinSayi(arr);
    //    Console.WriteLine("Arraydəki cüt ədədlərin sayı: " + count);
    //}

    //static int CutEdedlerinSayi(int[] array)
    //{
    //    int count = 0;
    //    foreach (int num in array)
    //    {
    //        if (num % 2 == 0)
    //            count++;
    //    }
    //    return count;
    //}



    ////6) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

    //static void Main()
    //{
    //    Console.Write("n ədədini daxil et: ");
    //    int n = Convert.ToInt32(Console.ReadLine());

    //    SadeveyaMurekkeb(n);
    //}

    //static void SadeveyaMurekkeb(int n)
    //{
    //    if (n < 2)
    //    {
    //        Console.WriteLine(n + " sadə və ya mürəkkəb deyil");
    //        return;
    //    }
    //    else if (n == 2) 
    //    {
    //        Console.WriteLine(n + " sadədir"); 
    //        return;
    //    }

    //    for (int i = 2; i < n; i++)
    //    {
    //        if (n % i == 0)
    //        {
    //            Console.WriteLine(n + " mürəkkəb ədəddir");
    //            return;
    //        }
    //    }

    //    Console.WriteLine(n + " sadə ədəddir");
    //}
}
