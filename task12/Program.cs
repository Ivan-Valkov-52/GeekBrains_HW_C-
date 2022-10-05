// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int foldOne = 7;
int foldTwo = 23;
if (number % foldOne == 0 & number % foldTwo == 0)
{
    Console.WriteLine(number + " -> ДА!!!");
}
else
{
    Console.WriteLine(number + " -> Нет!");
}