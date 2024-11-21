using System;


namespace Homework_lesson3
{
    internal class Program
    {

        /// <summary>
        /// Проверка на високосный год
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 || year % 400 == 0) && year % 100 != 0;
        }


        /// <summary>
        /// Первое задание из Тумакова
        /// </summary> 
        //Написать программу, которая читает с экрана число от 1 до 365 (номер дня
        //в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
        //февраля (високосный год не учитывать).
        static void Task1()
        {
            Console.WriteLine("Задание 1, 2, 3");

            string? readline;
            ushort correctNumber = 0;
            int year = 0;

            do
            {
                Console.Write("Введите число от 1 до 366: ");
                readline = Console.ReadLine();

                // Добавить к задаче из предыдущего упражнения проверку числа введенного
                // пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
                // исключение, и выдавать на экран сообщение.
                if (!ushort.TryParse(readline, out ushort number) || (number > 366 || number < 1))
                {
                    Console.WriteLine("Вы должны ввести число от 1 до 366");
                }
                else
                {
                    correctNumber = number;
                }
            }
            while (correctNumber == 0);


            //Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            //учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
            //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            //год.Однако, если он делится без остатка на 400, это високосный год.)
            do
            {
                Console.Write("Введите год: ");
                readline = Console.ReadLine();

                if (!int.TryParse(readline, out int number) || number <= 0)
                {
                    Console.WriteLine("Некоректный ввод");
                }
                else
                {
                    year = number;
                }
            }
            while (year == 0);


            DateTime date = new DateTime(year, 1, 1);
            date = date.AddDays(correctNumber - 1);

            if (!IsLeapYear(date.Year) && correctNumber == 366)
            {
                Console.WriteLine(date.ToString("d MMMM") + $" {year + 1} года");
            }
            else
            {
                Console.WriteLine(date.ToString("d MMMM"));
            }


            return;
        }

        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();

        }
    }
}
