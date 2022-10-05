// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numberFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = int.Parse(Console.ReadLine());
if (Math.Abs(numberFirst) == Math.Sqrt(Math.Abs(numberSecond)) || Math.Abs(numberSecond) == Math.Sqrt(Math.Abs(numberFirst)))
{
    Console.WriteLine($"{numberFirst}, {numberSecond} -> ДА!");
}
else
{
    Console.WriteLine($"{numberFirst}, {numberSecond} -> Нет!");
}