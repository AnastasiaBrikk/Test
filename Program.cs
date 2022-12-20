//Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнений алгоритма.

Console.Write("Input a number of strings: ");
int numberStrings = Convert.ToInt32(Console.ReadLine());

string[] FillArray(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input a {i + 1} string: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Массив не имеет значений!");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

string[] SortArray(string[] array)
{
    int countNecessaryValue = 0;
    string arrayValue = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) countNecessaryValue++;
    }
    string[] endArray = new string[countNecessaryValue];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3)
        {
            endArray[index] = array[i];
            index++;
        }
    }
    return endArray;
}

string[] originArray = FillArray(numberStrings);

Console.WriteLine("The origin array is:");
ShowArray(originArray);


string[] resultArray = SortArray(originArray);
Console.WriteLine("The sorted array:");
ShowArray(resultArray);
