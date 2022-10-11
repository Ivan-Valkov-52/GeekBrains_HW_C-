// Второй вариант

int[] FillArray()
{
    int[] array = new int[3];
    int number;
    for (int index = 0; index < array.Length; index++)
    {
        while (!int.TryParse(Console.ReadLine(), out number))
            Console.WriteLine("Ввели не корректное значение! Попробуйте ещё раз.");
        array[index] = number;
    }
    return array;
}

double DistancePoints(int[] pointsA, int[] pointsB)
{

    double result = Math.Sqrt(Math.Pow(pointsA[0] - pointsB[0], 2) + Math.Pow(pointsA[1] - pointsB[1], 2) + Math.Pow(pointsA[2] - pointsB[2], 2));
    return result;
}

Console.Clear();
Console.WriteLine("Введите координаты точки А(x,y,z): ");
int[] pointsA = FillArray();
Console.WriteLine("Введите координаты точки B(x,y,z): ");
int[] pointsB = FillArray();
Console.WriteLine("Координаты точек A(" + String.Join(",", pointsA) + "); " + "B(" + String.Join(",", pointsB) + ").");
Console.WriteLine("Расстояние между точками равно: " + Math.Round(DistancePoints(pointsA, pointsB), 2));

// Первый вариант
// int InputCoordinans()
// {
//     int number;
//     while (!int.TryParse(Console.ReadLine(), out number))
//         Console.WriteLine("Введите корректное значение!");
//     return number;
// }

// double DistancePoints(int xA, int yA, int zA, int xB, int yB, int zB)
// {
//     double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
//     return result;
// }

// Console.Clear();
// Console.Write("Введите координаты точки А(x,y,z): ");
// int xA = InputCoordinans();
// int yA = InputCoordinans();
// int zA = InputCoordinans();
// Console.Write("Введите координаты точки B(x,y,z): ");
// int xB = InputCoordinans();
// int yB = InputCoordinans();
// int zB = InputCoordinans();
// Console.WriteLine($"Координаты точек А({xA},{yA},{zA}); В({xB},{yB},{zB})");
// Console.WriteLine("Расстояние между точками равно: " + Math.Round(DistancePoints(xA, yA, zA, xB, yB, zB), 2));
