// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
int min = 0;
int max = 10;
double[,] baseCollection = new double[m, n];

PrintCollection(GetFilledCollection(baseCollection, max, min));

double[,] GetFilledCollection(double[,] coll, int mx, int mn)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            // coll[i, j] = new Random().NextDouble() * (mx - mn);
            coll[i, j] = rnd.NextDouble() + rnd.Next(mn, mx); // [min, max]
        }
    }
    return coll;
}

// Random rnd = new Random();
// array[i, j] = rnd.NextDouble() + rnd.Next(min, max); // [min, max]
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