// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12]  ->  19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int arrayLength = new Random().Next(4, 10);
int[] collection = new int[arrayLength];
int arrayMin = -10;
int arrayMax = 100;

int[] col = FillArray(collection, arrayMax, arrayMin, arrayLength);
Console.WriteLine($"[{String.Join(", ", col)}] -> {SumOdd(col, arrayLength)}");

int[] FillArray(int[] collection, int max, int min, int len)
{
    for (int count = 0; count < len; count++)
    {
        collection[count] = new Random().Next(min, max);
    }
    return collection;
}

int SumOdd(int[] collection, int len)
{
    int sum = 0;
    for (int count = 1; count < len; count += 2)
    {
        sum += collection[count];
    }
    return sum;
}