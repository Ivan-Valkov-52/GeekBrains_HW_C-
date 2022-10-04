// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int index = 0;
while (index <= Math.Abs(number * 2))
{
    if (number > 0)
    {
        Console.Write((number * -1) + index);
    }
    else
    {
        Console.Write(number + index);
    }
    Console.Write(" ");
    index++;
}