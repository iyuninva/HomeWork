// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// 1 Вариант работы программы:
int[] ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000);
    }
    return array;
}
// 2 Вариант работы программы:
int[] ArrayManual(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} значение: ");
        int j = Convert.ToInt32(Console.ReadLine());
        array[i] = j;
    }
    return array;
}

// Диалог человек машина:
Console.WriteLine("Выберите вариант работы программы: *Введите 1 или 2 варианты* ");
Console.WriteLine();
Console.WriteLine("1 - Заполнение массива Random числами из 8 элементов;");
Console.WriteLine("2 - Заполнение массива в ручную из любого числа элементов;");
Console.Write("Поле ввода: ");


// Логика выбора варианта:
int option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    int[] array = new int[8];
    ArrayRandom(array);
    Console.WriteLine();
    Console.Write("Массив из 8 элементов: ");
    Console.WriteLine(string.Join(", ", array));
}
else if (option == 2)
{
    Console.Write("Введите размер массива: ");
    int manual = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[manual];
    ArrayManual(array);
    Console.WriteLine();
    Console.Write($"Массив из {manual} элементов: ");
    Console.WriteLine(string.Join(", ", array));
}
else
{
    Console.WriteLine("Error - Введите корректный номер варианта!");
}

Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы ");
Console.ReadLine();