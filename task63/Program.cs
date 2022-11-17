// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InputNumber()
{
    int num;
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите корректное значение");
    return num;
}

void NumbersRec(int number)
{
    
    if(number < 1)
    {
        return;
    }
    else
    {
        NumbersRec(number - 1);
        Console.Write(number + " ");
    }
}

Console.Write("Введите число N: ");
int number = InputNumber();
Console.Write($"{number} -> ");
NumbersRec(number);