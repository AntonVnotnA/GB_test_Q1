// Из имеющегося массива строк сформировать новый массив из строк, 
// длина которых меньше либо равна 3 символа


using static System.Console;
Clear();

Write("Please print a quantity of alements of your array :");
int elementsQty = Convert.ToInt32(ReadLine()!);

string[] initialArray = FillArray(elementsQty);
WriteLine($"Initial array : [ {String.Join(", ", initialArray)} ]");

Write("Please print maximum length of the word : ");
int wordLength = Convert.ToInt32(ReadLine()!);

string[] filteredArray = FilterArray(initialArray, wordLength);
WriteLine($"Initial array : [ {String.Join(", ", filteredArray)} ]");

// PrintArray(filteredArray);



string[] FillArray(int qty)
{
    string[] array = new string[qty];
    for (int i = 0; i < qty; i++)
    {
        Write("Print a word : ");
        array[i] = ReadLine();
    }
    return array;
}

string[] FilterArray(string[] arr, int wLen)
{
    int j = 0;
    string[] newArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= wLen)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

// Нашел решение исключения пустых элеменотв из массива в интернете , но не смог разобраться.
// void PrintArray(string[] array)
// {
//     if (array.Length == 0)
//     {
//         WriteLine("Array is ampty. There are no words according to your limitations.");
//     }
//     else 
//     {
//         Array.ForEach(array, (str) => Console.Write($"{str} "));
//     }
// }