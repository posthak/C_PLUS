// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4   18 20
// 3 2 | 3 3   15 18
// Результирующая матрица будет:
// 18 20
// 15 18

// С ПРОВЕРКОЙ НА СООТВЕТСТВИЕ МАСИВОВ
Console.Clear();
int mA = 3;
int nA = 2;
int mB = 2;
int nB = 3;

int min = 1;
int max = 5;

int[,] collectionA = new int[mA, nA];
int[,] baseCollectionA = GetCollection(collectionA, min, max);

int[,] collectionB = new int[mB, nB];
int[,] baseCollectionB = GetCollection(collectionB, min, max);


PrintOneCollection(baseCollectionA);
Console.WriteLine("_____");
Console.WriteLine("");
PrintOneCollection(baseCollectionB);
Console.WriteLine("");

if (baseCollectionA.GetLength(0) == baseCollectionB.GetLength(1))
{
    Console.WriteLine("Результирующая матрица будет:");
    PrintOneCollection(MultiplyCollection(baseCollectionA, baseCollectionB));
}
else
{
    Console.WriteLine("Массивы не соответствуют, кол-во строк одного масива не равно кол-ву столбцов другого");
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
            Console.Write($"{collA[i, j]} ");
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
            int sum = 0;
            for (int k = 0; k < colA.GetLength(1); k++)
            {
                sum += colA[i, k] * colB[k, j];
            }
            colRes[i, j] = sum;
        }
    }
    return colRes;
}

// БЕЗ ПРОВЕРКИ НА СООТВЕТСТВИЕ МАСИВОВ

// Console.Clear();
// int m = 6;
// int n = 6;
// int min = 1;
// int max = 5;

// int[,] collectionA = new int[m, n];
// int[,] baseCollectionA = GetCollection(collectionA, min, max);

// int[,] collectionB = new int[m, n];
// int[,] baseCollectionB = GetCollection(collectionB, min, max);

// PrintTwoCollection(baseCollectionA, baseCollectionB);
// Console.WriteLine();
// PrintOneCollection(MultiplyCollection(baseCollectionA, baseCollectionB));

// int[,] GetCollection(int[,] coll, int mn, int mx)
// {
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             coll[i, j] = new Random().Next(mn, mx);
//         }
//     }
//     return coll;
// }

// void PrintTwoCollection(int[,] collA, int[,] collB)
// {
//     for (int i = 0; i < collA.GetLength(0); i++)
//     {
//         for (int j = 0; j < collA.GetLength(1); j++)
//         {
//             Console.Write($"{collA[i, j]} ");
//         }
//         Console.Write("| ");
//         for (int k = 0; k < collB.GetLength(1); k++)
//         {
//             Console.Write($"{collB[i, k]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintOneCollection(int[,] collA)
// {
//     for (int i = 0; i < collA.GetLength(0); i++)
//     {
//         for (int j = 0; j < collA.GetLength(1); j++)
//         {
//             Console.Write($"{collA[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MultiplyCollection(int[,] colA, int[,] colB)
// {
//     int[,] colRes = new int[colA.GetLength(0), colA.GetLength(1)];
//     for (int i = 0; i < colA.GetLength(0); i++)
//     {
//         for (int j = 0; j < colB.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < colA.GetLength(1); k++)
//             {
//                 sum += colA[i, k] * colB[k, j];
//             }
//             colRes[i, j] = sum;
//         }
//     }
//     return colRes;
// }