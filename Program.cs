// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FillStringArray(int size) 
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Enter string element >> ");
        arr[i] = Console.ReadLine();
    }

    return arr;
}

int FindLengthNewArray(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
          count++;
        }
    }

    return count;
}

string[] CreateNewArray(string[] arr)
{
    string[] newArray = new string[FindLengthNewArray(arr)];

    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j].Length <= 3 && arr[j] != "")
            {
                newArray[i] = arr[j];
                arr[j] = "";
                break;
            }
        }
    }

    return newArray;
}

Console.Write("Enter number of elements >> ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = FillStringArray(length);

Console.Write($"[{string.Join(", ", array)}] -> ");
Console.Write($"[{string.Join(", ", CreateNewArray(array))}]");
Console.WriteLine();