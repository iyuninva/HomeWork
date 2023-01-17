// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int[] ArraySum(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = number[i];
    }
    return array;
}

Console.WriteLine("Введите число: ");
int numberInt = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(numberInt);
int[] array = new int[number.Length];
Console.WriteLine(ArraySum(array));
