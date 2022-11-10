// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int ArrayLength = 8;
int[] Collection = new int[ArrayLength];

printArray(fillArray(Collection));


int[] fillArray(int[] Collection)
{
    for (int count = 0; count <= 7; count++)
    {
        Collection[count] = new Random().Next(1, 100);
    }
    return Collection;
}


void printArray(int[] Collection)
{
    string result = "";
    for (int count = 0; count <= 7; count++)
    {
        if (count < 7)
            result += Collection[count] + ", ";
        else
        {
            result += Collection[count];
        }
    }
    Console.Write($"{result} -> [{result}]");
}

