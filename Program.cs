using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveAndExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            //Recursive
            for(int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            //Extension
            string ifade = "Zikriye Ürkmez Cengiz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());   
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
        }
    }
    public static class Islemler
    {
        public static int Expo(int sayi,int us)
        {
            if(us<2)
                return 1;
            return Expo(sayi,us-1)*sayi;

        }
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');   
            return string.Join("", dizi);  
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
    }
}
