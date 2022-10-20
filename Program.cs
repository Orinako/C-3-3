using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте узнаем, является ли число простым!");
            Console.WriteLine("Введите число для проверки:");

            int N = int.Parse(Console.ReadLine());
            int i = 2;
            bool remainder = N % i != 0;

            while (remainder && i<N)
            {                
                    i++;                
            }
            if (remainder == true)
                Console.WriteLine("Число является простым!");
            else
                Console.WriteLine("Число не является простым!");

            Console.ReadKey();
        }
    }
}
