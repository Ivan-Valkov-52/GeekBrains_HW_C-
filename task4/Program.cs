// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
while (99 > Math.Abs(number) || 1000 < Math.Abs(number))
{
    Console.WriteLine("Введите другое значение!");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine("Последняя цифра числа равна: " + (Math.Abs(number) % 10));


// Мой вариант
// Console.Write("Введите трёхзначное число: ");
// string number = Console.ReadLine();
// int index = 2;
// char value = number[index];
// Console.WriteLine("Последнее число равно: " + value);