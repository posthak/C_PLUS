// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
int min = 1;
int max = 10;

int[,] collection = new int[m, n];
int[,] baseCollection = GetCollection(collection, min, max);
PrintCollection(baseCollection);

Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", GetAvgByColumn(baseCollection))}");

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

double[] GetAvgByColumn(int[,] coll)
{
    double[] result = new double[coll.GetLength(1)];
    for (int i = 0; i < coll.GetLength(1); i++)
    {
        for (int j = 0; j < coll.GetLength(0); j++)
        {
            result[i] += coll[j, i];
        }
        result[i] = Math.Round(result[i] / coll.GetLength(0), 2);
    }
    return result;
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