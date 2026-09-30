using System;
using System.Text;

namespace Lab3Variant16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // ЗАВДАННЯ 1: Пошук найбільшого числа
            Console.WriteLine("--- Завдання 1 ---");
            Console.WriteLine("Введіть цілі числа. Для завершення введіть 0:");

            int maxNumber = int.MinValue;
            int inputNumber;
            bool isFirstNumber = true;

            do
            {
                inputNumber = int.Parse(Console.ReadLine()!);

                if (inputNumber != 0)
                {
                    if (isFirstNumber || inputNumber > maxNumber)
                    {
                        maxNumber = inputNumber;
                        isFirstNumber = false;
                    }
                }
            }
            while (inputNumber != 0);

            if (!isFirstNumber)
            {
                Console.WriteLine($"Найбільше число у послідовності: {maxNumber}");
            }
            else
            {
                Console.WriteLine("Послідовність порожня (введено лише 0).");
            }

            // ЗАВДАННЯ 2: Перевірка масиву на симетрію
            Console.WriteLine("\n--- Завдання 2 ---");
            Console.WriteLine("Введіть кількість елементів масиву:");

            int arraySize = int.Parse(Console.ReadLine()!);

            int[] array = new int[arraySize];

            Console.WriteLine("Введіть елементи масиву по одному:");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine()!);
            }

            bool isSymmetric = true;

            for (int i = 0; i < arraySize / 2; i++)
            {
                if (array[i] != array[arraySize - 1 - i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("Масив є симетричним (паліндромом).");
            }
            else
            {
                Console.WriteLine("Масив не є симетричним.");
            }
        }
    }
}