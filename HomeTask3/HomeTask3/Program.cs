using System;

namespace HomeTask3
{
    public class Program
    {
        public static void Main(string[] args)
        {
             PracticalTask();
        }

        public static void PracticalTask()
        {
            /*
                * Создать массив на N элементов, где N указывается с консольной строки
                * Заполнить его случайными числами от 1 до 26 включительно
                * Создать 2 массива, где в 1 массиве будут значение только четных значений, а во втором нечетных
                * Заменить числа в 1 и 2 массиве  на буквы английского алфавита
                * Значения ячеек этих массивов равны порядковому номеру каждой буквы в алфавите
                * Если же буква является одной из списка (a, e, i, d, h, j) то она должна быть в верхнем регистре
                * Вывести на экран результат того, в каком из массивов будет больше букв в верхнем регистре
                * Вывести оба массива на экран
                * Каждый из массивов должен быть выведен 1 строкой, где его значения будут разделены пробелом.
            */

            int input = Convert.ToInt32(Console.ReadLine());
            int[] integerArray = new int[input];
            var random = new Random();
            int even = 0;
            int evenUpper = 0;
            int uneven = 0;
            int unevenUpper = 0;
            char[] evenIntegers = new char[0];
            char[] unevenIntegers = new char[0];

            for (int i = 0; i < input; i++)
            {
                integerArray[i] = random.Next(1, 27);

                if (integerArray[i] == 1 || integerArray[i] == 5 || integerArray[i] == 9)
                {
                    integerArray[i] = integerArray[i] - 32;
                    unevenUpper++;
                }
                else if (integerArray[i] == 4 || integerArray[i] == 8 || integerArray[i] == 10)
                {
                    integerArray[i] = integerArray[i] - 32;
                    evenUpper++;
                }

                if (integerArray[i] % 2 == 0)
                {
                    char[] tmp = new char[even + 1];
                    for (int j = 0; j < evenIntegers.Length; j++)
                    {
                        tmp[j] = evenIntegers[j];
                    }

                    tmp[even] = Convert.ToChar(integerArray[i] + 96);
                    evenIntegers = tmp;
                    even++;
                }
                else
                {
                    char[] tmp = new char[uneven + 1];
                    for (int j = 0; j < unevenIntegers.Length; j++)
                    {
                        tmp[j] = unevenIntegers[j];
                    }

                    tmp[uneven] = Convert.ToChar(integerArray[i] + 96);
                    unevenIntegers = tmp;
                    uneven++;
                }
            }

            Console.WriteLine($"Even chars: {string.Join(" ", evenIntegers)}");

            Console.WriteLine($"Uneven chars: {string.Join(" ", unevenIntegers)}");

            if (evenUpper > unevenUpper)
            {
                Console.WriteLine($"Even chars won with more uppers!\n{evenUpper} even upper chars");
            }
            else if (evenUpper < unevenUpper)
            {
                Console.WriteLine($"Uneven chars won with more uppers!\n{unevenUpper} uneven upper chars");
            }
            else
            {
                Console.WriteLine($"Draw! Both sides has {evenUpper} upper chars!");
            }
        }
    }
}