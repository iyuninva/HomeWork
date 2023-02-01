// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Метод заполнения массивов:
void ArrayRandom(int[,] ArrayMatrix)
{
    for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
        {
            ArrayMatrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
// Метод расчета проиведения матриц:
void MatrixMultiplication(int[,] ArrayFirstMatrix, int[,] ArraySecondMatrix, int[,] Array)
{
    
    int sum = 0;
    if (ArrayFirstMatrix.GetLength(1) == ArraySecondMatrix.GetLength(0))
    {
        Console.WriteLine();
        Console.WriteLine("Результат произведения матриц:");
        for (int k = 0; k < Array.GetLength(0); k++)
        {
            for (int l = 0; l < Array.GetLength(1); l++)
            {
                for (int m = 0; m < Array.GetLength(1); m++)
                {
                    sum += ArrayFirstMatrix[k, m] * ArraySecondMatrix[m, l];
                }
                Array[k, l] = sum;
                Console.Write(Array[k, l] + "\t");
            }
            Console.WriteLine();
        }
    }
    else if (ArrayFirstMatrix.GetLength(1) != ArraySecondMatrix.GetLength(0))
    {
        Console.WriteLine();
        Console.WriteLine("Умножение матриц не имеет смысла по причине не совпадения числа столбцов матрицы А с числом строк матрицы В");
    }
}
// Метод вывода массивов на экран:
void PrintArray(int[,] ArrayMatrix)
{
    Console.WriteLine();
    for (int n = 0; n < ArrayMatrix.GetLength(0); n++)
    {
        for (int b = 0; b < ArrayMatrix.GetLength(1); b++)
        {
            Console.Write(ArrayMatrix[n, b] + "\t");
        }

        Console.WriteLine();
    }
}
// Ввод в программу:
Console.Write("Нажмите любую клавишу для запуска программы: ");
Console.ReadKey();
Console.WriteLine();
int[,] ArrayFirstMatrix = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
ArrayRandom(ArrayFirstMatrix);
Console.Write("Первая матрица: ");
PrintArray(ArrayFirstMatrix);

Console.WriteLine();

int[,] ArraySecondMatrix = new int[ArrayFirstMatrix.GetLength(1), new Random().Next(2, 5)];
ArrayRandom(ArraySecondMatrix);
Console.Write("Вторая матрица: ");
PrintArray(ArraySecondMatrix);

int[,] Array = new int[ArrayFirstMatrix.GetLength(0), ArraySecondMatrix.GetLength(1)];
MatrixMultiplication(ArrayFirstMatrix, ArraySecondMatrix,Array);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();
Console.Clear();

