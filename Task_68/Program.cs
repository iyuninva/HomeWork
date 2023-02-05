// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Метод подсчета функции Аккермана
int PrintAckerman(int NumberOne, int NumberTwo)
{
    if (NumberOne == 0)
    {
        return NumberTwo + 1;
    }
    else if (NumberOne > 0 && NumberTwo == 0)
    {
        return PrintAckerman(NumberOne - 1, 1);
    }
    else if (NumberOne > 0 && NumberTwo > 0)
    {
        return PrintAckerman(NumberOne - 1, PrintAckerman(NumberOne, NumberTwo - 1));
    }
    return PrintAckerman(NumberOne, NumberTwo);
}

// Метод проверки положительного числа
int PositiveNumber(int NumberOne, int NumberTwo)
{
    if (NumberOne < 0 || NumberTwo < 0)
    {
        Console.WriteLine("Введите положительные натуральные числа!");
        return Input(NumberOne, NumberTwo);
    }
    return PrintAckerman(NumberOne, NumberTwo);
}

// Метод ввода чисел
int Input(int NumberOne, int NumberTwo)
{
    Console.Write("Введите число №1: ");
    NumberOne = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число №2: ");
    NumberTwo = Convert.ToInt32(Console.ReadLine());
    return PositiveNumber(NumberOne, NumberTwo);
}

// Старт программы
Console.WriteLine("Задача №68");
Console.Write("Нажмите Entrer для запуска программы: ");
Console.ReadLine();
Console.WriteLine();
int NumberOne = 0;
int NumberTwo = 0;
Input(NumberOne, NumberTwo);

// Результат работы программы и вывод в консоль
Console.WriteLine();
Console.Write("Результат работы программы: ");
Console.WriteLine(PrintAckerman(NumberOne, NumberTwo));

// Завершенеи программы
Console.WriteLine();
Console.Write("Нажмите любую клавишу для заверешния программы: ");
Console.ReadKey();
Console.Clear();