// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));

Console.WriteLine($"Расстояние между точками ({X1}, {Y1}, {Z1}) и ({X2}, {Y2}, {Z2}) = {Math.Round(d, 2)}");