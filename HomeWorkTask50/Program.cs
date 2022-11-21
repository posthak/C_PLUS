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

int[,] collection = new int[m, n];
int[,] baseCollection = GetCollection(collection, min, max);
PrintCollection(baseCollection);

Console.Write("Введите позицию элемента в массиве: ");
int element = Convert.ToInt32(Console.ReadLine());

if (IsAvailableElement(baseCollection, element)) Console.WriteLine($"{element} -> {element}");
else
{
    Console.WriteLine($"{element} -> Такого числа в массиве нет");
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

Boolean IsAvailableElement(int[,] coll, int elem)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (coll[i, j] == elem)
            {
                return true;
            }
        }
    }
    return false;
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