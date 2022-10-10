// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int InputCoordinans()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.WriteLine("Введите корректное значение!");
    return number;
}

double DistancePoints(int xA, int yA, int xB, int yB)
{
    double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    return result;
}

Console.Clear();
Console.Write("Введите координату x точки А: ");
int xA = InputCoordinans();
Console.Write("Введите координату y точки А: ");
int yA = InputCoordinans();
Console.Write("Введите координату x точки B: ");
int xB = InputCoordinans();
Console.Write("Введите координату y точки B: ");
int yB = InputCoordinans();
Console.WriteLine($"Координаты точки А({xA},{yA}); В({xB},{yB})");
Console.WriteLine("Расстояние между точками равно: " + Math.Round(DistancePoints(xA, yA, xB, yB), 2));