// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Метод подсчета функции Аккермана
int Ackerman(int NumberOne, int NumberTwo)
{
    if (NumberOne == 0)
    {
        return NumberTwo + 1;
    }
    else if (NumberOne > 0 && NumberTwo == 0)
    {
        return Ackerman(NumberOne - 1, 1);
    }
    else if (NumberOne > 0 && NumberTwo > 0)
    {
        return Ackerman(NumberOne - 1, Ackerman(NumberOne, NumberTwo - 1));
    }
    return Ackerman(NumberOne, NumberTwo);
}

// Старт программы
Console.WriteLine("Задача №68");
Console.Write("Нажмите Entrer для запуска программы: ");
Console.ReadLine();
Console.WriteLine();

Console.Write("Введите число №1: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Ackerman(NumberOne, NumberTwo);

Console.WriteLine();
Console.Write("Результат работы программы: ");
Console.WriteLine(Ackerman(NumberOne, NumberTwo));

// Завершенеи программы
Console.WriteLine();
Console.Write("Нажмите любую клавишу для заверешния программы: ");
Console.ReadKey();
Console.Clear();