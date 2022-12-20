// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Добрый день! Задача №13");
Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
String b = Convert.ToString(a);
int str = b.Length;

if (b.Contains("-")==true & str>3)
{
    Console.WriteLine(b[3]);
}
else if (b.Contains("-")==false & str>2)
{
    Console.WriteLine(b[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// НАКОНЕЦ ОНО ЖИВОЕ!!