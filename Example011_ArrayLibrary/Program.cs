﻿void FillArray(int[] collection)  // void - метод ничего не возвращает
{
     int length = collection.Length;
     int index = 0;
     while (index < length)
     {
         collection[index] = new Random().Next(1, 10); 
         // index = index + 1
         index++;
     }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// с использованием метода, возвращает позицию, индекс

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count);
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index = index++;
    }
    return position;
}
int [] array = new int[10]; // создай новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);