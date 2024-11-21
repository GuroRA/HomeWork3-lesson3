using System;

namespace HomeWork_File_lesson3
{

    internal class Program
    {
        enum WeekDays : byte
        {
            monday = 1,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        
        static string Task1(params int[] numbers)
        {
            //Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.

            Console.WriteLine("Задание 1");


            int correctCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] <= numbers[i])
                {
                    Console.WriteLine($"Элемент {numbers[i + 1]} на {i + 1} позиции ломает упорядоченность");
                    break;
                }
                correctCount++;
            }
            return correctCount == numbers.Length - 1 ? $"Последовательность упорядоченна" : $"Последовательность не упорядоченна";
        }

        static void Task2()
        {
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т. п.). По заданному номеру карты k(6 <=k <= 14) определить достоинство
            //соответствующей карты.Использовать try-catch-finally.

            Console.WriteLine("\nЗадание 2");

            int cardIndex;
            try
            {
                Console.Write("Введите число от 6 до 14: ");
                cardIndex = int.Parse(Console.ReadLine());
                switch (cardIndex)
                {
                    case 6:
                        Console.WriteLine("Шестёрка");
                        break;
                    case 7:
                        Console.WriteLine("Семёрка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмёрка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Число должно быть от 6 до 14");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return;

        }

        public static void Task3()
        {
            //Напишите программу, которая принимает на входе строку и производит выходные
            //данные в соответствии со следующей таблицей:

            Console.WriteLine("\nЗадание 3");

            Console.WriteLine("Кто вы: ");
            string? input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default :
                    Console.WriteLine("Beer");
                    break;
            }
            return;
        }


        public static string Task4()
        {
            //Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
            //..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            //Использовать enum.
            Console.WriteLine("\nЗадание 4");

            string? readline;
            byte numberOfWeek = 0;

            do
            {
                Console.Write("Введите число от 1 до 7: ");
                readline = Console.ReadLine();
                if (!byte.TryParse(readline, out byte number) || number > 7 || number < 0)
                {
                    Console.WriteLine("Вы должны ввести число от 1 до 7");
                }
                else
                {
                    numberOfWeek = number;
                }
            }
            while (numberOfWeek == 0);


            return $"День недели: {(WeekDays)numberOfWeek}";
        }

        public static string Task5()
        {
            //Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.
            Console.WriteLine("\nЗадание 5");

            int dollsCount = 0;
            string[] things = new string[6] {"Lipstik", "Pen", "Barbie doll", "Hello Kitty", "Hello Kitty", "wrench" };

            foreach (string item in things)
            {
                if (item == "Hello Kitty" || item == "Barbie doll")
                {
                    dollsCount++;
                }
            }

            return $"Кол-во кукол в сумке = {dollsCount}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Task1(1, 2, 3, 4, 5, 3, 7, 8, 9, 10));
            Task2();
            Task3();
            Console.WriteLine(Task4());
            Console.WriteLine(Task5());
            Console.ReadKey();
        }
    }
}
