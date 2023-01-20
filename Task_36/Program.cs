// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Метод заполнения массива:
void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
}
// Метод вычесления суммы чисел на нечетных позициях:
void Method(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 != 0)
        {
            sum += array[j];
            Console.Write($"Число стоящие на нечётной позиции: №{j} ");
            Console.WriteLine(array[j] + ", ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел стоящих на нечётных позициях: " + sum);
    Console.WriteLine();
}

// Ввод с клавиатуры длины массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.Write("Введите длину массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
ArrayRandom(array);

// Вывод случайного массива:
Console.WriteLine();
Console.WriteLine("Массив из случайных чисел: " + string.Join(", ", array));
Console.WriteLine();
Method(array);
// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();
