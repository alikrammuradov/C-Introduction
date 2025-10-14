using System.Globalization;
using System.Text.RegularExpressions;

namespace Out__String__StringBuilder
{
    internal class Program
    {

        ////1)  Sətirdəki sözlərin ilk hərfini böyük, qalanlarını kiçik et. (Məsələn: "hello world" => "Hello World") 


        //static void Main()
        //{
        //    Console.Write("Mətni daxil et: ");
        //    string metn = Console.ReadLine();

        //    string sonmetn = ConvertTitleCase(metn);
        //    Console.WriteLine("Nəticə: " + sonmetn);
        //}

        //static string ConvertTitleCase(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return input;

        //    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        //    return textInfo.ToTitleCase(input.ToLower());
        //}



        ////2) Verilmiş sətirdən bütün xüsusi simvolları sil(yalnız hərf və rəqəmlər qalsın). (Məsələn: "Hello@2025!" => "Hello2025") 
        

        //static void Main()
        //{
        //    Console.Write("Mətni daxil et: ");
        //    string metn = Console.ReadLine();

        //    string netice = SimvollariSil(metn);
        //    Console.WriteLine("Nəticə: " + netice);
        //}

        //static string SimvollariSil(string input)
        //{
        //    return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        //}



        ////3) Sətir “.com” ilə bitib-bitmədiyini yoxla.
        

        //static void Main()
        //{
        //    Console.Write("Mətni daxil et: ");
        //    string metn = Console.ReadLine();

        //    bool netice = ComIleBitir(metn);
        //    Console.WriteLine(netice);
        //}

        //static bool ComIleBitir(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return false;

        //    return input.EndsWith(".com", StringComparison.OrdinalIgnoreCase);
        //}
    }

}