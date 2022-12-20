// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Добрый день! Задача №15");
Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0 & a < 8)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Рабочий день!");
    }
}
else
{
    Console.WriteLine("Введите корректное число");
}
