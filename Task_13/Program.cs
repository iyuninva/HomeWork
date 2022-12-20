// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Добрый день! Задача №13");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
String c = "-";
String b = Convert.ToString(a);
if (b[0]==c[0])
{
	Console.WriteLine(b[3]);
}
else
{
	Console.WriteLine(b[2]);
}

