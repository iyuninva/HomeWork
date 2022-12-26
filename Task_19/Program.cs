//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// 1 Вариант ----------------------------------------------------------------------
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10000 && number <= 99999 || number >= -99999 && number <= -10000)
// {
//     int a1 = number / 10000;
//     int b1 = number % 10;
//     if (a1 == b1)
//     {
//         int a2 = number / 1000 % 10;
//         int b2 = number % 100 / 10;
//         if (a2 == b2)
//         {
//             Console.WriteLine($"Число {number} является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine($"Число {number} не является палиндромом!");
//         } 
//     }
//     else
//         {
//             Console.WriteLine($"Число {number} не является палиндромом!");
//         }
// }
// else
// {
//     Console.WriteLine("Error - Введите пятизначное число!");
// }
//---------------------------------------------------------------------------------
// 2 Вариант ----------------------------------------------------------------------

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number <= 99999 || number >= -99999 && number <= -10000)
{
    String a = Convert.ToString(number);
    if (a.Contains("-")==true && a[1] == a[5] && a[2] == a[4])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом!");
    }
}
else
{
    Console.WriteLine("Error - Введите пятизначное число!");
}
//---------------------------------------------------------------------------------