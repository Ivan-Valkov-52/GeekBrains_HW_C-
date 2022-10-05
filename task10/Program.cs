// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
int num1 = (number / 100) * 10;
int num2 = number % 10;
Console.WriteLine("Рандомное число: " + number);
Console.WriteLine("Первая часть числа: " + num1);
Console.WriteLine("Вторая часть числа: " + num2);
Console.WriteLine($"{number} -> {num1 + num2}");