// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод заполнения массива:
void FillArray(int M, int N)
{
    int[,] Array = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Array[i, j] = new Random().Next(1, 11);
            // Console.Write(Array[i, j] + " ");
        }
        // Console.WriteLine();
    }
    PrintArray(Array, M, N);
    Average(Array, M, N);
}

// Метод вывода массива на экран:
void PrintArray(int[,] Array, int M, int N)
{
    for (int k = 0; k < M; k++)
    {
        for (int l = 0; l < N; l++)
        {
            Console.Write(Array[k, l] + " ");
        }
        Console.WriteLine();
    }
}

// Метод нахождения среднего арифметического числа:
void Average(int[,] Array, int M, int N)
{
    double[] sum = new double[N];
    for (int m = 0; m < N; m++)
    {
        for (int n = 0; n < M; n++)
        {
            sum[m] += Array[n, m];
        }

        sum[m] = Math.Round(sum[m] / N, 1);
        Console.WriteLine();
        Console.Write($"Результат в {m + 1} столбце: " + sum[m]);
    }
}


// Ввод диапазона массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.Write("Введите колличество строк двумерного массива M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов двумерного массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FillArray(M, N);

// Окончание программы:
Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();