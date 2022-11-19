// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double min = 0;
double max = 10;
double[,] baseCollection = new double[m, n];

PrintCollection(GetFilledCollection(baseCollection, max, min));

double[,] GetFilledCollection(double[,] coll, double mx, double mn)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().NextDouble() * (mx - mn);
        }
    }
    return coll;
}

void PrintCollection(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}