// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Input b1: ");
double b1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input k1: ");
double k1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input b2: ");
double b2 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input k2: ");
double k2 = System.Convert.ToInt32(System.Console.ReadLine());


if (k1 == k2)
    System.Console.WriteLine("У заданных прямых нет одной точки пересечения");
else 
    System.Console.WriteLine($"Точка пересечения прямых: ({x(b1, k1, b2, k2)};{y(b1, k1, x(b1, k1, b2, k2))})");


double x(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double y(double b, double k, double x)
{
    return k * x + b;
}