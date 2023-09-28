using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_2_3_4_5
{
    internal class Program
    {
        enum dayofweek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.Определить, является ли последовательность из 10 чисел упорядоченной по возрастанию. В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность.");
            Console.WriteLine("Дана последовательность из 10 чисел: 1, 4, 5, 7, 8, 11, 14, 19, 25, 2");
            int[] sequence = new int[10] { 1, 4, 5, 7, 8, 11, 14, 19, 25, 2 };
            int index = -1;//порядковый номер числа,нарушевшего последовательность по возростанию
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    index = i + 1;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Последовательность из 10 чисел упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность из 10 чисел упорядочена не по возрастанию, она прерывается на индексе {index}");
            }
            Console.WriteLine("Задание 2.Написать программу, которая по заданному номеру карты k (6 <=k <= 14) определяет достоинство соответствующей карты.");
            Console.WriteLine("Введите номер карты от 6 до 14:");
            int k;
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                if ( k <= 6 && k >= 14)
                {
                    throw new Exception("Ошибка.Введено некоректное значение.");
                }    
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string card;
            switch (k)
            {
                case 6:
                card = "шестерка";
                break;
                case 7:
                card = "семерка";
                break;
                case 8:
                card = "восьмерка";
                break;
                case 9:
                card = "девятка";
                break;
                case 10:
                card = "десятка";
                break;
                case 11:
                card = "валет";
                break;
                case 12:
                card = "дама";
                break;
                case 13:
                card = "король";
                break;
                case 14:
                card = "туз";
                break;
                default:
                card = k.ToString();
                break;
            }
            Console.WriteLine($"Достоинство карты - {card} с порядковым номером - {k}.");
            Console.WriteLine("Задание 4.Составить программу, которая в зависимости от порядкового номера дня недели выводит на экран его название.");
            Console.WriteLine("Введите порядковый номер дня недели от 1 до 7:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Некорректный порядковый номер дня недели.");
                return;
            }
            DayOfWeek dayofweek = (DayOfWeek)number;
            Console.WriteLine($"День недели: {dayofweek}");
            Console.WriteLine("Задание 5.Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента Hello Kitty или Barbie doll необходимо положить их в “сумку”, т.е. прибавить к результату. Вывести на экран сколько кукол в “сумке”.");
            string[] toys = { "Hello Kitty", "Barbie doll", "Toy car", "Ball", "Plush hare", "Hello Kitty" };
            int count = 0;
            foreach (string toy in toys)
            {
            if (toy == "Hello Kitty" || toy == "Barbie doll")
            {
            count += 1;
            }
            }
            Console.WriteLine($"Количество кукол в сумке: {count}");
            Console.WriteLine("Задание 3.Написать программу, которая принимает на входе строку и производит выходные данные в соответствии с таблицей.");
            {
                Console.WriteLine("Введите строку:");
                string input = Console.ReadLine();
                string output = GetOutput(input);
                Console.WriteLine(output);
            }
            string GetOutput(string input)
            {
                switch (input)
                {
                    case "Jabroni":
                        return "Patron Tequila";
                    case "School Counsler":
                        return "Anything with Alcohol";
                    case "Programmer":
                        return "Hipster Craft Beer";
                    case "Bike Gang Member":
                        return "Moonshine";
                    case "Politician":
                        return "Your tax dollars";
                    case "Rapper":
                        return "Cristal";
                    default:
                        return "Beer";
                }
            }
            Console.ReadKey();
        }
    }
}
