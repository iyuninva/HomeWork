// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Straight(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
    {
        Console.WriteLine();
        Console.WriteLine("Заданные прямые не пересекаются!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

// Ввод данных:
Console.Write("Нажмите Enter для запуска программы: ");
Console.ReadLine();
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Straight(b1, k1, b2, k2);

// Окончание программы:
Console.Write("Нажмите Enter для завершения программы: ");
Console.ReadLine();


