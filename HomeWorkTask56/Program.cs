// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4;
int n = 4;
int min = 1;
int max = 10;

int[,] collection = new int[m, n];
int[,] baseCollection = GetCollection(collection, min, max);

PrintCollection(baseCollection);
Console.WriteLine();
Console.Write("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: ");
Console.WriteLine($"{GetMinElement(GetSumElementsRow(baseCollection))} строка");

// PrintCollection();

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

int[] GetSumElementsRow(int[,] coll)
{
    int[] collSumElement = new int[coll.GetLength(0)];
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            sum += coll[i, j];
        }
        collSumElement[i] = sum;
    }
    return collSumElement;
}

int GetMinElement(int[] collSum)
{
    int min = collSum[0];
    int rowNumber = 0;
    for (int i = 0; i < collSum.Length; i++)
    {
        if (min > collSum[i])
        {
            min = collSum[i];
            rowNumber = i;
        }
    }
    return rowNumber + 1;
}