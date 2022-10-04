Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> ");
if (number % 2 == 0)
{
    for (int i = 1; i <= (number / 2); i++)
    {
        if (i == (number / 2))
        {
            Console.Write(i + i);
            break;
        }
        Console.Write(i + i);
        Console.Write(", ");
    }
}
else
{
    for (int i = 1; i <= ((number-1) / 2); i++)
    {
        if (i == (number / 2))
        {
            Console.Write(i + i);
            break;
        }
        Console.Write(i + i);
        Console.Write(", ");
    }
}
