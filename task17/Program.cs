// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void quarterNumber(int x, int y)
{
    if (x == 0 && y == 0)
    {
        Console.WriteLine("Х и Y не могут быть одновременно равны 0");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else
    {
        Console.WriteLine("4 четверть");
    }
}

Console.Clear();
Console.Write("Введите координату Х: ");
int numberX = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int numberY = int.Parse(Console.ReadLine());
quarterNumber(numberX, numberY);