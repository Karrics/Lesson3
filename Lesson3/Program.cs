using System;
using System.Collections.Generic;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 1");
            Console.WriteLine("Работа с последовательностью");
            List<int> numb = new List<int>(); ;
            int i = 1;
            int j = 0;
            try
            {
                while (i <= 10)
                {
                    Console.WriteLine("Введите число под номером " + i);
                    numb.Add(Convert.ToInt32(Console.ReadLine()));
                    i++;
                }
                if (numb[0] < numb[1])
                {
                    if (numb[1] < numb[2])
                    {
                        if (numb[2] < numb[3])
                        {
                            if (numb[3] < numb[4])
                            {
                                if (numb[4] < numb[5])
                                {
                                    if (numb[5] < numb[6])
                                    {
                                        if (numb[6] < numb[7])
                                        {
                                            if (numb[7] < numb[8])
                                            {
                                                if (numb[8] < numb[9])
                                                {
                                                    Console.WriteLine("Последовательность возврастающая");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Возврастают только первые 9 чисел");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Возврастают только первые 8 чисел");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Возврастают только первые 7 чисел");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Возврастают только первые 6 чисел");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Возврастают только первые 5 чисел");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Возврастают только первые 4 числа");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Возврастают только первые 3 числа");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Возврастают только первые 2 числа");
                    }
                }
                else
                {
                    Console.WriteLine("Первое число не меньше второго");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 2");
            Console.WriteLine("Определить достоинство карты");
            Console.WriteLine("Введите число от 6 до 14");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Достоинство карты: ");
                switch (a)
                {
                    case 6: Console.WriteLine("6"); break;
                    case 7: Console.WriteLine("7"); break;
                    case 8: Console.WriteLine("8"); break;
                    case 9: Console.WriteLine("9"); break;
                    case 10: Console.WriteLine("10"); break;
                    case 11: Console.WriteLine("Jack"); break;
                    case 12: Console.WriteLine("Queen"); break;
                    case 13: Console.WriteLine("King"); break;
                    case 14: Console.WriteLine("Ace"); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку\n");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 3");
            Console.WriteLine("Работа с таблицей");
            string word = Console.ReadLine();
            switch (word)
            {
                case "Jabroni":
                    Console.WriteLine("Patrol Tequila"); break;
                case "School Counselor":
                    Console.WriteLine("Anything with Alcohol"); break;
                case "Programmer":
                    Console.WriteLine("Hipster Craft Beer"); break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine"); break;
                case "Politican":
                    Console.WriteLine("Your tax dollar"); break;
                case "Rapper":
                    Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;

            }
            Console.WriteLine();


            Console.WriteLine("Упр 4");
            Console.WriteLine("Вывести название дня недели по порядку");
            Console.WriteLine("Введите номер дня недели");
            try
            {
                int day = Convert.ToInt32(Console.ReadLine());
                if (0 < day & day < 8)
                {
                    Console.WriteLine((Weak)day);
                }
                else
                {
                    Console.WriteLine("Нет дня с таким порядковым номером");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 5");
            Console.WriteLine("Проверить весь массив строк");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для завершения");
            Console.ReadKey();
        }
        enum Weak
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            saturday = 6,
            Sunday = 7
        }
    }
}
