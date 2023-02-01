// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Метод заполнения массива:
void ArrayRandom(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 11);
        }
    }
    PrintArray(Array);
    SumStringArray(Array);
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
}
// Метод cуммирования элеметнов массива:
void SumStringArray(int[,] Array)
{
    Console.WriteLine();
    Console.Write("Вывести на экран суммы строк массима Array? yes/no: ");
    string Contexy = Convert.ToString(Console.ReadLine());

    int[] SumString = new int[Array.GetLength(0)];
    for (int m = 0; m < Array.GetLength(0); m++)
    {
        for (int n = 0; n < Array.GetLength(1); n++)
        {
            SumString[m] += Array[m, n];
        }
        if (Contexy.Equals("yes"))
        {
            Console.WriteLine($"Сумма элементов в строке № {m + 1} = " + SumString[m]);
        }
    }
    PrintNumberString(SumString);
}
// Метод вывода номера строки с наименьшей суммой элементов:
void PrintNumberString(int[] SumString)
{
    int MinNumber = SumString[0];
    int Number = 0;
    for (int b = 0; b < SumString.Length; b++)
    {
        if (SumString[b] < MinNumber)
        {
            MinNumber = SumString[b];
            Number = b;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элеметнов: {Number + 1}");
}

// Ввод в программу:
Console.Write("нажмите Enter для запуска программы: ");
Console.ReadLine();
int[,] Array = new int[new Random().Next(3, 5), new Random().Next(3, 5)];
ArrayRandom(Array);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();





