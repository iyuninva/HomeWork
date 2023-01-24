// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

// Метод заполнения массива:
int[,] FillArray(int[,] Array, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Array[i, j] = new Random().Next(-10, 11);
        }
    }
    return(Array);
}

// Метод вывода массивана экран:
void PrintArray(int[,] Array, int M, int N)
{
    Console.Write("Вывести созданный массив на экран? yes/no: ");
    string Context = Convert.ToString(Console.ReadLine());

    if (Context.Equals("yes"))
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
    else
    {
        Console.WriteLine();
        Console.WriteLine("Переход выбору диапазона");
    }
}

// Метод получения числа из диапазона:
void PositionSelection(int[,] Array, int NumberM, int NumberN, int M, int N)
{
    if (NumberM >= M | NumberN >= N | NumberM < 0 | NumberN < 0)
    {
        Console.WriteLine();
        Console.WriteLine("Указанные значения вне диапазона массива!");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Полученное число: ");
        Console.WriteLine(Array[NumberM, NumberN]);
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
int[,] Array = new int[M, N];
FillArray(Array, M, N);
// Передача данных в метод вывода на экран:
PrintArray(Array, M, N);

// Выбор числа из диапазона массива:
Console.WriteLine();
Console.Write($"Введите номер строки элемента массива M от 0 до {M-1}: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца элемента массива N от 0 до {N-1}: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
PositionSelection(Array, NumberM, NumberN, M, N);

// Окончание программы:
Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();