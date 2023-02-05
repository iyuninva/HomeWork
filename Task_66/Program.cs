// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int PrintSumNumber(int NumberOne, int NumberTwo)
{
    int sum = 0;
    if (NumberOne == NumberTwo + 1)
    {
        return 0;
    }
    sum = NumberOne + PrintSumNumber(NumberOne + 1, NumberTwo);
    return sum;
}

Console.WriteLine("Задача №66");
Console.Write("Нажмите Entrer для запуска программы: ");
Console.ReadLine();
Console.WriteLine();
int NumberOne = 0;
int NumberTwo = 0;
Console.Write("Желайте ввести числа с клавиатуры?: yes/no ");
string confirmation = Convert.ToString(Console.ReadLine());
if (confirmation == "yes")
{
    Console.Write("Введите число №1: ");
    NumberOne = Convert.ToInt32(Console.ReadLine()); ;
    Console.Write("Введите число №2: ");
    NumberTwo = Convert.ToInt32(Console.ReadLine()); ;
}
else
{
    NumberOne = new Random().Next(3, 11);
    Console.WriteLine($"Полученое число №1: {NumberOne}");
    NumberTwo = new Random().Next(3, 11);
    Console.WriteLine($"Полученое число №2: {NumberTwo}");
}

Console.WriteLine();
Console.Write("Результат работы программы: ");
int sum = PrintSumNumber(NumberOne, NumberTwo);
Console.Write(sum);

Console.WriteLine();
Console.Write("Нажмите любую клавишу для заверешния программы: ");
Console.ReadKey();
Console.Clear();