// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double DegreeMethod(int A, int B)
{
    int degree = 1;
    for(int i = 0; i < B || -i > B; i++)
    {   
        degree *= A;
    }
    return degree;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
double degree = DegreeMethod(A, B);
if (B > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Результатом возведения числа {A} в степень {B} является: {degree}");  
}
else
{
    double NegativeDegree = 1/degree;
    Console.WriteLine();
    Console.WriteLine($"Результатом возведения числа {A} в степень {B} является: {NegativeDegree}");  
}

Console.WriteLine();
Console.Write("Нажмите Enter для завершения программы ");
Console.ReadLine();


