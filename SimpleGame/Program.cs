using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадай число \n\n\nДля начала игры нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Первый игрок, введите своё имя: ");
            string nickName_1 = (Console.ReadLine());
            Console.Write("\nВторой игрок, введите своё имя: ");
            string nickName_2 = (Console.ReadLine());
            Console.WriteLine("\nДля начала игры нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();

            Random rand = new Random();
            int secretNumber = rand.Next(12, 120);
            int firstNumber = 0;
            int secondNumber = 0;
            int countOfTry = 10;


            Console.WriteLine($"Внимание! {nickName_1} и {nickName_2}, ваша задача \nугадать загаданное программой число. Оно находится в \nдиапазоне от 12 до 120. ");
            while (countOfTry != 0)
            {
                Console.Write("\n\n\nХод первого пользователя: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                if (firstNumber == secretNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Игра окончена! Загаданное число было {secretNumber}. \nПервый игрок победил!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"\nУвы, но {firstNumber} - не загаданное число. \nОсталось попыток: {(countOfTry + 1) / 2 - 1}");
                    countOfTry = countOfTry - 1;
                }

                Console.Write("\n\n\nХод второго пользователя: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                if (secondNumber == secretNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Игра окончена! Загаданное число было {secretNumber}. \nВторой игрок победил!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"\nУвы, но {secondNumber} - не загаданное число. \nОсталось попыток: {(countOfTry + 1) / 2 - 1} \n");
                    countOfTry = countOfTry - 1;
                }
            }
            Console.Clear();
            Console.WriteLine($"Увы. Игра окончена, из-за окончания попыток. \nЗагаданное число - {secretNumber}");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
