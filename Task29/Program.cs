// Задача 29: Напишите программу, которая задаёт массив из некоторого количества элементов 
//и выводит их на экран с помощью функций. 
//(можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)

Console.Write("Количество элементов: ");
int index = Convert.ToInt32(Console.ReadLine());

int[] Numbers (int index)
{
    int[] thisArray = new int[index];
    int i = 0;
    while(i < index)
    {
        Console.Write($"элемент {i+1}: ");
        int arrayNumber = Convert.ToInt32(Console.ReadLine());
        thisArray[i] = arrayNumber;
        i++;
    }
    return thisArray;
}

void PrintArray (int[] array, int index)
{
    for (int i = 0; i < index; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = Numbers(index);
Console.WriteLine("Получился вот такой массив: ");
PrintArray(array, index);