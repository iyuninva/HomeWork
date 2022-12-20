// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Добрый день! Задача №8");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count < a)
{
    count++;
    Console.WriteLine(count+2);
}
