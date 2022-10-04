Console.Clear();
Console.Write("Введите первое число: ");
double numberFirst = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberSecond = double.Parse(Console.ReadLine());
if (numberFirst > numberSecond)
{
    Console.WriteLine("max = " + numberFirst);
}
else
{
    Console.WriteLine("max = " + numberSecond);
}