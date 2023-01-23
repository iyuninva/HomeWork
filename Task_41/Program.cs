// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Метод заполнения массива:
void ArrayNumber(int Arraylength)
{
    int[] Array = new int[Arraylength];
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Индекс №{i}: [" + string.Join(", ", Array) + "]");
    }
    Sum(Array);
}

// Метод вычесления суммы больше 0: 
void Sum(int[] Array)
{
    int sum = 0;
    for (int j = 0; j < Array.Length; j++)
    {

        if (Array[j] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Введено чисел больше 0: [{sum}]");
}

// Ввод с клавиатуры длины массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.Write("Введите длину массива: ");
int Arraylength = Convert.ToInt32(Console.ReadLine());
ArrayNumber(Arraylength);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();



