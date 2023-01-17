// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int numberInt, int len)
{
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum += numberInt % 10;
        numberInt /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int numberInt = Convert.ToInt32(Console.ReadLine());
string numberStr = Convert.ToString(numberInt);

int len = numberStr.Length;

int sum = SumNumber(numberInt, len);

Console.WriteLine();
Console.WriteLine($"Результатом вычеслений, является: {sum}");

Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы ");
Console.ReadLine();
