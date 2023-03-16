using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль_2
{
    internal class Program
    {
        /*Задание 1
        Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
        Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
        а двумерный массив В случайными числами с помощью циклов. 
        Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. 
        Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
        общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.
        */
        static void Main(string[] args)
        {
            // объявление одномерного массива А (5 элементов)
            double[] A = new double[5];
            Console.WriteLine("Введите 5 чисел для массива А:");
            // заполнение массива А числами, введенными с клавиатуры пользователем
            for (int i = 0; i < 5; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }
            // объявление заполнение двумерного массива В случайными числами
            double[,] B = new double[3, 4];
            //Создание объекта для генерации случайных чисел
            Random rnd = new Random();
            //заполнение двумерного массива В случайными числами
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(1,100) * 0.1;
                }
            }
            // вывод значений массивов
            Console.WriteLine("Массив A: " + string.Join(" ", A));
            //Join(String, Object[]) — это удобный метод, который позволяет сцепить каждый элемент в массиве объектов с указаным разделителем (строкой).
            Console.WriteLine("Массив B: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            // нахождение общего максимального элемента
            // используем тернарный оператор
            // если A[0] больше значения B[0,0], то возвращается значение A[0], иначе - значение B[0,0].
            double max = A[0] > B[0, 0] ? A[0] : B[0, 0];
            for (int i = 0; i < 5; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                }
            }
            Console.WriteLine("Общий максимальный элемент: " + max);
            // нахождение общего минимального элемента
            double min = A[0] < B[0, 0] ? A[0] : B[0, 0];
            for (int i = 0; i < 5; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                }
            }
            Console.WriteLine("Общий минимальный элемент: " + min);
            // нахождение общей суммы всех элементов
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += B[i, j];
                }
            }
            Console.WriteLine("Общая сумма всех элементов: " + sum);
            // нахождение общего произведения всех элементов
            double prod = 1;
            for (int i = 0; i < 5; i++)
            {
                prod *= A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    prod *= B[i, j];
                }
            }
            Console.WriteLine("Общее произведение всех элементов: " + prod);
            // нахождение суммы четных элементов массива А
            double evenSum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenSum += A[i];
                }
            }
            Console.WriteLine("Сумма четных элементов массива А: " + evenSum);
            // нахождение суммы нечетных столбцов массива В
            double oddColumnSum = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnSum += B[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма нечетных столбцов массива В: " + oddColumnSum);
        }
    }
}
