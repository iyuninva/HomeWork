// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Метод заполнения массива неповторяющимися двузначными числами:
void ArrayRandom(int[,,] Array)
{
    int[] Temp = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2) + 1];
    int CountTemp = 0;
    for (int i = 0; i < Temp.GetLength(0); i++)
    {
        Temp[i] = new Random().Next(10, 100);
        CountTemp = Temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (Temp[i] == Temp[j])
                {
                    Temp[i] = new Random().Next(10, 100);
                    CountTemp = Temp[i];
                    j = 0;
                }
                CountTemp = Temp[i];
            }
        }
    }
    CompletionArray(Array, Temp);
}
// Метод заполнения трехмарного массива:
void CompletionArray(int[,,] Array, int[] Temp)
{
    int CountArray = 0;
    for (int k = 0; k < Array.GetLength(0); k++)
    {
        for (int l = 0; l < Array.GetLength(1); l++)
        {
            for (int m = 0; m < Array.GetLength(2); m++)
            {
                Array[k, l, m] = Temp[CountArray];
                CountArray++;
            }
        }
    }
    PrintArray(Array);
}

// Метод вывода массива на экран:
void PrintArray(int[,,] Array)
{
    for (int n = 0; n < Array.GetLength(0); n++)
    {
        for (int b = 0; b < Array.GetLength(1); b++)
        {
            for (int v = 0; v < Array.GetLength(2); v++)
            {
                Console.Write(Array[n, b, v] + $" |{n} {b} {v}|" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Ввод в программу:
Console.Write("Нажмите любую клавишу для запуска программы: ");
Console.ReadKey();
int[,,] Array = new int[new Random().Next(2, 5), new Random().Next(2, 5), new Random().Next(2, 5)];
ArrayRandom(Array);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();
Console.Clear();



