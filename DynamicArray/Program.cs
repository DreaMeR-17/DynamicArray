using System;
using System.Runtime.InteropServices;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[0];          
            int sum = 0;

            string commandExit = "exit";
            string commandSum = "sum";
            string userInput;

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Введите любое число.\nДля суммирования этих числе введите {commandSum}." +
                                   $"\nДля выхода из программы введите {commandExit}.");
                Console.Write("Массив чисел: ");

                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput.ToLower() == commandExit)
                {
                    isWork = false;
                    Console.Clear();
                }

                else if(userInput.ToLower() == commandSum)
                {
                    foreach (int number in userNumbers)
                    {
                        sum += number;
                    }

                    Console.WriteLine($"\nСумма всех введенных чисел: {sum}.\nДля продолжение нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else if(int.TryParse(userInput, out int number))
                {
                    int[] tempNumbers = new int[userNumbers.Length + 1];

                    for (int i = 0; i < userNumbers.Length; i++)
                    {
                        tempNumbers[i] = userNumbers[i];
                    }

                    tempNumbers[userNumbers.Length] = number;
                    userNumbers = tempNumbers;

                    Console.WriteLine("Все введенные числа: ");

                    foreach (int userNumber in userNumbers)
                    {
                        Console.Write(userNumber + " ");
                    }
                }

                else
                {
                    Console.WriteLine("Неправильный ввод.");
                    Console.Clear();
                }
            }
        }
    }
}
