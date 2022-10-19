// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
            break;
        }
        Console.Write(array[i] + ", ");
    }
}

int[] MultiArray(int[] array)
{
    int size;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] == array[array.Length - i - 1])
        {
            arr[i] = array[i];
        }
        else
        {
            arr[i] = array[i] * array[array.Length - i - 1];
        }
    }
    return arr;
}

int InputNomber(){
    int num;
    while(!int.TryParse(Console.ReadLine(), out num)){
        Console.Write("Введите корректное значение: ");
    }
    return num;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = GetArray(InputNomber(), 1, 9);
PrintArray(array);
Console.Write(" -> ");
PrintArray(MultiArray(array));
