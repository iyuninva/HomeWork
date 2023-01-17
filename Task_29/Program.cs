// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
    }
    return array;
}

int[] array = new int[8];
ArrayRandom(array);
Console.Write("Массив из 8 элементов: ");
Console.WriteLine(string.Join(", ", array));

Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы ");
Console.ReadLine();