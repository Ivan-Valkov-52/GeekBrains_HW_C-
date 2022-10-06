Console.Clear();
Console.Write("Введите день недели: ");
int numberDay;
while(!int.TryParse(Console.ReadLine(), out numberDay)){
    Console.WriteLine("Вы ввели не корректное значение! Попробуйте ещё раз.");
}
switch (numberDay)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine(numberDay + " -> Да!");
        break;
    case 6:
    case 7:
        Console.WriteLine(numberDay + " -> Нет!");
        break;
    default:
        Console.WriteLine("Введено не корректное значение!");
        break;
}