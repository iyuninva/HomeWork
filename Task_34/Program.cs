// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод заполнения массива:
int[] ArrayRandom(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

// Метод вычесления четных/нечетных чисел:
void ThreeNumbers(int[] array)
{
    int[] EvenNumber = new int[array.Length];
    int[] NotEvenNumber = new int[array.Length];
    int Evencount = 0;
    int NotEvencount = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            EvenNumber[j] = array[j];
            Evencount++;
        }
        else
        {
            NotEvenNumber[j] = array[j];
            NotEvencount++;
        }
        if (EvenNumber[j] != 0)
        {
            Console.WriteLine("Четное число: " + EvenNumber[j]);
        }
        if (array[j] % 2 != 0 & array[j] % 2 > 0)
        {
            Console.WriteLine("Нечетное число: " + NotEvenNumber[j]);
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество четных чисел: {Evencount}");
    Console.WriteLine($"Колличество нечетных чисел: {NotEvencount}");
    Console.WriteLine();
}

// Ввод с клавиатуры длины массива:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayRandom(length);

Console.WriteLine();
Console.WriteLine("Случайный массив из трехзначных положительных чисел: " + (string.Join(", ", array)));
ThreeNumbers(array);



