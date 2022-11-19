// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3;
int n = 4;
int min = 1;
int max = 10;

int[,] baseCollection = new int[m, n];
baseCollection = GetCollection(m, n, min, max);
PrintCollection(baseCollection);

Console.Write("Введите позицию элемента в массиве: ");
int element = Convert.ToInt32(Console.ReadLine());

IsAvailableElement(baseCollection, element);

int[,] GetCollection(int m, int n, int mn, int mx)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            baseCollection[i, j] = new Random().Next(mn, mx);
        }
    }
    return baseCollection;
}

void IsAvailableElement(int[,] col, int elem)
{
    Boolean available = false;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i, j] == elem)
            {
                available = true;
            }
        }
    }
    if (available) Console.WriteLine($"{elem} -> {elem}");
    else
    {
        Console.WriteLine($"{elem} -> Такого числа в массиве нет");
    }
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