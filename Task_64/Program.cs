// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Метод вывода в консоль натуральных чисел
void PrintNaturalNumber(int Number)
{
    if(Number == 0)
    {
        return;
    }
    Console.Write(Number + " ");
    PrintNaturalNumber(Number - 1);
}

Console.WriteLine("Задача №64");
Console.Write("Нажмите Entrer для запуска программы: ");
Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Результат работы программы: ");

int Number = new Random().Next(3, 11);

Console.Write($"Числа от {Number} до 1: ");
PrintNaturalNumber(Number);

Console.WriteLine();
Console.Write("Нажмите любую клавишу для заверешния программы: ");
Console.ReadKey();
Console.Clear();

