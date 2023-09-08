// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result;
}

int[] EnterNumber(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Promt($"Введите {i+1} число: ");
    }
    return array; 
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int UpToZero(int[] arr)
{
    int upZero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) 
        upZero++;
    }
    return upZero;
}

int countnumber = Promt("Укажите сколько чисел будете вводить: ");
Console.WriteLine();

int[] resultArray = EnterNumber(countnumber);
Console.WriteLine();

// PrintArray(resultArray); 
// Console.WriteLine();

int result = UpToZero(resultArray);
Console.WriteLine($"Количество чисел > 0 равно -> {result}");