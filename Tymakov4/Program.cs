using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Tymakov_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 4.1-4.2");
            Console.WriteLine("Определить дату");
            DateTime data = Convert.ToDateTime("01.01.2005");
            Console.WriteLine("Введите целое число дней");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 365)
            {
                Console.WriteLine("В невисокосном году не бывает столько дней");
            }
            else
            {
                data = data.AddDays(num - 1);
                Console.WriteLine(data.ToString("d MMMM"));
            }
            Console.WriteLine();


            Console.WriteLine("Дз 4.1");
            Console.WriteLine("Определить високосный год или нет");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 & (year % 100 != 0 | year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для завершения");
            Console.ReadKey();
        }
    }
}
