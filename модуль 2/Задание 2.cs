using System;

namespace модуль_2
{
    internal class Задание_2
    {
        /*Задание 2
        Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
        Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.*/
        static void Main()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            int min = -100;
            int max = 100;
            int minI = 0, minJ = 0, maxI = 0, maxJ = 0;

            // заполняем массив случайными числами и находим минимальный и максимальный элементы
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(min, max);
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minI = i;
                        minJ = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;

            // проверяем, какие индексы больше: максимальный или минимальный
            if (maxI > minI || (maxI == minI && maxJ > minJ))
            {
                for (int i = minI; i <= maxI; i++)
                {
                    for (int j = minJ; j <= maxJ; j++)
                    {
                        sum += array[i, j];
                    }
                }
            }
            else
            {
                for (int i = maxI; i <= minI; i++)
                {
                    for (int j = maxJ; j <= minJ; j++)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine($"Сумма элементов между минимальным ({min}) и максимальным ({max}) элементами: {sum}");
        }
    }
}
