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

int InputNomber(){
    int num;
    while(!int.TryParse(Console.ReadLine(), out num)){
        Console.Write("Введите корректное значение: ");
    }
    return num;
}

int EvenElementArray(int[] array){
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = GetArray(InputNomber(), 100, 999);
PrintArray(array);
Console.Write(" -> " + EvenElementArray(array));