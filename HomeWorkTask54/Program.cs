// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3;
int n = 4;
int min = 1;
int max = 10;

int[,] collection = new int[m, n];
int[,] baseCollection = GetCollection(collection, min, max);

PrintCollection(baseCollection);

Console.WriteLine("В итоге получается вот такой массив:");

PrintCollection(SortCollection(baseCollection));

int[,] GetCollection(int[,] coll, int mn, int mx)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(mn, mx);
        }
    }
    return coll;
}

void PrintCollection(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortCollection(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < coll.GetLength(1); k++)
            {
                if (coll[i, k] > coll[i, maxPosition]) maxPosition = k;
            }
            int temporary = coll[i, j];
            coll[i, j] = coll[i, maxPosition];
            coll[i, maxPosition] = temporary;
        }
    }
    return coll;
}