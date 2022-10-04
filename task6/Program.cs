Console.Clear();
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());
if (numberOne > numberTwo)
{
    if (numberOne > numberThree)
    {
        Console.WriteLine("max = " + numberOne);
    }
    else
    {
        Console.WriteLine("max = " + numberThree);
    }
}
else
{
    if (numberTwo > numberThree)
    {
        Console.WriteLine("max = " + numberTwo);
    }
    else
    {
        Console.WriteLine("max = " + numberThree);
    }
}
