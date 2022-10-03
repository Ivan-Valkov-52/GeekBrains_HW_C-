Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 == Math.Sqrt(number1)) // либо второй вариант number1 == Math.Pow(number2,2) 2 - это степень.
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}
