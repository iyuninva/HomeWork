// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Метод заполнения массива:
void FillArray(int Line, int Columns)
{
    int[,] Array = new int[Line, Columns];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 11);
        }
    }
    PrintArray(Array);
    OrderingArray(Array);
}

// Метод сортировки по строкам:
void OrderingArray(int[,] Array)
{
    int temp = 0;
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            for (int b = 0; b < Array.GetLength(1) - 1; b++)
            {
                if (Array[m, b] < Array[m, b + 1])
                {
                    temp = Array[m, b + 1];
                    Array[m, b + 1] = Array[m, b];
                    Array[m, b] = temp;
                }
            }
        }
    }
    PrintArray(Array);
}

// Метод вывода массива на экран:
void PrintArray(int[,] Array)
{

    for (int k = 0; k < Array.GetLength(0); k++)
    {
        for (int l = 0; l < Array.GetLength(1); l++)
        {
            Console.Write(Array[k, l] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Ввод диапазона массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.WriteLine("Введите размер двемерного массива: ");
Console.Write("Колличество строк:  ");
int Line = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов:  ");
int Columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FillArray(Line, Columns);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();