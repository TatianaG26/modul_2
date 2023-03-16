using System;

namespace модуль_2
{
    /*Задание 4
    Создайте приложение, которое производит операции над матрицами:
    ■ Умножение матрицы на число;
    ■ Сложение матриц;
    ■ Произведение матриц.*/
    internal class Задание_4
    {
        static void Main(string[] args)
        {
            // Создать матрицу
            int[,] matrix = { { 2, 3 }, { 4, 5 } };
            // Введите число
            Console.WriteLine("Введите число, на которое умножить матрицу:");
            int number = int.Parse(Console.ReadLine());

            // Вывести исходную матрицу
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            // Получить результат
            int[,] result = MultiplyMatrixByNumber(matrix, number);

            // Вывести результат
            Console.WriteLine("Результат умножения матрицы на число:");
            PrintMatrix(result);
            Console.WriteLine("______________________________________");
            // Создать две матрицы
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

            // Вывести исходные матрицы
            Console.WriteLine("Исходные матрицы:");
            Console.WriteLine("Матрица 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Матрица 2:");
            PrintMatrix(matrix2);

            // Получить результат
            result = AddMatrices(matrix1, matrix2);

            // Вывести результат
            Console.WriteLine("Результат сложения матриц:");
            PrintMatrix(result);
            Console.WriteLine("______________________________________");
            // Получить результат
            result = MultiplyMatrices(matrix1, matrix2);

            // Вывести результат
            Console.WriteLine("Результат произведения матриц:");
            PrintMatrix(result);
        }

        static int[,] MultiplyMatrixByNumber(int[,] matrix, int number) //Умножение матрицы на число
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }
            return result;
        }
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2) //Cложение матрицы
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                Console.Error.WriteLine("Невозможно выполнить операцию: число столбцов первой матрицы не соответствует числу строк второй матрицы");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
        static void PrintMatrix(int[,] matrix) //Вывод матрицы
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

    
