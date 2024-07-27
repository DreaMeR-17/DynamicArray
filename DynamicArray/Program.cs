using System;
using System.Runtime.InteropServices;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[0];

            string commandExit = "exit";
            string commandSum = "sum";
            string userInput;

            bool isWork = true;

            while (isWork)
            {
                foreach (int number in userNumbers)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();

                Console.WriteLine($"Для суммирования чисел введите {commandSum}." +
                                   $"\nДля выхода из программы введите {commandExit}.");
                Console.Write("Массив чисел: ");

                userInput = Console.ReadLine();

                Console.Clear();

                if (userInput.ToLower() == commandExit)
                {
                    isWork = false;
                    Console.Clear();
                }
                else if (userInput.ToLower() == commandSum)
                {
                    int sum = 0;

                    foreach (int userNumber in userNumbers)
                    {
                        sum += userNumber;
                    }

                    Console.WriteLine($"Сумма всех введенных чисел: {sum}.\nДля продолжение нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    int.TryParse(userInput, out int number);

                    int[] tempNumbers = new int[userNumbers.Length + 1];

                    for (int i = 0; i < userNumbers.Length; i++)
                    {
                        tempNumbers[i] = userNumbers[i];
                    }

                    tempNumbers[userNumbers.Length] = number;
                    userNumbers = tempNumbers;
                }
            }
        }
    }
}
