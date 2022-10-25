// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

void CoordinateX(int k1, int b1, int k2, int b2)
{

    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Две прямые совпадают!");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны!");
    }
    else
    {
        double x, y, delta;
        delta = (k1 * -1) - (k2 * -1);
        x = ((-b1 * -1) - (-b2 * -1)) / delta;
        y = ((k1 * -b2) - (k2 * -b1)) / delta;
        Console.Write("x = " + x + " " + "y = " + y);
    }
}

Console.Clear();
Console.WriteLine("Есть две прямые y = k1 * x + b1 и y = k2 * x + b2. Введите значения: ");
Console.Write("k1 = ");
int k1 = InputNumber();
Console.Write("b1 = ");
int b1 = InputNumber();
Console.Write("k2 = ");
int k2 = InputNumber();
Console.Write("b2 = ");
int b2 = InputNumber();
CoordinateX(k1, b1, k2, b2);



