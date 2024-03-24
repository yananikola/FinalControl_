/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] FilterArrayByLength(string[] array, int maxLength)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= maxLength)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    foreach (string item in array)
    {
        if (item.Length <= maxLength)
        {
            newArray[index] = item;
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.WriteLine(item);
    }
}

Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine();
string[] originalArray = input.Split(' ');

//string[] originalArray = { “1234”, “1567”, “-2”, “computer science” };
string[] newArray = FilterArrayByLength(originalArray, 3);

//Console.WriteLine("Исходный массив:");
//PrintArray(originalArray);

Console.WriteLine($"\nНовый массив (элементы длиной не более 3 символов): ");
PrintArray(newArray);