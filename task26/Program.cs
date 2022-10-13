// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
// 4 -> 24 
// 5 -> 120

int ProductNumbers (int num){
    int result = 1;
    for(int i = 1; i <= num; i++){
        result *= i;
    }
    return result;
}

Console.Clear();
Console.Write("Введи любое число: ");
int number;
while(!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Попробуйте ещё раз: ");
Console.WriteLine($"{number} -> {ProductNumbers(number)}");