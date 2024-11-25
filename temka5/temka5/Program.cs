using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temka5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Привет, мир";
            string str2 = "Привет, ад";
            string str3 = "Привет, поднебесье";

            int compareResult = string.Compare(str1, str3);
            Console.WriteLine($"Сравнение str1 и str3: {compareResult}");

            bool equalsResult = str1.Equals(str2);
            Console.WriteLine($"Равенство str1 и str2: {equalsResult}");

            int compareOrdinalResult = string.CompareOrdinal(str1, str3);
            Console.WriteLine($"Сравнение str1 и str3: {compareOrdinalResult}");

            int index = str1.IndexOf("мир");
            Console.WriteLine($"Индекс подстроки 'мир' в str1: {index}");

            bool containsResult = str1.Contains("Привет");
            Console.WriteLine($"Содержит ли str1 подстроку 'Привет': {containsResult}");

            Console.WriteLine($"str1 == str2: {str1 == str2}");
            Console.WriteLine($"str1 != str3: {str1 != str3}");
        }
    }
}
