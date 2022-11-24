// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4   18 20
// 3 2 | 3 3   15 18
// Результирующая матрица будет:
// 18 20
// 15 18

// С ПРОВЕРКОЙ НА ВОЗМОЖНОСТЬ УМНОЖЕНИЯ
Console.Clear();
int row1 = 2;
int coll1 = 4;
int row2 = 4;
int coll2 = 2;
int min = 1;
int max = 5;

int[,] collectionA = new int[row1, coll1];
int[,] baseCollectionA = GetCollection(collectionA, min, max);
int[,] collectionB = new int[row2, coll2];
int[,] baseCollectionB = GetCollection(collectionB, min, max);

PrintTwoCollection(baseCollectionA, baseCollectionB);
Console.WriteLine("");

if (coll1 != row2)
{
    Console.WriteLine("Умножение невозможно сделать");
}
else
{
    Console.WriteLine("Результирующая матрица будет:");
    PrintOneCollection(MultiplyCollection(baseCollectionA, baseCollectionB));
}

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

void PrintOneCollection(int[,] collA)
{
    for (int i = 0; i < collA.GetLength(0); i++)
    {
        for (int j = 0; j < collA.GetLength(1); j++)
        {
            Console.Write($"{collA[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintTwoCollection(int[,] collA, int[,] collB)
{
    int maxLengthRow = collA.GetLength(0) > collB.GetLength(0) ? maxLengthRow = collA.GetLength(0) : maxLengthRow = collB.GetLength(0);

    for (int i = 0; i < maxLengthRow; i++)
    {
        for (int j = 0; j < collA.GetLength(1); j++)
        {
            if (i < collA.GetLength(0))
            {
                Console.Write($"{collA[i, j]}  ");
            }
            else
            {
                Console.Write($"   ");
            }
        }
        Console.Write("|  ");
        if (i < collB.GetLength(0))
        {
            for (int k = 0; k < collB.GetLength(1); k++)
            {
                Console.Write($"{collB[i, k]}  ");
            }
        }
        Console.WriteLine();
    }
}

int[,] MultiplyCollection(int[,] colA, int[,] colB)
{
    int[,] colRes = new int[colA.GetLength(0), colB.GetLength(1)];
    for (int i = 0; i < colA.GetLength(0); i++)
    {
        for (int j = 0; j < colB.GetLength(1); j++)
        {
            for (int k = 0; k < colA.GetLength(1); k++)
            {
                colRes[i, j] += colA[i, k] * colB[k, j];
            }
        }
    }
    return colRes;
}