// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> Нет 
// 23432 -> Да
// 12821 -> Да

void Palindrome(int number)
{
    if (number % 10 == (number / 10000) % 10 && (number / 10) % 10 == (number / 1000) % 10)
    {
        Console.WriteLine(number + " -> Да");
    }
    else
    {
        Console.WriteLine(number + " -> Нет");
    }
}

Console.Clear();
Console.Write("Введите любое пятизначное число: ");
int number = int.Parse(Console.ReadLine());
Palindrome(number);

