using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1. Написать программу, которая читает с экрана число от 1 до 365, переводит этот число в месяц и день месяца.");
            Console.WriteLine("Введите число от 1 до 365.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 365)
            {
                Console.WriteLine("Ошибка.Введено некоректное число.");
            }
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthsname = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            int daysofmonths = 0;
            foreach (int daysincurrentmonth in days)
            {
                if (number <= daysincurrentmonth)
                {
                    daysofmonths = number;
                    break;
                }
                else
                {
                    number -= daysincurrentmonth;
                    month++;
                }
            }
            Console.WriteLine($"Дата: {daysofmonths} {monthsname[month]}");
            Console.WriteLine("Упражнение 4.2. Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать исключение, и выдавать на экран сообщение.");
            {
                try
                {
                    Console.WriteLine("Введите число от 1 до 365.");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    if (number1 < 1 || number1 > 365)
                    {
                        throw new Exception("Ошибка.Введено некоректное число.");
                    }
                    int[] days1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    string[] monthsName = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                    int months = 0;
                    int dayofmonths = 0;
                    foreach (int daysincurrentmonth in days1)
                    {
                        if (number1 <= daysincurrentmonth)
                        {
                            dayofmonths = number1;
                            break;
                        }
                        else
                        {
                            number1 -= daysincurrentmonth;
                            month++;
                        }
                        Console.WriteLine($"Дата: {dayofmonths} {monthsname[months]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Домашнее задание 4.1. Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год (високосный или нет).");
            try
            {
                Console.WriteLine("Введите число от 1 до 365.");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number2 < 1 || number2 > 365)
                {
                    throw new Exception("Ошибка.Введено некоректное значение.");
                }
                Console.WriteLine("Введите год.");
                int year = Convert.ToInt32(Console.ReadLine());
                bool year2 = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                int[] daysinmonth = year2? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int month3 = 0;
                int day = 0;
                for (int i = 0; i < daysinmonth.Length; i++)
                {
                    if (number2 <= daysinmonth[i])
                    {
                        month3 = i + 1;
                        day = number2;
                        break;
                    }
                    else
                    {
                        number2 -= daysinmonth[i];
                    }
                }
                Console.WriteLine($"Дата: {day}.{month3}.{year}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }   
    }
}
