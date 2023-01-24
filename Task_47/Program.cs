// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void FillArray(int M, int N)
{
    double[,] Array = new double[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Array[i, j] = new Random().Next(-99, 100)/10.0;
            // Console.Write(Array[i, j] + " ");
        }
        // Console.WriteLine();
    }
    PrintArray(Array, M, N);
}

void PrintArray(double[,] Array, int M, int N)
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

// Ввод с клавиатуры длины массива:
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
