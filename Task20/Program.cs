// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// А(3,6); В(2,1) -> 5.09

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double yB = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Lenght(xA, yA, xB, yB), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {result}");

double Lenght(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2));
}

