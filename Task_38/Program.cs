// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Метод заполнения массива:
void ArrayDoubleRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 3);
    }
}
// Метод вычесления разницы минимального и максимального числа: 
void Method(double[] array)
{
    double MaxNumber = array[0];
    double MinNumber = array[0];
    int positionMax = 0;
    int positionMin = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(MaxNumber <= array[i])
        {
            MaxNumber = array[i];
            positionMax = i;

        }
        else if(MinNumber >= array[i])
        {
            MinNumber = array[i];
            positionMin = i;
        }
    }
    Console.WriteLine($"Максимальное число на позиции №{positionMax}: {MaxNumber}");
    Console.WriteLine($"Минимальное число на позиции №{positionMin}: {MinNumber}");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива составляет: {MaxNumber - MinNumber}");
    Console.WriteLine();
}

// Ввод с клавиатуры длины массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.Write("Введите длину массива: ");
double[] array = new double[Convert.ToInt32(Console.ReadLine())];
ArrayDoubleRandom(array);

// Вывод случайного массива:
Console.WriteLine();
Console.WriteLine("Массив из случайных чисел: " + string.Join(", ", array));
Console.WriteLine();
Method(array);
// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();