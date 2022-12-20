// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Добрый день! Задача №15");
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.Write("Понедельник -");
        Console.Write(" Рабочий день :(");
        break;
    case 2:
        Console.Write("Вторник -");
        Console.Write(" Рабочий день :(");
        break;
    case 3:
        Console.Write("Среда -");
        Console.Write(" Рабочий день :(");
        break;
    case 4:
        Console.Write("Четверг -");
        Console.Write(" Рабочий день :(");
        break;
    case 5:
        Console.Write("Пятница -");
        Console.Write("Рабочий день :(");
        break;
    case 6:
        Console.Write("Суббота -");
        Console.Write(" Выходной!");
        break;
    case 7:
        Console.Write("Воскресенье -");
        Console.Write(" Выходной!");
        break;
}


